// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.DataForm
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.ComponentModel;
using System.Reflection;
using System.Resources;

public class DataForm
{
  public static readonly string[] tbl_ShiftDir_All = new string[4]{ "OFF", "-RPT", "+RPT", "-/+" };
  public static readonly string[] tbl_ShiftDir_Vfo = new string[3]{ "OFF", "-RPT", "+RPT" };
  public static readonly string[] tbl_Mode = new string[3]{ "FM", "AM", "NFM" };
  public static readonly string[] tbl_SqlType_All = new string[11]{ "OFF", "TONE ENC", "TONE SQL", "REV TONE", "DCS", "PR FREQ", "PAGER", "DCS ENC", "TONE DCS", "DCS TSQL", "JR FREQ" };
  public static readonly string[] tbl_SqlType_ExOff_JPN = new string[8]{ "OFF", "TONE ENC", "TONE SQL", "REV TONE", "DCS", "PR FREQ", "PAGER", "JR FREQ" };
  public static readonly string[] tbl_SqlType_ExOff_NonJPN = new string[7]{ "OFF", "TONE ENC", "TONE SQL", "REV TONE", "DCS", "PR FREQ", "PAGER" };
  public static readonly string[] tbl_SqlType_ExOn_JPN = new string[11]{ "OFF", "TONE ENC", "TONE SQL", "REV TONE", "DCS", "PR FREQ", "PAGER", "DCS ENC", "TONE DCS", "DCS TSQL", "JR FREQ" };
  public static readonly string[] tbl_SqlType_ExOn_NonJPN = new string[10]{ "OFF", "TONE ENC", "TONE SQL", "REV TONE", "DCS", "PR FREQ", "PAGER", "DCS ENC", "TONE DCS", "DCS TSQL" };
  public static readonly string[] tbl_ToneFreq = new string[50]{ "67.0 Hz", "69.3 Hz", "71.9 Hz", "74.4 Hz", "77.0 Hz", "79.7 Hz", "82.5 Hz", "85.4 Hz", "88.5 Hz", "91.5 Hz", "94.8 Hz", "97.4 Hz", "100.0 Hz", "103.5 Hz", "107.2 Hz", "110.9 Hz", "114.8 Hz", "118.8 Hz", "123.0 Hz", "127.3 Hz", "131.8 Hz", "136.5 Hz", "141.3 Hz", "146.2 Hz", "151.4 Hz", "156.7 Hz", "159.8 Hz", "162.2 Hz", "165.5 Hz", "167.9 Hz", "171.3 Hz", "173.8 Hz", "177.3 Hz", "179.9 Hz", "183.5 Hz", "186.2 Hz", "189.9 Hz", "192.8 Hz", "196.6 Hz", "199.5 Hz", "203.5 Hz", "206.5 Hz", "210.7 Hz", "218.1 Hz", "225.7 Hz", "229.1 Hz", "233.6 Hz", "241.8 Hz", "250.3 Hz", "254.1 Hz" };
  public static readonly string[] tbl_DcsCode = new string[104]{ "023", "025", "026", "031", "032", "036", "043", "047", "051", "053", "054", "065", "071", "072", "073", "074", "114", "115", "116", "122", "125", "131", "132", "134", "143", "145", "152", "155", "156", "162", "165", "172", "174", "205", "212", "223", "225", "226", "243", "244", "245", "246", "251", "252", "255", "261", "263", "265", "266", "271", "274", "306", "311", "315", "325", "331", "332", "343", "346", "351", "356", "364", "365", "371", "411", "412", "413", "423", "431", "432", "445", "446", "452", "454", "455", "462", "464", "465", "466", "503", "506", "516", "523", "526", "532", "546", "565", "606", "612", "624", "627", "631", "632", "654", "662", "664", "703", "712", "723", "731", "732", "734", "743", "754" };
  public static readonly string[] tbl_PrTone = new string[28]{ "300 Hz", "400 Hz", "500 Hz", "600 Hz", "700 Hz", "800 Hz", "900 Hz", "1000 Hz", "1100 Hz", "1200 Hz", "1300 Hz", "1400 Hz", "1500 Hz", "1600 Hz", "1700 Hz", "1800 Hz", "1900 Hz", "2000 Hz", "2100 Hz", "2200 Hz", "2300 Hz", "2400 Hz", "2500 Hz", "2600 Hz", "2700 Hz", "2800 Hz", "2900 Hz", "3000 Hz" };
  public static readonly string[] tbl_SendOut = new string[3]{ "HIGH", "MID", "LOW" };
  public static readonly string[] tbl_Skip = new string[3]{ "OFF", "SKIP", "SELECT" };
  public static readonly string[] tbl_Step_all = new string[10]{ "5.0KHz", "6.25KHz", "8.33KHz", "10.0KHz", "12.5KHz", "15.0KHz", "20.0KHz", "25.0KHz", "50.0KHz", "100.0KHz" };
  public static readonly string[] tbl_Step_air = new string[10]{ "5.0KHz", "6.25KHz", "8.33KHz", "10.0KHz", "12.5KHz", "15.0KHz", "20.0KHz", "25.0KHz", "50.0KHz", "100.0KHz" };
  public static readonly string[] tbl_Step_vhf = new string[9]{ "5.0KHz", "6.25KHz", "10.0KHz", "12.5KHz", "15.0KHz", "20.0KHz", "25.0KHz", "50.0KHz", "100.0KHz" };
  public static readonly string[] tbl_Step_gr1 = new string[9]{ "5.0KHz", "6.25KHz", "10.0KHz", "12.5KHz", "15.0KHz", "20.0KHz", "25.0KHz", "50.0KHz", "100.0KHz" };
  public static readonly string[] tbl_Step_uhf = new string[9]{ "5.0KHz", "6.25KHz", "10.0KHz", "12.5KHz", "15.0KHz", "20.0KHz", "25.0KHz", "50.0KHz", "100.0KHz" };
  public static readonly string[] tbl_Step_gr2 = new string[6]{ "10.0KHz", "12.5KHz", "20.0KHz", "25.0KHz", "50.0KHz", "100.0KHz" };
  public static readonly string[,] tbl_Mode_Ft1d_Csv = new string[3, 2]{ { "NFM", "FM" }, { "AM", "AM" }, { "NFM", "NFM" } };
  public static readonly string[,] tbl_SqlType_Ft1d_Csv = new string[11, 2]{ { "OFF", "OFF" }, { "TONE", "TONE ENC" }, { "TONE SQL", "TONE SQL" }, { "DCS", "DCS" }, { "REV TONE", "REV TONE" }, { "JR FREQ", "JR FREQ" }, { "PR FREQ", "PR FREQ" }, { "PAGER", "PAGER" }, { "DCS(TX)", "DCS ENC" }, { "ENC(TX)DCS(RX)", "TONE DCS" }, { "DCS(TX)DEC(RX)", "DCS TSQL" } };
  public static readonly object[,,] tbl_Default = new object[5, 16, 16]{ { { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "88.5 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "88.5 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "108.00000", (object) "108.00000", (object) "0.00000", (object) "OFF", (object) "AM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" } }, { { (object) "144.00000", (object) "144.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "144.00000", (object) "144.00000", (object) "0.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "144.00000", (object) "144.00000", (object) "0.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "144.00000", (object) "144.00000", (object) "0.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "5.0KHz", (object) false, (object) false, (object) "" }, { (object) "145.00000", (object) "145.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "88.5 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "20.0KHz", (object) false, (object) false, (object) "" }, { (object) "144.00000", (object) "144.00000", (object) "0.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "144.00000", (object) "144.00000", (object) "0.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "144.00000", (object) "144.00000", (object) "0.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "5.0KHz", (object) false, (object) false, (object) "" }, { (object) "144.00000", (object) "144.00000", (object) "0.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "144.00000", (object) "144.00000", (object) "0.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "144.00000", (object) "144.00000", (object) "0.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "144.00000", (object) "144.00000", (object) "0.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "145.00000", (object) "145.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "88.5 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "144.00000", (object) "144.00000", (object) "0.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "144.00000", (object) "144.00000", (object) "0.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "144.00000", (object) "144.00000", (object) "0.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "5.0KHz", (object) false, (object) false, (object) "" } }, { { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "174.00000", (object) "174.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "88.5 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "50.0KHz", (object) false, (object) false, (object) "" }, { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "174.00000", (object) "174.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "88.5 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "50.0KHz", (object) false, (object) false, (object) "" }, { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "222.00000", (object) "222.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" } }, { { (object) "430.00000", (object) "430.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "430.00000", (object) "430.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "430.00000", (object) "430.00000", (object) "7.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "430.00000", (object) "430.00000", (object) "5.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "433.00000", (object) "433.00000", (object) "5.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "88.5 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "20.0KHz", (object) false, (object) false, (object) "" }, { (object) "430.00000", (object) "430.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "430.00000", (object) "430.00000", (object) "7.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "430.00000", (object) "430.00000", (object) "5.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "430.00000", (object) "430.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "432.00000", (object) "432.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "430.00000", (object) "430.00000", (object) "5.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "430.00000", (object) "430.00000", (object) "5.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "433.00000", (object) "433.00000", (object) "5.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "88.5 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "20.0KHz", (object) false, (object) false, (object) "" }, { (object) "430.00000", (object) "430.00000", (object) "1.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "430.00000", (object) "430.00000", (object) "7.60000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" }, { (object) "430.00000", (object) "430.00000", (object) "5.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "25.0KHz", (object) false, (object) false, (object) "" } }, { { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "88.5 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "88.5 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" }, { (object) "850.00000", (object) "850.00000", (object) "0.00000", (object) "OFF", (object) "FM", (object) "", (object) "OFF", (object) "100.0 Hz", (object) "023", (object) "1500 Hz", (object) "HIGH", (object) "OFF", (object) "12.5KHz", (object) false, (object) false, (object) "" } } };
  public static readonly bool[,] tbl_VisibleRow = new bool[8, 16]{ { true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true }, { true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true }, { true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true }, { true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true }, { true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true }, { true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true }, { true, true, true, true, true, false, true, true, true, true, true, false, true, false, true, true }, { true, true, true, true, true, false, true, true, true, true, true, false, true, false, true, true } };
  public static readonly bool[,,] tbl_ReadOnlyCell = new bool[5, 16, 16]{ { { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false }, { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false }, { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false } }, { { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false } }, { { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false }, { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false }, { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false } }, { { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false } }, { { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false }, { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false }, { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false }, { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false } } };
  public static readonly Decimal[,,] tbl_RecvFreq = new Decimal[5, 16, 2]{ { { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) }, { new Decimal(10800000, 0, 0, false, (byte) 5), new Decimal(13700000, 0, 0, false, (byte) 5) } }, { { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14600500, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14600500, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14600500, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14800500, 0, 0, false, (byte) 5) } }, { { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) }, { new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5) } }, { { new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(43200000, 0, 0, false, (byte) 5), new Decimal(43800500, 0, 0, false, (byte) 5) }, { new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44000500, 0, 0, false, (byte) 5) }, { new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44000500, 0, 0, false, (byte) 5) }, { new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(45000500, 0, 0, false, (byte) 5) } }, { { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) }, { new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(100000000, 0, 0, false, (byte) 5) } } };
  public static readonly Decimal[,] SendFreq = new Decimal[16, 4]{ { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14605000, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44005000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14605000, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44005000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14605000, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44005000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14805000, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(45005000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14605000, 0, 0, false, (byte) 5), new Decimal(43200000, 0, 0, false, (byte) 5), new Decimal(43805000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14605000, 0, 0, false, (byte) 5), new Decimal(43200000, 0, 0, false, (byte) 5), new Decimal(43805000, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14805000, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(45005000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14605000, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44005000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14605000, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44005000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14605000, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44005000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14805000, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(45005000, 0, 0, false, (byte) 5) } };
  public static readonly Decimal[] tbl_Add833KHz = new Decimal[12]{ new Decimal(0, 0, 0, false, (byte) 5), new Decimal(833, 0, 0, false, (byte) 5), new Decimal(1666, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5), new Decimal(3333, 0, 0, false, (byte) 5), new Decimal(4166, 0, 0, false, (byte) 5), new Decimal(5000, 0, 0, false, (byte) 5), new Decimal(5833, 0, 0, false, (byte) 5), new Decimal(6666, 0, 0, false, (byte) 5), new Decimal(7500, 0, 0, false, (byte) 5), new Decimal(8333, 0, 0, false, (byte) 5), new Decimal(9166, 0, 0, false, (byte) 5) };
  private object[][,] backupObj = new object[8][,];
  private ResourceManager resources = new ResourceManager("Ftm400dAdms7.Strings", typeof (DataForm).Assembly);
  public const int TAB_MAX = 8;
  public const int TAB_BANDA = 0;
  public const int TAB_BANDB = 1;
  public const int TAB_PMSA = 2;
  public const int TAB_PMSB = 3;
  public const int TAB_HOMEA = 4;
  public const int TAB_HOMEB = 5;
  public const int TAB_VFOA = 6;
  public const int TAB_VFOB = 7;
  public const int ROW_MAX = 1056;
  public const int ROW_BANDA = 500;
  public const int ROW_BANDB = 500;
  public const int ROW_PMSA = 18;
  public const int ROW_PMSB = 18;
  public const int ROW_HOMEA = 5;
  public const int ROW_HOMEB = 5;
  public const int ROW_VFOA = 5;
  public const int ROW_VFOB = 5;
  public const int COL_MAX = 16;
  public const int COL_RECVFREQ = 0;
  public const int COL_SENDFREQ = 1;
  public const int COL_SHIFTFREQ = 2;
  public const int COL_SHIFTDIR = 3;
  public const int COL_MODE = 4;
  public const int COL_MEMORYNAME = 5;
  public const int COL_SQLTYPE = 6;
  public const int COL_TONEFREQ = 7;
  public const int COL_DCSCODE = 8;
  public const int COL_PRTONE = 9;
  public const int COL_SENDOUT = 10;
  public const int COL_SKIP = 11;
  public const int COL_STEP = 12;
  public const int COL_MEMORYDIR = 13;
  public const int COL_CLOCKSHIFT = 14;
  public const int COL_COMMENT = 15;
  private const int FREQMAXLEN = 9;
  private const int MEMORYNAMEMAXLEN = 8;
  private const int COMMENTMAXLEN = 255;
  private const int HEADERWIDTH = 110;
  private const int HEADERHEIGHT = 40;
  private const int DATAWIDTH = 100;
  private const int DATAHEIGHT = 40;
  private const int COMMENTWIDTH = 200;
  public const int BAND_AIR = 0;
  public const int BAND_VHF = 1;
  public const int BAND_GR1 = 2;
  public const int BAND_UHF = 3;
  public const int BAND_GR2 = 4;
  private const string RPTOFF = "OFF";
  private const string RPTMINUS = "-RPT";
  private const string RPTPLUS = "+RPT";
  private const string RPTSEMIDUPLEX = "-/+";
  private const string MODEFM = "FM";
  private const string MODEAM = "AM";
  private const string MODENFM = "NFM";
  private const string SQLOFF = "OFF";
  private const string SQLTONEENC = "TONE ENC";
  private const string SQLTONESQL = "TONE SQL";
  private const string SQLREVTONE = "REV TONE";
  private const string SQLDCS = "DCS";
  private const string SQLPRFREQ = "PR FREQ";
  private const string SQLPAGER = "PAGER";
  private const string SQLDCSENC = "DCS ENC";
  private const string TONEDCS = "TONE DCS";
  private const string DCSTSQL = "DCS TSQL";
  private const string SQLJRFREQ = "JR FREQ";
  private const string TONE67_0Hz = "67.0 Hz";
  private const string TONE69_3Hz = "69.3 Hz";
  private const string TONE71_9Hz = "71.9 Hz";
  private const string TONE74_4Hz = "74.4 Hz";
  private const string TONE77_0Hz = "77.0 Hz";
  private const string TONE79_7Hz = "79.7 Hz";
  private const string TONE82_5Hz = "82.5 Hz";
  private const string TONE85_4Hz = "85.4 Hz";
  private const string TONE88_5Hz = "88.5 Hz";
  private const string TONE91_5Hz = "91.5 Hz";
  private const string TONE94_8Hz = "94.8 Hz";
  private const string TONE97_4Hz = "97.4 Hz";
  private const string TONE100_0Hz = "100.0 Hz";
  private const string TONE103_5Hz = "103.5 Hz";
  private const string TONE107_2Hz = "107.2 Hz";
  private const string TONE110_9Hz = "110.9 Hz";
  private const string TONE114_8Hz = "114.8 Hz";
  private const string TONE118_8Hz = "118.8 Hz";
  private const string TONE123_0Hz = "123.0 Hz";
  private const string TONE127_3Hz = "127.3 Hz";
  private const string TONE131_8Hz = "131.8 Hz";
  private const string TONE136_5Hz = "136.5 Hz";
  private const string TONE141_3Hz = "141.3 Hz";
  private const string TONE146_2Hz = "146.2 Hz";
  private const string TONE151_4Hz = "151.4 Hz";
  private const string TONE156_7Hz = "156.7 Hz";
  private const string TONE159_8Hz = "159.8 Hz";
  private const string TONE162_2Hz = "162.2 Hz";
  private const string TONE165_5Hz = "165.5 Hz";
  private const string TONE167_9Hz = "167.9 Hz";
  private const string TONE171_3Hz = "171.3 Hz";
  private const string TONE173_8Hz = "173.8 Hz";
  private const string TONE177_3Hz = "177.3 Hz";
  private const string TONE179_9Hz = "179.9 Hz";
  private const string TONE183_5Hz = "183.5 Hz";
  private const string TONE186_2Hz = "186.2 Hz";
  private const string TONE189_9Hz = "189.9 Hz";
  private const string TONE192_8Hz = "192.8 Hz";
  private const string TONE196_6Hz = "196.6 Hz";
  private const string TONE199_5Hz = "199.5 Hz";
  private const string TONE203_5Hz = "203.5 Hz";
  private const string TONE206_5Hz = "206.5 Hz";
  private const string TONE210_7Hz = "210.7 Hz";
  private const string TONE218_1Hz = "218.1 Hz";
  private const string TONE225_7Hz = "225.7 Hz";
  private const string TONE229_1Hz = "229.1 Hz";
  private const string TONE233_6Hz = "233.6 Hz";
  private const string TONE241_8Hz = "241.8 Hz";
  private const string TONE250_3Hz = "250.3 Hz";
  private const string TONE254_1Hz = "254.1 Hz";
  private const string DCS023 = "023";
  private const string DCS025 = "025";
  private const string DCS026 = "026";
  private const string DCS031 = "031";
  private const string DCS032 = "032";
  private const string DCS036 = "036";
  private const string DCS043 = "043";
  private const string DCS047 = "047";
  private const string DCS051 = "051";
  private const string DCS053 = "053";
  private const string DCS054 = "054";
  private const string DCS065 = "065";
  private const string DCS071 = "071";
  private const string DCS072 = "072";
  private const string DCS073 = "073";
  private const string DCS074 = "074";
  private const string DCS114 = "114";
  private const string DCS115 = "115";
  private const string DCS116 = "116";
  private const string DCS122 = "122";
  private const string DCS125 = "125";
  private const string DCS131 = "131";
  private const string DCS132 = "132";
  private const string DCS134 = "134";
  private const string DCS143 = "143";
  private const string DCS145 = "145";
  private const string DCS152 = "152";
  private const string DCS155 = "155";
  private const string DCS156 = "156";
  private const string DCS162 = "162";
  private const string DCS165 = "165";
  private const string DCS172 = "172";
  private const string DCS174 = "174";
  private const string DCS205 = "205";
  private const string DCS212 = "212";
  private const string DCS223 = "223";
  private const string DCS225 = "225";
  private const string DCS226 = "226";
  private const string DCS243 = "243";
  private const string DCS244 = "244";
  private const string DCS245 = "245";
  private const string DCS246 = "246";
  private const string DCS251 = "251";
  private const string DCS252 = "252";
  private const string DCS255 = "255";
  private const string DCS261 = "261";
  private const string DCS263 = "263";
  private const string DCS265 = "265";
  private const string DCS266 = "266";
  private const string DCS271 = "271";
  private const string DCS274 = "274";
  private const string DCS306 = "306";
  private const string DCS311 = "311";
  private const string DCS315 = "315";
  private const string DCS325 = "325";
  private const string DCS331 = "331";
  private const string DCS332 = "332";
  private const string DCS343 = "343";
  private const string DCS346 = "346";
  private const string DCS351 = "351";
  private const string DCS356 = "356";
  private const string DCS364 = "364";
  private const string DCS365 = "365";
  private const string DCS371 = "371";
  private const string DCS411 = "411";
  private const string DCS412 = "412";
  private const string DCS413 = "413";
  private const string DCS423 = "423";
  private const string DCS431 = "431";
  private const string DCS432 = "432";
  private const string DCS445 = "445";
  private const string DCS446 = "446";
  private const string DCS452 = "452";
  private const string DCS454 = "454";
  private const string DCS455 = "455";
  private const string DCS462 = "462";
  private const string DCS464 = "464";
  private const string DCS465 = "465";
  private const string DCS466 = "466";
  private const string DCS503 = "503";
  private const string DCS506 = "506";
  private const string DCS516 = "516";
  private const string DCS523 = "523";
  private const string DCS526 = "526";
  private const string DCS532 = "532";
  private const string DCS546 = "546";
  private const string DCS565 = "565";
  private const string DCS606 = "606";
  private const string DCS612 = "612";
  private const string DCS624 = "624";
  private const string DCS627 = "627";
  private const string DCS631 = "631";
  private const string DCS632 = "632";
  private const string DCS654 = "654";
  private const string DCS662 = "662";
  private const string DCS664 = "664";
  private const string DCS703 = "703";
  private const string DCS712 = "712";
  private const string DCS723 = "723";
  private const string DCS731 = "731";
  private const string DCS732 = "732";
  private const string DCS734 = "734";
  private const string DCS743 = "743";
  private const string DCS754 = "754";
  private const string PR300HZ = "300 Hz";
  private const string PR400HZ = "400 Hz";
  private const string PR500HZ = "500 Hz";
  private const string PR600HZ = "600 Hz";
  private const string PR700HZ = "700 Hz";
  private const string PR800HZ = "800 Hz";
  private const string PR900HZ = "900 Hz";
  private const string PR1000HZ = "1000 Hz";
  private const string PR1100HZ = "1100 Hz";
  private const string PR1200HZ = "1200 Hz";
  private const string PR1300HZ = "1300 Hz";
  private const string PR1400HZ = "1400 Hz";
  private const string PR1500HZ = "1500 Hz";
  private const string PR1600HZ = "1600 Hz";
  private const string PR1700HZ = "1700 Hz";
  private const string PR1800HZ = "1800 Hz";
  private const string PR1900HZ = "1900 Hz";
  private const string PR2000HZ = "2000 Hz";
  private const string PR2100HZ = "2100 Hz";
  private const string PR2200HZ = "2200 Hz";
  private const string PR2300HZ = "2300 Hz";
  private const string PR2400HZ = "2400 Hz";
  private const string PR2500HZ = "2500 Hz";
  private const string PR2600HZ = "2600 Hz";
  private const string PR2700HZ = "2700 Hz";
  private const string PR2800HZ = "2800 Hz";
  private const string PR2900HZ = "2900 Hz";
  private const string PR3000HZ = "3000 Hz";
  private const string SOHIGH = "HIGH";
  private const string SOMID = "MID";
  private const string SOLOW = "LOW";
  private const string SKIPOFF = "OFF";
  private const string SKIPSKIP = "SKIP";
  private const string SKIPSELECT = "SELECT";
  private const string STEP5_0KHz = "5.0KHz";
  private const string STEP6_25KHz = "6.25KHz";
  private const string STEP8_33KHz = "8.33KHz";
  private const string STEP10_0KHz = "10.0KHz";
  private const string STEP12_5KHz = "12.5KHz";
  private const string STEP15_0KHz = "15.0KHz";
  private const string STEP20_0KHz = "20.0KHz";
  private const string STEP25_0KHz = "25.0KHz";
  private const string STEP50_0KHz = "50.0KHz";
  private const string STEP100_0KHz = "100.0KHz";
  private const int FT1D = 0;
  private const int FTM400D = 1;
  public const int R_MIN = 0;
  public const int R_MAX = 1;
  public const int S_MINL = 0;
  public const int S_MAXL = 1;
  public const int S_MINH = 2;
  public const int S_MAXH = 3;
  private int finedCol;
  private string finedStr;
  //private AdmsForm aform;
  private Database db;
  private IContainer components;
/*
  private TabPage tab_VfoB;
  public DataGridView dgv_VfoB;
  private TabPage tab_VfoA;
  public DataGridView dgv_VfoA;
  private TabPage tab_PmsB;
  public DataGridView dgv_PmsB;
  private TabPage tab_PmsA;
  public DataGridView dgv_PmsA;
  private TabPage tab_HomeA;
  public DataGridView dgv_HomeA;
  private TabPage tab_HomeB;
  public DataGridView dgv_HomeB;
  private TabPage tab_BandA;
  public DataGridView dgv_BandA;
  private TabPage tab_BandB;
  public DataGridView dgv_BandB;
  public TabControl tabc_DataForm;
*/

  public string FilePath { get; set; }

  public string FileName { get; set; }

  public bool IsSave { get; set; }

  public bool IsSend { get; set; }

  public DataForm()
  {
  }
/*
  public DataForm(AdmsForm admsform, Database database)
  {
    this.db = database;
    this.aform = admsform;
    this.IsSave = false;
    this.IsSend = !Settings.Instance.AutoMtxPTN;
    this.backupObj[0] = new object[500, 16];
    this.backupObj[1] = new object[500, 16];
    this.backupObj[2] = new object[18, 16];
    this.backupObj[3] = new object[18, 16];
    this.backupObj[4] = new object[5, 16];
    this.backupObj[5] = new object[5, 16];
    this.backupObj[6] = new object[5, 16];
    this.backupObj[7] = new object[5, 16];
    this.InitializeComponent();
  }

  private void DataForm_Load(object sender, EventArgs e)
  {
    this.dgvSetup(this.dgv_BandA, this.db.aBandMemory);
    this.dgvSetup(this.dgv_BandB, this.db.bBandMemory);
    this.dgvSetup(this.dgv_PmsA, this.db.aBandPmsMemory);
    this.dgvSetup(this.dgv_PmsB, this.db.bBandPmsMemory);
    this.dgvSetup(this.dgv_HomeA, this.db.aBandHome);
    this.dgvSetup(this.dgv_HomeB, this.db.bBandHome);
    this.dgvSetup(this.dgv_VfoA, this.db.aBandVfo);
    this.dgvSetup(this.dgv_VfoB, this.db.bBandVfo);
    this.toDgvCell(this.dgv_BandA, this.db.aBandMemory);
    this.toDgvCell(this.dgv_BandB, this.db.bBandMemory);
    this.toDgvCell(this.dgv_PmsA, this.db.aBandPmsMemory);
    this.toDgvCell(this.dgv_PmsB, this.db.bBandPmsMemory);
    this.toDgvCell(this.dgv_HomeA, this.db.aBandHome);
    this.toDgvCell(this.dgv_HomeB, this.db.bBandHome);
    this.toDgvCell(this.dgv_VfoA, this.db.aBandVfo);
    this.toDgvCell(this.dgv_VfoB, this.db.bBandVfo);
  }

  private void dgvSetup(DataGridView dgv, BindingList<BandMemory> bandmemory)
  {
    typeof (DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue((object) dgv, (object) true, (object[]) null);
    dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
    this.dgvTxtBoxInit(dgv, "RECVFREQ");
    this.dgvTxtBoxInit(dgv, "SENDFREQ");
    this.dgvTxtBoxInit(dgv, "SHIFTFREQ");
    if (this.tabIdex(dgv) < 6)
      this.dgvCmbBoxInit(dgv, "SHIFTDIR", DataForm.tbl_ShiftDir_All);
    else
      this.dgvCmbBoxInit(dgv, "SHIFTDIR", DataForm.tbl_ShiftDir_Vfo);
    this.dgvCmbBoxInit(dgv, "MODE", DataForm.tbl_Mode);
    this.dgvTxtBoxInit(dgv, "MEMORYNAME");
    this.dgvCmbBoxInit(dgv, "SQLTYPE", DataForm.tbl_SqlType_All);
    this.dgvCmbBoxInit(dgv, "TONEFREQ", DataForm.tbl_ToneFreq);
    this.dgvCmbBoxInit(dgv, "DCSCODE", DataForm.tbl_DcsCode);
    this.dgvCmbBoxInit(dgv, "PRTONE", DataForm.tbl_PrTone);
    this.dgvCmbBoxInit(dgv, "SENDOUT", DataForm.tbl_SendOut);
    this.dgvCmbBoxInit(dgv, "SKIP", DataForm.tbl_Skip);
    this.dgvCmbBoxInit(dgv, "STEP", DataForm.tbl_Step_all);
    this.dgvChkBoxInit(dgv, "MEMORYMASK");
    this.dgvChkBoxInit(dgv, "CLOCKSHIFT");
    this.dgvTxtBoxInit(dgv, "COMMENT");
    int index = this.tabIdex(dgv);
    dgv.Columns[0].Width = 100;
    dgv.Columns[0].ReadOnly = false;
    dgv.Columns[0].DefaultCellStyle.Format = "N5";
    dgv.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    ((DataGridViewTextBoxColumn) dgv.Columns[0]).MaxInputLength = 9;
    dgv.Columns[0].Visible = DataForm.tbl_VisibleRow[index, 0];
    dgv.Columns[1].Width = 100;
    dgv.Columns[1].ReadOnly = false;
    dgv.Columns[1].DefaultCellStyle.Format = "N5";
    dgv.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    ((DataGridViewTextBoxColumn) dgv.Columns[1]).MaxInputLength = 9;
    dgv.Columns[1].Visible = DataForm.tbl_VisibleRow[index, 1];
    dgv.Columns[2].Width = 100;
    dgv.Columns[2].ReadOnly = false;
    dgv.Columns[2].DefaultCellStyle.Format = "N5";
    dgv.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    ((DataGridViewTextBoxColumn) dgv.Columns[2]).MaxInputLength = 9;
    dgv.Columns[2].Visible = DataForm.tbl_VisibleRow[index, 2];
    dgv.Columns[3].Width = 100;
    dgv.Columns[3].ReadOnly = false;
    dgv.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[3].Visible = DataForm.tbl_VisibleRow[index, 3];
    dgv.Columns[4].Width = 100;
    dgv.Columns[4].ReadOnly = false;
    dgv.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[4].Visible = DataForm.tbl_VisibleRow[index, 4];
    dgv.Columns[5].Width = 100;
    dgv.Columns[5].ReadOnly = false;
    dgv.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
    ((DataGridViewTextBoxColumn) dgv.Columns[5]).MaxInputLength = 8;
    dgv.Columns[5].Visible = DataForm.tbl_VisibleRow[index, 5];
    dgv.Columns[6].Width = 100;
    dgv.Columns[6].ReadOnly = false;
    dgv.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[6].Visible = DataForm.tbl_VisibleRow[index, 6];
    dgv.Columns[7].Width = 100;
    dgv.Columns[7].ReadOnly = false;
    dgv.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[7].Visible = DataForm.tbl_VisibleRow[index, 7];
    dgv.Columns[8].Width = 100;
    dgv.Columns[8].ReadOnly = false;
    dgv.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[8].Visible = DataForm.tbl_VisibleRow[index, 8];
    dgv.Columns[9].Width = 100;
    dgv.Columns[9].ReadOnly = false;
    dgv.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[9].Visible = DataForm.tbl_VisibleRow[index, 9];
    dgv.Columns[10].Width = 100;
    dgv.Columns[10].ReadOnly = false;
    dgv.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[10].Visible = DataForm.tbl_VisibleRow[index, 10];
    dgv.Columns[11].Width = 100;
    dgv.Columns[11].ReadOnly = false;
    dgv.Columns[11].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[11].Visible = DataForm.tbl_VisibleRow[index, 11];
    dgv.Columns[12].Width = 100;
    dgv.Columns[12].ReadOnly = false;
    dgv.Columns[12].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[12].Visible = DataForm.tbl_VisibleRow[index, 12];
    dgv.Columns[13].Width = 100;
    dgv.Columns[13].ReadOnly = false;
    dgv.Columns[13].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[13].Visible = DataForm.tbl_VisibleRow[index, 13];
    dgv.Columns[14].Width = 100;
    dgv.Columns[14].ReadOnly = false;
    dgv.Columns[14].SortMode = DataGridViewColumnSortMode.NotSortable;
    dgv.Columns[14].Visible = DataForm.tbl_VisibleRow[index, 14];
    dgv.Columns[15].Width = 200;
    dgv.Columns[15].ReadOnly = false;
    dgv.Columns[15].SortMode = DataGridViewColumnSortMode.NotSortable;
    ((DataGridViewTextBoxColumn) dgv.Columns[15]).MaxInputLength = (int) byte.MaxValue;
    dgv.Columns[15].Visible = DataForm.tbl_VisibleRow[index, 15];
    dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
    dgv.ColumnHeadersHeight = 40;
    dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    dgv.Rows.Add(bandmemory.Count);
    if (this.tabIdex(dgv) < 4)
      this.dgvRowHeaderInit(dgv, "CHANNELNUM");
    else
      this.dgvRowHeaderInit(dgv, "BAND");
    dgv.EnableHeadersVisualStyles = false;
    dgv.Columns[0].Frozen = true;
    dgv.AllowUserToResizeRows = false;
    dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
    dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
  }

  private void dgvRowHeaderInit(DataGridView dgv, string rName)
  {
    dgv.TopLeftHeaderCell.Value = (object) this.resources.GetString(rName);
    dgv.RowHeadersWidth = 110;
    dgv.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
  }

  private void dgvTxtBoxInit(DataGridView dgv, string rName)
  {
    DataGridViewTextBoxColumn viewTextBoxColumn = new DataGridViewTextBoxColumn();
    viewTextBoxColumn.HeaderText = this.resources.GetString(rName);
    dgv.Columns.Add((DataGridViewColumn) viewTextBoxColumn);
  }

  private void dgvChkBoxInit(DataGridView dgv, string rName)
  {
    DataGridViewCheckBoxColumn viewCheckBoxColumn = new DataGridViewCheckBoxColumn();
    viewCheckBoxColumn.HeaderText = this.resources.GetString(rName);
    dgv.Columns.Add((DataGridViewColumn) viewCheckBoxColumn);
  }

  private void dgvCmbBoxInit(DataGridView dgv, string rName, string[] Items)
  {
    DataGridViewComboBoxColumn viewComboBoxColumn = new DataGridViewComboBoxColumn();
    viewComboBoxColumn.HeaderText = this.resources.GetString(rName);
    dgv.Columns.Add((DataGridViewColumn) viewComboBoxColumn);
    viewComboBoxColumn.DisplayStyleForCurrentCellOnly = true;
    viewComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
    viewComboBoxColumn.FlatStyle = FlatStyle.Popup;
    viewComboBoxColumn.Items.AddRange((object[]) Items);
  }

  private void DataForm_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (this.IsSave)
      return;
    switch (MessageBox.Show(this.resources.GetString("ISSAVECLOSE"), this.resources.GetString("INFOMSG"), MessageBoxButtons.YesNoCancel))
    {
      case DialogResult.Cancel:
        e.Cancel = true;
        break;
      case DialogResult.Yes:
        if (this.FilePath == null || this.FilePath == "")
        {
          this.aform.FileSaveAs(this);
          break;
        }
        this.aform.FileSave(this);
        break;
    }
  }

  private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
  {
    DataGridView dataGridView = (DataGridView) sender;
    this.backup();
    if (!(e.Control is DataGridViewTextBoxEditingControl))
      return;
    DataGridViewTextBoxEditingControl control = (DataGridViewTextBoxEditingControl) e.Control;
    control.KeyPress -= new KeyPressEventHandler(KeyPressCancel.txt_Freq_KeyPress);
    control.KeyPress -= new KeyPressEventHandler(KeyPressCancel.txt_MemoryName_KeyPress);
    switch (dataGridView.CurrentCell.ColumnIndex)
    {
      case 0:
      case 1:
        control.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_Freq_KeyPress);
        break;
      case 5:
        control.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_MemoryName_KeyPress);
        break;
    }
  }

  private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
  {
    switch (e.ColumnIndex)
    {
      case 0:
        this.dgv_RecvFreq(sender, e);
        break;
      case 1:
        this.dgv_SendFreq(sender, e);
        break;
      case 2:
        this.dgv_ShiftFreq(sender, e);
        break;
      case 3:
        this.dgv_ShiftDir(sender, e);
        break;
      case 5:
        this.dgv_MemoryName(sender, e);
        break;
    }
    this.IsSave = false;
  }

  private void dgv_RecvFreq(object sender, DataGridViewCellEventArgs e)
  {
    DataGridView dgv = (DataGridView) sender;
    int selectedIndex1 = this.tabc_DataForm.SelectedIndex;
    int num1;
    int num2;
    if (selectedIndex1 % 2 == 0)
    {
      num1 = this.db.Config_AtModeA;
      num2 = this.db.Config_AtRptShftA;
    }
    else
    {
      num1 = this.db.Config_AtModeB;
      num2 = this.db.Config_AtRptShftB;
    }
    if (dgv[e.ColumnIndex, e.RowIndex].Value == null)
    {
      int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
      dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
    }
    else if (dgv[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
    {
      int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
      dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
    }
    else
    {
      Decimal num3;
      try
      {
        num3 = Decimal.Parse(dgv[e.ColumnIndex, e.RowIndex].Value.ToString());
      }
      catch
      {
        int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
        return;
      }
      int bandIdx = DataForm.GetBandIdx(num3);
      if (bandIdx == -1)
      {
        int num4 = (int) MessageBox.Show(this.resources.GetString("FREQERRORMSG"), this.resources.GetString("FREQERROR"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
      }
      else if (DataForm.isRecvDisableAria(num3))
      {
        int num4 = (int) MessageBox.Show(this.resources.GetString("FREQERRORMSG"), this.resources.GetString("FREQERROR"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
      }
      else if (selectedIndex1 >= 4 && bandIdx != e.RowIndex)
      {
        int num4 = (int) MessageBox.Show(this.resources.GetString("FREQERRORMSG"), this.resources.GetString("FREQERROR"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
      }
      else
      {
        Decimal freqStep = DataForm.getFreqStep(num3);
        if (freqStep == new Decimal(-1))
        {
          int num4 = (int) MessageBox.Show(this.resources.GetString("FREQERRORMSG"), this.resources.GetString("FREQERROR"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
          dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
        }
        else
        {
          dgv[e.ColumnIndex, e.RowIndex].Value = (object) num3.ToString("N5");
          if (this.isBrank(dgv, e.RowIndex, 1))
          {
            for (int index = 1; index < dgv.ColumnCount; ++index)
              dgv.Rows[e.RowIndex].Cells[index].Value = DataForm.tbl_Default[bandIdx, Settings.Instance.MtxPTN, index];
          }
          dgv.Rows[e.RowIndex].Cells[12].Value = (object) (freqStep.ToString() + "KHz");
          if (num1 == 1)
            DataForm.autoMode(dgv, e.RowIndex, num3);
          if (num2 == 1)
            DataForm.autoRptrShift(dgv, e.RowIndex, num3);
          this.inputLimited(dgv, e.RowIndex);
        }
      }
    }
  }

  private void dgv_SendFreq(object sender, DataGridViewCellEventArgs e)
  {
    DataGridView dgv = (DataGridView) sender;
    if (dgv[e.ColumnIndex, e.RowIndex].Value == null)
    {
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
    }
    else if (dgv[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
    {
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
    }
    else
    {
      Decimal num1;
      try
      {
        num1 = Decimal.Parse(dgv[e.ColumnIndex, e.RowIndex].Value.ToString());
      }
      catch
      {
        int selectedIndex = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
        return;
      }
      if (!DataForm.checkSendFreq(num1))
      {
        int num2 = (int) MessageBox.Show(this.resources.GetString("FREQERRORMSG"), this.resources.GetString("FREQERROR"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        int selectedIndex = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
      }
      else if (DataForm.getFreqStep(num1) == new Decimal(-1))
      {
        int num2 = (int) MessageBox.Show(this.resources.GetString("FREQERRORMSG"), this.resources.GetString("FREQERROR"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        int selectedIndex = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
      }
      else
      {
        dgv[e.ColumnIndex, e.RowIndex].Value = (object) num1.ToString("N5");
        this.inputLimited(dgv, e.RowIndex);
      }
    }
  }

  private void dgv_ShiftFreq(object sender, DataGridViewCellEventArgs e)
  {
    DataGridView dgv = (DataGridView) sender;
    if (dgv[e.ColumnIndex, e.RowIndex].Value == null)
    {
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
    }
    else if (dgv[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
    {
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
    }
    else
    {
      Decimal sftFreq;
      try
      {
        sftFreq = Decimal.Parse(dgv[e.ColumnIndex, e.RowIndex].Value.ToString());
      }
      catch
      {
        int selectedIndex = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
        return;
      }
      if (!DataForm.checkShiftFreq(sftFreq))
      {
        int num = (int) MessageBox.Show(this.resources.GetString("FREQERRORMSG"), this.resources.GetString("FREQERROR"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        int selectedIndex = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
      }
      else
      {
        dgv[e.ColumnIndex, e.RowIndex].Value = (object) sftFreq.ToString("N5");
        this.inputLimited(dgv, e.RowIndex);
      }
    }
  }

  private void dgv_MemoryName(object sender, DataGridViewCellEventArgs e)
  {
    DataGridView dgv = (DataGridView) sender;
    int selectedIndex = this.tabc_DataForm.SelectedIndex;
    if (this.isBrank(dgv, e.RowIndex, e.ColumnIndex))
      return;
    foreach (char c in dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToCharArray())
    {
      if (!Moji.IsMemoryNameChar(c))
      {
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
        break;
      }
    }
  }

  private void dgv_ShiftDir(object sender, DataGridViewCellEventArgs e)
  {
    this.inputLimited((DataGridView) sender, e.RowIndex);
  }

  private void DataForm_Activated(object sender, EventArgs e)
  {
    this.aform.MenuToolStripSetting(this.tabc_DataForm.SelectedIndex, this.IsSend);
  }

  private void tabc_DataForm_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.aform.MenuToolStripSetting(this.tabc_DataForm.SelectedIndex, this.IsSend);
  }

  public Database GetDB()
  {
    return this.db;
  }

  public int SelectedIndexTab()
  {
    return this.tabc_DataForm.SelectedIndex;
  }

  public DataGridView SelectedDgv()
  {
    return this.selectedDgv();
  }
*/
  public static int GetBandIdx(Decimal frq)
  {
    return DataForm.bandIdx(frq);
  }
/*
  public static string[] GetSTEPList(Decimal frq)
  {
    switch (DataForm.bandIdx(frq))
    {
      case 0:
        return DataForm.tbl_Step_air;
      case 1:
        return DataForm.tbl_Step_vhf;
      case 2:
        return DataForm.tbl_Step_gr1;
      case 3:
        return DataForm.tbl_Step_uhf;
      case 4:
        return DataForm.tbl_Step_gr2;
      default:
        throw new ArgumentOutOfRangeException();
    }
  }

  public void EditEnd()
  {
    this.dgv_BandA.EndEdit();
    this.dgv_BandB.EndEdit();
    this.dgv_PmsA.EndEdit();
    this.dgv_PmsB.EndEdit();
    this.dgv_HomeA.EndEdit();
    this.dgv_HomeB.EndEdit();
    this.dgv_VfoA.EndEdit();
    this.dgv_VfoB.EndEdit();
  }

  public void DatabaseToDataGridView()
  {
    this.toDgvCell(this.dgv_BandA, this.db.aBandMemory);
    this.toDgvCell(this.dgv_BandB, this.db.bBandMemory);
    this.toDgvCell(this.dgv_PmsA, this.db.aBandPmsMemory);
    this.toDgvCell(this.dgv_PmsB, this.db.bBandPmsMemory);
    this.toDgvCell(this.dgv_HomeA, this.db.aBandHome);
    this.toDgvCell(this.dgv_HomeB, this.db.bBandHome);
    this.toDgvCell(this.dgv_VfoA, this.db.aBandVfo);
    this.toDgvCell(this.dgv_VfoB, this.db.bBandVfo);
  }

  public void DataGridViewToDatabase()
  {
    this.toDbProperty(this.dgv_BandA, this.db.aBandMemory);
    this.toDbProperty(this.dgv_BandB, this.db.bBandMemory);
    this.toDbProperty(this.dgv_PmsA, this.db.aBandPmsMemory);
    this.toDbProperty(this.dgv_PmsB, this.db.bBandPmsMemory);
    this.toDbProperty(this.dgv_HomeA, this.db.aBandHome);
    this.toDbProperty(this.dgv_HomeB, this.db.bBandHome);
    this.toDbProperty(this.dgv_VfoA, this.db.aBandVfo);
    this.toDbProperty(this.dgv_VfoB, this.db.bBandVfo);
  }

  private void toDgvCell(DataGridView dgv, BindingList<BandMemory> bandmemory)
  {
    int num = this.tabIdex(dgv);
    for (int row = 0; row < bandmemory.Count; ++row)
    {
      dgv.Rows[row].HeaderCell.Value = (object) bandmemory[row].No;
      if (bandmemory[row].MemoryDir || num >= 4)
      {
        dgv.Rows[row].Cells[0].Value = (object) bandmemory[row].RecvFreq.ToString("N5");
        dgv.Rows[row].Cells[1].Value = (object) bandmemory[row].SendFreq.ToString("N5");
        dgv.Rows[row].Cells[2].Value = (object) bandmemory[row].ShiftFreq.ToString("N5");
        dgv.Rows[row].Cells[3].Value = (object) DataForm.tbl_ShiftDir_All[bandmemory[row].ShiftDir];
        dgv.Rows[row].Cells[4].Value = (object) DataForm.tbl_Mode[bandmemory[row].Mode];
        dgv.Rows[row].Cells[5].Value = (object) bandmemory[row].MemoryName;
        dgv.Rows[row].Cells[6].Value = (object) DataForm.tbl_SqlType_All[bandmemory[row].SqlType];
        dgv.Rows[row].Cells[7].Value = (object) DataForm.tbl_ToneFreq[bandmemory[row].ToneFreq];
        dgv.Rows[row].Cells[8].Value = (object) DataForm.tbl_DcsCode[bandmemory[row].DcsCode];
        dgv.Rows[row].Cells[9].Value = (object) DataForm.tbl_PrTone[bandmemory[row].PrTone];
        dgv.Rows[row].Cells[10].Value = (object) DataForm.tbl_SendOut[bandmemory[row].SendOut];
        dgv.Rows[row].Cells[11].Value = (object) DataForm.tbl_Skip[bandmemory[row].Skip];
        dgv.Rows[row].Cells[12].Value = (object) DataForm.tbl_Step_all[bandmemory[row].Step];
        dgv.Rows[row].Cells[13].Value = (object) !bandmemory[row].MemoryDir;
        dgv.Rows[row].Cells[14].Value = (object) bandmemory[row].ClockShift;
        dgv.Rows[row].Cells[15].Value = (object) bandmemory[row].Comment;
      }
      else
        this.clear(dgv, row);
      this.inputLimited(dgv, row);
    }
  }

  private void toDbProperty(DataGridView dgv, BindingList<BandMemory> bandmemory)
  {
    for (int row = 0; row < bandmemory.Count; ++row)
    {
      int num = this.tabIdex(dgv);
      if (dgv.Rows[row].Cells[13].Value == null)
        dgv.Rows[row].Cells[13].Value = (object) true;
      if (!(bool) dgv.Rows[row].Cells[13].Value || num >= 4)
      {
        bandmemory[row].RecvFreq = Decimal.Parse(dgv.Rows[row].Cells[0].Value.ToString());
        bandmemory[row].ShiftFreq = Decimal.Parse(dgv.Rows[row].Cells[2].Value.ToString());
        bandmemory[row].ShiftDir = this.GetIndex(dgv, DataForm.tbl_ShiftDir_All, row, 3);
        if (bandmemory[row].ShiftDir == 3)
          bandmemory[row].SendFreq = Decimal.Parse(dgv.Rows[row].Cells[1].Value.ToString());
        else
          bandmemory[row].SendFreq = new Decimal(0);
        bandmemory[row].Mode = this.GetIndex(dgv, DataForm.tbl_Mode, row, 4);
        bandmemory[row].MemoryName = (string) dgv.Rows[row].Cells[5].Value;
        bandmemory[row].SqlType = this.GetIndex(dgv, DataForm.tbl_SqlType_All, row, 6);
        bandmemory[row].ToneFreq = this.GetIndex(dgv, DataForm.tbl_ToneFreq, row, 7);
        bandmemory[row].DcsCode = this.GetIndex(dgv, DataForm.tbl_DcsCode, row, 8);
        bandmemory[row].PrTone = this.GetIndex(dgv, DataForm.tbl_PrTone, row, 9);
        bandmemory[row].SendOut = this.GetIndex(dgv, DataForm.tbl_SendOut, row, 10);
        bandmemory[row].Skip = this.GetIndex(dgv, DataForm.tbl_Skip, row, 11);
        bandmemory[row].Step = this.GetIndex(dgv, DataForm.tbl_Step_all, row, 12);
        bandmemory[row].MemoryDir = true;
        bandmemory[row].ClockShift = (bool) dgv.Rows[row].Cells[14].Value;
        bandmemory[row].Comment = (string) dgv.Rows[row].Cells[15].Value;
      }
      else
        bandmemory[row].MemoryDir = false;
    }
  }

  private int GetIndex(DataGridView dgv, string[] tbl, int row, int col)
  {
    for (int index = 0; index < tbl.Length; ++index)
    {
      if (tbl[index] == (string) dgv.Rows[row].Cells[col].Value)
        return index;
    }
    return 0;
  }

  private void allLimited(DataGridView dgv)
  {
    for (int row = 0; row < dgv.Rows.Count; ++row)
      this.inputLimited(dgv, row);
  }

  private void inputLimited(DataGridView dgv, int row)
  {
    if (dgv.Rows[row].Cells[0].Value == null)
      dgv.Rows[row].Cells[0].Value = (object) "";
    if (dgv.Rows[row].Cells[1].Value == null)
      dgv.Rows[row].Cells[1].Value = (object) "";
    Decimal result1;
    if (!Decimal.TryParse(dgv.Rows[row].Cells[0].Value.ToString(), out result1))
    {
      dgv.Rows[row].Cells[0].ReadOnly = false;
      dgv.Rows[row].Cells[0].Style.ForeColor = Color.Black;
      for (int index = 1; index < dgv.ColumnCount; ++index)
      {
        dgv.Rows[row].Cells[index].ReadOnly = true;
        dgv.Rows[row].Cells[index].Style.ForeColor = Color.LightGray;
      }
    }
    else
    {
      Decimal result2;
      if (!Decimal.TryParse(dgv.Rows[row].Cells[1].Value.ToString(), out result2))
        result2 = result1;
      Decimal result3;
      if (!Decimal.TryParse(dgv.Rows[row].Cells[2].Value.ToString(), out result3))
        result3 = new Decimal(0);
      int bandIdx = DataForm.GetBandIdx(result1);
      string str1 = dgv.Rows[row].Cells[12].Value.ToString();
      DataGridViewComboBoxCell viewComboBoxCell1 = (DataGridViewComboBoxCell) dgv[12, row];
      viewComboBoxCell1.Items.Clear();
      viewComboBoxCell1.Items.AddRange((object[]) DataForm.GetSTEPList(result1));
      dgv.Rows[row].Cells[12].Value = Array.IndexOf<string>(DataForm.GetSTEPList(result1), str1) != -1 ? (object) str1 : DataForm.tbl_Default[bandIdx, Settings.Instance.MtxPTN, 12];
      string str2 = dgv.Rows[row].Cells[6].Value.ToString();
      int sEX = dgv == this.dgv_BandA || dgv == this.dgv_PmsA || (dgv == this.dgv_HomeA || dgv == this.dgv_VfoA) ? this.db.Signaling_SqlExA : this.db.Signaling_SqlExB;
      DataGridViewComboBoxCell viewComboBoxCell2 = (DataGridViewComboBoxCell) dgv[6, row];
      viewComboBoxCell2.Items.Clear();
      viewComboBoxCell2.Items.AddRange((object[]) DataForm.getSQLTYPEList(sEX));
      dgv.Rows[row].Cells[6].Value = Array.IndexOf<string>(DataForm.getSQLTYPEList(sEX), str2) != -1 ? (object) str2 : ((bool) dgv.Rows[row].Cells[13].Value ? (object) "" : DataForm.tbl_Default[bandIdx, Settings.Instance.MtxPTN, 6]);
      dgv.Rows[row].Cells[0].ReadOnly = false;
      dgv.Rows[row].Cells[0].Style.ForeColor = Color.Black;
      for (int index = 0; index < dgv.ColumnCount; ++index)
        dgv.Rows[row].Cells[index].ReadOnly = DataForm.tbl_ReadOnlyCell[bandIdx, Settings.Instance.MtxPTN, index];
      switch (this.GetIndex(dgv, DataForm.tbl_ShiftDir_All, row, 3))
      {
        case 0:
          dgv.Rows[row].Cells[1].ReadOnly = true;
          dgv.Rows[row].Cells[1].Value = dgv.Rows[row].Cells[0].Value;
          break;
        case 1:
          dgv.Rows[row].Cells[1].ReadOnly = true;
          dgv.Rows[row].Cells[1].Value = (object) (result1 - result3);
          break;
        case 2:
          dgv.Rows[row].Cells[1].ReadOnly = true;
          dgv.Rows[row].Cells[1].Value = (object) (result1 + result3);
          break;
        case 3:
          dgv.Rows[row].Cells[1].ReadOnly = false;
          if (!DataForm.checkSendFreq(result2))
          {
            dgv.Rows[row].Cells[1].Value = (object) DataForm.SendFreq[Settings.Instance.MtxPTN, 0];
            break;
          }
          break;
        default:
          throw new FormatException();
      }
      if (this.db.Config_AtStepA == 1)
      {
        for (int index = 0; index < this.dgv_VfoA.RowCount; ++index)
          this.dgv_VfoA.Rows[index].Cells[12].ReadOnly = true;
      }
      else
      {
        for (int index = 0; index < this.dgv_VfoA.RowCount; ++index)
          this.dgv_VfoA.Rows[index].Cells[12].ReadOnly = false;
      }
      if (this.db.Config_AtStepB == 1)
      {
        for (int index = 0; index < this.dgv_VfoB.RowCount; ++index)
          this.dgv_VfoB.Rows[index].Cells[12].ReadOnly = true;
      }
      else
      {
        for (int index = 0; index < this.dgv_VfoB.RowCount; ++index)
          this.dgv_VfoB.Rows[index].Cells[12].ReadOnly = false;
      }
      if (this.db.Config_AtModeA == 1)
      {
        for (int row1 = 0; row1 < this.dgv_VfoA.RowCount; ++row1)
        {
          this.dgv_VfoA.Rows[row1].Cells[4].ReadOnly = true;
          if (this.dgv_VfoA.Rows[row1].Cells[0].Value != null)
          {
            Decimal result4;
            if (Decimal.TryParse(this.dgv_VfoA.Rows[row1].Cells[0].Value.ToString(), out result4))
              DataForm.autoMode(this.dgv_VfoA, row1, result4);
            else
              this.dgv_VfoA.Rows[row1].Cells[4].Value = DataForm.tbl_Default[row1, Settings.Instance.MtxPTN, 4];
          }
        }
      }
      else
      {
        for (int index = 0; index < this.dgv_VfoA.RowCount; ++index)
          this.dgv_VfoA.Rows[index].Cells[4].ReadOnly = false;
      }
      if (this.db.Config_AtModeB == 1)
      {
        for (int row1 = 0; row1 < this.dgv_VfoB.RowCount; ++row1)
        {
          this.dgv_VfoB.Rows[row1].Cells[4].ReadOnly = true;
          if (this.dgv_VfoB.Rows[row1].Cells[0].Value != null)
          {
            Decimal result4;
            if (Decimal.TryParse(this.dgv_VfoB.Rows[row1].Cells[0].Value.ToString(), out result4))
              DataForm.autoMode(this.dgv_VfoB, row1, result4);
            else
              this.dgv_VfoB.Rows[row1].Cells[4].Value = DataForm.tbl_Default[row1, Settings.Instance.MtxPTN, 4];
          }
        }
      }
      else
      {
        for (int index = 0; index < this.dgv_VfoB.RowCount; ++index)
          this.dgv_VfoB.Rows[index].Cells[4].ReadOnly = false;
      }
      for (int index = 0; index < dgv.ColumnCount; ++index)
        dgv.Rows[row].Cells[index].Style.ForeColor = !dgv.Rows[row].Cells[index].ReadOnly ? Color.Black : Color.LightGray;
    }
  }

  public void Clear()
  {
    if (!this.isDelet())
      return;
    this.backup();
    DataGridView dgv = this.selectedDgv();
    int rowIndex = dgv.SelectedCells[0].RowIndex;
    int selectedIndex = this.tabc_DataForm.SelectedIndex;
    this.clear(dgv, rowIndex);
    this.allLimited(dgv);
    this.IsSave = false;
  }

  private void clear(DataGridView dgv, int row)
  {
    dgv.Rows[row].Cells[0].Value = (object) "";
    dgv.Rows[row].Cells[1].Value = (object) "";
    dgv.Rows[row].Cells[2].Value = (object) "";
    dgv.Rows[row].Cells[3].Value = (object) "";
    dgv.Rows[row].Cells[4].Value = (object) "";
    dgv.Rows[row].Cells[5].Value = (object) "";
    dgv.Rows[row].Cells[6].Value = (object) "";
    dgv.Rows[row].Cells[7].Value = (object) "";
    dgv.Rows[row].Cells[8].Value = (object) "";
    dgv.Rows[row].Cells[9].Value = (object) "";
    dgv.Rows[row].Cells[10].Value = (object) "";
    dgv.Rows[row].Cells[11].Value = (object) "";
    dgv.Rows[row].Cells[12].Value = (object) "";
    dgv.Rows[row].Cells[13].Value = (object) true;
    dgv.Rows[row].Cells[14].Value = (object) false;
    dgv.Rows[row].Cells[15].Value = (object) "";
  }

  public object[] Copy()
  {
    object[] objArray = new object[16];
    DataGridView dataGridView = this.selectedDgv();
    int rowIndex = dataGridView.SelectedCells[0].RowIndex;
    for (int index = 0; index < dataGridView.ColumnCount; ++index)
      objArray[index] = dataGridView.Rows[rowIndex].Cells[index].Value;
    return objArray;
  }

  public void Past(object[] copy)
  {
    this.backup();
    DataGridView dgv = this.selectedDgv();
    int rowIndex = dgv.SelectedCells[0].RowIndex;
    for (int index = 0; index < dgv.ColumnCount; ++index)
      dgv.Rows[rowIndex].Cells[index].Value = copy[index];
    this.allLimited(dgv);
    this.IsSave = false;
  }

  public void Undo()
  {
    DataGridView dgv = this.selectedDgv();
    int selectedIndex = this.tabc_DataForm.SelectedIndex;
    if (dgv != null)
    {
      for (int index1 = 0; index1 < dgv.RowCount; ++index1)
      {
        for (int index2 = 0; index2 < dgv.ColumnCount; ++index2)
          dgv.Rows[index1].Cells[index2].Value = this.backupObj[selectedIndex][index1, index2];
      }
    }
    this.allLimited(dgv);
    this.IsSave = false;
  }

  private void backup()
  {
    DataGridView dataGridView = this.selectedDgv();
    int selectedIndex = this.tabc_DataForm.SelectedIndex;
    if (dataGridView != null)
    {
      for (int index1 = 0; index1 < dataGridView.RowCount; ++index1)
      {
        for (int index2 = 0; index2 < dataGridView.ColumnCount; ++index2)
          this.backupObj[selectedIndex][index1, index2] = dataGridView.Rows[index1].Cells[index2].Value;
      }
    }
    this.aform.EnableUndo();
  }

  public void Insert()
  {
    if (!this.isDelet())
      return;
    DataGridView dgv = this.selectedDgv();
    int rowIndex = dgv.SelectedCells[0].RowIndex;
    string str = (string) dgv.Rows[dgv.RowCount - 1].Cells[0].Value;
    if (str != null && str != "" && MessageBox.Show(this.resources.GetString("CHINSERTINFO"), this.resources.GetString("CHINSERT"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.OK)
      return;
    this.backup();
    dgv.Rows.Insert(rowIndex);
    dgv.Rows.RemoveAt(dgv.RowCount - 1);
    this.resetRowNo();
    this.allLimited(dgv);
    this.IsSave = false;
  }

  public void Delete()
  {
    if (!this.isDelet())
      return;
    DataGridView dgv = this.selectedDgv();
    int index1 = dgv.SelectedCells.Count - 1;
    int index2 = dgv.SelectedCells[0].RowIndex;
    int num1 = dgv.SelectedCells[index1].RowIndex;
    if (index2 > num1)
    {
      int num2 = index2;
      index2 = num1;
      num1 = num2;
    }
    int count = num1 - index2 + 1;
    if (count > 0)
    {
      this.backup();
      for (int index3 = 0; index3 < count; ++index3)
        dgv.Rows.RemoveAt(index2);
      dgv.Rows.Add(count);
      this.resetRowNo();
    }
    this.allLimited(dgv);
    this.IsSave = false;
  }

  private void resetRowNo()
  {
    DataGridView dataGridView = this.selectedDgv();
    BindingList<BandMemory> bindingList = this.selectedDB();
    for (int index = 0; index < bindingList.Count; ++index)
      dataGridView.Rows[index].HeaderCell.Value = (object) bindingList[index].No;
  }

  public void Up()
  {
    if (!this.isUp())
      return;
    DataGridView dgv = this.selectedDgv();
    int rowIndex = dgv.SelectedCells[0].RowIndex;
    this.backup();
    object[] objArray1 = new object[16];
    object[] objArray2 = new object[16];
    for (int index = 0; index < dgv.ColumnCount; ++index)
    {
      objArray1[index] = dgv.Rows[rowIndex].Cells[index].Value;
      objArray2[index] = dgv.Rows[rowIndex - 1].Cells[index].Value;
      dgv.Rows[rowIndex - 1].Cells[index].Value = objArray1[index];
      dgv.Rows[rowIndex].Cells[index].Value = objArray2[index];
    }
    dgv.CurrentCell = dgv[dgv.SelectedCells[0].ColumnIndex, dgv.SelectedCells[0].RowIndex - 1];
    dgv.Focus();
    this.allLimited(dgv);
    this.IsSave = false;
  }

  public void Down()
  {
    if (!this.isDown())
      return;
    DataGridView dgv = this.selectedDgv();
    int rowIndex = dgv.SelectedCells[0].RowIndex;
    this.backup();
    object[] objArray1 = new object[16];
    object[] objArray2 = new object[16];
    for (int index = 0; index < dgv.ColumnCount; ++index)
    {
      objArray1[index] = dgv.Rows[rowIndex].Cells[index].Value;
      objArray2[index] = dgv.Rows[rowIndex + 1].Cells[index].Value;
      dgv.Rows[rowIndex + 1].Cells[index].Value = objArray1[index];
      dgv.Rows[rowIndex].Cells[index].Value = objArray2[index];
    }
    dgv.CurrentCell = dgv[dgv.SelectedCells[0].ColumnIndex, dgv.SelectedCells[0].RowIndex + 1];
    dgv.Focus();
    this.allLimited(dgv);
    this.IsSave = false;
  }

  public void MoveChannel(int channel)
  {
    if (!this.isDelet())
      return;
    DataGridView dgv = this.selectedDgv();
    int rowIndex = dgv.SelectedCells[0].RowIndex;
    int selectedIndex = this.tabc_DataForm.SelectedIndex;
    if (channel == 1 && selectedIndex < 2 && this.isBrank(dgv, rowIndex, 0))
      return;
    this.backup();
    object[] objArray = new object[16];
    for (int index = 0; index < dgv.ColumnCount; ++index)
    {
      objArray[index] = dgv.Rows[rowIndex].Cells[index].Value;
      dgv.Rows[channel - 1].Cells[index].Value = objArray[index];
    }
    this.clear(dgv, rowIndex);
    dgv.CurrentCell = dgv[dgv.SelectedCells[0].ColumnIndex, channel - 1];
    dgv.Focus();
    this.allLimited(dgv);
    this.IsSave = false;
  }

  public bool Fined(int colNum, string data)
  {
    return this.fined(colNum, data);
  }

  public void FinedNext()
  {
    this.fined(this.finedCol, this.finedStr);
  }

  private bool fined(int colNum, string data)
  {
    bool flag1 = false;
    bool flag2 = false;
    DataGridView dataGridView = this.selectedDgv();
    int rowIndex = dataGridView.SelectedCells[0].RowIndex;
    int index1 = dataGridView.SelectedCells[0].RowIndex;
    if (colNum < 3)
    {
      Decimal result;
      if (data == "" || data == null)
      {
        result = new Decimal(0);
        flag2 = true;
      }
      else if (Decimal.TryParse(data, out result))
        flag2 = true;
      if (flag2)
      {
        for (int index2 = rowIndex + 1; index2 < dataGridView.RowCount; ++index2)
        {
          Decimal num = dataGridView[colNum, index2].Value != null ? (!(dataGridView[colNum, index2].Value.ToString() == "") ? Decimal.Parse(dataGridView[colNum, index2].Value.ToString()) : new Decimal(0)) : new Decimal(0);
          if (result == num)
          {
            index1 = index2;
            flag1 = true;
            break;
          }
        }
        if (!flag1)
        {
          for (int index2 = 0; index2 <= rowIndex; ++index2)
          {
            Decimal num = dataGridView[colNum, index2].Value != null ? (!(dataGridView[colNum, index2].Value.ToString() == "") ? Decimal.Parse(dataGridView[colNum, index2].Value.ToString()) : new Decimal(0)) : new Decimal(0);
            if (result == num)
            {
              index1 = index2;
              flag1 = true;
              break;
            }
          }
        }
      }
      else
      {
        if (data == null)
          data = "";
        for (int index2 = rowIndex + 1; index2 < dataGridView.RowCount; ++index2)
        {
          string str = dataGridView[colNum, index2].Value != null ? dataGridView[colNum, index2].Value.ToString() : "";
          if (data == str)
          {
            index1 = index2;
            flag1 = true;
            break;
          }
        }
        if (!flag1)
        {
          for (int index2 = 0; index2 <= rowIndex; ++index2)
          {
            string str = dataGridView[colNum, index2].Value != null ? dataGridView[colNum, index2].Value.ToString() : "";
            if (data == str)
            {
              index1 = index2;
              flag1 = true;
              break;
            }
          }
        }
      }
    }
    if (flag1)
    {
      this.finedCol = colNum;
      this.finedStr = data;
      dataGridView.FirstDisplayedScrollingRowIndex = index1;
      dataGridView.CurrentCell = dataGridView[colNum, index1];
      dataGridView.Focus();
    }
    else
    {
      int num1 = (int) MessageBox.Show(this.resources.GetString("SEARCHNOHIT"), this.resources.GetString("INFOMSG"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    return flag1;
  }

  public bool AddFreq(Decimal startFreq, int addChannel, string step)
  {
    Decimal num1 = Decimal.Parse(step.Replace("KHz", ""));
    Decimal fstep = num1 / new Decimal(1000);
    DataGridView dgv = this.selectedDgv();
    int bandIdx = DataForm.GetBandIdx(startFreq);
    if (bandIdx == -1 || DataForm.isRecvDisableAria(startFreq))
      return false;
    Decimal frq = startFreq + fstep * (Decimal) addChannel - fstep;
    if (DataForm.GetBandIdx(frq) == -1 || Array.IndexOf<string>(DataForm.GetSTEPList(frq), step) == -1)
      return false;
    Decimal rFreq = startFreq;
    for (int index = 0; index < addChannel; ++index)
    {
      if (DataForm.isRecvDisableAria(rFreq))
        return false;
      rFreq += fstep;
    }
    if (!DataForm.checkStepFreq(startFreq - DataForm.tbl_RecvFreq[bandIdx, Settings.Instance.MtxPTN, 0], fstep))
      return false;
    this.backup();
    int index1 = 0;
    if (fstep == new Decimal(833, 0, 0, false, (byte) 5))
    {
      for (int index2 = 0; index2 < DataForm.tbl_Add833KHz.Length; ++index2)
      {
        Decimal num2 = startFreq - DataForm.tbl_Add833KHz[index2];
        if (num2 % new Decimal(10000, 0, 0, false, (byte) 5) == new Decimal(0))
        {
          index1 = index2;
          startFreq = num2;
          break;
        }
      }
    }
    for (int index2 = 0; index2 < addChannel; ++index2)
    {
      int index3 = dgv.SelectedCells[0].RowIndex + index2;
      Decimal num2;
      if (fstep == new Decimal(833, 0, 0, false, (byte) 5))
      {
        num2 = startFreq + DataForm.tbl_Add833KHz[index1];
        ++index1;
        if (index1 >= DataForm.tbl_Add833KHz.Length)
        {
          startFreq += new Decimal(10000, 0, 0, false, (byte) 5);
          index1 = 0;
        }
      }
      else
        num2 = startFreq + fstep * (Decimal) index2;
      dgv[0, index3].Value = (object) num2.ToString("0.00000");
      for (int index4 = 1; index4 < dgv.ColumnCount; ++index4)
        dgv.Rows[index3].Cells[index4].Value = DataForm.tbl_Default[bandIdx, Settings.Instance.MtxPTN, index4];
      dgv.Rows[index3].Cells[12].Value = (object) (num1.ToString() + "KHz");
    }
    this.allLimited(dgv);
    this.IsSave = false;
    return true;
  }

  public void Sort(int col1, int col2, int updn, int range)
  {
    DataGridView dgv = this.selectedDgv();
    int rowIndex = dgv.SelectedCells[0].RowIndex;
    this.backup();
    int colNum1 = col1;
    int colNum2 = col2 - 1;
    int rowMin;
    int rowMax;
    if (range == 0)
    {
      int index = dgv.SelectedCells.Count - 1;
      rowMin = dgv.SelectedCells[0].RowIndex;
      rowMax = dgv.SelectedCells[index].RowIndex;
      if (rowMin == rowMax)
        return;
      if (rowMin > rowMax)
      {
        int num = rowMin;
        rowMin = rowMax;
        rowMax = num;
      }
    }
    else
    {
      rowMin = 0;
      rowMax = dgv.RowCount - 1;
    }
    if (col2 > 0)
      this.sort(dgv, rowMin, rowMax, colNum1, colNum2, updn);
    else
      this.sort(dgv, rowMin, rowMax, colNum1, 0, updn);
    this.allLimited(dgv);
    this.IsSave = false;
  }

  private void sort(DataGridView dgv, int rowMin, int rowMax, int colNum1, int colNum2, int updn)
  {
    for (int src = rowMin; src < rowMax; ++src)
    {
      for (int dst = src + 1; dst <= rowMax; ++dst)
      {
        Decimal num1 = new Decimal(0);
        if ((dgv[colNum1, src].Value != null || dgv[colNum1, dst].Value != null) && (dgv[colNum1, src].Value == null || dgv[colNum1, dst].Value != null))
        {
          if (dgv[colNum1, src].Value == null && dgv[colNum1, dst].Value != null)
          {
            if (updn == 0)
              this.changeRow(dgv, src, dst);
            if (updn == 1)
              this.changeRow(dgv, src, dst);
          }
          else if (!(dgv[colNum1, src].Value.ToString() != "") || !(dgv[colNum1, dst].Value.ToString() == ""))
          {
            if (dgv[colNum1, src].Value.ToString() == "" && dgv[colNum1, dst].Value.ToString() != "")
            {
              if (updn == 0)
                this.changeRow(dgv, src, dst);
              if (updn == 1)
                this.changeRow(dgv, src, dst);
            }
            else if (dgv[colNum1, src].Value.ToString() != "" && dgv[colNum1, dst].Value.ToString() != "")
            {
              Decimal num2;
              switch (colNum1)
              {
                case 3:
                case 4:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                  num2 = (Decimal) ((int) (byte) Array.IndexOf<string>(this.selectedDgvList(colNum1), dgv.Rows[src].Cells[colNum1].Value.ToString()) - (int) (byte) Array.IndexOf<string>(this.selectedDgvList(colNum1), dgv.Rows[dst].Cells[colNum1].Value.ToString()));
                  break;
                case 5:
                case 15:
                  num2 = (Decimal) string.Compare(dgv[colNum1, src].Value.ToString(), dgv[colNum1, dst].Value.ToString());
                  break;
                default:
                  num2 = Decimal.Parse(dgv[colNum1, src].Value.ToString()) - Decimal.Parse(dgv[colNum1, dst].Value.ToString());
                  break;
              }
              if (updn == 0)
              {
                if (num2 > new Decimal(0))
                  this.changeRow(dgv, src, dst);
                else if (num2 == new Decimal(0))
                {
                  Decimal num3 = new Decimal(0);
                  if ((dgv[colNum2, src].Value != null || dgv[colNum2, dst].Value != null) && (dgv[colNum2, src].Value == null || dgv[colNum2, dst].Value != null))
                  {
                    if (dgv[colNum2, src].Value == null && dgv[colNum2, dst].Value != null)
                      this.changeRow(dgv, src, dst);
                    else if (!(dgv[colNum2, src].Value.ToString() != "") || !(dgv[colNum2, dst].Value.ToString() == ""))
                    {
                      if (dgv[colNum2, src].Value.ToString() == "" && dgv[colNum2, dst].Value.ToString() != "")
                        this.changeRow(dgv, src, dst);
                      else if (dgv[colNum2, src].Value.ToString() != "" && dgv[colNum2, dst].Value.ToString() != "")
                      {
                        switch (colNum2)
                        {
                          case 3:
                          case 4:
                          case 6:
                          case 7:
                          case 8:
                          case 9:
                          case 10:
                          case 11:
                          case 12:
                            num3 = (Decimal) ((int) (byte) Array.IndexOf<string>(this.selectedDgvList(colNum2), dgv.Rows[src].Cells[colNum2].Value.ToString()) - (int) (byte) Array.IndexOf<string>(this.selectedDgvList(colNum2), dgv.Rows[dst].Cells[colNum2].Value.ToString()));
                            break;
                          case 5:
                          case 15:
                            num3 = (Decimal) string.Compare(dgv[colNum2, src].Value.ToString(), dgv[colNum2, dst].Value.ToString());
                            break;
                          default:
                            num3 = Decimal.Parse(dgv[colNum2, src].Value.ToString()) - Decimal.Parse(dgv[colNum2, dst].Value.ToString());
                            break;
                        }
                      }
                    }
                  }
                  if (num3 > new Decimal(0))
                    this.changeRow(dgv, src, dst);
                }
              }
              else if (num2 < new Decimal(0))
                this.changeRow(dgv, src, dst);
              else if (num2 == new Decimal(0))
              {
                Decimal num3 = new Decimal(0);
                if ((dgv[colNum2, src].Value != null || dgv[colNum2, dst].Value != null) && (dgv[colNum2, src].Value == null || dgv[colNum2, dst].Value != null))
                {
                  if (dgv[colNum2, src].Value == null && dgv[colNum2, dst].Value != null)
                    this.changeRow(dgv, src, dst);
                  else if (!(dgv[colNum2, src].Value.ToString() != "") || !(dgv[colNum2, dst].Value.ToString() == ""))
                  {
                    if (dgv[colNum2, src].Value.ToString() == "" && dgv[colNum2, dst].Value.ToString() != "")
                      this.changeRow(dgv, src, dst);
                    else if (dgv[colNum2, src].Value.ToString() != "" && dgv[colNum2, dst].Value.ToString() != "")
                    {
                      switch (colNum2)
                      {
                        case 3:
                        case 4:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                          num3 = (Decimal) ((int) (byte) Array.IndexOf<string>(this.selectedDgvList(colNum2), dgv.Rows[src].Cells[colNum2].Value.ToString()) - (int) (byte) Array.IndexOf<string>(this.selectedDgvList(colNum2), dgv.Rows[dst].Cells[colNum2].Value.ToString()));
                          break;
                        case 5:
                        case 15:
                          num3 = (Decimal) string.Compare(dgv[colNum2, src].Value.ToString(), dgv[colNum2, dst].Value.ToString());
                          break;
                        default:
                          num3 = Decimal.Parse(dgv[colNum2, src].Value.ToString()) - Decimal.Parse(dgv[colNum2, dst].Value.ToString());
                          break;
                      }
                    }
                  }
                }
                if (num3 < new Decimal(0))
                  this.changeRow(dgv, src, dst);
              }
            }
          }
        }
      }
    }
  }

  private string[] selectedDgvList(int col)
  {
    string[] strArray = (string[]) null;
    switch (col)
    {
      case 3:
        strArray = DataForm.tbl_ShiftDir_All;
        break;
      case 4:
        strArray = DataForm.tbl_Mode;
        break;
      case 6:
        strArray = DataForm.tbl_SqlType_All;
        break;
      case 7:
        strArray = DataForm.tbl_ToneFreq;
        break;
      case 8:
        strArray = DataForm.tbl_DcsCode;
        break;
      case 9:
        strArray = DataForm.tbl_PrTone;
        break;
      case 10:
        strArray = DataForm.tbl_SendOut;
        break;
      case 11:
        strArray = DataForm.tbl_Skip;
        break;
      case 12:
        strArray = DataForm.tbl_Step_all;
        break;
    }
    return strArray;
  }

  private void changeRow(DataGridView dgv, int src, int dst)
  {
    object[] objArray1 = new object[16];
    object[] objArray2 = new object[16];
    for (int index = 0; index < dgv.ColumnCount; ++index)
    {
      objArray1[index] = dgv.Rows[src].Cells[index].Value;
      objArray2[index] = dgv.Rows[dst].Cells[index].Value;
      dgv.Rows[dst].Cells[index].Value = objArray1[index];
      dgv.Rows[src].Cells[index].Value = objArray2[index];
    }
  }

  public bool Inport(string[][] str)
  {
    DataGridView dgv = this.selectedDgv();
    this.backup();
    bool flag;
    try
    {
      if (int.Parse(str[0][str[0].Length - 1]) != this.tabc_DataForm.SelectedIndex)
        throw new Exception();
      for (int row = 0; row < dgv.Rows.Count; ++row)
      {
        int index = 1;
        this.clear(dgv, row);
        for (int col = 0; col < dgv.Columns.Count; ++col)
        {
          if (dgv.Columns[col].Visible)
          {
            if (str[row][index] != null && str[row][index] != "")
            {
              switch (col)
              {
                case 0:
                case 1:
                case 2:
                  dgv.Rows[row].Cells[col].Value = (object) Decimal.Parse(str[row][index]);
                  dgv.Rows[row].Cells[13].Value = (object) false;
                  break;
                case 3:
                case 4:
                case 6:
                case 7:
                case 9:
                case 10:
                case 11:
                case 12:
                  if (-1 == Array.IndexOf<string>(this.selectedDgvList(col), str[row][index]))
                    throw new Exception();
                  dgv.Rows[row].Cells[col].Value = (object) str[row][index];
                  break;
                case 5:
                case 15:
                  dgv.Rows[row].Cells[col].Value = (object) str[row][index];
                  break;
                case 8:
                  if (-1 == Array.IndexOf<string>(DataForm.tbl_DcsCode, str[row][index].PadLeft(3, '0')))
                    throw new Exception();
                  dgv.Rows[row].Cells[col].Value = (object) str[row][index].PadLeft(3, '0');
                  break;
                case 14:
                  dgv.Rows[row].Cells[col].Value = "TRUE" == str[row][index] || "1" == str[row][index] ? (object) true : (object) false;
                  break;
              }
            }
            ++index;
          }
        }
      }
      flag = true;
      this.allLimited(dgv);
      this.IsSave = false;
    }
    catch
    {
      this.Undo();
      this.allLimited(dgv);
      flag = false;
    }
    return flag;
  }

  public bool InportFT1D(string[][] str)
  {
    object[][,] objArray = new object[4][,]{ new object[500, 16], new object[500, 16], new object[18, 16], new object[18, 16] };
    DataGridView[] dataGridViewArray = new DataGridView[4]{ this.dgv_BandA, this.dgv_BandB, this.dgv_PmsA, this.dgv_PmsB };
    for (int index1 = 0; index1 < 4; ++index1)
    {
      if (dataGridViewArray != null)
      {
        for (int index2 = 0; index2 < dataGridViewArray[index1].RowCount; ++index2)
        {
          for (int index3 = 0; index3 < dataGridViewArray[index1].ColumnCount; ++index3)
            objArray[index1][index2, index3] = dataGridViewArray[index1].Rows[index2].Cells[index3].Value;
        }
      }
    }
    bool flag;
    if (this.tabc_DataForm.SelectedIndex < 2)
    {
      if (str.Length != 900)
        return false;
      for (int index = 0; index < 900; ++index)
      {
        Decimal result;
        if (Decimal.TryParse(str[index][2], out result) && (DataForm.GetBandIdx(result) == -1 || DataForm.isRecvDisableAria(result)))
          return false;
      }
      flag = this.ft1dInportMEMORY(this.dgv_BandA, ref str, 500, 0);
      if (flag)
        flag = this.ft1dInportMEMORY(this.dgv_BandB, ref str, 400, 500);
    }
    else
    {
      if (str.Length != 100)
        return false;
      for (int index = 0; index < 100; ++index)
      {
        Decimal result;
        if (Decimal.TryParse(str[index][1], out result) && (DataForm.GetBandIdx(result) == -1 || DataForm.isRecvDisableAria(result)))
          return false;
      }
      flag = this.ft1dInportPMS(this.dgv_PmsA, ref str, 18, 0);
      if (flag)
        flag = this.ft1dInportPMS(this.dgv_PmsB, ref str, 18, 50);
    }
    if (!flag)
    {
      for (int index1 = 0; index1 < 4; ++index1)
      {
        if (dataGridViewArray[index1] != null)
        {
          for (int index2 = 0; index2 < dataGridViewArray[index1].RowCount; ++index2)
          {
            for (int index3 = 0; index3 < dataGridViewArray[index1].ColumnCount; ++index3)
              dataGridViewArray[index1].Rows[index2].Cells[index3].Value = objArray[index1][index2, index3];
          }
        }
        this.allLimited(dataGridViewArray[index1]);
      }
      return false;
    }
    this.IsSave = false;
    return true;
  }

  private bool ft1dInportMEMORY(DataGridView dgv, ref string[][] str, int rowCount, int offset)
  {
    bool flag1;
    try
    {
      for (int row = 0; row < rowCount; ++row)
      {
        this.clear(dgv, row);
        if (row == 0)
        {
          for (int index = 0; index < dgv.ColumnCount; ++index)
            dgv.Rows[0].Cells[index].Value = offset != 0 ? DataForm.tbl_Default[3, Settings.Instance.MtxPTN, index] : DataForm.tbl_Default[1, Settings.Instance.MtxPTN, index];
        }
        for (int index1 = 0; index1 < dgv.Columns.Count; ++index1)
        {
          if (str[row + offset][16] == "0")
          {
            Decimal num = new Decimal(0, 0, 0, false, (byte) 2);
            switch (index1)
            {
              case 0:
                num = Decimal.Parse(str[row + offset][2]);
                dgv.Rows[row].Cells[index1].Value = (object) num.ToString("N5");
                continue;
              case 1:
                num = Decimal.Parse(str[row + offset][3]);
                dgv.Rows[row].Cells[index1].Value = (object) num.ToString("N5");
                continue;
              case 2:
                num = Decimal.Parse(str[row + offset][4]);
                dgv.Rows[row].Cells[index1].Value = (object) num.ToString("N5");
                continue;
              case 3:
                string str1 = str[row + offset][5];
                if (-1 == Array.IndexOf<string>(DataForm.tbl_ShiftDir_All, str1))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str1;
                continue;
              case 4:
                string str2 = str[row + offset][6];
                if (-1 == Array.IndexOf<string>(DataForm.tbl_Mode, str2))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str2;
                continue;
              case 5:
                if (str[row + offset][7] != null || str[row + offset][7] != "")
                {
                  char[] charArray = str[row + offset][7].ToCharArray();
                  int length = charArray.Length;
                  if (charArray.Length > 8)
                    length = 8;
                  char[] chArray = new char[length];
                  for (int index2 = 0; index2 < chArray.Length; ++index2)
                    chArray[index2] = Moji.IsMemoryNameChar(charArray[index2]) ? charArray[index2] : '?';
                  dgv.Rows[row].Cells[index1].Value = (object) new string(chArray);
                  continue;
                }
                dgv.Rows[row].Cells[index1].Value = (object) "";
                continue;
              case 6:
                bool flag2 = false;
                for (int index2 = 0; index2 < DataForm.tbl_SqlType_Ft1d_Csv.GetLength(0); ++index2)
                {
                  if (DataForm.tbl_SqlType_Ft1d_Csv[index2, 0] == str[row + offset][8])
                  {
                    dgv.Rows[row].Cells[index1].Value = (object) DataForm.tbl_SqlType_Ft1d_Csv[index2, 1];
                    flag2 = true;
                  }
                }
                if (!flag2)
                  throw new Exception();
                continue;
              case 7:
                string str3 = str[row + offset][9];
                if (-1 == Array.IndexOf<string>(DataForm.tbl_ToneFreq, str3))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str3;
                continue;
              case 8:
                string str4 = str[row + offset][10].PadLeft(3, '0');
                if (-1 == Array.IndexOf<string>(DataForm.tbl_DcsCode, str4))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str4;
                continue;
              case 9:
                string str5 = str[row + offset][12];
                if (-1 == Array.IndexOf<string>(DataForm.tbl_PrTone, str5))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str5;
                continue;
              case 10:
                dgv.Rows[row].Cells[index1].Value = (object) "HIGH";
                continue;
              case 11:
                string str6 = str[row + offset][14];
                if (-1 == Array.IndexOf<string>(DataForm.tbl_Skip, str6))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str6;
                continue;
              case 12:
                string str7 = str[row + offset][15];
                if (-1 == Array.IndexOf<string>(DataForm.tbl_Step_all, str7))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str7;
                continue;
              case 13:
                dgv.Rows[row].Cells[index1].Value = (object) false;
                continue;
              case 14:
                dgv.Rows[row].Cells[index1].Value = "TRUE" == str[row + offset][22] || "1" == str[row + offset][22] ? (object) true : (object) false;
                continue;
              case 15:
                dgv.Rows[row].Cells[index1].Value = (object) str[row + offset][47];
                continue;
              default:
                continue;
            }
          }
        }
      }
      flag1 = true;
      this.allLimited(dgv);
    }
    catch
    {
      flag1 = false;
    }
    return flag1;
  }

  private bool ft1dInportPMS(DataGridView dgv, ref string[][] str, int rowCount, int offset)
  {
    bool flag1;
    try
    {
      for (int row = 0; row < rowCount; ++row)
      {
        this.clear(dgv, row);
        for (int index1 = 0; index1 < dgv.Columns.Count; ++index1)
        {
          if (str[row + offset][15] == "0")
          {
            Decimal num = new Decimal(0, 0, 0, false, (byte) 2);
            switch (index1)
            {
              case 0:
                num = Decimal.Parse(str[row + offset][1]);
                dgv.Rows[row].Cells[index1].Value = (object) num.ToString("N5");
                continue;
              case 1:
                num = Decimal.Parse(str[row + offset][2]);
                dgv.Rows[row].Cells[index1].Value = (object) num.ToString("N5");
                continue;
              case 2:
                num = Decimal.Parse(str[row + offset][3]);
                dgv.Rows[row].Cells[index1].Value = (object) num.ToString("N5");
                continue;
              case 3:
                string str1 = str[row + offset][4];
                if (-1 == Array.IndexOf<string>(DataForm.tbl_ShiftDir_All, str1))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str1;
                continue;
              case 4:
                string str2 = str[row + offset][5];
                if (-1 == Array.IndexOf<string>(DataForm.tbl_Mode, str2))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str2;
                continue;
              case 5:
                if (str[row + offset][6] != null || str[row + offset][6] != "")
                {
                  char[] charArray = str[row + offset][6].ToCharArray();
                  int length = charArray.Length;
                  if (charArray.Length > 8)
                    length = 8;
                  char[] chArray = new char[length];
                  for (int index2 = 0; index2 < chArray.Length; ++index2)
                    chArray[index2] = Moji.IsMemoryNameChar(charArray[index2]) ? charArray[index2] : '?';
                  dgv.Rows[row].Cells[index1].Value = (object) new string(chArray);
                  continue;
                }
                dgv.Rows[row].Cells[index1].Value = (object) "";
                continue;
              case 6:
                bool flag2 = false;
                dgv.Rows[row].Cells[index1].Value = (object) DataForm.tbl_SqlType_Ft1d_Csv[0, 1];
                for (int index2 = 0; index2 < DataForm.tbl_SqlType_Ft1d_Csv.GetLength(0); ++index2)
                {
                  if (DataForm.tbl_SqlType_Ft1d_Csv[index2, 0] == str[row + offset][7])
                  {
                    dgv.Rows[row].Cells[index1].Value = (object) DataForm.tbl_SqlType_Ft1d_Csv[index2, 1];
                    flag2 = true;
                  }
                }
                if (!flag2)
                  throw new Exception();
                continue;
              case 7:
                string str3 = str[row + offset][8];
                if (-1 == Array.IndexOf<string>(DataForm.tbl_ToneFreq, str3))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str3;
                continue;
              case 8:
                string str4 = str[row + offset][9].PadLeft(3, '0');
                if (-1 == Array.IndexOf<string>(DataForm.tbl_DcsCode, str4))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str4;
                continue;
              case 9:
                string str5 = str[row + offset][11];
                if (-1 == Array.IndexOf<string>(DataForm.tbl_PrTone, str5))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str5;
                continue;
              case 10:
                dgv.Rows[row].Cells[index1].Value = (object) "HIGH";
                continue;
              case 11:
                string str6 = str[row + offset][13];
                if (-1 == Array.IndexOf<string>(DataForm.tbl_Skip, str6))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str6;
                continue;
              case 12:
                string str7 = str[row + offset][14];
                if (-1 == Array.IndexOf<string>(DataForm.tbl_Step_all, str7))
                  throw new Exception();
                dgv.Rows[row].Cells[index1].Value = (object) str7;
                continue;
              case 13:
                dgv.Rows[row].Cells[index1].Value = (object) false;
                continue;
              case 14:
                dgv.Rows[row].Cells[index1].Value = "TRUE" == str[row + offset][21] || "1" == str[row + offset][21] ? (object) true : (object) false;
                continue;
              case 15:
                dgv.Rows[row].Cells[index1].Value = (object) str[row + offset][46];
                continue;
              default:
                continue;
            }
          }
        }
      }
      flag1 = true;
      this.allLimited(dgv);
    }
    catch
    {
      flag1 = false;
    }
    return flag1;
  }

  public string[][] Export()
  {
    DataGridView dataGridView = this.selectedDgv();
    int num = 0;
    for (int index = 0; index < dataGridView.Columns.Count; ++index)
    {
      if (dataGridView.Columns[index].Visible)
        ++num;
    }
    string[][] strArray = new string[dataGridView.Rows.Count][];
    for (int index1 = 0; index1 < dataGridView.Rows.Count; ++index1)
    {
      strArray[index1] = new string[num + 2];
      strArray[index1][0] = dataGridView.Rows[index1].HeaderCell.Value.ToString();
      strArray[index1][strArray[index1].Length - 1] = this.tabc_DataForm.SelectedIndex.ToString();
      int index2 = 1;
      for (int index3 = 0; index3 < dataGridView.Columns.Count; ++index3)
      {
        if (dataGridView.Columns[index3].Visible)
        {
          strArray[index1][index2] = "";
          if (dataGridView.Rows[index1].Cells[index3].Value != null)
            strArray[index1][index2] = index3 != 14 ? this.changeCSVStr(dataGridView.Rows[index1].Cells[index3].Value.ToString()) : Convert.ToInt32(dataGridView.Rows[index1].Cells[index3].Value).ToString();
          ++index2;
        }
      }
    }
    return strArray;
  }

  public string[][] ExportFT1D()
  {
    string[][] str;
    if (this.tabc_DataForm.SelectedIndex < 2)
    {
      str = new string[900][];
      this.ft1dExportMEMORY(this.dgv_BandA, ref str, 500, 0);
      this.ft1dExportMEMORY(this.dgv_BandB, ref str, 400, 500);
    }
    else
    {
      str = new string[100][];
      this.ft1dExportPMS(this.dgv_PmsA, ref str, 18, 0);
      for (int index1 = 18; index1 < 50; ++index1)
      {
        str[index1] = new string[48];
        str[index1][0] = index1 % 2 != 1 ? "L" + (object) (index1 / 2 + 1) : "U" + (object) (index1 / 2 + 1);
        str[index1][16] = "0";
        str[index1][20] = "0";
        for (int index2 = 22; index2 < 46; ++index2)
          str[index1][index2] = "0";
        str[index1][15] = "1";
        str[index1][21] = "0";
        str[index1][47] = "1,";
      }
      this.ft1dExportPMS(this.dgv_PmsB, ref str, 18, 50);
      for (int index1 = 68; index1 < 100; ++index1)
      {
        str[index1] = new string[48];
        str[index1][0] = index1 % 2 != 1 ? "L" + (object) (index1 / 2 + 1) : "U" + (object) (index1 / 2 + 1);
        str[index1][16] = "0";
        str[index1][20] = "0";
        for (int index2 = 22; index2 < 46; ++index2)
          str[index1][index2] = "0";
        str[index1][15] = "1";
        str[index1][21] = "0";
        str[index1][47] = "1,";
      }
    }
    return str;
  }

  private void ft1dExportMEMORY(DataGridView dgv, ref string[][] str, int rowCount, int offset)
  {
    for (int index1 = 0; index1 < rowCount; ++index1)
    {
      str[index1 + offset] = new string[49];
      for (int index2 = 0; index2 < dgv.Columns.Count; ++index2)
      {
        if (dgv.Rows[index1].Cells[index2].Value != null && dgv.Rows[index1].Cells[index2].Value.ToString() != "")
        {
          switch (index2)
          {
            case 0:
              str[index1 + offset][2] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 1:
              str[index1 + offset][3] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 2:
              str[index1 + offset][4] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 3:
              str[index1 + offset][5] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 4:
              int index3 = Array.IndexOf<string>(DataForm.tbl_Mode, dgv.Rows[index1].Cells[index2].Value.ToString());
              str[index1 + offset][6] = DataForm.tbl_Mode_Ft1d_Csv[index3, 0];
              continue;
            case 5:
              string s = this.changeHalfCode(dgv.Rows[index1].Cells[index2].Value.ToString());
              str[index1 + offset][7] = this.changeCSVStr(s);
              continue;
            case 6:
              str[index1 + offset][8] = DataForm.tbl_SqlType_Ft1d_Csv[0, 0];
              for (int index4 = 0; index4 < DataForm.tbl_SqlType_Ft1d_Csv.GetLength(0); ++index4)
              {
                if (DataForm.tbl_SqlType_Ft1d_Csv[index4, 1] == dgv.Rows[index1].Cells[index2].Value.ToString())
                {
                  str[index1 + offset][8] = DataForm.tbl_SqlType_Ft1d_Csv[index4, 0];
                  break;
                }
              }
              continue;
            case 7:
              str[index1 + offset][9] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 8:
              str[index1 + offset][10] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 9:
              str[index1 + offset][12] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 10:
              str[index1 + offset][13] = "HIGH";
              continue;
            case 11:
              str[index1 + offset][14] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 12:
              str[index1 + offset][15] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 13:
              str[index1 + offset][16] = Convert.ToInt32(dgv.Rows[index1].Cells[index2].Value).ToString();
              continue;
            case 14:
              str[index1 + offset][22] = Convert.ToInt32(dgv.Rows[index1].Cells[index2].Value).ToString();
              continue;
            case 15:
              str[index1 + offset][47] = this.changeCSVStr(dgv.Rows[index1].Cells[index2].Value.ToString());
              continue;
            default:
              continue;
          }
        }
      }
      str[index1 + offset][0] = (index1 + 1 + offset).ToString();
      str[0][1] = "1";
      str[index1 + offset][1] = "0";
      str[index1 + offset][17] = "0";
      str[index1 + offset][21] = "0";
      for (int index2 = 23; index2 < 47; ++index2)
        str[index1 + offset][index2] = "0";
      if (str[index1 + offset][16] == "0")
      {
        str[index1 + offset][11] = this.resources.GetString("DCSDIMNORMAL");
        str[index1 + offset][18] = "OFF";
        str[index1 + offset][19] = "OFF";
        str[index1 + offset][20] = "OFF";
      }
      str[index1 + offset][48] = "1,";
    }
  }

  private void ft1dExportPMS(DataGridView dgv, ref string[][] str, int rowCount, int offset)
  {
    for (int index1 = 0; index1 < rowCount; ++index1)
    {
      str[index1 + offset] = new string[48];
      for (int index2 = 0; index2 < dgv.Columns.Count; ++index2)
      {
        if (dgv.Rows[index1].Cells[index2].Value != null && dgv.Rows[index1].Cells[index2].Value.ToString() != "")
        {
          switch (index2)
          {
            case 0:
              str[index1 + offset][1] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 1:
              str[index1 + offset][2] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 2:
              str[index1 + offset][3] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 3:
              str[index1 + offset][4] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 4:
              int index3 = Array.IndexOf<string>(DataForm.tbl_Mode, dgv.Rows[index1].Cells[index2].Value.ToString());
              str[index1 + offset][5] = DataForm.tbl_Mode_Ft1d_Csv[index3, 0];
              continue;
            case 5:
              string s = this.changeHalfCode(dgv.Rows[index1].Cells[index2].Value.ToString());
              str[index1 + offset][6] = this.changeCSVStr(s);
              continue;
            case 6:
              str[index1 + offset][7] = DataForm.tbl_SqlType_Ft1d_Csv[0, 0];
              for (int index4 = 0; index4 < DataForm.tbl_SqlType_Ft1d_Csv.GetLength(0); ++index4)
              {
                if (DataForm.tbl_SqlType_Ft1d_Csv[index4, 1] == dgv.Rows[index1].Cells[index2].Value.ToString())
                {
                  str[index1 + offset][7] = DataForm.tbl_SqlType_Ft1d_Csv[index4, 0];
                  break;
                }
              }
              continue;
            case 7:
              str[index1 + offset][8] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 8:
              str[index1 + offset][9] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 9:
              str[index1 + offset][11] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 10:
              str[index1 + offset][12] = "HIGH";
              continue;
            case 11:
              str[index1 + offset][13] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 12:
              str[index1 + offset][14] = dgv.Rows[index1].Cells[index2].Value.ToString();
              continue;
            case 13:
              str[index1 + offset][15] = Convert.ToInt32(dgv.Rows[index1].Cells[index2].Value).ToString();
              continue;
            case 14:
              str[index1 + offset][21] = Convert.ToInt32(dgv.Rows[index1].Cells[index2].Value).ToString();
              continue;
            case 15:
              str[index1 + offset][46] = this.changeCSVStr(dgv.Rows[index1].Cells[index2].Value.ToString());
              continue;
            default:
              continue;
          }
        }
      }
      str[index1 + offset][0] = (index1 + offset) % 2 != 1 ? "L" + (object) ((index1 + offset) / 2 + 1) : "U" + (object) ((index1 + offset) / 2 + 1);
      str[index1 + offset][16] = "0";
      str[index1 + offset][20] = "0";
      for (int index2 = 22; index2 < 46; ++index2)
        str[index1 + offset][index2] = "0";
      if (str[index1 + offset][15] == "0")
      {
        str[index1 + offset][10] = this.resources.GetString("DCSDIMNORMAL");
        str[index1 + offset][17] = "OFF";
        str[index1 + offset][18] = "OFF";
        str[index1 + offset][19] = "OFF";
      }
      str[index1 + offset][47] = "1,";
    }
  }

  private string changeCSVStr(string s)
  {
    if (0 <= s.IndexOf("\"") || 0 <= s.IndexOf(","))
    {
      s = s.Replace("\"", "\"\"");
      s = "\"" + s + "\"";
    }
    return s;
  }

  private string changeHalfCode(string s)
  {
    string[] strArray = new string[16]{ "\"", "$", "%", "'", "+", "<", "=", ">", "[", "\\", "]", "`", "{", "|", "}", "~" };
    for (int index = 0; index < strArray.Length; ++index)
    {
      if (0 <= s.IndexOf(strArray[index]))
        s = s.Replace(strArray[index], "?");
    }
    return s;
  }

  private bool isDelet()
  {
    DataGridView dataGridView = this.selectedDgv();
    int rowIndex = dataGridView.SelectedCells[0].RowIndex;
    int selectedIndex = this.tabc_DataForm.SelectedIndex;
    return dataGridView != null && (selectedIndex >= 2 || rowIndex != 0) && selectedIndex <= 3;
  }

  private bool isUp()
  {
    DataGridView dgv = this.selectedDgv();
    int rowIndex = dgv.SelectedCells[0].RowIndex;
    int selectedIndex = this.tabc_DataForm.SelectedIndex;
    return dgv != null && dgv.SelectedCells[0].RowIndex != 0 && (selectedIndex >= 2 || dgv.SelectedCells[0].RowIndex != 1 || !this.isBrank(dgv, 1, 0));
  }

  private bool isDown()
  {
    DataGridView dgv = this.selectedDgv();
    int rowIndex = dgv.SelectedCells[0].RowIndex;
    int selectedIndex = this.tabc_DataForm.SelectedIndex;
    return dgv != null && dgv.SelectedCells[0].RowIndex != dgv.RowCount - 1 && (selectedIndex >= 2 || dgv.SelectedCells[0].RowIndex != 0 || !this.isBrank(dgv, 1, 0));
  }

  private bool isBrank(DataGridView dgv, int row, int col)
  {
    return dgv.Rows[row].Cells[col].Value == null || dgv.Rows[row].Cells[col].Value.ToString() == "";
  }

  private DataGridView selectedDgv()
  {
    DataGridView dataGridView = (DataGridView) null;
    switch (this.tabc_DataForm.SelectedIndex)
    {
      case 0:
        dataGridView = this.dgv_BandA;
        break;
      case 1:
        dataGridView = this.dgv_BandB;
        break;
      case 2:
        dataGridView = this.dgv_PmsA;
        break;
      case 3:
        dataGridView = this.dgv_PmsB;
        break;
      case 4:
        dataGridView = this.dgv_HomeA;
        break;
      case 5:
        dataGridView = this.dgv_HomeB;
        break;
      case 6:
        dataGridView = this.dgv_VfoA;
        break;
      case 7:
        dataGridView = this.dgv_VfoB;
        break;
    }
    return dataGridView;
  }

  private BindingList<BandMemory> selectedDB()
  {
    BindingList<BandMemory> bindingList = (BindingList<BandMemory>) null;
    switch (this.tabc_DataForm.SelectedIndex)
    {
      case 0:
        bindingList = this.db.aBandMemory;
        break;
      case 1:
        bindingList = this.db.bBandMemory;
        break;
      case 2:
        bindingList = this.db.aBandPmsMemory;
        break;
      case 3:
        bindingList = this.db.bBandPmsMemory;
        break;
      case 4:
        bindingList = this.db.aBandHome;
        break;
      case 5:
        bindingList = this.db.bBandHome;
        break;
      case 6:
        bindingList = this.db.aBandVfo;
        break;
      case 7:
        bindingList = this.db.bBandVfo;
        break;
    }
    return bindingList;
  }

  private int tabIdex(DataGridView dgv)
  {
    int num = -1;
    if (dgv == this.dgv_BandA)
      num = 0;
    else if (dgv == this.dgv_BandB)
      num = 1;
    else if (dgv == this.dgv_PmsA)
      num = 2;
    else if (dgv == this.dgv_PmsB)
      num = 3;
    else if (dgv == this.dgv_HomeA)
      num = 4;
    else if (dgv == this.dgv_HomeB)
      num = 5;
    else if (dgv == this.dgv_VfoA)
      num = 6;
    else if (dgv == this.dgv_VfoB)
      num = 7;
    return num;
  }

  private static Decimal getFreqStep(Decimal frq)
  {
    int bandIdx = DataForm.GetBandIdx(frq);
    string[] stepList = DataForm.GetSTEPList(frq);
    for (int index = Array.IndexOf<object>((object[]) stepList, DataForm.tbl_Default[bandIdx, Settings.Instance.MtxPTN, 12]); index >= 0; --index)
    {
      Decimal num = Decimal.Parse(stepList[index].Replace("KHz", ""));
      if (DataForm.checkStepFreq(frq, num / new Decimal(1000)))
        return num;
    }
    return new Decimal(-1);
  }

  private static string[] getSQLTYPEList(int sEX)
  {
    return sEX != 0 ? (Settings.Instance.MaskID != 2 ? DataForm.tbl_SqlType_ExOn_NonJPN : DataForm.tbl_SqlType_ExOn_JPN) : (Settings.Instance.MaskID != 2 ? DataForm.tbl_SqlType_ExOff_NonJPN : DataForm.tbl_SqlType_ExOff_JPN);
  }
*/
  private static int bandIdx(Decimal frq)
  {
    for (int index = 0; index < DataForm.tbl_RecvFreq.GetLength(0); ++index)
    {
      if (DataForm.tbl_RecvFreq[index, Settings.Instance.MtxPTN, 0] <= frq && frq < DataForm.tbl_RecvFreq[index, Settings.Instance.MtxPTN, 1])
        return index;
    }
    return -1;
  }
/*
  private static bool checkStepFreq(Decimal frq, Decimal fstep)
  {
    if (fstep == new Decimal(833, 0, 0, false, (byte) 5))
    {
      for (int index = 0; index < DataForm.tbl_Add833KHz.Length; ++index)
      {
        if ((frq - DataForm.tbl_Add833KHz[index]) % new Decimal(10000, 0, 0, false, (byte) 5) == new Decimal(0))
          return true;
      }
    }
    else if (frq % fstep == new Decimal(0) && fstep != new Decimal(1500, 0, 0, false, (byte) 5))
      return true;
    return false;
  }

  private static bool checkSendFreq(Decimal sFreq)
  {
    int mtxPtn = Settings.Instance.MtxPTN;
    return DataForm.SendFreq[mtxPtn, 0] <= sFreq && sFreq < DataForm.SendFreq[mtxPtn, 1] || DataForm.SendFreq[mtxPtn, 2] <= sFreq && sFreq < DataForm.SendFreq[mtxPtn, 3];
  }

  private static bool checkShiftFreq(Decimal sftFreq)
  {
    return sftFreq % new Decimal(5000, 0, 0, false, (byte) 5) == new Decimal(0) && new Decimal(0, 0, 0, false, (byte) 5) <= sftFreq && sftFreq <= new Decimal(9995000, 0, 0, false, (byte) 5);
  }

  private static bool isRecvDisableAria(Decimal rFreq)
  {
    bool flag = false;
    int mtxPtn = Settings.Instance.MtxPTN;
    int num = DataForm.bandIdx(rFreq);
    if (Settings.Instance.MtxPTN == 12)
    {
      switch (num)
      {
        case 2:
          if (new Decimal(38000000, 0, 0, false, (byte) 5) < rFreq && rFreq < new Decimal(38300000, 0, 0, false, (byte) 5))
          {
            flag = true;
            break;
          }
          break;
        case 3:
          if (new Decimal(41200000, 0, 0, false, (byte) 5) < rFreq && rFreq < new Decimal(41600000, 0, 0, false, (byte) 5))
          {
            flag = true;
            break;
          }
          break;
        case 4:
          if (new Decimal(81000000, 0, 0, false, (byte) 5) < rFreq && rFreq < new Decimal(84600000, 0, 0, false, (byte) 5))
          {
            flag = true;
            break;
          }
          if (new Decimal(86000000, 0, 0, false, (byte) 5) < rFreq && rFreq < new Decimal(90100000, 0, 0, false, (byte) 5))
          {
            flag = true;
            break;
          }
          if (new Decimal(91500000, 0, 0, false, (byte) 5) < rFreq && rFreq < new Decimal(96100000, 0, 0, false, (byte) 5))
          {
            flag = true;
            break;
          }
          break;
      }
    }
    else if ((Settings.Instance.MtxPTN == 11 || Settings.Instance.MtxPTN == 10) && num == 4)
    {
      if (new Decimal(72950000, 0, 0, false, (byte) 5) <= rFreq && rFreq < new Decimal(75000000, 0, 0, false, (byte) 5))
        flag = true;
      else if (new Decimal(82400000, 0, 0, false, (byte) 5) <= rFreq && rFreq <= new Decimal(84900000, 0, 0, false, (byte) 5))
        flag = true;
      else if (new Decimal(91500000, 0, 0, false, (byte) 5) <= rFreq && rFreq <= new Decimal(96100000, 0, 0, false, (byte) 5))
        flag = true;
      else if (new Decimal(91200000, 0, 0, false, (byte) 5) <= rFreq && rFreq <= new Decimal(94351000, 0, 0, false, (byte) 5))
        flag = true;
      else if (new Decimal(95700000, 0, 0, false, (byte) 5) <= rFreq && rFreq <= new Decimal(98851000, 0, 0, false, (byte) 5))
        flag = true;
    }
    return flag;
  }

  private static void autoMode(DataGridView dgv, int row, Decimal frq)
  {
    int index = -1;
    if (Settings.Instance.MtxPTN == 7 || Settings.Instance.MtxPTN == 3 || (Settings.Instance.MtxPTN == 11 || Settings.Instance.MtxPTN == 10) || (Settings.Instance.MtxPTN == 12 || Settings.Instance.MtxPTN == 4))
    {
      if (new Decimal(10800000, 0, 0, false, (byte) 5) <= frq && frq < new Decimal(13700000, 0, 0, false, (byte) 5))
        index = 1;
      else if (new Decimal(13700000, 0, 0, false, (byte) 5) <= frq && frq < new Decimal(30000000, 0, 0, false, (byte) 5))
        index = 0;
      else if (new Decimal(30000000, 0, 0, false, (byte) 5) <= frq && frq < new Decimal(33600000, 0, 0, false, (byte) 5))
        index = 1;
      else if (new Decimal(33600000, 0, 0, false, (byte) 5) <= frq && frq <= new Decimal(99999000, 0, 0, false, (byte) 5))
        index = 0;
    }
    else if (Settings.Instance.MtxPTN == 0 || Settings.Instance.MtxPTN == 6 || (Settings.Instance.MtxPTN == 2 || Settings.Instance.MtxPTN == 5) || (Settings.Instance.MtxPTN == 1 || Settings.Instance.MtxPTN == 8))
    {
      if (new Decimal(10800000, 0, 0, false, (byte) 5) <= frq && frq < new Decimal(13700000, 0, 0, false, (byte) 5))
        index = 1;
      else if (new Decimal(13700000, 0, 0, false, (byte) 5) <= frq && frq < new Decimal(30000000, 0, 0, false, (byte) 5))
        index = 0;
      else if (new Decimal(30000000, 0, 0, false, (byte) 5) <= frq && frq < new Decimal(32000000, 0, 0, false, (byte) 5))
        index = 1;
      else if (new Decimal(32000000, 0, 0, false, (byte) 5) <= frq && frq <= new Decimal(99999000, 0, 0, false, (byte) 5))
        index = 0;
    }
    else if (Settings.Instance.MtxPTN == 15)
    {
      if (new Decimal(14400000, 0, 0, false, (byte) 5) <= frq && frq <= new Decimal(14800000, 0, 0, false, (byte) 5))
        index = 0;
      else if (new Decimal(43000000, 0, 0, false, (byte) 5) <= frq && frq <= new Decimal(45000000, 0, 0, false, (byte) 5))
        index = 0;
    }
    else if (Settings.Instance.MtxPTN == 14 || Settings.Instance.MtxPTN == 13)
    {
      if (new Decimal(14400000, 0, 0, false, (byte) 5) <= frq && frq <= new Decimal(14600000, 0, 0, false, (byte) 5))
        index = 0;
      else if (new Decimal(43000000, 0, 0, false, (byte) 5) <= frq && frq <= new Decimal(44000000, 0, 0, false, (byte) 5))
        index = 0;
    }
    else if (Settings.Instance.MtxPTN == 9)
    {
      if (new Decimal(14400000, 0, 0, false, (byte) 5) <= frq && frq <= new Decimal(14600000, 0, 0, false, (byte) 5))
        index = 0;
      else if (new Decimal(43200000, 0, 0, false, (byte) 5) <= frq && frq <= new Decimal(43800000, 0, 0, false, (byte) 5))
        index = 0;
    }
    if (index == -1)
      return;
    dgv[4, row].Value = (object) DataForm.tbl_Mode[index];
  }

  private static void autoRptrShift(DataGridView dgv, int row, Decimal rFreq)
  {
    int mtxPtn = Settings.Instance.MtxPTN;
    int num = DataForm.bandIdx(rFreq);
    if (Settings.Instance.MtxPTN == 15 || Settings.Instance.MtxPTN == 7 || (Settings.Instance.MtxPTN == 3 || Settings.Instance.MtxPTN == 11) || Settings.Instance.MtxPTN == 10)
    {
      switch (num)
      {
        case 1:
          if (new Decimal(14510000, 0, 0, false, (byte) 5) <= rFreq && rFreq < new Decimal(14550000, 0, 0, false, (byte) 5))
          {
            dgv[2, row].Value = (object) new Decimal(60000, 0, 0, false, (byte) 5);
            dgv[3, row].Value = (object) DataForm.tbl_ShiftDir_All[1];
            dgv[6, row].Value = (object) DataForm.tbl_SqlType_All[0];
            dgv[7, row].Value = (object) DataForm.tbl_ToneFreq[12];
            break;
          }
          if (new Decimal(14600000, 0, 0, false, (byte) 5) <= rFreq && rFreq < new Decimal(14640000, 0, 0, false, (byte) 5))
          {
            dgv[2, row].Value = (object) new Decimal(60000, 0, 0, false, (byte) 5);
            dgv[3, row].Value = (object) DataForm.tbl_ShiftDir_All[2];
            dgv[6, row].Value = (object) DataForm.tbl_SqlType_All[0];
            dgv[7, row].Value = (object) DataForm.tbl_ToneFreq[12];
            break;
          }
          if (new Decimal(14660000, 0, 0, false, (byte) 5) <= rFreq && rFreq < new Decimal(14700000, 0, 0, false, (byte) 5))
          {
            dgv[2, row].Value = (object) new Decimal(60000, 0, 0, false, (byte) 5);
            dgv[3, row].Value = (object) DataForm.tbl_ShiftDir_All[1];
            dgv[6, row].Value = (object) DataForm.tbl_SqlType_All[0];
            dgv[7, row].Value = (object) DataForm.tbl_ToneFreq[12];
            break;
          }
          if (new Decimal(14700000, 0, 0, false, (byte) 5) <= rFreq && rFreq < new Decimal(14740000, 0, 0, false, (byte) 5))
          {
            dgv[2, row].Value = (object) new Decimal(60000, 0, 0, false, (byte) 5);
            dgv[3, row].Value = (object) DataForm.tbl_ShiftDir_All[2];
            dgv[6, row].Value = (object) DataForm.tbl_SqlType_All[0];
            dgv[7, row].Value = (object) DataForm.tbl_ToneFreq[12];
            break;
          }
          if (!(new Decimal(14760000, 0, 0, false, (byte) 5) <= rFreq) || !(rFreq < new Decimal(14800000, 0, 0, false, (byte) 5)))
            break;
          dgv[2, row].Value = (object) new Decimal(60000, 0, 0, false, (byte) 5);
          dgv[3, row].Value = (object) DataForm.tbl_ShiftDir_All[1];
          dgv[6, row].Value = (object) DataForm.tbl_SqlType_All[0];
          dgv[7, row].Value = (object) DataForm.tbl_ToneFreq[12];
          break;
        case 2:
          if (!(new Decimal(22392000, 0, 0, false, (byte) 5) <= rFreq) || !(rFreq <= new Decimal(22498000, 0, 0, false, (byte) 5)))
            break;
          dgv[2, row].Value = (object) new Decimal(160000, 0, 0, false, (byte) 5);
          dgv[3, row].Value = (object) DataForm.tbl_ShiftDir_All[1];
          dgv[6, row].Value = (object) DataForm.tbl_SqlType_All[0];
          dgv[7, row].Value = (object) DataForm.tbl_ToneFreq[12];
          break;
        case 3:
          if (new Decimal(44000000, 0, 0, false, (byte) 5) <= rFreq && rFreq < new Decimal(44500000, 0, 0, false, (byte) 5))
          {
            dgv[2, row].Value = (object) new Decimal(500000, 0, 0, false, (byte) 5);
            dgv[3, row].Value = (object) DataForm.tbl_ShiftDir_All[2];
            dgv[6, row].Value = (object) DataForm.tbl_SqlType_All[0];
            dgv[7, row].Value = (object) DataForm.tbl_ToneFreq[12];
            break;
          }
          if (!(new Decimal(44500000, 0, 0, false, (byte) 5) <= rFreq) || !(rFreq < new Decimal(45000000, 0, 0, false, (byte) 5)))
            break;
          dgv[2, row].Value = (object) new Decimal(500000, 0, 0, false, (byte) 5);
          dgv[3, row].Value = (object) DataForm.tbl_ShiftDir_All[1];
          dgv[6, row].Value = (object) DataForm.tbl_SqlType_All[0];
          dgv[7, row].Value = (object) DataForm.tbl_ToneFreq[12];
          break;
      }
    }
    else if (Settings.Instance.MtxPTN == 14 || Settings.Instance.MtxPTN == 6 || Settings.Instance.MtxPTN == 2)
    {
      switch (num)
      {
        case 1:
          if (!(new Decimal(14560000, 0, 0, false, (byte) 5) <= rFreq) || !(rFreq <= new Decimal(14580000, 0, 0, false, (byte) 5)))
            break;
          dgv[2, row].Value = (object) new Decimal(60000, 0, 0, false, (byte) 5);
          dgv[3, row].Value = (object) DataForm.tbl_ShiftDir_All[1];
          dgv[6, row].Value = (object) DataForm.tbl_SqlType_All[0];
          dgv[7, row].Value = (object) DataForm.tbl_ToneFreq[0];
          break;
        case 3:
          if (!(new Decimal(43820000, 0, 0, false, (byte) 5) <= rFreq) || !(rFreq < new Decimal(43945000, 0, 0, false, (byte) 5)))
            break;
          dgv[2, row].Value = (object) new Decimal(760000, 0, 0, false, (byte) 5);
          dgv[3, row].Value = (object) DataForm.tbl_ShiftDir_All[1];
          dgv[6, row].Value = (object) DataForm.tbl_SqlType_All[0];
          dgv[7, row].Value = (object) DataForm.tbl_ToneFreq[0];
          break;
      }
    }
    else if (Settings.Instance.MtxPTN == 13 || Settings.Instance.MtxPTN == 5 || (Settings.Instance.MtxPTN == 1 || Settings.Instance.MtxPTN == 9) || Settings.Instance.MtxPTN == 8)
    {
      switch (num)
      {
        case 1:
          if (!(new Decimal(14560000, 0, 0, false, (byte) 5) <= rFreq) || !(rFreq <= new Decimal(14580000, 0, 0, false, (byte) 5)))
            break;
          dgv[2, row].Value = (object) new Decimal(60000, 0, 0, false, (byte) 5);
          dgv[3, row].Value = (object) DataForm.tbl_ShiftDir_All[1];
          dgv[6, row].Value = (object) DataForm.tbl_SqlType_All[0];
          dgv[7, row].Value = (object) DataForm.tbl_ToneFreq[0];
          break;
        case 3:
          if (!(new Decimal(43300000, 0, 0, false, (byte) 5) <= rFreq) || !(rFreq < new Decimal(43340000, 0, 0, false, (byte) 5)))
            break;
          dgv[2, row].Value = (object) new Decimal(160000, 0, 0, false, (byte) 5);
          dgv[3, row].Value = (object) DataForm.tbl_ShiftDir_All[2];
          dgv[6, row].Value = (object) DataForm.tbl_SqlType_All[0];
          dgv[7, row].Value = (object) DataForm.tbl_ToneFreq[0];
          break;
      }
    }
    else
    {
      if (Settings.Instance.MtxPTN != 12 && Settings.Instance.MtxPTN != 4 || (num != 3 || !(new Decimal(43900000, 0, 0, false, (byte) 5) <= rFreq)) || !(rFreq < new Decimal(44000000, 0, 0, false, (byte) 5)))
        return;
      dgv[2, row].Value = (object) new Decimal(500000, 0, 0, false, (byte) 5);
      dgv[3, row].Value = (object) DataForm.tbl_ShiftDir_All[1];
      dgv[6, row].Value = (object) DataForm.tbl_SqlType_All[1];
      dgv[7, row].Value = (object) DataForm.tbl_ToneFreq[8];
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (DataForm));
    this.tab_VfoB = new TabPage();
    this.dgv_VfoB = new DataGridView();
    this.tab_VfoA = new TabPage();
    this.dgv_VfoA = new DataGridView();
    this.tab_PmsB = new TabPage();
    this.dgv_PmsB = new DataGridView();
    this.tab_PmsA = new TabPage();
    this.dgv_PmsA = new DataGridView();
    this.tab_BandB = new TabPage();
    this.dgv_BandB = new DataGridView();
    this.tab_BandA = new TabPage();
    this.dgv_BandA = new DataGridView();
    this.tabc_DataForm = new TabControl();
    this.tab_HomeA = new TabPage();
    this.dgv_HomeA = new DataGridView();
    this.tab_HomeB = new TabPage();
    this.dgv_HomeB = new DataGridView();
    this.tab_VfoB.SuspendLayout();
    ((ISupportInitialize) this.dgv_VfoB).BeginInit();
    this.tab_VfoA.SuspendLayout();
    ((ISupportInitialize) this.dgv_VfoA).BeginInit();
    this.tab_PmsB.SuspendLayout();
    ((ISupportInitialize) this.dgv_PmsB).BeginInit();
    this.tab_PmsA.SuspendLayout();
    ((ISupportInitialize) this.dgv_PmsA).BeginInit();
    this.tab_BandB.SuspendLayout();
    ((ISupportInitialize) this.dgv_BandB).BeginInit();
    this.tab_BandA.SuspendLayout();
    ((ISupportInitialize) this.dgv_BandA).BeginInit();
    this.tabc_DataForm.SuspendLayout();
    this.tab_HomeA.SuspendLayout();
    ((ISupportInitialize) this.dgv_HomeA).BeginInit();
    this.tab_HomeB.SuspendLayout();
    ((ISupportInitialize) this.dgv_HomeB).BeginInit();
    this.SuspendLayout();
    this.tab_VfoB.BackColor = SystemColors.Control;
    this.tab_VfoB.Controls.Add((Control) this.dgv_VfoB);
    componentResourceManager.ApplyResources((object) this.tab_VfoB, "tab_VfoB");
    this.tab_VfoB.Name = "tab_VfoB";
    this.dgv_VfoB.AllowUserToAddRows = false;
    this.dgv_VfoB.AllowUserToDeleteRows = false;
    this.dgv_VfoB.AllowUserToResizeRows = false;
    this.dgv_VfoB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    componentResourceManager.ApplyResources((object) this.dgv_VfoB, "dgv_VfoB");
    this.dgv_VfoB.Name = "dgv_VfoB";
    this.dgv_VfoB.RowTemplate.Height = 21;
    this.dgv_VfoB.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
    this.dgv_VfoB.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
    this.tab_VfoA.BackColor = SystemColors.Control;
    this.tab_VfoA.Controls.Add((Control) this.dgv_VfoA);
    componentResourceManager.ApplyResources((object) this.tab_VfoA, "tab_VfoA");
    this.tab_VfoA.Name = "tab_VfoA";
    this.dgv_VfoA.AllowUserToAddRows = false;
    this.dgv_VfoA.AllowUserToDeleteRows = false;
    this.dgv_VfoA.AllowUserToResizeRows = false;
    this.dgv_VfoA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    componentResourceManager.ApplyResources((object) this.dgv_VfoA, "dgv_VfoA");
    this.dgv_VfoA.Name = "dgv_VfoA";
    this.dgv_VfoA.RowTemplate.Height = 21;
    this.dgv_VfoA.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
    this.dgv_VfoA.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
    this.tab_PmsB.BackColor = SystemColors.Control;
    this.tab_PmsB.Controls.Add((Control) this.dgv_PmsB);
    componentResourceManager.ApplyResources((object) this.tab_PmsB, "tab_PmsB");
    this.tab_PmsB.Name = "tab_PmsB";
    this.dgv_PmsB.AllowUserToAddRows = false;
    this.dgv_PmsB.AllowUserToDeleteRows = false;
    this.dgv_PmsB.AllowUserToResizeRows = false;
    this.dgv_PmsB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    componentResourceManager.ApplyResources((object) this.dgv_PmsB, "dgv_PmsB");
    this.dgv_PmsB.Name = "dgv_PmsB";
    this.dgv_PmsB.RowTemplate.Height = 21;
    this.dgv_PmsB.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
    this.dgv_PmsB.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
    this.tab_PmsA.BackColor = SystemColors.Control;
    this.tab_PmsA.Controls.Add((Control) this.dgv_PmsA);
    componentResourceManager.ApplyResources((object) this.tab_PmsA, "tab_PmsA");
    this.tab_PmsA.Name = "tab_PmsA";
    this.dgv_PmsA.AllowUserToAddRows = false;
    this.dgv_PmsA.AllowUserToDeleteRows = false;
    this.dgv_PmsA.AllowUserToResizeRows = false;
    this.dgv_PmsA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    componentResourceManager.ApplyResources((object) this.dgv_PmsA, "dgv_PmsA");
    this.dgv_PmsA.Name = "dgv_PmsA";
    this.dgv_PmsA.RowTemplate.Height = 21;
    this.dgv_PmsA.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
    this.dgv_PmsA.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
    this.tab_BandB.BackColor = SystemColors.Control;
    this.tab_BandB.Controls.Add((Control) this.dgv_BandB);
    componentResourceManager.ApplyResources((object) this.tab_BandB, "tab_BandB");
    this.tab_BandB.Name = "tab_BandB";
    this.dgv_BandB.AllowUserToAddRows = false;
    this.dgv_BandB.AllowUserToDeleteRows = false;
    this.dgv_BandB.AllowUserToResizeRows = false;
    this.dgv_BandB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    componentResourceManager.ApplyResources((object) this.dgv_BandB, "dgv_BandB");
    this.dgv_BandB.Name = "dgv_BandB";
    this.dgv_BandB.RowTemplate.Height = 21;
    this.dgv_BandB.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
    this.dgv_BandB.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
    this.tab_BandA.BackColor = SystemColors.Control;
    this.tab_BandA.Controls.Add((Control) this.dgv_BandA);
    componentResourceManager.ApplyResources((object) this.tab_BandA, "tab_BandA");
    this.tab_BandA.Name = "tab_BandA";
    this.dgv_BandA.AllowUserToAddRows = false;
    this.dgv_BandA.AllowUserToDeleteRows = false;
    this.dgv_BandA.AllowUserToResizeRows = false;
    this.dgv_BandA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    componentResourceManager.ApplyResources((object) this.dgv_BandA, "dgv_BandA");
    this.dgv_BandA.Name = "dgv_BandA";
    this.dgv_BandA.RowTemplate.Height = 21;
    this.dgv_BandA.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
    this.dgv_BandA.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
    this.tabc_DataForm.Controls.Add((Control) this.tab_BandA);
    this.tabc_DataForm.Controls.Add((Control) this.tab_BandB);
    this.tabc_DataForm.Controls.Add((Control) this.tab_PmsA);
    this.tabc_DataForm.Controls.Add((Control) this.tab_PmsB);
    this.tabc_DataForm.Controls.Add((Control) this.tab_HomeA);
    this.tabc_DataForm.Controls.Add((Control) this.tab_HomeB);
    this.tabc_DataForm.Controls.Add((Control) this.tab_VfoA);
    this.tabc_DataForm.Controls.Add((Control) this.tab_VfoB);
    componentResourceManager.ApplyResources((object) this.tabc_DataForm, "tabc_DataForm");
    this.tabc_DataForm.Name = "tabc_DataForm";
    this.tabc_DataForm.SelectedIndex = 0;
    this.tabc_DataForm.SelectedIndexChanged += new EventHandler(this.tabc_DataForm_SelectedIndexChanged);
    this.tab_HomeA.BackColor = SystemColors.Control;
    this.tab_HomeA.Controls.Add((Control) this.dgv_HomeA);
    componentResourceManager.ApplyResources((object) this.tab_HomeA, "tab_HomeA");
    this.tab_HomeA.Name = "tab_HomeA";
    this.dgv_HomeA.AllowUserToAddRows = false;
    this.dgv_HomeA.AllowUserToDeleteRows = false;
    this.dgv_HomeA.AllowUserToResizeRows = false;
    this.dgv_HomeA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    componentResourceManager.ApplyResources((object) this.dgv_HomeA, "dgv_HomeA");
    this.dgv_HomeA.Name = "dgv_HomeA";
    this.dgv_HomeA.RowTemplate.Height = 21;
    this.dgv_HomeA.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
    this.dgv_HomeA.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
    this.tab_HomeB.BackColor = SystemColors.Control;
    this.tab_HomeB.Controls.Add((Control) this.dgv_HomeB);
    componentResourceManager.ApplyResources((object) this.tab_HomeB, "tab_HomeB");
    this.tab_HomeB.Name = "tab_HomeB";
    this.dgv_HomeB.AllowUserToAddRows = false;
    this.dgv_HomeB.AllowUserToDeleteRows = false;
    this.dgv_HomeB.AllowUserToResizeRows = false;
    this.dgv_HomeB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    componentResourceManager.ApplyResources((object) this.dgv_HomeB, "dgv_HomeB");
    this.dgv_HomeB.Name = "dgv_HomeB";
    this.dgv_HomeB.RowTemplate.Height = 21;
    this.dgv_HomeB.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
    this.dgv_HomeB.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
    componentResourceManager.ApplyResources((object) this, "$this");
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.tabc_DataForm);
    this.Name = nameof (DataForm);
    this.Activated += new EventHandler(this.DataForm_Activated);
    this.FormClosing += new FormClosingEventHandler(this.DataForm_FormClosing);
    this.Load += new EventHandler(this.DataForm_Load);
    this.tab_VfoB.ResumeLayout(false);
    ((ISupportInitialize) this.dgv_VfoB).EndInit();
    this.tab_VfoA.ResumeLayout(false);
    ((ISupportInitialize) this.dgv_VfoA).EndInit();
    this.tab_PmsB.ResumeLayout(false);
    ((ISupportInitialize) this.dgv_PmsB).EndInit();
    this.tab_PmsA.ResumeLayout(false);
    ((ISupportInitialize) this.dgv_PmsA).EndInit();
    this.tab_BandB.ResumeLayout(false);
    ((ISupportInitialize) this.dgv_BandB).EndInit();
    this.tab_BandA.ResumeLayout(false);
    ((ISupportInitialize) this.dgv_BandA).EndInit();
    this.tabc_DataForm.ResumeLayout(false);
    this.tab_HomeA.ResumeLayout(false);
    ((ISupportInitialize) this.dgv_HomeA).EndInit();
    this.tab_HomeB.ResumeLayout(false);
    ((ISupportInitialize) this.dgv_HomeB).EndInit();
    this.ResumeLayout(false);
  }
*/
}
