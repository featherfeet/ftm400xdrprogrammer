// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.Category
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

public class Category
{
  public string No { get; set; }

  public string Name { get; set; }

  public Category()
  {
  }

  public Category(int number)
  {
    this.No = "C" + (object) (number + 1);
    this.Name = "";
  }
}
