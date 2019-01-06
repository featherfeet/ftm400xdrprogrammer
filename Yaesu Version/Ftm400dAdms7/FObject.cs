// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.FObject
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;

namespace Ftm400dAdms7
{
  [Serializable]
  public class FObject
  {
    public byte[] buffer = new byte[76800];
    public string[] AbandMemCmnt = new string[500];
    public string[] BbandMemCmnt = new string[500];
    public string[] AbandPmsCmnt = new string[18];
    public string[] BbandPmsCmnt = new string[18];
    public string[] AbandHomeCmnt = new string[5];
    public string[] BbandHomeCmnt = new string[5];
    public string[] AbandVfoCmnt = new string[5];
    public string[] BbandVfoCmnt = new string[5];
  }
}
