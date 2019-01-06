// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.BandMemory
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.Resources;

namespace Ftm400dAdms7
{
  public class BandMemory
  {
    public string No { get; set; }

    public Decimal RecvFreq { get; set; }

    public Decimal SendFreq { get; set; }

    public Decimal ShiftFreq { get; set; }

    public int ShiftDir { get; set; }

    public int Mode { get; set; }

    public string MemoryName { get; set; }

    public int SqlType { get; set; }

    public int ToneFreq { get; set; }

    public int DcsCode { get; set; }

    public int PrTone { get; set; }

    public int SendOut { get; set; }

    public int Skip { get; set; }

    public int Step { get; set; }

    public bool ClockShift { get; set; }

    public bool MemoryDir { get; set; }

    public string Comment { get; set; }

    public BandMemory()
    {
    }

    public BandMemory(int Number, int select)
    {
      switch (select)
      {
        case 0:
          this.No = string.Concat((object) (Number + 1));
          break;
        case 1:
          if (Number % 2 == 1)
          {
            this.No = "P" + (object) (Number / 2 + 1) + "U";
            break;
          }
          this.No = "P" + (object) (Number / 2 + 1) + "L";
          break;
        default:
          ResourceManager resourceManager = new ResourceManager("Ftm400dAdms7.Strings", typeof (DataForm).Assembly);
          switch (Number)
          {
            case 0:
              this.No = resourceManager.GetString("AIRBAND");
              return;
            case 1:
              this.No = resourceManager.GetString("VHFBAND");
              return;
            case 2:
              this.No = resourceManager.GetString("GR1BAND");
              return;
            case 3:
              this.No = resourceManager.GetString("UHFBAND");
              return;
            case 4:
              this.No = resourceManager.GetString("GR2BAND");
              return;
            default:
              return;
          }
      }
    }
  }
}
