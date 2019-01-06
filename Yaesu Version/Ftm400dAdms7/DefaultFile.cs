// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.DefaultFile
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.IO;

namespace Ftm400dAdms7
{
  [Serializable]
  public class DefaultFile
  {
    public readonly string[] DEFAULTFILENAME = new string[16]
    {
      "default_a2u.dat",
      "default_a2u.dat",
      "default_a2u.dat",
      "default_a2u.dat",
      "default_fw.dat",
      "default_a2u.dat",
      "default_a2u.dat",
      "default_a2u.dat",
      "default_a2u.dat",
      "default_fw.dat",
      "default_a2u.dat",
      "default_a2u.dat",
      "default_fw.dat",
      "default_a2u.dat",
      "default_a2u.dat",
      "default_a2u.dat"
    };
    private byte[] _defaultBuffer;

    public byte[] DefaultBuffer
    {
      get
      {
        return this._defaultBuffer;
      }
      set
      {
        this._defaultBuffer = value;
      }
    }

    public DefaultFile()
    {
      this._defaultBuffer = new byte[76800];
    }

    public void LoadFromDefaultFile()
    {
      FileStream fileStream = new FileStream(this.defaultPath(), FileMode.Open, FileAccess.Read);
      fileStream.Read(this._defaultBuffer, 0, this._defaultBuffer.Length);
      fileStream.Close();
    }

    private string defaultPath()
    {
      return Directory.GetCurrentDirectory() + "/config/" + this.DEFAULTFILENAME[Settings.Instance.MtxPTN];
    }
  }
}
