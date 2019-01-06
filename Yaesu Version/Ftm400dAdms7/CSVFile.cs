// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.CSVFile
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ftm400dAdms7
{
  public class CSVFile
  {
    private string filename;
    private Encoding encode;
    private List<string[]> dataList;

    public CSVFile()
    {
      this.encode = Encoding.GetEncoding("Shift_JIS");
      this.dataList = new List<string[]>();
    }

    public string FileName
    {
      get
      {
        return this.filename;
      }
      set
      {
        this.filename = value;
      }
    }

    public Encoding Encode
    {
      get
      {
        return this.encode;
      }
      set
      {
        this.encode = value;
      }
    }

    public string[][] Data
    {
      get
      {
        return this.dataList.ToArray();
      }
      set
      {
        this.dataList.Clear();
        this.dataList.AddRange((IEnumerable<string[]>) value);
      }
    }

    public bool Read()
    {
      if (!File.Exists(this.filename))
        return false;
      TextFieldParser textFieldParser = (TextFieldParser) null;
      this.dataList.Clear();
      try
      {
        textFieldParser = new TextFieldParser(this.filename, this.encode);
        textFieldParser.TextFieldType = FieldType.Delimited;
        textFieldParser.SetDelimiters(",");
        textFieldParser.TrimWhiteSpace = false;
        while (!textFieldParser.EndOfData)
          this.dataList.Add(textFieldParser.ReadFields());
      }
      catch
      {
        return false;
      }
      finally
      {
        if (textFieldParser != null)
        {
          textFieldParser.Close();
          textFieldParser.Dispose();
        }
      }
      return true;
    }

    public bool Write()
    {
      StreamWriter streamWriter = (StreamWriter) null;
      try
      {
        streamWriter = new StreamWriter(this.filename, false, this.encode);
        for (int index1 = 0; index1 < this.dataList.Count; ++index1)
        {
          string[] data = this.dataList[index1];
          for (int index2 = 0; index2 < data.Length; ++index2)
          {
            streamWriter.Write(data[index2]);
            if (index2 != data.Length - 1)
              streamWriter.Write(",");
          }
          streamWriter.Write("\n");
        }
      }
      catch
      {
        return false;
      }
      finally
      {
        if (streamWriter != null)
        {
          streamWriter.Close();
          streamWriter.Dispose();
        }
      }
      return true;
    }
  }
}
