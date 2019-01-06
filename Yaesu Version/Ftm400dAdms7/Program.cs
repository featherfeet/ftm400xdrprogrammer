// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.Program
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Ftm400dAdms7
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Settings.LoadFromXmlFile();
      if (Settings.Instance.Errorlogger)
      {
        Application.ThreadException += new ThreadExceptionEventHandler(Program.Application_ThreadException);
        Thread.GetDomain().UnhandledException += new UnhandledExceptionEventHandler(Program.Program_UnhandledException);
      }
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new AdmsForm());
    }

    private static void Program_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
      Exception exceptionObject = e.ExceptionObject as Exception;
      if (exceptionObject == null)
        return;
      Program.ShowError(exceptionObject, "UnhandledException");
    }

    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
      Program.ShowError(e.Exception, "ThreadException");
    }

    private static void ShowError(Exception ex, string title)
    {
      int num = (int) MessageBox.Show("プログラム中で補足されなかったエラーが発生しました。詳細はエラーログをごらん下さい。", title);
      StreamWriter streamWriter = new StreamWriter(Directory.GetCurrentDirectory() + "\\log\\error.txt", true);
      streamWriter.WriteLine("[" + title + "]");
      streamWriter.WriteLine("[message]\r\n" + ex.Message);
      streamWriter.WriteLine("[source]\r\n" + ex.Source);
      streamWriter.WriteLine("[stacktrace]\r\n" + ex.StackTrace);
      streamWriter.WriteLine();
      streamWriter.Close();
    }
  }
}
