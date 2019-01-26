// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.SerialProtocol
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.ComponentModel;
using System.IO;
using System.IO.Ports;
using System.Resources;
using System.Threading;
using System.Timers;

public class SerialProtocol
{
  private byte[] DataArray = new byte[76800];
  private const int WAITSEC = 3000;
  private const int TO13SEC = 13000;
  private const int TO01SEC = 1000;
  private const int TO05SEC = 5000;
  private const int BUFDATASIZE = 76800;
  private const int CMDDATASIZE = 131;
  private const int ERRORTHROW = 1000;
  private readonly string TIMEOUTERRMESSAGE;
  private readonly string CHECKSUMERRMESSAGE;
  private readonly string FORMATERRMESSAGE;
  private readonly string COMPLETEDMESSAGE;
  private readonly string SENDMESSAGE;
  private readonly string RECVMESSAGE;
  private readonly string CPUTYPERRMESSAGE;
  private bool IsSend;
  private bool IsTimeout;
  private string errorMessage;
  private int tmpMaskID;
  private int tmpMtxPTN;
  private SerialPort mySerial;
  private Database db;
  private System.Timers.Timer myTimer;
  private BackgroundWorker backgroundWorker1;

  public SerialProtocol()
  {
  }

  public SerialProtocol(SerialPort serialport, Database db, bool isSend)
  {
    this.mySerial = serialport;
    this.IsSend = isSend;
    this.db = db;
    this.db.Buffer.CopyTo((Array) this.DataArray, 0);
    this.tmpMaskID = Settings.Instance.MaskID;
    this.tmpMtxPTN = Settings.Instance.MtxPTN;
    this.TIMEOUTERRMESSAGE = "TIMEOUT ERROR";
    this.CHECKSUMERRMESSAGE = "CHECKSUM ERROR";
    this.FORMATERRMESSAGE = "FORMAT ERROR";
    this.COMPLETEDMESSAGE = "COMPLETED";
    this.SENDMESSAGE = "SENDING";
    this.RECVMESSAGE = "RECEIVING";
    this.CPUTYPERRMESSAGE = "CPU TYPE ERROR";
    this.myTimer = new System.Timers.Timer();
    this.myTimer.Elapsed += new ElapsedEventHandler(this.OnTimerEvent);
    this.backgroundWorker1.WorkerSupportsCancellation = true;
  }

  public void PortOpen()
  {
    this.mySerial.BaudRate = 38400;
    this.mySerial.DataBits = 8;
    this.mySerial.Parity = Parity.None;
    this.mySerial.StopBits = StopBits.One;
    this.mySerial.Handshake = Handshake.None;
    try
    {
      this.mySerial.Open();
    }
    catch
    {
      throw new IOException("COM PORT OPEN ERROR");
    }
  }

  public void PortClose()
  {
    this.mySerial.Close();
  }

  public void Run()
  {
    this.DoWork();
  }

  private void sendPtnA()
  {
    byte[] numArray = new byte[131];
    numArray[0] = (byte) 0;
    numArray[1] = (byte) 0;
    numArray[2] = this.db.Buffer[0];
    numArray[3] = this.db.Buffer[1];
    numArray[4] = this.db.Buffer[2];
    numArray[5] = this.db.Buffer[3];
    numArray[6] = this.db.Buffer[4];
    numArray[7] = this.db.Buffer[5];
    numArray[8] = this.db.Buffer[6];
    numArray[9] = this.db.Buffer[7];
    numArray[10] = this.db.Buffer[8];
    numArray[11] = this.db.Buffer[9];
    numArray[12] = this.db.Buffer[10];
    for (int index = 13; index < numArray.Length - 1; ++index)
      numArray[index] = (byte) 0;
    numArray[numArray.Length - 1] = this.calcCheckSum(numArray, numArray.Length - 1);
    this.mySerial.Write(numArray, 0, numArray.Length);
  }

  private void sendPtnBorCorD(int address)
  {
    byte[] numArray = new byte[131];
    if (address == 128)
    {
      numArray[0] = byte.MaxValue;
      numArray[1] = (byte) 253;
    }
    else
    {
      numArray[0] = (byte) ((address & 65280) >> 8);
      numArray[1] = (byte) (address & (int) byte.MaxValue);
    }
    for (int index = 2; index < numArray.Length - 1; ++index)
    {
      numArray[index] = this.db.Buffer[address];
      ++address;
    }
    numArray[numArray.Length - 1] = this.calcCheckSum(numArray, numArray.Length - 1);
    this.mySerial.Write(numArray, 0, numArray.Length);
  }

  private void sendPtnE()
  {
    byte[] numArray = new byte[131];
    numArray[0] = byte.MaxValue;
    numArray[1] = (byte) 254;
    for (int index = 2; index < numArray.Length - 1; ++index)
      numArray[index] = (byte) 0;
    numArray[numArray.Length - 1] = this.calcCheckSum(numArray, numArray.Length - 1);
    this.mySerial.Write(numArray, 0, numArray.Length);
  }

  private void recvAck()
  {
    byte[] buffer = new byte[1];
    while (!this.IsTimeout)
    {
      if (this.mySerial.BytesToRead >= buffer.Length)
      {
        this.mySerial.Read(buffer, 0, buffer.Length);
        if (buffer[0] == (byte) 6)
          return;
        this.errorMessage = this.FORMATERRMESSAGE;
        throw new Exception();
      }
    }
    this.errorMessage = this.TIMEOUTERRMESSAGE;
    throw new Exception();
  }

  private void recvPtnA()
  {
    byte[] numArray = new byte[131];
    while (!this.IsTimeout)
    {
      if (this.mySerial.BytesToRead >= numArray.Length)
      {
        this.mySerial.Read(numArray, 0, numArray.Length);
        if (numArray[0] != (byte) 0 || numArray[1] != (byte) 0 || ((int) numArray[2] != (int) this.db.Buffer[0] || (int) numArray[3] != (int) this.db.Buffer[1]) || ((int) numArray[4] != (int) this.db.Buffer[2] || (int) numArray[5] != (int) this.db.Buffer[3] || ((int) numArray[6] != (int) this.db.Buffer[4] || (int) numArray[7] != (int) this.db.Buffer[5])) || ((int) numArray[8] != (int) this.db.Buffer[6] || (int) numArray[9] != (int) this.db.Buffer[7]))
        {
          this.errorMessage = this.FORMATERRMESSAGE;
          throw new Exception();
        }
        if (Settings.Instance.Language == 0)
        {
          if (numArray[10] != (byte) 2)
          {
            this.errorMessage = this.CPUTYPERRMESSAGE;
            throw new Exception();
          }
        }
        else if (numArray[10] != (byte) 0 && numArray[10] != (byte) 1 && numArray[10] != (byte) 3)
        {
          this.errorMessage = this.CPUTYPERRMESSAGE;
          throw new Exception();
        }
        if (Settings.Instance.AutoMaskID)
          this.tmpMaskID = (int) numArray[10];
        else if ((int) numArray[10] != Settings.Instance.MaskID)
        {
          this.errorMessage = this.CPUTYPERRMESSAGE;
          throw new Exception();
        }
        if (Settings.Instance.AutoMtxPTN)
          this.tmpMtxPTN = (int) numArray[11];
        else if ((int) numArray[11] != Settings.Instance.MtxPTN)
        {
          this.errorMessage = this.CPUTYPERRMESSAGE;
          throw new Exception();
        }
        if (Settings.Instance.CheckVerTBL && (int) numArray[12] != Settings.Instance.VerTBL)
        {
          this.errorMessage = this.FORMATERRMESSAGE;
          throw new Exception();
        }
        for (int index = 13; index < numArray.Length - 2; ++index)
        {
          if (numArray[index] != (byte) 0)
          {
            this.errorMessage = this.FORMATERRMESSAGE;
            throw new Exception();
          }
        }
        if ((int) this.calcCheckSum(numArray, numArray.Length - 1) == (int) numArray[numArray.Length - 1])
          return;
        this.errorMessage = this.CHECKSUMERRMESSAGE;
        throw new Exception();
      }
    }
    this.errorMessage = this.TIMEOUTERRMESSAGE;
    throw new Exception();
  }

  private void recvPtnBorCorD(int address)
  {
    byte[] numArray = new byte[131];
    while (!this.IsTimeout)
    {
      if (this.mySerial.BytesToRead >= numArray.Length)
      {
        this.mySerial.Read(numArray, 0, numArray.Length);
        if ((int) this.calcCheckSum(numArray, numArray.Length - 1) != (int) numArray[numArray.Length - 1])
        {
          this.errorMessage = this.CHECKSUMERRMESSAGE;
          throw new Exception();
        }
        for (int index = 2; index < numArray.Length - 1; ++index)
        {
          this.DataArray[address] = numArray[index];
          ++address;
        }
        return;
      }
    }
    this.errorMessage = this.TIMEOUTERRMESSAGE;
    throw new Exception();
  }

  private void recvPtnE()
  {
    byte[] numArray = new byte[131];
    while (!this.IsTimeout)
    {
      if (this.mySerial.BytesToRead >= numArray.Length)
      {
        this.mySerial.Read(numArray, 0, numArray.Length);
        int index = 13;
        while (index < numArray.Length - 1 && numArray[index] == (byte) 0)
          ++index;
        if ((int) this.calcCheckSum(numArray, numArray.Length - 1) == (int) numArray[numArray.Length - 1])
          return;
        this.errorMessage = this.CHECKSUMERRMESSAGE;
        throw new Exception();
      }
    }
    this.errorMessage = this.TIMEOUTERRMESSAGE;
    throw new Exception();
  }

  private void sendAck()
  {
    this.mySerial.Write(new byte[1]{ (byte) 6 }, 0, 1);
  }

  private byte calcCheckSum(byte[] buf, int len)
  {
    byte num = 0;
    for (int index = 0; index < len; ++index)
      num += buf[index];
    return num;
  }

  private void OnTimerEvent(object source, ElapsedEventArgs e)
  {
    this.IsTimeout = true;
  }

  private void startToTimer(double time)
  {
    this.myTimer.Enabled = true;
    this.myTimer.AutoReset = true;
    this.myTimer.Interval = time;
    this.IsTimeout = false;
  }

  private void stopToTimer()
  {
    this.myTimer.Enabled = false;
    this.myTimer.AutoReset = false;
    this.IsTimeout = false;
  }

  private void DoWork()
  {
    try
    {
      if (this.IsSend)
      {
        this.sendPtnA();
        this.startToTimer(5000.0);
        this.recvAck();
        int address = 256;
        while (address < 76800)
        {
          Thread.Sleep(10);
          this.startToTimer(1000.0);
          if (address != 1024)
          {
            this.sendPtnBorCorD(address);
            this.recvAck();
            int percentProgress = address * 100 / 76800;
	    Console.WriteLine(percentProgress + "%");
          }
          address += 128;
        }
        Thread.Sleep(10);
        this.startToTimer(1000.0);
        this.sendPtnBorCorD(128);
        this.recvAck();
        int percentProgress1 = (address + 128) * 100 / 76800;
	Console.WriteLine(percentProgress1);
        Thread.Sleep(10);
        this.startToTimer(1000.0);
        this.sendPtnE();
        this.recvAck();
        int percentProgress2 = (address + 128) * 100 / 76800;
	Console.WriteLine(percentProgress2);
        this.stopToTimer();
      }
      else
      {
        this.startToTimer(13000.0);
        this.recvPtnA();
        this.sendAck();
        int address = 256;
        while (address < 76800)
        {
          this.startToTimer(1000.0);
          if (address != 1024)
          {
            this.recvPtnBorCorD(address);
            this.sendAck();
            int percentProgress = address * 100 / 76800;
            Console.WriteLine(percentProgress);
          }
          address += 128;
        }
        this.startToTimer(1000.0);
        this.recvPtnBorCorD(128);
        this.sendAck();
        int percentProgress1 = (address + 128) * 100 / 76800;
        Console.WriteLine(percentProgress1);
        this.startToTimer(1000.0);
        this.recvPtnE();
        this.sendAck();
        int percentProgress2 = (address + 128) * 100 / 76800;
        Console.WriteLine(percentProgress2);
        this.stopToTimer();
        this.DataArray.CopyTo((Array) this.db.Buffer, 0);
      }
    }
    catch
    {
      Console.WriteLine("1000");
    }
  }

}
