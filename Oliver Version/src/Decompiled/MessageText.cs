// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.MessageText
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

public class MessageText
{
  public string No { get; set; }

  public string Message { get; set; }

  public MessageText()
  {
  }

  public MessageText(int number)
  {
    this.No = string.Concat((object) (number + 1));
    this.Message = "";
  }
}
