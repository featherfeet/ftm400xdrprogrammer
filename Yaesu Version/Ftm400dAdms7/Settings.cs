// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.Settings
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.IO;
using System.Xml.Serialization;

namespace Ftm400dAdms7
{
  [Serializable]
  public class Settings
  {
    public const int USA = 0;
    public const int EXP = 1;
    public const int JPN = 2;
    public const int AUS = 3;
    public const int ALL = 0;
    public const int C3 = 1;
    public const int B3 = 2;
    public const int A3 = 3;
    public const int FW = 4;
    public const int C2 = 5;
    public const int B2 = 6;
    public const int A2 = 7;
    public const int D2 = 8;
    public const int D1 = 9;
    public const int A3U = 10;
    public const int A2U = 11;
    public const int F = 12;
    public const int C1 = 13;
    public const int B1 = 14;
    public const int A1 = 15;
    public const int JAPANESE = 0;
    public const int ENGLISH = 1;
    private bool _debugMode;
    private bool _datalogger;
    private bool _errorlogger;
    private bool _autoMaskID;
    private bool _autoMtxPTN;
    private bool _checkVerTBL;
    private int _language;
    private int _maskID;
    private int _mtxPTN;
    private int _verTBL;
    private string _comPortName;
    [NonSerialized]
    private static Settings _instance;

    public bool DebugMode
    {
      get
      {
        return this._debugMode;
      }
      set
      {
        this._debugMode = value;
      }
    }

    public bool AutoMaskID
    {
      get
      {
        return this._autoMaskID;
      }
      set
      {
        this._autoMaskID = value;
      }
    }

    public bool AutoMtxPTN
    {
      get
      {
        return this._autoMtxPTN;
      }
      set
      {
        this._autoMtxPTN = value;
      }
    }

    public bool CheckVerTBL
    {
      get
      {
        return this._checkVerTBL;
      }
      set
      {
        this._checkVerTBL = value;
      }
    }

    public bool Datalogger
    {
      get
      {
        return this._datalogger;
      }
      set
      {
        this._datalogger = value;
      }
    }

    public bool Errorlogger
    {
      get
      {
        return this._errorlogger;
      }
      set
      {
        this._errorlogger = value;
      }
    }

    public int Language
    {
      get
      {
        return this._language;
      }
      set
      {
        this._language = value;
      }
    }

    public int MaskID
    {
      get
      {
        return this._maskID;
      }
      set
      {
        this._maskID = value;
      }
    }

    public int MtxPTN
    {
      get
      {
        return this._mtxPTN;
      }
      set
      {
        this._mtxPTN = value;
      }
    }

    public int VerTBL
    {
      get
      {
        return this._verTBL;
      }
      set
      {
        this._verTBL = value;
      }
    }

    public string ComPortName
    {
      get
      {
        return this._comPortName;
      }
      set
      {
        this._comPortName = value;
      }
    }

    public Settings()
    {
      this._debugMode = false;
      this._autoMaskID = false;
      this._autoMtxPTN = false;
      this._checkVerTBL = false;
      this._datalogger = false;
      this._errorlogger = false;
      this._language = 0;
      this._maskID = 0;
      this._mtxPTN = 0;
      this._verTBL = 1;
      this._comPortName = "COM1";
    }

    [XmlIgnore]
    public static Settings Instance
    {
      get
      {
        if (Settings._instance == null)
          Settings._instance = new Settings();
        return Settings._instance;
      }
      set
      {
        Settings._instance = value;
      }
    }

    public static void LoadFromXmlFile()
    {
      string path = Settings.settingPath();
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (Settings));
      FileStream fileStream = new FileStream(path, FileMode.Open);
      object obj = (object) (Settings) xmlSerializer.Deserialize((Stream) fileStream);
      fileStream.Close();
      Settings.Instance = (Settings) obj;
    }

    public static void SaveToXmlFile()
    {
      string path = Settings.settingPath();
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (Settings));
      FileStream fileStream = new FileStream(path, FileMode.Create);
      xmlSerializer.Serialize((Stream) fileStream, (object) Settings.Instance);
      fileStream.Close();
    }

    private static string settingPath()
    {
      return Directory.GetCurrentDirectory() + "/config/config.xml";
    }
  }
}
