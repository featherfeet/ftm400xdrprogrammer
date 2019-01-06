// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.FObjectConvert
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;

namespace Ftm400dAdms7
{
  public class FObjectConvert
  {
    public static void ToFObject(Database db, FObject obj)
    {
      db.Buffer.CopyTo((Array) obj.buffer, 0);
      for (int index = 0; index < obj.AbandMemCmnt.Length; ++index)
        obj.AbandMemCmnt[index] = db.aBandMemory[index].Comment;
      for (int index = 0; index < obj.BbandMemCmnt.Length; ++index)
        obj.BbandMemCmnt[index] = db.bBandMemory[index].Comment;
      for (int index = 0; index < obj.AbandPmsCmnt.Length; ++index)
        obj.AbandPmsCmnt[index] = db.aBandPmsMemory[index].Comment;
      for (int index = 0; index < obj.BbandPmsCmnt.Length; ++index)
        obj.BbandPmsCmnt[index] = db.bBandPmsMemory[index].Comment;
      for (int index = 0; index < obj.AbandHomeCmnt.Length; ++index)
        obj.AbandHomeCmnt[index] = db.aBandHome[index].Comment;
      for (int index = 0; index < obj.BbandHomeCmnt.Length; ++index)
        obj.BbandHomeCmnt[index] = db.bBandHome[index].Comment;
      for (int index = 0; index < obj.AbandVfoCmnt.Length; ++index)
        obj.AbandVfoCmnt[index] = db.aBandVfo[index].Comment;
      for (int index = 0; index < obj.BbandVfoCmnt.Length; ++index)
        obj.BbandVfoCmnt[index] = db.bBandVfo[index].Comment;
    }

    public static void ToDatabase(Database db, FObject obj)
    {
      obj.buffer.CopyTo((Array) db.Buffer, 0);
      for (int index = 0; index < obj.AbandMemCmnt.Length; ++index)
        db.aBandMemory[index].Comment = obj.AbandMemCmnt[index];
      for (int index = 0; index < obj.BbandMemCmnt.Length; ++index)
        db.bBandMemory[index].Comment = obj.BbandMemCmnt[index];
      for (int index = 0; index < obj.AbandPmsCmnt.Length; ++index)
        db.aBandPmsMemory[index].Comment = obj.AbandPmsCmnt[index];
      for (int index = 0; index < obj.BbandPmsCmnt.Length; ++index)
        db.bBandPmsMemory[index].Comment = obj.BbandPmsCmnt[index];
      for (int index = 0; index < obj.AbandHomeCmnt.Length; ++index)
        db.aBandHome[index].Comment = obj.AbandHomeCmnt[index];
      for (int index = 0; index < obj.BbandHomeCmnt.Length; ++index)
        db.bBandHome[index].Comment = obj.BbandHomeCmnt[index];
      for (int index = 0; index < obj.AbandVfoCmnt.Length; ++index)
        db.aBandVfo[index].Comment = obj.AbandVfoCmnt[index];
      for (int index = 0; index < obj.BbandVfoCmnt.Length; ++index)
        db.bBandVfo[index].Comment = obj.BbandVfoCmnt[index];
    }
  }
}
