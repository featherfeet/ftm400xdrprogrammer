// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.DataConverter
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.ComponentModel;

namespace Ftm400dAdms7
{
  public class DataConverter
  {
    public static readonly int[] HEADER = new int[4]{ 0, 0, 0, 128 };
    public static readonly int[] BACKUP = new int[4]{ 128, 1048575, 128, 256 };
    public static readonly int[] LRFVFO = new int[4]{ 256, 1048575, 256, 80 };
    public static readonly int[] RRFVFO = new int[4]{ 336, 1048575, 336, 80 };
    public static readonly int[] LRFHOME = new int[4]{ 416, 160, 416, 80 };
    public static readonly int[] RRFHOME = new int[4]{ 496, 240, 496, 80 };
    public static readonly int[] SYSTEM = new int[4]{ 640, 1048575, 512, 128 };
    public static readonly int[] DTMFMEMORY = new int[4]{ 768, 1048575, 1048575, 0 };
    public static readonly int[] WIRESLAST = new int[4]{ 912, 1048575, 1048575, 0 };
    public static readonly int[] ADJUST = new int[4]{ 1024, 1048575, 1048575, 0 };
    public static readonly int[] RADHARDMASKID = new int[4]{ 1144, 1048575, 1048575, 0 };
    public static readonly int[] LRFHOMENAME = new int[4]{ 1192, 424, 1048575, 40 };
    public static readonly int[] RRFHOMENAME = new int[4]{ 1152, 384, 1048575, 40 };
    public static readonly int[] APRS = new int[4]{ 1280, 1048575, 640, 128 };
    public static readonly int[] REPLYTEXT = new int[4]{ 1408, 1048575, 1048575, 0 };
    public static readonly int[] MESSAGEGROUP = new int[4]{ 1536, 1048575, 1048575, 0 };
    public static readonly int[] DIGIPATH = new int[4]{ 1664, 1048575, 1048575, 0 };
    public static readonly int[] CALLRINGERSIGN = new int[4]{ 1856, 1048575, 1048575, 0 };
    public static readonly int[] MESSAGETEXT = new int[4]{ 1920, 1048575, 1048575, 0 };
    public static readonly int[] LBANDMEMORY = new int[4]{ 2048, 512, 1048575, 8288 };
    public static readonly int[] RBANDMEMORY = new int[4]{ 10336, 8800, 1048575, 8288 };
    public static readonly int[] LBANDMEMORYNAME = new int[4]{ 18624, 17088, 1048575, 4144 };
    public static readonly int[] RBANDMEMORYNAME = new int[4]{ 22768, 21232, 1048575, 4144 };
    public static readonly int[] BACKTRACKMEMORY = new int[4]{ 26912, 25376, 1048575, 160 };
    public static readonly int[] PHRASEMEMORY = new int[4]{ 27264, 1048575, 1048575, 0 };
    public static readonly int[] WIRESCATENAME = new int[4]{ 28544, 1048575, 1048575, 0 };
    public static readonly int[] GMGNAME = new int[4]{ 30720, 1048575, 1048575, 0 };
    public static readonly int[] PRESET = new int[4]{ 31744, 1048575, 1048575, 0 };
    public static readonly int[] STATUSTEXT = new int[4]{ 32256, 1048575, 1048575, 0 };
    public static readonly int[] STATIONMEMORY = new int[4]{ 32768, 1048575, 1048575, 0 };
    public static readonly int[] MESSAGEMEMORY = new int[4]{ 45568, 1048575, 1048575, 0 };
    public static readonly int[] STATIONINFOMEMORY = new int[4]{ 58624, 1048575, 1048575, 0 };
    public static readonly int[] MESSAGEINFOMEMORY = new int[4]{ 61568, 1048575, 1048575, 0 };
    public static readonly int[] GMMEMBERMEMORY = new int[4]{ 65536, 1048575, 1048575, 0 };
    public static readonly int[] WIRESCATEUSERID = new int[4]{ 74240, 1048575, 1048575, 0 };
    public static readonly Decimal[] tbl_1KHz_freq = new Decimal[16]{ new Decimal(0, 0, 0, false, (byte) 5), new Decimal(0, 0, 0, false, (byte) 5), new Decimal(125, 0, 0, false, (byte) 5), new Decimal(166, 0, 0, false, (byte) 5), new Decimal(250, 0, 0, false, (byte) 5), new Decimal(333, 0, 0, false, (byte) 5), new Decimal(375, 0, 0, false, (byte) 5), new Decimal(0, 0, 0, false, (byte) 5), new Decimal(500, 0, 0, false, (byte) 5), new Decimal(0, 0, 0, false, (byte) 5), new Decimal(625, 0, 0, false, (byte) 5), new Decimal(666, 0, 0, false, (byte) 5), new Decimal(750, 0, 0, false, (byte) 5), new Decimal(833, 0, 0, false, (byte) 5), new Decimal(875, 0, 0, false, (byte) 5), new Decimal(0, 0, 0, false, (byte) 5) };
    private const char charNON = 'Ê';
    public const int ALL = 0;
    public const int MEM = 1;
    public const int SYS = 2;
    public const int SIZE = 3;
    public const int NONADDR = 1048575;
    private Database db;
    private byte[] dat;
    private byte[] sd;

    public void Memory(byte[] clone, byte[] memory)
    {
      Array.Copy((Array) clone, 2, (Array) memory, 0, 5);
    }

    public bool Decode(Database database)
    {
      this.db = database;
      this.dat = this.db.Buffer;
      this.decodeHeader();
      this.decodeBackup();
      this.decodeLrfVfo();
      this.decodeRrfVfo();
      this.decodeLrfHome();
      this.decodeRrfHome();
      this.decodeSystem();
      this.decodeDtmfmemory();
      this.decodeWiresLast();
      this.decodeAdjust();
      this.decodeRadHardMaskId();
      this.decodeLrfHomeName();
      this.decodeRrfHomeName();
      this.decodeAprs();
      this.decodeReplyText();
      this.decodeMessageGroup();
      this.decodeDigiPath();
      this.decodeCallRingerSign();
      this.decodeMessageText();
      this.decodeLbandMemory();
      this.decodeRbandMemory();
      this.decodeLbandMemoryName();
      this.decodeRbandMemoryName();
      this.decodeBackTrackMemory();
      this.decodePhraseMemory();
      this.decodeWiresCateName();
      this.decodeGmName();
      this.decodePreset();
      this.decodeStatusText();
      this.decodeStationMemory();
      this.decodeMessageMemory();
      this.decodeStationInfoMemory();
      this.decodeMessageInfoMemory();
      this.decodeGmMemberMemory();
      this.decodeWiresCateUserId();
      return true;
    }

    public bool Encode(Database database)
    {
      this.db = database;
      this.dat = this.db.Buffer;
      this.encodeHeader();
      this.encodeBackup();
      this.encodeLrfVfo();
      this.encodeRrfVfo();
      this.encodeLrfHome();
      this.encodeRrfHome();
      this.encodeSystem();
      this.encodeDtmfmemory();
      this.encodeWiresLast();
      this.encodeAdjust();
      this.encodeRadHardMaskId();
      this.encodeLrfHomeName();
      this.encodeRrfHomeName();
      this.encodeAprs();
      this.encodeReplyText();
      this.encodeMessageGroup();
      this.encodeDigiPath();
      this.encodeCallRingerSign();
      this.encodeMessageText();
      this.encodeLbandMemory();
      this.encodeRbandMemory();
      this.encodeLbandMemoryName();
      this.encodeRbandMemoryName();
      this.encodeBackTrackMemory();
      this.encodePhraseMemory();
      this.encodeWiresCateName();
      this.encodeGmName();
      this.encodePreset();
      this.encodeStatusText();
      this.encodeStationMemory();
      this.encodeMessageMemory();
      this.encodeStationInfoMemory();
      this.encodeMessageInfoMemory();
      this.encodeGmMemberMemory();
      this.encodeWiresCateUserId();
      return true;
    }

    public bool DecodeSdCadeAll(Database database, byte[] tbuff)
    {
      this.db = database;
      this.sd = tbuff;
      this.dat = this.db.Buffer;
      this.sd.CopyTo((Array) this.dat, 0);
      return true;
    }

    public bool EncodeSdCadeAll(Database database, byte[] tbuff)
    {
      this.db = database;
      this.sd = tbuff;
      this.dat = this.db.Buffer;
      this.dat.CopyTo((Array) this.sd, 0);
      return true;
    }

    public bool DecodeSdCadeMemory(Database database, byte[] tbuff)
    {
      this.db = database;
      this.sd = tbuff;
      this.dat = this.db.Buffer;
      Array.Copy((Array) this.sd, DataConverter.HEADER[1], (Array) this.dat, DataConverter.HEADER[0], DataConverter.HEADER[3]);
      Array.Copy((Array) this.sd, DataConverter.LRFHOME[1], (Array) this.dat, DataConverter.LRFHOME[0], DataConverter.LRFHOME[3]);
      Array.Copy((Array) this.sd, DataConverter.RRFHOME[1], (Array) this.dat, DataConverter.RRFHOME[0], DataConverter.RRFHOME[3]);
      Array.Copy((Array) this.sd, DataConverter.LRFHOMENAME[1], (Array) this.dat, DataConverter.LRFHOMENAME[0], DataConverter.LRFHOMENAME[3]);
      Array.Copy((Array) this.sd, DataConverter.RRFHOMENAME[1], (Array) this.dat, DataConverter.RRFHOMENAME[0], DataConverter.RRFHOMENAME[3]);
      Array.Copy((Array) this.sd, DataConverter.LBANDMEMORY[1], (Array) this.dat, DataConverter.LBANDMEMORY[0], DataConverter.LBANDMEMORY[3]);
      Array.Copy((Array) this.sd, DataConverter.RBANDMEMORY[1], (Array) this.dat, DataConverter.RBANDMEMORY[0], DataConverter.RBANDMEMORY[3]);
      Array.Copy((Array) this.sd, DataConverter.LBANDMEMORYNAME[1], (Array) this.dat, DataConverter.LBANDMEMORYNAME[0], DataConverter.LBANDMEMORYNAME[3]);
      Array.Copy((Array) this.sd, DataConverter.RBANDMEMORYNAME[1], (Array) this.dat, DataConverter.RBANDMEMORYNAME[0], DataConverter.RBANDMEMORYNAME[3]);
      Array.Copy((Array) this.sd, DataConverter.BACKTRACKMEMORY[1], (Array) this.dat, DataConverter.BACKTRACKMEMORY[0], DataConverter.BACKTRACKMEMORY[3]);
      return true;
    }

    public bool EncodeSdCadeMemory(Database database, byte[] tbuff)
    {
      this.db = database;
      this.sd = tbuff;
      this.dat = this.db.Buffer;
      Array.Copy((Array) this.dat, DataConverter.HEADER[0], (Array) this.sd, DataConverter.HEADER[1], DataConverter.HEADER[3]);
      Array.Copy((Array) this.dat, DataConverter.LRFHOME[0], (Array) this.sd, DataConverter.LRFHOME[1], DataConverter.LRFHOME[3]);
      Array.Copy((Array) this.dat, DataConverter.RRFHOME[0], (Array) this.sd, DataConverter.RRFHOME[1], DataConverter.RRFHOME[3]);
      Array.Copy((Array) this.dat, DataConverter.LRFHOMENAME[0], (Array) this.sd, DataConverter.LRFHOMENAME[1], DataConverter.LRFHOMENAME[3]);
      Array.Copy((Array) this.dat, DataConverter.RRFHOMENAME[0], (Array) this.sd, DataConverter.RRFHOMENAME[1], DataConverter.RRFHOMENAME[3]);
      Array.Copy((Array) this.dat, DataConverter.LBANDMEMORY[0], (Array) this.sd, DataConverter.LBANDMEMORY[1], DataConverter.LBANDMEMORY[3]);
      Array.Copy((Array) this.dat, DataConverter.RBANDMEMORY[0], (Array) this.sd, DataConverter.RBANDMEMORY[1], DataConverter.RBANDMEMORY[3]);
      Array.Copy((Array) this.dat, DataConverter.LBANDMEMORYNAME[0], (Array) this.sd, DataConverter.LBANDMEMORYNAME[1], DataConverter.LBANDMEMORYNAME[3]);
      Array.Copy((Array) this.dat, DataConverter.RBANDMEMORYNAME[0], (Array) this.sd, DataConverter.RBANDMEMORYNAME[1], DataConverter.RBANDMEMORYNAME[3]);
      Array.Copy((Array) this.dat, DataConverter.BACKTRACKMEMORY[0], (Array) this.sd, DataConverter.BACKTRACKMEMORY[1], DataConverter.BACKTRACKMEMORY[3]);
      return true;
    }

    public bool DecodeSdCadeSystem(Database database, byte[] tbuff)
    {
      this.db = database;
      this.sd = tbuff;
      this.dat = this.db.Buffer;
      Array.Copy((Array) this.sd, DataConverter.HEADER[2], (Array) this.dat, DataConverter.HEADER[0], DataConverter.HEADER[3]);
      Array.Copy((Array) this.sd, DataConverter.BACKUP[2], (Array) this.dat, DataConverter.BACKUP[0], DataConverter.BACKUP[3]);
      Array.Copy((Array) this.sd, DataConverter.LRFVFO[2], (Array) this.dat, DataConverter.LRFVFO[0], DataConverter.LRFVFO[3]);
      Array.Copy((Array) this.sd, DataConverter.RRFVFO[2], (Array) this.dat, DataConverter.RRFVFO[0], DataConverter.RRFVFO[3]);
      Array.Copy((Array) this.sd, DataConverter.SYSTEM[2], (Array) this.dat, DataConverter.SYSTEM[0], DataConverter.SYSTEM[3]);
      Array.Copy((Array) this.sd, DataConverter.APRS[2], (Array) this.dat, DataConverter.APRS[0], DataConverter.APRS[3]);
      return true;
    }

    public bool EncodeSdCadeSystem(Database database, byte[] tbuff)
    {
      this.db = database;
      this.sd = tbuff;
      this.dat = this.db.Buffer;
      Array.Copy((Array) this.dat, DataConverter.HEADER[0], (Array) this.sd, DataConverter.HEADER[2], DataConverter.HEADER[3]);
      Array.Copy((Array) this.dat, DataConverter.BACKUP[0], (Array) this.sd, DataConverter.BACKUP[2], DataConverter.BACKUP[3]);
      Array.Copy((Array) this.dat, DataConverter.LRFVFO[0], (Array) this.sd, DataConverter.LRFVFO[2], DataConverter.LRFVFO[3]);
      Array.Copy((Array) this.dat, DataConverter.RRFVFO[0], (Array) this.sd, DataConverter.RRFVFO[2], DataConverter.RRFVFO[3]);
      Array.Copy((Array) this.dat, DataConverter.SYSTEM[0], (Array) this.sd, DataConverter.SYSTEM[2], DataConverter.SYSTEM[3]);
      Array.Copy((Array) this.dat, DataConverter.APRS[0], (Array) this.sd, DataConverter.APRS[2], DataConverter.APRS[3]);
      return true;
    }

    private void decodeHeader()
    {
    }

    private void decodeBackup()
    {
      this.decodeMemoryCommon(this.db.aBandVfo, (int) this.dat[196], this.dat, 128);
      this.decodeMemoryCommon(this.db.bBandVfo, (int) this.dat[212], this.dat, 144);
      this.db.Config_Unit = (int) this.dat[161];
      if (((int) this.dat[164] & 128) >> 7 == 0)
      {
        this.db.Config_Apo = 0;
      }
      else
      {
        //if (((int) this.dat[164] & 128) >> 7 != 1)
        //  throw new FormatException();
        this.db.Config_Apo = ((int) this.dat[164] & (int) sbyte.MaxValue) > 4 ? (((int) this.dat[164] & (int) sbyte.MaxValue) + 5) / 2 : ((int) this.dat[164] & (int) sbyte.MaxValue) + 1;
      }
      this.db.Config_TimeZone = ((int) this.dat[168] & 128) >> 7 != 0 ? 28 - ((int) this.dat[168] & (int) sbyte.MaxValue) : 28 + (int) this.dat[168];
      this.db.Option_VcMemVlm = (int) this.dat[169];
      this.db.Config_Tot = (int) this.dat[170];
      this.db.Option_VcMemAnnc = (int) this.dat[174];
      if (this.dat[175] == (byte) 21)
      {
        this.db.Config_GpsDtm = 0;
      }
      else
      {
// OLIVER OLIVER OLIVER
        //if (this.dat[175] != (byte) 179)
        //  throw new FormatException();
        this.db.Config_GpsDtm = 1;
      }
      if (((int) this.dat[180] & 128) >> 7 == 0)
      {
        this.db.Config_GpsLog = 0;
      }
      else
      {
        //if (((int) this.dat[180] & 128) >> 7 != 1)
        //  throw new FormatException();
        this.db.Config_GpsLog = ((int) this.dat[180] & (int) sbyte.MaxValue) + 1;
      }
      this.db.FuncSet_Array1 = (int) this.dat[181] - 1;
      this.db.FuncSet_Array2 = (int) this.dat[182] - 1;
      this.db.FuncSet_Array3 = (int) this.dat[183] - 1;
      this.db.FuncSet_Array4 = (int) this.dat[184] - 1;
      this.db.WiresX_PresetFreq = this.conv_3byteFreqBcdToDecimal(new byte[3]
      {
        (byte) ((((int) this.dat[185] & 15) << 4) + (((int) this.dat[186] & 240) >> 4)),
        (byte) ((((int) this.dat[186] & 15) << 4) + (((int) this.dat[187] & 240) >> 4)),
        (byte) ((((int) this.dat[187] & 15) << 4) + (((int) this.dat[185] & 240) >> 4))
      });
      this.db.Scan_ScanRsmA = (int) this.dat[201];
      this.db.Scan_ScanRsmB = (int) this.dat[217];
      this.db.Scan_DWStopA = ((int) this.dat[226] & 2) >> 1;
      this.db.Signaling_WxAlrtA = ((int) this.dat[226] & 64) >> 6;
      this.db.Signaling_SqlExA = (int) this.dat[227] & 1;
      this.db.Config_AtStepA = ((int) this.dat[227] & 8) >> 3;
      this.db.Config_AtModeA = ((int) this.dat[227] & 16) >> 4;
      this.db.Config_RxCovA = ((int) this.dat[227] & 32) >> 5;
      this.db.Config_AtRptShftA = ((int) this.dat[228] & 4) >> 2;
      this.db.Scan_ScanDrctnA = ((int) this.dat[228] & 32) >> 5;
      this.db.Display_BandScpA = ((int) this.dat[229] & 32) >> 5;
      this.db.Display_TgtLctn = ((int) this.dat[232] & 4) >> 2;
      this.db.Display_TimeVdd = ((int) this.dat[232] & 8) >> 3;
      this.db.Digital_StandbyBeep = ((int) this.dat[232] & 16) >> 4;
      if (((int) this.dat[233] & 3) == 0)
      {
        this.db.Audio_SubBandMute = 0;
      }
      else
      {
        //if (((int) this.dat[233] & 3) != 3)
          //throw new FormatException();
        this.db.Audio_SubBandMute = 1;
      }
      this.db.Option_BltthBttery = (int) this.dat[234] & 1;
      this.db.Option_RxMute = ((int) this.dat[235] & 4) >> 2;
      if (((int) this.dat[235] & 8) >> 3 == 0)
      {
        //if (((int) this.dat[250] & 16) >> 4 != 0)
          //throw new FormatException();
        this.db.Config_Beep = 0;
      }
      else
        this.db.Config_Beep = ((int) this.dat[250] & 16) >> 4 != 0 ? 2 : 1;
      this.db.Option_VcMemLng = ((int) this.dat[235] & 64) >> 6;
      this.db.Digital_LocationService = ((int) this.dat[235] & 128) >> 7;
      this.db.WiresX_SearchSetup = ((int) this.dat[236] & 8) >> 3;
      this.db.WiresX_RptWiresFreq = ((int) this.dat[236] & 16) >> 4;
      this.db.Gm_RangeRinger = ((int) this.dat[236] & 32) >> 5;
      this.db.Config_GpsDev = ((int) this.dat[236] & 128) >> 7;
      this.db.Digital_AmsTxMode = (int) this.dat[238];
      this.db.Scan_DWStopB = ((int) this.dat[242] & 2) >> 1;
      this.db.Signaling_WxAlrtB = ((int) this.dat[242] & 64) >> 6;
      this.db.Signaling_SqlExB = (int) this.dat[243] & 1;
      this.db.Config_AtStepB = ((int) this.dat[243] & 8) >> 3;
      this.db.Config_AtModeB = ((int) this.dat[243] & 16) >> 4;
      this.db.Config_RxCovB = ((int) this.dat[243] & 32) >> 5;
      this.db.Config_AtRptShftB = ((int) this.dat[244] & 4) >> 2;
      this.db.Scan_ScanDrctnB = ((int) this.dat[244] & 32) >> 5;
      this.db.Display_BandScpB = ((int) this.dat[245] & 32) >> 5;
      this.db.Option_BltthAudio = (int) this.dat[248] & 1;
      this.db.Signaling_AutDialer = ((int) this.dat[248] & 4) >> 2;
      switch ((int) this.dat[249] & 7)
      {
        case 0:
          this.db.Config_DtTmFrmtDt = 1;
          break;
        case 1:
          this.db.Config_DtTmFrmtDt = 3;
          break;
        case 2:
          this.db.Config_DtTmFrmtDt = 0;
          break;
        case 4:
          this.db.Config_DtTmFrmtDt = 2;
          break;
        //default:
          //throw new FormatException();
      }
      this.db.Config_DtTmFrmtHr = ((int) this.dat[249] & 16) >> 4;
      this.db.Option_VcMemPR = (int) this.dat[250] & 1;
    }

    private void decodeLrfVfo()
    {
      int offset = DataConverter.LRFVFO[0];
      for (int index = 0; index < this.db.aBandVfo.Count; ++index)
      {
        if (index != (int) this.dat[196])
          this.decodeMemoryCommon(this.db.aBandVfo, index, this.dat, offset);
        offset += 16;
      }
    }

    private void decodeRrfVfo()
    {
      int offset = DataConverter.RRFVFO[0];
      for (int index = 0; index < this.db.bBandVfo.Count; ++index)
      {
        if (index != (int) this.dat[212])
          this.decodeMemoryCommon(this.db.bBandVfo, index, this.dat, offset);
        offset += 16;
      }
    }

    private void decodeLrfHome()
    {
      int offset = DataConverter.LRFHOME[0];
      for (int index = 0; index < this.db.aBandHome.Count; ++index)
      {
        this.decodeMemoryCommon(this.db.aBandHome, index, this.dat, offset);
        offset += 16;
      }
    }

    private void decodeRrfHome()
    {
      int offset = DataConverter.RRFHOME[0];
      for (int index = 0; index < this.db.bBandHome.Count; ++index)
      {
        this.decodeMemoryCommon(this.db.bBandHome, index, this.dat, offset);
        offset += 16;
      }
    }

    private void decodeSystem()
    {
      this.db.Signaling_BellRingerA = (int) this.dat[652];
      this.db.Signaling_BellRingerB = (int) this.dat[668];
      char[] chArray = new char[10];
      for (int index = 0; index < chArray.Length; ++index)
      {
        if (this.dat[696 + index] != byte.MaxValue)
          chArray[index] = (char) this.dat[696 + index];
      }
      this.db.Gm_CallSign = new string(chArray).Replace("\0", "");
      this.db.Display_LcdBrigtness = (int) this.dat[709];
      this.db.Audio_MicGain = (int) this.dat[711];
      this.db.Display_LcdContrast = (int) this.dat[713];
      this.db.Signaling_PageRx1 = (int) this.dat[714];
      this.db.Signaling_PageRx2 = (int) this.dat[715];
      this.db.Signaling_PageTx1 = (int) this.dat[716];
      this.db.Signaling_PageTx2 = (int) this.dat[717];
      this.db.Option_BltthVox = (int) this.dat[722];
      this.db.Option_UsbCmrSize = (int) this.dat[723];
      this.db.Option_UsbCmrQlty = (int) this.dat[724];
      this.db.Digital_SqlType = (int) this.dat[726];
      this.db.Digital_SqlCode = (int) this.dat[727] - 1;
      this.db.Digital_RxDgID = (int) this.dat[729];
      this.db.Digital_TxDgID = (int) this.dat[730];
      this.db.WiresX_DgID = (int) this.dat[731];
      this.db.Digital_Popup = (int) this.dat[735];
      this.db.Display_BgClr = (int) this.dat[736];
      this.db.Display_Altitude = (int) this.dat[737] & 1;
      this.db.Display_TimerClk = ((int) this.dat[737] & 2) >> 1;
      this.db.Display_GpsInfo = ((int) this.dat[737] & 4) >> 2;
      if (Settings.Instance.MaskID == 2)
      {
        this.db.Config_MicProgKeyP1 = this.dat[739] > (byte) 233 ? (int) this.dat[739] - 220 - 1 : (int) this.dat[739] - 220;
        this.db.Config_MicProgKeyP2 = this.dat[740] > (byte) 233 ? (int) this.dat[740] - 220 - 1 : (int) this.dat[740] - 220;
        this.db.Config_MicProgKeyP3 = this.dat[741] > (byte) 233 ? (int) this.dat[741] - 220 - 1 : (int) this.dat[741] - 220;
        if (this.dat[742] <= (byte) 233)
          this.db.Config_MicProgKeyP4 = (int) this.dat[742] - 220;
        else
          this.db.Config_MicProgKeyP4 = (int) this.dat[742] - 220 - 1;
      }
      else
      {
        this.db.Config_MicProgKeyP1 = (int) this.dat[739] - 220;
        this.db.Config_MicProgKeyP2 = (int) this.dat[740] - 220;
        this.db.Config_MicProgKeyP3 = (int) this.dat[741] - 220;
        this.db.Config_MicProgKeyP4 = (int) this.dat[742] - 220;
      }
    }

    private void decodeDtmfmemory()
    {
      int num = DataConverter.DTMFMEMORY[0];
      for (int index1 = 0; index1 < this.db.dtmfMemory.Count; ++index1)
      {
        char[] chArray = new char[16];
        for (int index2 = 0; index2 < chArray.Length; ++index2)
        {
          char dtmfChar = Moji.ConvertToDtmfChar(this.dat[num + index2]);
          if (dtmfChar != 'ÿ')
            chArray[index2] = dtmfChar;
          else
            break;
        }
        string str = new string(chArray);
        this.db.dtmfMemory[index1].CODE = str.Replace("\0", "");
        num += 16;
      }
    }

    private void decodeWiresLast()
    {
    }

    private void decodeAdjust()
    {
    }

    private void decodeRadHardMaskId()
    {
    }

    private void decodeLrfHomeName()
    {
      int offset = DataConverter.LRFHOMENAME[0];
      for (int index = 0; index < this.db.aBandHome.Count; ++index)
      {
        this.decodeMemoryNameCommon(this.db.aBandHome, index, this.dat, offset);
        offset += 8;
      }
    }

    private void decodeRrfHomeName()
    {
      int offset = DataConverter.RRFHOMENAME[0];
      for (int index = 0; index < this.db.bBandHome.Count; ++index)
      {
        this.decodeMemoryNameCommon(this.db.bBandHome, index, this.dat, offset);
        offset += 8;
      }
    }

    private void decodeAprs()
    {
      this.db.AprsUnit_Position = (int) this.dat[1280];
      this.db.AprsUnit_Distance = (int) this.dat[1281];
      this.db.AprsUnit_Speed = (int) this.dat[1282];
      this.db.AprsUnit_Altitude = (int) this.dat[1283];
      this.db.AprsUnit_Baro = (int) this.dat[1284];
      this.db.AprsUnit_Temp = (int) this.dat[1285];
      this.db.AprsUnit_Rain = (int) this.dat[1286];
      this.db.AprsUnit_Wind = (int) this.dat[1287];
      char[] chArray1 = new char[6];
      for (int index = 0; index < chArray1.Length; ++index)
      {
        if (this.dat[1288 + index] != (byte) 202)
          chArray1[index] = (char) this.dat[1288 + index];
      }
      this.db.AprsCommon_CallsignCode = new string(chArray1).Replace("\0", "");
      this.db.AprsCommon_CallsignSsId = this.dat[1294] != (byte) 202 ? (int) this.dat[1294] : 0;
      this.db.MyPosition_ManualLat = ((int) this.dat[1296] & 16) >> 4;
      this.db.MyPosition_ManualLatDD = (Decimal) this.conv_1byteBcdToInteger(this.dat[1297]);
      this.db.MyPosition_ManualLatMM1 = (Decimal) this.conv_1byteBcdToInteger(this.dat[1298]);
      this.db.MyPosition_ManualLatMM2 = (Decimal) ((((int) this.dat[1299] << 8) + (int) this.dat[1300]) / 10);
      this.db.MyPosition_ManualLon = ((int) this.dat[1301] & 16) >> 4;
      this.db.MyPosition_ManualLonDD = (Decimal) (((int) this.dat[1301] & 15) * 100 + this.conv_1byteBcdToInteger(this.dat[1302]));
      this.db.MyPosition_ManualLonMM1 = (Decimal) this.conv_1byteBcdToInteger(this.dat[1303]);
      this.db.MyPosition_ManualLonMM2 = (Decimal) ((((int) this.dat[1304] << 8) + (int) this.dat[1305]) / 10);
      char[] chArray2 = new char[6];
      for (int index = 0; index < chArray2.Length; ++index)
      {
        if (this.dat[1306 + index] != (byte) 202)
          chArray2[index] = (char) this.dat[1306 + index];
      }
      this.db.MsgReply_CallSignCode = new string(chArray2);
      this.db.MsgReply_CallSignSsId = this.dat[1312] != (byte) 202 ? (this.dat[1312] != (byte) 42 ? (int) this.dat[1312] : 16) : 0;
      this.db.MySymbol_1_Icn = new string(new char[2]
      {
        (char) this.dat[1314],
        (char) this.dat[1315]
      });
      this.db.MySymbol_2_Icn = new string(new char[2]
      {
        (char) this.dat[1316],
        (char) this.dat[1317]
      });
      this.db.MySymbol_3_Icn = new string(new char[2]
      {
        (char) this.dat[1318],
        (char) this.dat[1319]
      });
      char[] chArray3 = new char[1]{ (char) this.dat[1320] };
      this.db.MySymbol_41_Icn = new string(chArray3);
      chArray3[0] = (char) this.dat[1321];
      this.db.MySymbol_42_Icn = new string(chArray3);
      this.db.AprsFilter_RangeLimit = ((int) this.dat[1322] << 8) + (int) this.dat[1323];
      this.db.MySymbol_Sel = (int) this.dat[1324];
      this.db.DigiPath_Sel = (int) this.dat[1325];
      this.db.AprsCommon_Intrvl = (int) this.dat[1326];
      this.db.AprsCommon_RtLmt = (int) this.dat[1327] - 5;
      this.db.AprsCommon_LwSpd = (int) this.dat[1328] - 1;
      this.db.AprsCommon_Ambgty = (int) this.dat[1329];
      this.db.AprsCommon_PstnCmnt = (int) this.dat[1330];
      this.db.MsgReply_Reply = (int) this.dat[1331] & 1;
      this.db.AprsCommon_Alttd = ((int) this.dat[1331] & 4) >> 2;
      this.db.AprsCommon_SpdCrc = ((int) this.dat[1331] & 8) >> 3;
      this.db.AprsCommon_Dcy = ((int) this.dat[1331] & 16) >> 4;
      this.db.AprsCommon_Auto = ((int) this.dat[1331] & 64) >> 6;
      this.db.AprsCommon_Prprtnl = ((int) this.dat[1331] & 128) >> 7;
      this.db.AprsCommon_Modem = (int) this.dat[1332] & 1;
      this.db.AprsCommon_Mute = ((int) this.dat[1332] & 2) >> 1;
      this.db.Data_DSpeedData = ((int) this.dat[1332] & 32) >> 5;
      this.db.Data_DSpeedAprs = ((int) this.dat[1332] & 64) >> 6;
      this.db.Data_DSqlcTx = ((int) this.dat[1333] & 32) >> 5;
      this.db.Data_DSqlcData = ((int) this.dat[1333] & 64) >> 6;
      this.db.Data_DSqlcAprs = ((int) this.dat[1333] & 128) >> 7;
      this.db.BeaconStatusText_Sel = (int) this.dat[1334];
      this.db.BeaconStatusText_TxRate = (int) this.dat[1335];
      this.db.AprsFilter_MicE = (int) this.dat[1336] & 1;
      this.db.AprsFilter_Position = ((int) this.dat[1336] & 2) >> 1;
      this.db.AprsFilter_Weather = ((int) this.dat[1336] & 4) >> 2;
      this.db.AprsFilter_Object = ((int) this.dat[1336] & 8) >> 3;
      this.db.AprsFilter_Item = ((int) this.dat[1336] & 16) >> 4;
      this.db.AprsFilter_Status = ((int) this.dat[1336] & 32) >> 5;
      this.db.AprsFilter_Other = ((int) this.dat[1336] & 64) >> 6;
      this.db.AprsRinger_TxBcn = (int) this.dat[1337];
      this.db.AprsRinger_TxMsg = (int) this.dat[1338];
      this.db.AprsRinger_RxBcn = (int) this.dat[1339];
      this.db.AprsRinger_RxMsg = (int) this.dat[1340];
      this.db.AprsRinger_MyPacket = (int) this.dat[1341];
      this.db.AprsRinger_CllRngr = (int) this.dat[1342];
      this.db.AprsRinger_RngRbgr = (int) this.dat[1343];
      this.db.AprsRinger_MsgVc = (int) this.dat[1344];
      this.db.MyPosition_Sel = (int) this.dat[1345];
      this.db.AprsCommon_Cmps = (int) this.dat[1346];
      this.db.Data_DBandAprs = (int) this.dat[1347];
      this.db.Data_DBandData = (int) this.dat[1348];
      switch (this.dat[1349])
      {
        case byte.MaxValue:
          this.db.AprsPopup_Bcn = 4;
          break;
        case 0:
          this.db.AprsPopup_Bcn = 0;
          break;
        case 3:
          this.db.AprsPopup_Bcn = 1;
          break;
        case 5:
          this.db.AprsPopup_Bcn = 2;
          break;
        case 10:
          this.db.AprsPopup_Bcn = 3;
          break;
        default:
          throw new FormatException();
      }
      switch (this.dat[1350])
      {
        case byte.MaxValue:
          this.db.AprsPopup_Msg = 4;
          break;
        case 0:
          this.db.AprsPopup_Msg = 0;
          break;
        case 3:
          this.db.AprsPopup_Msg = 1;
          break;
        case 5:
          this.db.AprsPopup_Msg = 2;
          break;
        case 10:
          this.db.AprsPopup_Msg = 3;
          break;
        default:
          throw new FormatException();
      }
      this.db.AprsCommon_TxDelay = (int) this.dat[1351];
      this.db.Data_ComOutput = (int) this.dat[1352];
      this.db.Data_ComSpeed = (int) this.dat[1353];
      this.db.SmartBeaconing_Select = (int) this.dat[1354];
      this.db.SmartBeaconing1_LowSpeed = (Decimal) this.dat[1355];
      this.db.SmartBeaconing1_HighSpeed = (Decimal) this.dat[1356];
      this.db.SmartBeaconing1_SlowRate = (Decimal) this.dat[1357];
      this.db.SmartBeaconing1_FastRate = (Decimal) this.dat[1358];
      this.db.SmartBeaconing1_TurnAngle = (Decimal) this.dat[1359];
      this.db.SmartBeaconing1_TurnSlope = (Decimal) this.dat[1360];
      this.db.SmartBeaconing1_TurnTime = (Decimal) this.dat[1361];
      this.db.SmartBeaconing2_LowSpeed = (Decimal) this.dat[1362];
      this.db.SmartBeaconing2_HighSpeed = (Decimal) this.dat[1363];
      this.db.SmartBeaconing2_SlowRate = (Decimal) this.dat[1364];
      this.db.SmartBeaconing2_FastRate = (Decimal) this.dat[1365];
      this.db.SmartBeaconing2_TurnAngle = (Decimal) this.dat[1366];
      this.db.SmartBeaconing2_TurnSlope = (Decimal) this.dat[1367];
      this.db.SmartBeaconing2_TurnTime = (Decimal) this.dat[1368];
      this.db.SmartBeaconing3_LowSpeed = (Decimal) this.dat[1369];
      this.db.SmartBeaconing3_HighSpeed = (Decimal) this.dat[1370];
      this.db.SmartBeaconing3_SlowRate = (Decimal) this.dat[1371];
      this.db.SmartBeaconing3_FastRate = (Decimal) this.dat[1372];
      this.db.SmartBeaconing3_TurnAngle = (Decimal) this.dat[1373];
      this.db.SmartBeaconing3_TurnSlope = (Decimal) this.dat[1374];
      this.db.SmartBeaconing3_TurnTime = (Decimal) this.dat[1375];
      this.db.AprsMsgText_Sel = (int) this.dat[1376];
      this.db.AprsFilter_Altnet = ((int) this.dat[1377] & 32) >> 5;
      this.db.AprsPopup_MyPacket = ((int) this.dat[1377] & 64) >> 6;
      this.db.Data_ComWpFormat = (int) this.dat[1378];
      this.db.Data_ComWpFilter = this.dat[1379] > (byte) 7 ? (int) this.dat[1379] - 1 : (int) this.dat[1379];
      this.db.AprsPopupColor_Bcn = (int) this.dat[1381];
      this.db.AprsPopupColor_Mbl = (int) this.dat[1382];
      this.db.AprsPopupColor_ObjItm = (int) this.dat[1383];
      this.db.AprsPopupColor_CllRngr = (int) this.dat[1384];
      this.db.AprsPopupColor_RngRngr = (int) this.dat[1385];
      this.db.AprsPopupColor_Msg = (int) this.dat[1386];
      this.db.AprsPopupColor_GrpBult = (int) this.dat[1387];
      this.db.AprsPopupColor_MyPckt = (int) this.dat[1388];
      this.db.VoiceAleat_VoiceAleat = (int) this.dat[1389];
      this.db.VoiceAleat_ToneSql = (int) this.dat[1390];
      this.db.VoiceAleat_Dcs = (int) this.dat[1391];
      this.db.SortFilter_Sort = (int) this.dat[1392];
      this.db.SortFilter_Filter = (int) this.dat[1393];
    }

    private void decodeReplyText()
    {
      int num = DataConverter.REPLYTEXT[0];
      char[] chArray = new char[64];
      for (int index = 0; index < chArray.Length; ++index)
      {
        if (this.dat[num + index] != (byte) 202)
          chArray[index] = (char) this.dat[num + index];
      }
      this.db.MsgReply_ReplyText = new string(chArray).Replace("\0", "");
    }

    private void decodeMessageGroup()
    {
      int num = DataConverter.MESSAGEGROUP[0];
      string[] strArray = new string[9];
      for (int index1 = 0; index1 < strArray.Length; ++index1)
      {
        char[] chArray = new char[9];
        for (int index2 = 0; index2 < chArray.Length; ++index2)
        {
          if (this.dat[num + index2] != (byte) 202)
            chArray[index2] = (char) this.dat[num + index2];
        }
        string str = new string(chArray);
        strArray[index1] = str.Replace("\0", "");
        num += 10;
      }
      this.db.AprsMsgGroup_G1 = strArray[0];
      this.db.AprsMsgGroup_G2 = strArray[1];
      this.db.AprsMsgGroup_G3 = strArray[2];
      this.db.AprsMsgGroup_G4 = strArray[3];
      this.db.AprsMsgGroup_G5 = strArray[4];
      this.db.AprsMsgGroup_G6 = strArray[5];
      this.db.AprsMsgGroup_B1 = strArray[6];
      this.db.AprsMsgGroup_B2 = strArray[7];
      this.db.AprsMsgGroup_B3 = strArray[8];
    }

    private void decodeDigiPath()
    {
      int num = DataConverter.DIGIPATH[0];
      string[] strArray = new string[24];
      int[] numArray = new int[24];
      for (int index1 = 0; index1 < strArray.Length; ++index1)
      {
        char[] chArray = new char[6];
        for (int index2 = 0; index2 < chArray.Length; ++index2)
        {
          if (this.dat[num + index2] != (byte) 202)
            chArray[index2] = (char) this.dat[num + index2];
        }
        string str = new string(chArray);
        strArray[index1] = str.Replace("\0", "");
        numArray[index1] = this.dat[num + 6] != (byte) 202 ? (int) this.dat[num + 6] : 0;
        num += 8;
      }
      this.db.DigiPathCode_P11 = strArray[0];
      this.db.DigiPathCode_P12 = strArray[1];
      this.db.DigiPathCode_P21 = strArray[2];
      this.db.DigiPathCode_P22 = strArray[3];
      this.db.DigiPathCode_P31 = strArray[4];
      this.db.DigiPathCode_P32 = strArray[5];
      this.db.DigiPathCode_P41 = strArray[6];
      this.db.DigiPathCode_P42 = strArray[7];
      this.db.DigiPathCode_F11 = strArray[8];
      this.db.DigiPathCode_F12 = strArray[9];
      this.db.DigiPathCode_F13 = strArray[10];
      this.db.DigiPathCode_F14 = strArray[11];
      this.db.DigiPathCode_F15 = strArray[12];
      this.db.DigiPathCode_F16 = strArray[13];
      this.db.DigiPathCode_F17 = strArray[14];
      this.db.DigiPathCode_F18 = strArray[15];
      this.db.DigiPathCode_F21 = strArray[16];
      this.db.DigiPathCode_F22 = strArray[17];
      this.db.DigiPathCode_F23 = strArray[18];
      this.db.DigiPathCode_F24 = strArray[19];
      this.db.DigiPathCode_F25 = strArray[20];
      this.db.DigiPathCode_F26 = strArray[21];
      this.db.DigiPathCode_F27 = strArray[22];
      this.db.DigiPathCode_F28 = strArray[23];
      this.db.DigiPathSsId_P11 = numArray[0];
      this.db.DigiPathSsId_P12 = numArray[1];
      this.db.DigiPathSsId_P21 = numArray[2];
      this.db.DigiPathSsId_P22 = numArray[3];
      this.db.DigiPathSsId_P31 = numArray[4];
      this.db.DigiPathSsId_P32 = numArray[5];
      this.db.DigiPathSsId_P41 = numArray[6];
      this.db.DigiPathSsId_P42 = numArray[7];
      this.db.DigiPathSsId_F11 = numArray[8];
      this.db.DigiPathSsId_F12 = numArray[9];
      this.db.DigiPathSsId_F13 = numArray[10];
      this.db.DigiPathSsId_F14 = numArray[11];
      this.db.DigiPathSsId_F15 = numArray[12];
      this.db.DigiPathSsId_F16 = numArray[13];
      this.db.DigiPathSsId_F17 = numArray[14];
      this.db.DigiPathSsId_F18 = numArray[15];
      this.db.DigiPathSsId_F21 = numArray[16];
      this.db.DigiPathSsId_F22 = numArray[17];
      this.db.DigiPathSsId_F23 = numArray[18];
      this.db.DigiPathSsId_F24 = numArray[19];
      this.db.DigiPathSsId_F25 = numArray[20];
      this.db.DigiPathSsId_F26 = numArray[21];
      this.db.DigiPathSsId_F27 = numArray[22];
      this.db.DigiPathSsId_F28 = numArray[23];
    }

    private void decodeCallRingerSign()
    {
      int num = DataConverter.CALLRINGERSIGN[0];
      string[] strArray = new string[8];
      int[] numArray = new int[8];
      for (int index1 = 0; index1 < strArray.Length; ++index1)
      {
        char[] chArray = new char[6];
        for (int index2 = 0; index2 < chArray.Length; ++index2)
        {
          if (this.dat[num + index2] != (byte) 202)
            chArray[index2] = (char) this.dat[num + index2];
        }
        string str = new string(chArray);
        strArray[index1] = str.Replace("\0", "");
        numArray[index1] = this.dat[num + 6] != (byte) 202 ? (int) this.dat[num + 6] : 0;
        num += 8;
      }
      this.db.AprsRingerCallCode_1 = strArray[0];
      this.db.AprsRingerCallCode_2 = strArray[1];
      this.db.AprsRingerCallCode_3 = strArray[2];
      this.db.AprsRingerCallCode_4 = strArray[3];
      this.db.AprsRingerCallCode_5 = strArray[4];
      this.db.AprsRingerCallCode_6 = strArray[5];
      this.db.AprsRingerCallCode_7 = strArray[6];
      this.db.AprsRingerCallCode_8 = strArray[7];
      this.db.AprsRingerCallSsID_1 = numArray[0];
      this.db.AprsRingerCallSsID_2 = numArray[1];
      this.db.AprsRingerCallSsID_3 = numArray[2];
      this.db.AprsRingerCallSsID_4 = numArray[3];
      this.db.AprsRingerCallSsID_5 = numArray[4];
      this.db.AprsRingerCallSsID_6 = numArray[5];
      this.db.AprsRingerCallSsID_7 = numArray[6];
      this.db.AprsRingerCallSsID_8 = numArray[7];
    }

    private void decodeMessageText()
    {
      int num = DataConverter.MESSAGETEXT[0];
      string[] strArray = new string[8];
      for (int index1 = 0; index1 < strArray.Length; ++index1)
      {
        char[] chArray = new char[16];
        for (int index2 = 0; index2 < chArray.Length; ++index2)
        {
          if (this.dat[num + index2] != (byte) 202)
            chArray[index2] = (char) this.dat[num + index2];
        }
        string str = new string(chArray);
        strArray[index1] = str.Replace("\0", "");
        num += 16;
      }
      this.db.AprsMsgText_1 = strArray[0];
      this.db.AprsMsgText_2 = strArray[1];
      this.db.AprsMsgText_3 = strArray[2];
      this.db.AprsMsgText_4 = strArray[3];
      this.db.AprsMsgText_5 = strArray[4];
      this.db.AprsMsgText_6 = strArray[5];
      this.db.AprsMsgText_7 = strArray[6];
      this.db.AprsMsgText_8 = strArray[7];
    }

    private void decodeLbandMemory()
    {
      int offset = DataConverter.LBANDMEMORY[0];
      for (int index = 0; index < this.db.aBandMemory.Count; ++index)
      {
        this.decodeMemoryCommon(this.db.aBandMemory, index, this.dat, offset);
        offset += 16;
      }
      for (int index = 0; index < this.db.aBandPmsMemory.Count; ++index)
      {
        this.decodeMemoryCommon(this.db.aBandPmsMemory, index, this.dat, offset);
        offset += 16;
      }
    }

    private void decodeRbandMemory()
    {
      int offset = DataConverter.RBANDMEMORY[0];
      for (int index = 0; index < this.db.bBandMemory.Count; ++index)
      {
        this.decodeMemoryCommon(this.db.bBandMemory, index, this.dat, offset);
        offset += 16;
      }
      for (int index = 0; index < this.db.bBandPmsMemory.Count; ++index)
      {
        this.decodeMemoryCommon(this.db.bBandPmsMemory, index, this.dat, offset);
        offset += 16;
      }
    }

    private void decodeLbandMemoryName()
    {
      int offset = DataConverter.LBANDMEMORYNAME[0];
      for (int index = 0; index < this.db.aBandMemory.Count; ++index)
      {
        this.decodeMemoryNameCommon(this.db.aBandMemory, index, this.dat, offset);
        offset += 8;
      }
      for (int index = 0; index < this.db.aBandPmsMemory.Count; ++index)
      {
        this.decodeMemoryNameCommon(this.db.aBandPmsMemory, index, this.dat, offset);
        offset += 8;
      }
    }

    private void decodeRbandMemoryName()
    {
      int offset = DataConverter.RBANDMEMORYNAME[0];
      for (int index = 0; index < this.db.bBandMemory.Count; ++index)
      {
        this.decodeMemoryNameCommon(this.db.bBandMemory, index, this.dat, offset);
        offset += 8;
      }
      for (int index = 0; index < this.db.bBandPmsMemory.Count; ++index)
      {
        this.decodeMemoryNameCommon(this.db.bBandPmsMemory, index, this.dat, offset);
        offset += 8;
      }
    }

    private void decodeBackTrackMemory()
    {
    }

    private void decodePhraseMemory()
    {
      int num = DataConverter.PHRASEMEMORY[0];
      char[] chArray = new char[80];
      for (int index1 = 0; index1 < this.db.messageText.Count; ++index1)
      {
        for (int index2 = 0; index2 < chArray.Length; ++index2)
        {
          char messageTextChar = Moji.ConvertToMessageTextChar(this.dat[num + index2]);
          chArray[index2] = messageTextChar == 'ÿ' ? char.MinValue : messageTextChar;
        }
        string str = chArray[0] != char.MinValue ? new string(chArray) : "";
        this.db.messageText[index1].Message = str.Replace("\0", "");
        num += 128;
      }
    }

    private void decodeWiresCateName()
    {
      int num = DataConverter.WIRESCATENAME[0];
      char[] chArray = new char[16];
      for (int index1 = 0; index1 < this.db.category.Count; ++index1)
      {
        for (int index2 = 0; index2 < chArray.Length; ++index2)
        {
          char categoryChar = Moji.ConvertToCategoryChar(this.dat[num + index2]);
          chArray[index2] = categoryChar == 'Ê' ? char.MinValue : categoryChar;
        }
        string str = chArray[0] != char.MinValue ? new string(chArray) : "";
        this.db.category[index1].Name = str.Replace("\0", "");
        num += 16;
      }
    }

    private void decodeGmName()
    {
      int index1 = DataConverter.GMGNAME[0] + 16;
      string[] strArray = new string[16];
      for (int index2 = 0; index2 < strArray.Length; ++index2)
      {
        char[] chArray = new char[16];
        if (this.dat[index1] != byte.MaxValue)
        {
          for (int index3 = 0; index3 < chArray.Length; ++index3)
          {
            if (this.dat[index1 + index3] != byte.MaxValue)
              chArray[index3] = Moji.ConvertToGroupNameChar(this.dat[index1 + index3]);
          }
        }
        string str = new string(chArray);
        strArray[index2] = str.Replace("\0", "");
        index1 += 16;
      }
      for (int index2 = 0; index2 < this.db.group.Count; ++index2)
      {
        int num = (int) this.dat[673 + index2];
        this.db.group[index2].GroupName = num == (int) byte.MaxValue ? "" : strArray[num - 1];
      }
    }

    private void decodePreset()
    {
    }

    private void decodeStatusText()
    {
      int num = DataConverter.STATUSTEXT[0];
      string[] strArray = new string[5];
      int[] numArray = new int[5];
      for (int index1 = 0; index1 < strArray.Length; ++index1)
      {
        char[] chArray = new char[60];
        for (int index2 = 0; index2 < chArray.Length; ++index2)
        {
          if (this.dat[num + index2] != (byte) 202)
            chArray[index2] = (char) this.dat[num + index2];
        }
        string str = new string(chArray);
        strArray[index1] = str.Replace("\0", "");
        numArray[index1] = (int) this.dat[num + 60];
        num += 64;
      }
      this.db.BeaconStatusText_1 = strArray[0];
      this.db.BeaconStatusText_2 = strArray[1];
      this.db.BeaconStatusText_3 = strArray[2];
      this.db.BeaconStatusText_4 = strArray[3];
      this.db.BeaconStatusText_5 = strArray[4];
      this.db.BeaconStatusText_1_Mode = numArray[0];
      this.db.BeaconStatusText_2_Mode = numArray[1];
      this.db.BeaconStatusText_3_Mode = numArray[2];
      this.db.BeaconStatusText_4_Mode = numArray[3];
      this.db.BeaconStatusText_5_Mode = numArray[4];
    }

    private void decodeStationMemory()
    {
    }

    private void decodeMessageMemory()
    {
    }

    private void decodeStationInfoMemory()
    {
    }

    private void decodeMessageInfoMemory()
    {
    }

    private void decodeGmMemberMemory()
    {
      int num1 = DataConverter.GMMEMBERMEMORY[0] + 512;
      string[,] strArray = new string[16, 24];
      for (int index1 = 0; index1 < this.db.group.Count; ++index1)
      {
        for (int index2 = 0; index2 < 24; ++index2)
        {
          char[] chArray = new char[10];
          for (int index3 = 0; index3 < chArray.Length; ++index3)
          {
            if (this.dat[num1 + 5 + index3] != byte.MaxValue)
              chArray[index3] = (char) this.dat[num1 + 5 + index3];
          }
          string str = new string(chArray);
          strArray[index1, index2] = str.Replace("\0", "");
          num1 += 15;
        }
        num1 = num1 + 24 + 128;
      }
      for (int index = 0; index < this.db.group.Count; ++index)
      {
        int num2 = (int) this.dat[673 + index];
        if (num2 != (int) byte.MaxValue)
        {
          this.db.group[index].MemberName1 = strArray[num2 - 1, 0];
          this.db.group[index].MemberName2 = strArray[num2 - 1, 1];
          this.db.group[index].MemberName3 = strArray[num2 - 1, 2];
          this.db.group[index].MemberName4 = strArray[num2 - 1, 3];
          this.db.group[index].MemberName5 = strArray[num2 - 1, 4];
          this.db.group[index].MemberName6 = strArray[num2 - 1, 5];
          this.db.group[index].MemberName7 = strArray[num2 - 1, 6];
          this.db.group[index].MemberName8 = strArray[num2 - 1, 7];
          this.db.group[index].MemberName9 = strArray[num2 - 1, 8];
          this.db.group[index].MemberName10 = strArray[num2 - 1, 9];
          this.db.group[index].MemberName11 = strArray[num2 - 1, 10];
          this.db.group[index].MemberName12 = strArray[num2 - 1, 11];
          this.db.group[index].MemberName13 = strArray[num2 - 1, 12];
          this.db.group[index].MemberName14 = strArray[num2 - 1, 13];
          this.db.group[index].MemberName15 = strArray[num2 - 1, 14];
          this.db.group[index].MemberName16 = strArray[num2 - 1, 15];
          this.db.group[index].MemberName17 = strArray[num2 - 1, 16];
          this.db.group[index].MemberName18 = strArray[num2 - 1, 17];
          this.db.group[index].MemberName19 = strArray[num2 - 1, 18];
          this.db.group[index].MemberName20 = strArray[num2 - 1, 19];
          this.db.group[index].MemberName21 = strArray[num2 - 1, 20];
          this.db.group[index].MemberName22 = strArray[num2 - 1, 21];
          this.db.group[index].MemberName23 = strArray[num2 - 1, 22];
          this.db.group[index].MemberName24 = strArray[num2 - 1, 23];
        }
        else
        {
          this.db.group[index].MemberName1 = "";
          this.db.group[index].MemberName2 = "";
          this.db.group[index].MemberName3 = "";
          this.db.group[index].MemberName4 = "";
          this.db.group[index].MemberName5 = "";
          this.db.group[index].MemberName6 = "";
          this.db.group[index].MemberName7 = "";
          this.db.group[index].MemberName8 = "";
          this.db.group[index].MemberName9 = "";
          this.db.group[index].MemberName10 = "";
          this.db.group[index].MemberName11 = "";
          this.db.group[index].MemberName12 = "";
          this.db.group[index].MemberName13 = "";
          this.db.group[index].MemberName14 = "";
          this.db.group[index].MemberName15 = "";
          this.db.group[index].MemberName16 = "";
          this.db.group[index].MemberName17 = "";
          this.db.group[index].MemberName18 = "";
          this.db.group[index].MemberName19 = "";
          this.db.group[index].MemberName20 = "";
          this.db.group[index].MemberName21 = "";
          this.db.group[index].MemberName22 = "";
          this.db.group[index].MemberName23 = "";
          this.db.group[index].MemberName24 = "";
        }
      }
    }

    private void decodeWiresCateUserId()
    {
    }

    private void decodeMemoryCommon(BindingList<BandMemory> memory, int index, byte[] dat, int offset)
    {
      byte[] bcdBytes = new byte[3];
      switch (((int) dat[offset] & 96) >> 5)
      {
        case 0:
          memory[index].Skip = 0;
          break;
        case 1:
          memory[index].Skip = 1;
          break;
        case 2:
          memory[index].Skip = 2;
          break;
      }
      memory[index].MemoryDir = Convert.ToBoolean(((int) dat[offset] & 128) >> 7);
      switch ((int) dat[offset + 1] & 7)
      {
        case 0:
          memory[index].ShiftDir = 0;
          break;
        case 2:
          memory[index].ShiftDir = 1;
          break;
        case 3:
          memory[index].ShiftDir = 2;
          break;
        case 4:
          memory[index].ShiftDir = 3;
          break;
      }
      switch (((int) dat[offset + 1] & 48) >> 4)
      {
        case 0:
          memory[index].Mode = 0;
          break;
        case 1:
          memory[index].Mode = 1;
          break;
        case 2:
          memory[index].Mode = 2;
          break;
      }
      int num1 = (int) dat[offset + 5] & 15;
      bcdBytes[0] = (byte) ((((int) dat[offset + 2] & 15) << 4) + (((int) dat[offset + 3] & 240) >> 4));
      bcdBytes[1] = (byte) ((((int) dat[offset + 3] & 15) << 4) + (((int) dat[offset + 4] & 240) >> 4));
      bcdBytes[2] = (byte) (((int) dat[offset + 4] & 15) << 4);
      Decimal num2 = this.conv_3byteFreqBcdToDecimal(bcdBytes) + this.GetAddFreqDecimal(((int) dat[offset + 2] & 240) >> 4);
      memory[index].RecvFreq = num2;
      memory[index].SqlType = ((int) dat[offset + 5] & 240) >> 4;
      memory[index].Step = num1;
      bcdBytes[0] = (byte) ((((int) dat[offset + 6] & 15) << 4) + (((int) dat[offset + 7] & 240) >> 4));
      bcdBytes[1] = (byte) ((((int) dat[offset + 7] & 15) << 4) + (((int) dat[offset + 8] & 240) >> 4));
      bcdBytes[2] = (byte) (((int) dat[offset + 8] & 15) << 4);
      Decimal num3 = this.conv_3byteFreqBcdToDecimal(bcdBytes) + this.GetAddFreqDecimal(((int) dat[offset + 6] & 240) >> 4);
      memory[index].SendFreq = num3;
      memory[index].ToneFreq = (int) dat[offset + 9] & 63;
      memory[index].SendOut = ((int) dat[offset + 9] & 192) >> 6;
      memory[index].DcsCode = (int) dat[offset + 10] & (int) sbyte.MaxValue;
      memory[index].ClockShift = Convert.ToBoolean(((int) dat[offset + 10] & 128) >> 7);
      memory[index].PrTone = ((int) dat[offset + 11] & 31) - 3;
      int num4 = ((int) dat[offset + 12] << 8) + (int) dat[offset + 13];
      memory[index].ShiftFreq = (Decimal) num4 * new Decimal(5, 0, 0, false, (byte) 2);
    }

    private void decodeMemoryNameCommon(BindingList<BandMemory> memory, int index, byte[] dat, int offset)
    {
      char[] chArray = new char[8];
      for (int index1 = 0; index1 < chArray.Length; ++index1)
      {
        char memoryNameChar = Moji.ConvertToMemoryNameChar(dat[offset + index1]);
        chArray[index1] = memoryNameChar == 'Ê' ? char.MinValue : memoryNameChar;
      }
      string str = chArray[0] != char.MinValue ? new string(chArray) : "";
      memory[index].MemoryName = str.Replace("\0", "");
    }

    private void encodeHeader()
    {
      byte[] buf = new byte[(int) sbyte.MaxValue];
      this.dat[8] = (byte) Settings.Instance.MaskID;
      this.dat[9] = (byte) Settings.Instance.MtxPTN;
      this.dat[10] = (byte) Settings.Instance.VerTBL;
      for (int index = 0; index < buf.Length; ++index)
        buf[index] = this.dat[index];
      this.dat[(int) sbyte.MaxValue] = this.calc_CheckSum(buf);
    }

    private void encodeBackup()
    {
      this.encodeMemoryCommon(this.db.aBandVfo, (int) this.dat[196], this.dat, 128);
      this.encodeMemoryCommon(this.db.bBandVfo, (int) this.dat[212], this.dat, 144);
      this.dat[161] = (byte) this.db.Config_Unit;
      this.dat[164] = this.db.Config_Apo != 0 ? (this.db.Config_Apo > 4 ? (byte) (128 + (this.db.Config_Apo * 2 - 5)) : (byte) (128 + (this.db.Config_Apo - 1))) : (byte) 0;
      this.dat[168] = this.db.Config_TimeZone >= 28 ? (byte) (this.db.Config_TimeZone - 28) : (byte) (128 + (28 - this.db.Config_TimeZone));
      this.dat[169] = (byte) this.db.Option_VcMemVlm;
      this.dat[170] = (byte) this.db.Config_Tot;
      this.dat[174] = (byte) this.db.Option_VcMemAnnc;
      switch (this.db.Config_GpsDtm)
      {
        case 0:
          this.dat[175] = (byte) 21;
          break;
        case 1:
          this.dat[175] = (byte) 179;
          break;
        default:
          throw new FormatException();
      }
      switch (this.db.Config_GpsLog)
      {
        case 0:
          this.dat[180] = (byte) 3;
          break;
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
        case 6:
          this.dat[180] = (byte) (128 + this.db.Config_GpsLog - 1);
          break;
        default:
          throw new FormatException();
      }
      this.dat[181] = (byte) (this.db.FuncSet_Array1 + 1);
      this.dat[182] = (byte) (this.db.FuncSet_Array2 + 1);
      this.dat[183] = (byte) (this.db.FuncSet_Array3 + 1);
      this.dat[184] = (byte) (this.db.FuncSet_Array4 + 1);
      byte[] numArray1 = new byte[3];
      byte[] numArray2 = this.conv_DecimalTo3byteFreqBcd(this.db.WiresX_PresetFreq);
      this.dat[185] = (byte) ((((int) numArray2[2] & 15) << 4) + (((int) numArray2[0] & 240) >> 4));
      this.dat[186] = (byte) ((((int) numArray2[0] & 15) << 4) + (((int) numArray2[1] & 240) >> 4));
      this.dat[187] = (byte) ((((int) numArray2[1] & 15) << 4) + (((int) numArray2[2] & 240) >> 4));
      this.dat[201] = (byte) this.db.Scan_ScanRsmA;
      this.dat[217] = (byte) this.db.Scan_ScanRsmB;
      this.bitSet(226, this.db.Scan_DWStopA, 2);
      this.bitSet(226, this.db.Signaling_WxAlrtA, 64);
      this.bitSet(227, this.db.Signaling_SqlExA, 1);
      this.bitSet(227, this.db.Config_AtStepA, 8);
      this.bitSet(227, this.db.Config_AtModeA, 16);
      this.bitSet(227, this.db.Config_RxCovA, 32);
      this.bitSet(228, this.db.Config_AtRptShftA, 4);
      this.bitSet(228, this.db.Scan_ScanDrctnA, 32);
      this.bitSet(229, this.db.Display_BandScpA, 32);
      this.bitSet(232, this.db.Display_TgtLctn, 4);
      this.bitSet(232, this.db.Display_TimeVdd, 8);
      this.bitSet(232, this.db.Digital_StandbyBeep, 16);
      switch (this.db.Audio_SubBandMute)
      {
        case 0:
          this.bitSet(233, 0, 3);
          break;
        case 1:
          this.bitSet(233, 3, 3);
          break;
        default:
          throw new FormatException();
      }
      this.bitSet(234, this.db.Option_BltthBttery, 1);
      this.bitSet(235, this.db.Option_RxMute, 4);
      switch (this.db.Config_Beep)
      {
        case 0:
          this.bitSet(235, 0, 8);
          this.bitSet(250, 0, 16);
          break;
        case 1:
          this.bitSet(235, 1, 8);
          this.bitSet(250, 0, 16);
          break;
        case 2:
          this.bitSet(235, 1, 8);
          this.bitSet(250, 1, 16);
          break;
        default:
          throw new FormatException();
      }
      this.bitSet(235, this.db.Option_VcMemLng, 64);
      this.bitSet(235, this.db.Digital_LocationService, 128);
      this.bitSet(236, this.db.WiresX_SearchSetup, 8);
      this.bitSet(236, this.db.WiresX_RptWiresFreq, 16);
      this.bitSet(236, this.db.Gm_RangeRinger, 32);
      this.bitSet(236, this.db.Config_GpsDev, 128);
      this.dat[238] = (byte) this.db.Digital_AmsTxMode;
      this.bitSet(242, this.db.Scan_DWStopB, 2);
      this.bitSet(242, this.db.Signaling_WxAlrtB, 64);
      this.bitSet(243, this.db.Signaling_SqlExB, 1);
      this.bitSet(243, this.db.Config_AtStepB, 8);
      this.bitSet(243, this.db.Config_AtModeB, 16);
      this.bitSet(243, this.db.Config_RxCovB, 32);
      this.bitSet(244, this.db.Config_AtRptShftB, 4);
      this.bitSet(244, this.db.Scan_ScanDrctnB, 32);
      this.bitSet(245, this.db.Display_BandScpB, 32);
      this.bitSet(248, this.db.Option_BltthAudio, 1);
      this.bitSet(248, this.db.Signaling_AutDialer, 4);
      switch (this.db.Config_DtTmFrmtDt)
      {
        case 0:
          this.bitSet(249, 2, 7);
          break;
        case 1:
          this.bitSet(249, 0, 7);
          break;
        case 2:
          this.bitSet(249, 4, 7);
          break;
        case 3:
          this.bitSet(249, 1, 7);
          break;
        default:
          throw new FormatException();
      }
      this.bitSet(249, this.db.Config_DtTmFrmtHr, 16);
      this.bitSet(250, this.db.Option_VcMemPR, 1);
    }

    private void encodeLrfVfo()
    {
      int offset = DataConverter.LRFVFO[0];
      for (int index = 0; index < this.db.aBandVfo.Count; ++index)
      {
        this.encodeMemoryCommon(this.db.aBandVfo, index, this.dat, offset);
        offset += 16;
      }
    }

    private void encodeRrfVfo()
    {
      int offset = DataConverter.RRFVFO[0];
      for (int index = 0; index < this.db.bBandVfo.Count; ++index)
      {
        this.encodeMemoryCommon(this.db.bBandVfo, index, this.dat, offset);
        offset += 16;
      }
    }

    private void encodeLrfHome()
    {
      int offset = DataConverter.LRFHOME[0];
      for (int index = 0; index < this.db.aBandHome.Count; ++index)
      {
        this.encodeMemoryCommon(this.db.aBandHome, index, this.dat, offset);
        offset += 16;
      }
    }

    private void encodeRrfHome()
    {
      int offset = DataConverter.RRFHOME[0];
      for (int index = 0; index < this.db.bBandHome.Count; ++index)
      {
        this.encodeMemoryCommon(this.db.bBandHome, index, this.dat, offset);
        offset += 16;
      }
    }

    private void encodeSystem()
    {
      this.dat[652] = (byte) this.db.Signaling_BellRingerA;
      this.dat[668] = (byte) this.db.Signaling_BellRingerB;
      for (int index = 0; index < this.db.group.Count; ++index)
        this.dat[673 + index] = this.db.group[index].GroupName == "" || this.db.group[index].GroupName == null ? byte.MaxValue : (byte) (index + 1);
      this.conv_StringToBytes(this.db.Gm_CallSign, 10, false).CopyTo((Array) this.dat, 696);
      this.dat[709] = (byte) this.db.Display_LcdBrigtness;
      this.dat[711] = (byte) this.db.Audio_MicGain;
      this.dat[713] = (byte) this.db.Display_LcdContrast;
      this.dat[714] = (byte) this.db.Signaling_PageRx1;
      this.dat[715] = (byte) this.db.Signaling_PageRx2;
      this.dat[716] = (byte) this.db.Signaling_PageTx1;
      this.dat[717] = (byte) this.db.Signaling_PageTx2;
      this.dat[722] = (byte) this.db.Option_BltthVox;
      this.dat[723] = (byte) this.db.Option_UsbCmrSize;
      this.dat[724] = (byte) this.db.Option_UsbCmrQlty;
      this.dat[726] = (byte) this.db.Digital_SqlType;
      this.dat[727] = (byte) (this.db.Digital_SqlCode + 1);
      this.dat[729] = (byte) this.db.Digital_RxDgID;
      this.dat[730] = (byte) this.db.Digital_TxDgID;
      this.dat[731] = (byte) this.db.WiresX_DgID;
      this.dat[735] = (byte) this.db.Digital_Popup;
      this.dat[736] = (byte) this.db.Display_BgClr;
      this.bitSet(737, this.db.Display_Altitude, 1);
      this.bitSet(737, this.db.Display_TimerClk, 2);
      this.bitSet(737, this.db.Display_GpsInfo, 4);
      if (Settings.Instance.MaskID == 2)
      {
        this.dat[739] = this.db.Config_MicProgKeyP1 > 12 ? (byte) (this.db.Config_MicProgKeyP1 + 220 + 1) : (byte) (this.db.Config_MicProgKeyP1 + 220);
        this.dat[740] = this.db.Config_MicProgKeyP2 > 12 ? (byte) (this.db.Config_MicProgKeyP2 + 220 + 1) : (byte) (this.db.Config_MicProgKeyP2 + 220);
        this.dat[741] = this.db.Config_MicProgKeyP3 > 12 ? (byte) (this.db.Config_MicProgKeyP3 + 220 + 1) : (byte) (this.db.Config_MicProgKeyP3 + 220);
        if (this.db.Config_MicProgKeyP4 <= 12)
          this.dat[742] = (byte) (this.db.Config_MicProgKeyP4 + 220);
        else
          this.dat[742] = (byte) (this.db.Config_MicProgKeyP4 + 220 + 1);
      }
      else
      {
        this.dat[739] = (byte) (this.db.Config_MicProgKeyP1 + 220);
        this.dat[740] = (byte) (this.db.Config_MicProgKeyP2 + 220);
        this.dat[741] = (byte) (this.db.Config_MicProgKeyP3 + 220);
        this.dat[742] = (byte) (this.db.Config_MicProgKeyP4 + 220);
      }
    }

    private void encodeDtmfmemory()
    {
      int num = DataConverter.DTMFMEMORY[0];
      for (int index1 = 0; index1 < this.db.dtmfMemory.Count; ++index1)
      {
        char[] chArray = this.conv_StringToChar(this.db.dtmfMemory[index1].CODE, 16, false);
        for (int index2 = 0; index2 < chArray.Length; ++index2)
          this.dat[num + index2] = Moji.ConvertToDtmfBin(chArray[index2]);
        num += 16;
      }
    }

    private void encodeWiresLast()
    {
    }

    private void encodeAdjust()
    {
    }

    private void encodeRadHardMaskId()
    {
    }

    private void encodeLrfHomeName()
    {
      int offset = DataConverter.LRFHOMENAME[0];
      for (int index = 0; index < this.db.aBandHome.Count; ++index)
      {
        this.encodeMemoryNameCommon(this.db.aBandHome, index, this.dat, offset);
        offset += 8;
      }
    }

    private void encodeRrfHomeName()
    {
      int offset = DataConverter.RRFHOMENAME[0];
      for (int index = 0; index < this.db.bBandHome.Count; ++index)
      {
        this.encodeMemoryNameCommon(this.db.bBandHome, index, this.dat, offset);
        offset += 8;
      }
    }

    private void encodeAprs()
    {
      this.dat[1280] = (byte) this.db.AprsUnit_Position;
      this.dat[1281] = (byte) this.db.AprsUnit_Distance;
      this.dat[1282] = (byte) this.db.AprsUnit_Speed;
      this.dat[1283] = (byte) this.db.AprsUnit_Altitude;
      this.dat[1284] = (byte) this.db.AprsUnit_Baro;
      this.dat[1285] = (byte) this.db.AprsUnit_Temp;
      this.dat[1286] = (byte) this.db.AprsUnit_Rain;
      this.dat[1287] = (byte) this.db.AprsUnit_Wind;
      this.conv_StringToBytes(this.db.AprsCommon_CallsignCode, 6, true).CopyTo((Array) this.dat, 1288);
      this.dat[1294] = this.db.AprsCommon_CallsignSsId != 0 ? (byte) this.db.AprsCommon_CallsignSsId : (byte) 202;
      this.bitSet(1296, this.db.MyPosition_ManualLat, 16);
      this.dat[1297] = this.conv_IntegerTo1byteBcd(Decimal.ToInt32(this.db.MyPosition_ManualLatDD));
      this.dat[1298] = this.conv_IntegerTo1byteBcd(Decimal.ToInt32(this.db.MyPosition_ManualLatMM1));
      this.dat[1299] = (byte) ((Decimal.ToInt32(this.db.MyPosition_ManualLatMM2) * 10 & 65280) >> 8);
      this.dat[1300] = (byte) (Decimal.ToInt32(this.db.MyPosition_ManualLatMM2) * 10 & (int) byte.MaxValue);
      this.bitSet(1301, this.db.MyPosition_ManualLon, 16);
      byte[] numArray1 = new byte[2];
      byte[] numArray2 = this.conv_DecimalTo2byteBcd(this.db.MyPosition_ManualLonDD);
      this.bitSet(1301, (int) numArray2[0], 15);
      this.dat[1302] = numArray2[1];
      this.dat[1303] = this.conv_IntegerTo1byteBcd(Decimal.ToInt32(this.db.MyPosition_ManualLonMM1));
      this.dat[1304] = (byte) ((Decimal.ToInt32(this.db.MyPosition_ManualLonMM2) * 10 & 65280) >> 8);
      this.dat[1305] = (byte) (Decimal.ToInt32(this.db.MyPosition_ManualLonMM2) * 10 & (int) byte.MaxValue);
      this.conv_StringToBytes(this.db.MsgReply_CallSignCode, 6, true).CopyTo((Array) this.dat, 1306);
      this.dat[1312] = this.db.MsgReply_CallSignSsId != 0 ? (this.db.MsgReply_CallSignSsId != 16 ? (byte) this.db.MsgReply_CallSignSsId : (byte) 42) : (byte) 202;
      byte[] bytes1 = this.conv_StringToBytes(this.db.MySymbol_1_Icn, 2, true);
      this.dat[1314] = bytes1[0];
      this.dat[1315] = bytes1[1];
      byte[] bytes2 = this.conv_StringToBytes(this.db.MySymbol_2_Icn, 2, true);
      this.dat[1316] = bytes2[0];
      this.dat[1317] = bytes2[1];
      byte[] bytes3 = this.conv_StringToBytes(this.db.MySymbol_3_Icn, 2, true);
      this.dat[1318] = bytes3[0];
      this.dat[1319] = bytes3[1];
      this.dat[1320] = this.conv_StringToBytes(this.db.MySymbol_41_Icn, 1, true)[0];
      this.dat[1321] = this.conv_StringToBytes(this.db.MySymbol_42_Icn, 1, true)[0];
      this.dat[1322] = (byte) ((this.db.AprsFilter_RangeLimit & 65280) >> 8);
      this.dat[1323] = (byte) (this.db.AprsFilter_RangeLimit & (int) byte.MaxValue);
      this.dat[1324] = (byte) this.db.MySymbol_Sel;
      this.dat[1325] = (byte) this.db.DigiPath_Sel;
      this.dat[1326] = (byte) this.db.AprsCommon_Intrvl;
      this.dat[1327] = (byte) (this.db.AprsCommon_RtLmt + 5);
      this.dat[1328] = (byte) (this.db.AprsCommon_LwSpd + 1);
      this.dat[1329] = (byte) this.db.AprsCommon_Ambgty;
      this.dat[1330] = (byte) this.db.AprsCommon_PstnCmnt;
      this.bitSet(1331, this.db.MsgReply_Reply, 1);
      this.bitSet(1331, this.db.AprsCommon_Alttd, 4);
      this.bitSet(1331, this.db.AprsCommon_SpdCrc, 8);
      this.bitSet(1331, this.db.AprsCommon_Dcy, 16);
      this.bitSet(1331, this.db.AprsCommon_Auto, 64);
      this.bitSet(1331, this.db.AprsCommon_Prprtnl, 128);
      this.bitSet(1332, this.db.AprsCommon_Modem, 1);
      this.bitSet(1332, this.db.AprsCommon_Mute, 2);
      this.bitSet(1332, this.db.Data_DSpeedData, 32);
      this.bitSet(1332, this.db.Data_DSpeedAprs, 64);
      this.bitSet(1333, this.db.Data_DSqlcTx, 32);
      this.bitSet(1333, this.db.Data_DSqlcData, 64);
      this.bitSet(1333, this.db.Data_DSqlcAprs, 128);
      this.dat[1334] = (byte) this.db.BeaconStatusText_Sel;
      this.dat[1335] = (byte) this.db.BeaconStatusText_TxRate;
      this.bitSet(1336, this.db.AprsFilter_MicE, 1);
      this.bitSet(1336, this.db.AprsFilter_Position, 2);
      this.bitSet(1336, this.db.AprsFilter_Weather, 4);
      this.bitSet(1336, this.db.AprsFilter_Object, 8);
      this.bitSet(1336, this.db.AprsFilter_Item, 16);
      this.bitSet(1336, this.db.AprsFilter_Status, 32);
      this.bitSet(1336, this.db.AprsFilter_Other, 64);
      this.dat[1337] = (byte) this.db.AprsRinger_TxBcn;
      this.dat[1338] = (byte) this.db.AprsRinger_TxMsg;
      this.dat[1339] = (byte) this.db.AprsRinger_RxBcn;
      this.dat[1340] = (byte) this.db.AprsRinger_RxMsg;
      this.dat[1341] = (byte) this.db.AprsRinger_MyPacket;
      this.dat[1342] = (byte) this.db.AprsRinger_CllRngr;
      this.dat[1343] = (byte) this.db.AprsRinger_RngRbgr;
      this.dat[1344] = (byte) this.db.AprsRinger_MsgVc;
      this.dat[1345] = (byte) this.db.MyPosition_Sel;
      this.dat[1346] = (byte) this.db.AprsCommon_Cmps;
      this.dat[1347] = (byte) this.db.Data_DBandAprs;
      this.dat[1348] = (byte) this.db.Data_DBandData;
      switch (this.db.AprsPopup_Bcn)
      {
        case 0:
          this.dat[1349] = (byte) 0;
          break;
        case 1:
          this.dat[1349] = (byte) 3;
          break;
        case 2:
          this.dat[1349] = (byte) 5;
          break;
        case 3:
          this.dat[1349] = (byte) 10;
          break;
        case 4:
          this.dat[1349] = byte.MaxValue;
          break;
        default:
          throw new FormatException();
      }
      switch (this.db.AprsPopup_Msg)
      {
        case 0:
          this.dat[1350] = (byte) 0;
          break;
        case 1:
          this.dat[1350] = (byte) 3;
          break;
        case 2:
          this.dat[1350] = (byte) 5;
          break;
        case 3:
          this.dat[1350] = (byte) 10;
          break;
        case 4:
          this.dat[1350] = byte.MaxValue;
          break;
        default:
          throw new FormatException();
      }
      this.dat[1351] = (byte) this.db.AprsCommon_TxDelay;
      this.dat[1352] = (byte) this.db.Data_ComOutput;
      this.dat[1353] = (byte) this.db.Data_ComSpeed;
      this.dat[1354] = (byte) this.db.SmartBeaconing_Select;
      this.dat[1355] = (byte) this.db.SmartBeaconing1_LowSpeed;
      this.dat[1356] = (byte) this.db.SmartBeaconing1_HighSpeed;
      this.dat[1357] = (byte) this.db.SmartBeaconing1_SlowRate;
      this.dat[1358] = (byte) this.db.SmartBeaconing1_FastRate;
      this.dat[1359] = (byte) this.db.SmartBeaconing1_TurnAngle;
      this.dat[1360] = (byte) this.db.SmartBeaconing1_TurnSlope;
      this.dat[1361] = (byte) this.db.SmartBeaconing1_TurnTime;
      this.dat[1362] = (byte) this.db.SmartBeaconing2_LowSpeed;
      this.dat[1363] = (byte) this.db.SmartBeaconing2_HighSpeed;
      this.dat[1364] = (byte) this.db.SmartBeaconing2_SlowRate;
      this.dat[1365] = (byte) this.db.SmartBeaconing2_FastRate;
      this.dat[1366] = (byte) this.db.SmartBeaconing2_TurnAngle;
      this.dat[1367] = (byte) this.db.SmartBeaconing2_TurnSlope;
      this.dat[1368] = (byte) this.db.SmartBeaconing2_TurnTime;
      this.dat[1369] = (byte) this.db.SmartBeaconing3_LowSpeed;
      this.dat[1370] = (byte) this.db.SmartBeaconing3_HighSpeed;
      this.dat[1371] = (byte) this.db.SmartBeaconing3_SlowRate;
      this.dat[1372] = (byte) this.db.SmartBeaconing3_FastRate;
      this.dat[1373] = (byte) this.db.SmartBeaconing3_TurnAngle;
      this.dat[1374] = (byte) this.db.SmartBeaconing3_TurnSlope;
      this.dat[1375] = (byte) this.db.SmartBeaconing3_TurnTime;
      this.dat[1376] = (byte) this.db.AprsMsgText_Sel;
      this.bitSet(1377, this.db.AprsFilter_Altnet, 32);
      this.bitSet(1377, this.db.AprsPopup_MyPacket, 64);
      this.dat[1378] = (byte) this.db.Data_ComWpFormat;
      this.dat[1379] = this.db.Data_ComWpFilter > 7 ? (byte) (this.db.Data_ComWpFilter + 1) : (byte) this.db.Data_ComWpFilter;
      this.dat[1381] = (byte) this.db.AprsPopupColor_Bcn;
      this.dat[1382] = (byte) this.db.AprsPopupColor_Mbl;
      this.dat[1383] = (byte) this.db.AprsPopupColor_ObjItm;
      this.dat[1384] = (byte) this.db.AprsPopupColor_CllRngr;
      this.dat[1385] = (byte) this.db.AprsPopupColor_RngRngr;
      this.dat[1386] = (byte) this.db.AprsPopupColor_Msg;
      this.dat[1387] = (byte) this.db.AprsPopupColor_GrpBult;
      this.dat[1388] = (byte) this.db.AprsPopupColor_MyPckt;
      this.dat[1389] = (byte) this.db.VoiceAleat_VoiceAleat;
      this.dat[1390] = (byte) this.db.VoiceAleat_ToneSql;
      this.dat[1391] = (byte) this.db.VoiceAleat_Dcs;
      this.dat[1392] = (byte) this.db.SortFilter_Sort;
      this.dat[1393] = (byte) this.db.SortFilter_Filter;
    }

    private void encodeReplyText()
    {
      this.conv_StringToBytes(this.db.MsgReply_ReplyText, 64, true).CopyTo((Array) this.dat, DataConverter.REPLYTEXT[0]);
    }

    private void encodeMessageGroup()
    {
      int index = DataConverter.MESSAGEGROUP[0];
      foreach (string str in new string[9]{ this.db.AprsMsgGroup_G1, this.db.AprsMsgGroup_G2, this.db.AprsMsgGroup_G3, this.db.AprsMsgGroup_G4, this.db.AprsMsgGroup_G5, this.db.AprsMsgGroup_G6, this.db.AprsMsgGroup_B1, this.db.AprsMsgGroup_B2, this.db.AprsMsgGroup_B3 })
      {
        this.conv_StringToBytes(str, 9, true).CopyTo((Array) this.dat, index);
        index += 10;
      }
    }

    private void encodeDigiPath()
    {
      int index1 = DataConverter.DIGIPATH[0];
      string[] strArray = new string[24];
      int[] numArray = new int[24];
      strArray[0] = this.db.DigiPathCode_P11;
      strArray[1] = this.db.DigiPathCode_P12;
      strArray[2] = this.db.DigiPathCode_P21;
      strArray[3] = this.db.DigiPathCode_P22;
      strArray[4] = this.db.DigiPathCode_P31;
      strArray[5] = this.db.DigiPathCode_P32;
      strArray[6] = this.db.DigiPathCode_P41;
      strArray[7] = this.db.DigiPathCode_P42;
      strArray[8] = this.db.DigiPathCode_F11;
      strArray[9] = this.db.DigiPathCode_F12;
      strArray[10] = this.db.DigiPathCode_F13;
      strArray[11] = this.db.DigiPathCode_F14;
      strArray[12] = this.db.DigiPathCode_F15;
      strArray[13] = this.db.DigiPathCode_F16;
      strArray[14] = this.db.DigiPathCode_F17;
      strArray[15] = this.db.DigiPathCode_F18;
      strArray[16] = this.db.DigiPathCode_F21;
      strArray[17] = this.db.DigiPathCode_F22;
      strArray[18] = this.db.DigiPathCode_F23;
      strArray[19] = this.db.DigiPathCode_F24;
      strArray[20] = this.db.DigiPathCode_F25;
      strArray[21] = this.db.DigiPathCode_F26;
      strArray[22] = this.db.DigiPathCode_F27;
      strArray[23] = this.db.DigiPathCode_F28;
      numArray[0] = this.db.DigiPathSsId_P11;
      numArray[1] = this.db.DigiPathSsId_P12;
      numArray[2] = this.db.DigiPathSsId_P21;
      numArray[3] = this.db.DigiPathSsId_P22;
      numArray[4] = this.db.DigiPathSsId_P31;
      numArray[5] = this.db.DigiPathSsId_P32;
      numArray[6] = this.db.DigiPathSsId_P41;
      numArray[7] = this.db.DigiPathSsId_P42;
      numArray[8] = this.db.DigiPathSsId_F11;
      numArray[9] = this.db.DigiPathSsId_F12;
      numArray[10] = this.db.DigiPathSsId_F13;
      numArray[11] = this.db.DigiPathSsId_F14;
      numArray[12] = this.db.DigiPathSsId_F15;
      numArray[13] = this.db.DigiPathSsId_F16;
      numArray[14] = this.db.DigiPathSsId_F17;
      numArray[15] = this.db.DigiPathSsId_F18;
      numArray[16] = this.db.DigiPathSsId_F21;
      numArray[17] = this.db.DigiPathSsId_F22;
      numArray[18] = this.db.DigiPathSsId_F23;
      numArray[19] = this.db.DigiPathSsId_F24;
      numArray[20] = this.db.DigiPathSsId_F25;
      numArray[21] = this.db.DigiPathSsId_F26;
      numArray[22] = this.db.DigiPathSsId_F27;
      numArray[23] = this.db.DigiPathSsId_F28;
      for (int index2 = 0; index2 < strArray.Length; ++index2)
      {
        this.conv_StringToBytes(strArray[index2], 6, true).CopyTo((Array) this.dat, index1);
        this.dat[index1 + 6] = numArray[index2] != 0 ? (byte) numArray[index2] : (byte) 202;
        index1 += 8;
      }
    }

    private void encodeCallRingerSign()
    {
      int index1 = DataConverter.CALLRINGERSIGN[0];
      string[] strArray = new string[8];
      int[] numArray = new int[8];
      strArray[0] = this.db.AprsRingerCallCode_1;
      strArray[1] = this.db.AprsRingerCallCode_2;
      strArray[2] = this.db.AprsRingerCallCode_3;
      strArray[3] = this.db.AprsRingerCallCode_4;
      strArray[4] = this.db.AprsRingerCallCode_5;
      strArray[5] = this.db.AprsRingerCallCode_6;
      strArray[6] = this.db.AprsRingerCallCode_7;
      strArray[7] = this.db.AprsRingerCallCode_8;
      numArray[0] = this.db.AprsRingerCallSsID_1;
      numArray[1] = this.db.AprsRingerCallSsID_2;
      numArray[2] = this.db.AprsRingerCallSsID_3;
      numArray[3] = this.db.AprsRingerCallSsID_4;
      numArray[4] = this.db.AprsRingerCallSsID_5;
      numArray[5] = this.db.AprsRingerCallSsID_6;
      numArray[6] = this.db.AprsRingerCallSsID_7;
      numArray[7] = this.db.AprsRingerCallSsID_8;
      for (int index2 = 0; index2 < strArray.Length; ++index2)
      {
        this.conv_StringToBytes(strArray[index2], 6, true).CopyTo((Array) this.dat, index1);
        this.dat[index1 + 6] = numArray[index2] != 0 ? (byte) numArray[index2] : (byte) 202;
        index1 += 8;
      }
    }

    private void encodeMessageText()
    {
      int index = DataConverter.MESSAGETEXT[0];
      foreach (string str in new string[8]{ this.db.AprsMsgText_1, this.db.AprsMsgText_2, this.db.AprsMsgText_3, this.db.AprsMsgText_4, this.db.AprsMsgText_5, this.db.AprsMsgText_6, this.db.AprsMsgText_7, this.db.AprsMsgText_8 })
      {
        this.conv_StringToBytes(str, 16, true).CopyTo((Array) this.dat, index);
        index += 16;
      }
    }

    private void encodeLbandMemory()
    {
      int offset = DataConverter.LBANDMEMORY[0];
      for (int index = 0; index < this.db.aBandMemory.Count; ++index)
      {
        this.encodeMemoryCommon(this.db.aBandMemory, index, this.dat, offset);
        offset += 16;
      }
      for (int index = 0; index < this.db.aBandPmsMemory.Count; ++index)
      {
        this.encodeMemoryCommon(this.db.aBandPmsMemory, index, this.dat, offset);
        offset += 16;
      }
    }

    private void encodeRbandMemory()
    {
      int offset = DataConverter.RBANDMEMORY[0];
      for (int index = 0; index < this.db.bBandMemory.Count; ++index)
      {
        this.encodeMemoryCommon(this.db.bBandMemory, index, this.dat, offset);
        offset += 16;
      }
      for (int index = 0; index < this.db.bBandPmsMemory.Count; ++index)
      {
        this.encodeMemoryCommon(this.db.bBandPmsMemory, index, this.dat, offset);
        offset += 16;
      }
    }

    private void encodeLbandMemoryName()
    {
      int offset = DataConverter.LBANDMEMORYNAME[0];
      for (int index = 0; index < this.db.aBandMemory.Count; ++index)
      {
        this.encodeMemoryNameCommon(this.db.aBandMemory, index, this.dat, offset);
        offset += 8;
      }
      for (int index = 0; index < this.db.aBandPmsMemory.Count; ++index)
      {
        this.encodeMemoryNameCommon(this.db.aBandPmsMemory, index, this.dat, offset);
        offset += 8;
      }
    }

    private void encodeRbandMemoryName()
    {
      int offset = DataConverter.RBANDMEMORYNAME[0];
      for (int index = 0; index < this.db.bBandMemory.Count; ++index)
      {
        this.encodeMemoryNameCommon(this.db.bBandMemory, index, this.dat, offset);
        offset += 8;
      }
      for (int index = 0; index < this.db.bBandPmsMemory.Count; ++index)
      {
        this.encodeMemoryNameCommon(this.db.bBandPmsMemory, index, this.dat, offset);
        offset += 8;
      }
    }

    private void encodeBackTrackMemory()
    {
    }

    private void encodePhraseMemory()
    {
      int num = DataConverter.PHRASEMEMORY[0];
      for (int index1 = 0; index1 < this.db.messageText.Count; ++index1)
      {
        char[] chArray = this.conv_StringToChar(this.db.messageText[index1].Message, 80, false);
        for (int index2 = 0; index2 < chArray.Length; ++index2)
          this.dat[num + index2] = Moji.ConvertToMessageTextBin(chArray[index2]);
        num += 128;
      }
    }

    private void encodeWiresCateName()
    {
      int num = DataConverter.WIRESCATENAME[0];
      for (int index1 = 0; index1 < this.db.category.Count; ++index1)
      {
        char[] chArray = this.conv_StringToChar(this.db.category[index1].Name, 16, true);
        for (int index2 = 0; index2 < chArray.Length; ++index2)
          this.dat[num + index2] = Moji.ConvertToCategoryBin(chArray[index2]);
        num += 16;
      }
    }

    private void encodeGmName()
    {
      int num = DataConverter.GMGNAME[0] + 16;
      for (int index1 = 0; index1 < this.db.group.Count; ++index1)
      {
        char[] chArray = this.conv_StringToChar(this.db.group[index1].GroupName, 16, false);
        for (int index2 = 0; index2 < chArray.Length; ++index2)
          this.dat[num + index2] = Moji.ConvertToGroupNameBin(chArray[index2]);
        num += 16;
      }
    }

    private void encodePreset()
    {
    }

    private void encodeStatusText()
    {
      int index1 = DataConverter.STATUSTEXT[0];
      string[] strArray = new string[5];
      int[] numArray = new int[5];
      strArray[0] = this.db.BeaconStatusText_1;
      strArray[1] = this.db.BeaconStatusText_2;
      strArray[2] = this.db.BeaconStatusText_3;
      strArray[3] = this.db.BeaconStatusText_4;
      strArray[4] = this.db.BeaconStatusText_5;
      numArray[0] = this.db.BeaconStatusText_1_Mode;
      numArray[1] = this.db.BeaconStatusText_2_Mode;
      numArray[2] = this.db.BeaconStatusText_3_Mode;
      numArray[3] = this.db.BeaconStatusText_4_Mode;
      numArray[4] = this.db.BeaconStatusText_5_Mode;
      for (int index2 = 0; index2 < strArray.Length; ++index2)
      {
        this.conv_StringToBytes(strArray[index2], 60, true).CopyTo((Array) this.dat, index1);
        this.dat[index1 + 60] = (byte) numArray[index2];
        index1 += 64;
      }
    }

    private void encodeStationMemory()
    {
    }

    private void encodeMessageMemory()
    {
    }

    private void encodeStationInfoMemory()
    {
    }

    private void encodeMessageInfoMemory()
    {
    }

    private void encodeGmMemberMemory()
    {
      int num = DataConverter.GMMEMBERMEMORY[0] + 512;
      string[] strArray = new string[24];
      for (int index1 = 0; index1 < this.db.group.Count; ++index1)
      {
        strArray[0] = this.db.group[index1].MemberName1;
        strArray[1] = this.db.group[index1].MemberName2;
        strArray[2] = this.db.group[index1].MemberName3;
        strArray[3] = this.db.group[index1].MemberName4;
        strArray[4] = this.db.group[index1].MemberName5;
        strArray[5] = this.db.group[index1].MemberName6;
        strArray[6] = this.db.group[index1].MemberName7;
        strArray[7] = this.db.group[index1].MemberName8;
        strArray[8] = this.db.group[index1].MemberName9;
        strArray[9] = this.db.group[index1].MemberName10;
        strArray[10] = this.db.group[index1].MemberName11;
        strArray[11] = this.db.group[index1].MemberName12;
        strArray[12] = this.db.group[index1].MemberName13;
        strArray[13] = this.db.group[index1].MemberName14;
        strArray[14] = this.db.group[index1].MemberName15;
        strArray[15] = this.db.group[index1].MemberName16;
        strArray[16] = this.db.group[index1].MemberName17;
        strArray[17] = this.db.group[index1].MemberName18;
        strArray[18] = this.db.group[index1].MemberName19;
        strArray[19] = this.db.group[index1].MemberName20;
        strArray[20] = this.db.group[index1].MemberName21;
        strArray[21] = this.db.group[index1].MemberName22;
        strArray[22] = this.db.group[index1].MemberName23;
        strArray[23] = this.db.group[index1].MemberName24;
        for (int index2 = 0; index2 < 24; ++index2)
        {
          this.conv_StringToBytes(strArray[index2], 10, false).CopyTo((Array) this.dat, num + 5);
          num += 15;
        }
        num = num + 24 + 128;
      }
    }

    private void encodeWiresCateUserId()
    {
    }

    private void encodeMemoryCommon(BindingList<BandMemory> memory, int index, byte[] dat, int offset)
    {
      byte[] numArray1 = new byte[3];
      Decimal recvFreq1 = memory[index].RecvFreq;
      this.bitSet(offset, DataForm.GetBandIdx(recvFreq1), 7);
      this.bitSet(offset, memory[index].Skip, 96);
      this.bitSet(offset, (int) Convert.ToByte(memory[index].MemoryDir), 128);
      switch (memory[index].ShiftDir)
      {
        case 0:
          this.bitSet(offset + 1, 0, 7);
          break;
        case 1:
          this.bitSet(offset + 1, 2, 7);
          break;
        case 2:
          this.bitSet(offset + 1, 3, 7);
          break;
        case 3:
          this.bitSet(offset + 1, 4, 7);
          break;
        default:
          throw new FormatException();
      }
      this.bitSet(offset + 1, memory[index].Mode, 48);
      int step = memory[index].Step;
      Decimal recvFreq2 = memory[index].RecvFreq;
      byte[] numArray2 = this.conv_DecimalTo3byteFreqBcd(recvFreq2);
      dat[offset + 2] = (byte) (((this.GetAddFreqIndex(recvFreq2) & 15) << 4) + (((int) numArray2[0] & 240) >> 4));
      dat[offset + 3] = (byte) ((((int) numArray2[0] & 15) << 4) + (((int) numArray2[1] & 240) >> 4));
      dat[offset + 4] = (byte) ((((int) numArray2[1] & 15) << 4) + (((int) numArray2[2] & 240) >> 4));
      dat[offset + 5] = (byte) (((memory[index].SqlType & 15) << 4) + ((int) dat[offset + 5] & -241));
      dat[offset + 5] = (byte) ((step & 15) + ((int) dat[offset + 5] & -16));
      Decimal sendFreq = memory[index].SendFreq;
      byte[] numArray3 = this.conv_DecimalTo3byteFreqBcd(sendFreq);
      dat[offset + 6] = (byte) (((this.GetAddFreqIndex(sendFreq) & 15) << 4) + (((int) numArray3[0] & 240) >> 4));
      dat[offset + 7] = (byte) ((((int) numArray3[0] & 15) << 4) + (((int) numArray3[1] & 240) >> 4));
      dat[offset + 8] = (byte) ((((int) numArray3[1] & 15) << 4) + (((int) numArray3[2] & 240) >> 4));
      dat[offset + 9] = (byte) ((memory[index].SendOut << 6) + memory[index].ToneFreq);
      dat[offset + 10] = (byte) (((int) Convert.ToByte(memory[index].ClockShift) << 7) + memory[index].DcsCode);
      int num1 = memory[index].MemoryName == "" || memory[index].MemoryName == null ? 0 : 1;
      dat[offset + 11] = (byte) ((num1 << 7) + (memory[index].PrTone + 3));
      int num2 = (int) (memory[index].ShiftFreq / new Decimal(5, 0, 0, false, (byte) 2));
      dat[offset + 12] = (byte) ((num2 & 65280) >> 8);
      dat[offset + 13] = (byte) (num2 & (int) byte.MaxValue);
    }

    private void encodeMemoryNameCommon(BindingList<BandMemory> memory, int index, byte[] dat, int offset)
    {
      char[] chArray = this.conv_StringToChar(memory[index].MemoryName, 8, true);
      for (int index1 = 0; index1 < chArray.Length; ++index1)
        dat[offset + index1] = Moji.ConvertToMemoryNameBin(chArray[index1]);
    }

    private Decimal conv_3byteFreqBcdToDecimal(byte[] bcdBytes)
    {
      Decimal[] numArray = new Decimal[6];
      int index1 = 0;
      int index2 = 0;
      for (; index1 < bcdBytes.Length; ++index1)
      {
        numArray[index2] = (Decimal) ((int) bcdBytes[index1] >> 4);
        numArray[index2 + 1] = (Decimal) ((int) bcdBytes[index1] & 15);
        if (numArray[index2] > new Decimal(9) || numArray[index2 + 1] > new Decimal(9))
          throw new FormatException();
        index2 += 2;
      }
      return numArray[0] * new Decimal(100) + numArray[1] * new Decimal(10) + numArray[2] * new Decimal(1) + numArray[3] / new Decimal(10) + numArray[4] / new Decimal(100) + numArray[5] / new Decimal(1000);
    }

    private byte[] conv_DecimalTo3byteFreqBcd(Decimal Dec)
    {
      byte[] numArray1 = new byte[6];
      byte[] numArray2 = new byte[3];
      if (!(Dec < new Decimal(1000)) || !(Dec >= new Decimal(0)))
        throw new FormatException();
      long num1 = (long) (Dec * new Decimal(1000));
      numArray1[0] = (byte) ((ulong) num1 % 10UL);
      long num2 = (num1 - (long) numArray1[0]) / 10L;
      numArray1[1] = (byte) ((ulong) num2 % 10UL);
      long num3 = (num2 - (long) numArray1[1]) / 10L;
      numArray1[2] = (byte) ((ulong) num3 % 10UL);
      long num4 = (num3 - (long) numArray1[2]) / 10L;
      numArray1[3] = (byte) ((ulong) num4 % 10UL);
      long num5 = (num4 - (long) numArray1[3]) / 10L;
      numArray1[4] = (byte) ((ulong) num5 % 10UL);
      long num6 = (num5 - (long) numArray1[4]) / 10L;
      numArray1[5] = (byte) ((ulong) num6 % 10UL);
      numArray2[0] = (byte) (((uint) numArray1[5] << 4) + (uint) numArray1[4]);
      numArray2[1] = (byte) (((uint) numArray1[3] << 4) + (uint) numArray1[2]);
      numArray2[2] = (byte) (((uint) numArray1[1] << 4) + (uint) numArray1[0]);
      return numArray2;
    }

    private byte[] conv_DecimalTo3byteBcd(Decimal Dec)
    {
      byte[] numArray1 = new byte[6];
      byte[] numArray2 = new byte[3];
      long num1 = (long) Dec;
      numArray1[0] = (byte) ((ulong) num1 % 10UL);
      long num2 = (num1 - (long) numArray1[0]) / 10L;
      numArray1[1] = (byte) ((ulong) num2 % 10UL);
      long num3 = (num2 - (long) numArray1[1]) / 10L;
      numArray1[2] = (byte) ((ulong) num3 % 10UL);
      long num4 = (num3 - (long) numArray1[2]) / 10L;
      numArray1[3] = (byte) ((ulong) num4 % 10UL);
      long num5 = (num4 - (long) numArray1[3]) / 10L;
      numArray1[4] = (byte) ((ulong) num5 % 10UL);
      long num6 = (num5 - (long) numArray1[4]) / 10L;
      numArray1[5] = (byte) ((ulong) num6 % 10UL);
      numArray2[0] = (byte) (((uint) numArray1[5] << 4) + (uint) numArray1[4]);
      numArray2[1] = (byte) (((uint) numArray1[3] << 4) + (uint) numArray1[2]);
      numArray2[2] = (byte) (((uint) numArray1[1] << 4) + (uint) numArray1[0]);
      return numArray2;
    }

    private Decimal conv_2byteBcdToDecimal(byte[] bcdBytes)
    {
      Decimal[] numArray = new Decimal[6];
      int index1 = 0;
      int index2 = 0;
      for (; index1 < bcdBytes.Length; ++index1)
      {
        numArray[index2] = (Decimal) ((int) bcdBytes[index1] >> 4);
        numArray[index2 + 1] = (Decimal) ((int) bcdBytes[index1] & 15);
        if (numArray[index2] > new Decimal(9) || numArray[index2 + 1] > new Decimal(9))
          throw new FormatException();
        index2 += 2;
      }
      return numArray[0] * new Decimal(1000) + numArray[1] * new Decimal(100) + numArray[2] * new Decimal(10) + numArray[3];
    }

    private byte[] conv_DecimalTo2byteBcd(Decimal Dec)
    {
      byte[] numArray1 = new byte[4];
      byte[] numArray2 = new byte[2];
      long num1 = (long) Dec;
      numArray1[0] = (byte) ((ulong) num1 % 10UL);
      long num2 = (num1 - (long) numArray1[0]) / 10L;
      numArray1[1] = (byte) ((ulong) num2 % 10UL);
      long num3 = (num2 - (long) numArray1[1]) / 10L;
      numArray1[2] = (byte) ((ulong) num3 % 10UL);
      long num4 = (num3 - (long) numArray1[2]) / 10L;
      numArray1[3] = (byte) ((ulong) num4 % 10UL);
      long num5 = (num4 - (long) numArray1[3]) / 10L;
      numArray2[0] = (byte) (((uint) numArray1[3] << 4) + (uint) numArray1[2]);
      numArray2[1] = (byte) (((uint) numArray1[1] << 4) + (uint) numArray1[0]);
      return numArray2;
    }

    private byte conv_IntegerTo2byteBcd(int val)
    {
      if (val < 100 && val >= 0)
        return (byte) ((val / 10 % 10 << 4) + val / 1 % 10);
      throw new FormatException();
    }

    private int conv_1byteBcdToInteger(byte bcd)
    {
      int num1 = (int) bcd >> 4;
      int num2 = (int) bcd & 15;
      if (num1 > 9 || num2 > 9)
        throw new FormatException();
      return num1 * 10 + num2;
    }

    private byte conv_IntegerTo1byteBcd(int val)
    {
      if (val < 100 && val >= 0)
        return (byte) ((val / 10 % 10 << 4) + val / 1 % 10);
      throw new FormatException();
    }

    private void bitSet(int address, int value, int mask)
    {
      int num = 0;
      if ((mask & 1) != 0)
        num = 0;
      else if ((mask & 2) != 0)
        num = 1;
      else if ((mask & 4) != 0)
        num = 2;
      else if ((mask & 8) != 0)
        num = 3;
      else if ((mask & 16) != 0)
        num = 4;
      else if ((mask & 32) != 0)
        num = 5;
      else if ((mask & 64) != 0)
        num = 6;
      else if ((mask & 128) != 0)
        num = 7;
      this.dat[address] = (byte) ((value << num) + ((int) this.dat[address] & ~mask));
    }

    private byte[] conv_StringToBytes(string str, int len, bool charNon)
    {
      byte[] numArray = new byte[len];
      if (str == null)
        str = "";
      if (charNon)
      {
        for (int index = 0; index < len; ++index)
          numArray[index] = (byte) 202;
      }
      else
      {
        for (int index = 0; index < len; ++index)
          numArray[index] = byte.MaxValue;
      }
      char[] charArray = str.ToCharArray();
      if (charArray.Length > len)
        throw new FormatException();
      for (int index = 0; index < charArray.Length; ++index)
        numArray[index] = (byte) charArray[index];
      return numArray;
    }

    private char[] conv_StringToChar(string str, int len, bool charNon)
    {
      char[] chArray = new char[len];
      if (str == null)
        str = "";
      if (charNon)
      {
        for (int index = 0; index < len; ++index)
          chArray[index] = 'Ê';
      }
      else
      {
        for (int index = 0; index < len; ++index)
          chArray[index] = 'ÿ';
      }
      char[] charArray = str.ToCharArray();
      if (charArray.Length > len)
        throw new FormatException();
      for (int index = 0; index < charArray.Length; ++index)
        chArray[index] = charArray[index];
      return chArray;
    }

    private byte calc_CheckSum(byte[] buf)
    {
      byte num = 0;
      for (int index = 0; index < buf.Length; ++index)
        num += buf[index];
      return num;
    }

    private Decimal GetAddFreqDecimal(int freqIndex)
    {
      return DataConverter.tbl_1KHz_freq[freqIndex];
    }

    private int GetAddFreqIndex(Decimal freq)
    {
      Decimal num = freq - Math.Floor(freq * new Decimal(100)) / new Decimal(100);
      for (int index = 0; index < DataConverter.tbl_1KHz_freq.Length; ++index)
      {
        if (num == DataConverter.tbl_1KHz_freq[index])
          return index;
      }
      return 0;
    }
  }
}
