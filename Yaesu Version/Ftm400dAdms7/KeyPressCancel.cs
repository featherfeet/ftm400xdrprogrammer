// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.KeyPressCancel
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System.Windows.Forms;

namespace Ftm400dAdms7
{
  public class KeyPressCancel
  {
    public static void txt_Freq_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar >= '0' && '9' >= e.KeyChar || (e.KeyChar == '.' || e.KeyChar == '\b'))
        return;
      e.Handled = true;
    }

    public static void txt_AprsCallSign_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar >= '0' && '9' >= e.KeyChar || e.KeyChar >= 'A' && 'Z' >= e.KeyChar || e.KeyChar == '\b')
        return;
      e.Handled = true;
    }

    public static void txt_AprsDigiPath_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar >= '0' && '9' >= e.KeyChar || e.KeyChar >= 'A' && 'Z' >= e.KeyChar || e.KeyChar == '\b')
        return;
      e.Handled = true;
    }

    public static void txt_AprsRinger_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar >= '0' && '9' >= e.KeyChar || e.KeyChar >= 'A' && 'Z' >= e.KeyChar || e.KeyChar == '\b')
        return;
      e.Handled = true;
    }

    public static void txt_AprsMsgRplyCallSign_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar >= '0' && '9' >= e.KeyChar || e.KeyChar >= 'A' && 'Z' >= e.KeyChar || (e.KeyChar == '*' || e.KeyChar == '\b'))
        return;
      e.Handled = true;
    }

    public static void txt_AprsMsgGroup_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar >= '0' && '9' >= e.KeyChar || e.KeyChar >= 'A' && 'Z' >= e.KeyChar || (e.KeyChar == '*' || e.KeyChar == ' ' || e.KeyChar == '\b'))
        return;
      e.Handled = true;
    }

    public static void txt_GmCallSign_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar >= '0' && '9' >= e.KeyChar || e.KeyChar >= 'A' && 'Z' >= e.KeyChar || (e.KeyChar == '/' || e.KeyChar == '-' || e.KeyChar == '\b'))
        return;
      e.Handled = true;
    }

    public static void txt_GmMemberName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar >= '0' && '9' >= e.KeyChar || e.KeyChar >= 'A' && 'Z' >= e.KeyChar || (e.KeyChar == '/' || e.KeyChar == '-' || e.KeyChar == '\b'))
        return;
      e.Handled = true;
    }

    public static void txt_AprsStatusText_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar >= ' ' && '~' >= e.KeyChar || e.KeyChar == '\b')
        return;
      e.Handled = true;
    }

    public static void txt_AprsMsgRplyText_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar >= ' ' && 'z' >= e.KeyChar || (e.KeyChar == '}' || e.KeyChar == '\b'))
        return;
      e.Handled = true;
    }

    public static void txt_AprsMsgText_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar >= ' ' && 'z' >= e.KeyChar || (e.KeyChar == '}' || e.KeyChar == '\b'))
        return;
      e.Handled = true;
    }

    public static void txt_Dtmf_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Moji.IsDtmf(e.KeyChar) || e.KeyChar == '\b')
        return;
      e.Handled = true;
    }

    public static void txt_GmGroupName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Moji.IsGroupName(e.KeyChar) || e.KeyChar == '\b')
        return;
      e.Handled = true;
    }

    public static void txt_CategoryName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Moji.IsCategoryChar(e.KeyChar) || e.KeyChar == '\b')
        return;
      e.Handled = true;
    }

    public static void txt_MessageText_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Moji.IsMessageTextChar(e.KeyChar) || e.KeyChar == '\b')
        return;
      e.Handled = true;
    }

    public static void txt_MemoryName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Moji.IsMemoryNameChar(e.KeyChar) || e.KeyChar == '\b')
        return;
      e.Handled = true;
    }
  }
}
