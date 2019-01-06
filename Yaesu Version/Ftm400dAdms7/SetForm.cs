// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.SetForm
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Ftm400dAdms7
{
  public class SetForm : Form
  {
    public static readonly string[] tbl_mpk_all = new string[19]{ "OFF", "BAND SCOPE", "SCAN", "HOME", "DCS CODE", "TONE FREQ", "RPT SHIFT", "REVERSE", "TX POWER", "SQL OFF", "T-CALL", "VOICE", "D_X", "KWX", "S-LIST", "MSG", "REPLY", "M-EDIT", "PRF" };
    public static readonly string[] tbl_mpk_jpn = new string[18]{ "OFF", "BAND SCOPE", "SCAN", "HOME", "DCS CODE", "TONE FREQ", "RPT SHIFT", "REVERSE", "TX POWER", "SQL OFF", "T-CALL", "VOICE", "D_X", "S-LIST", "MSG", "REPLY", "M-EDIT", "PRF" };
    public static readonly string[] tbl_mpk_eng = new string[18]{ "OFF", "BAND SCOPE", "SCAN", "HOME", "DCS CODE", "TONE FREQ", "RPT SHIFT", "REVERSE", "TX POWER", "SQL OFF", "T-CALL", "VOICE", "D_X", "KWX", "S-LIST", "MSG", "REPLY", "M-EDIT" };
    public static readonly Decimal[,] tbl_PresetFreq = new Decimal[16, 6]{ { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(1250, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(1250, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(1250, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(500, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14602000, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44002000, 0, 0, false, (byte) 5), new Decimal(2000, 0, 0, false, (byte) 5), new Decimal(2000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14601250, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44002500, 0, 0, false, (byte) 5), new Decimal(1250, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14601250, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44002500, 0, 0, false, (byte) 5), new Decimal(1250, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14800500, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(45002500, 0, 0, false, (byte) 5), new Decimal(500, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14601250, 0, 0, false, (byte) 5), new Decimal(43200000, 0, 0, false, (byte) 5), new Decimal(43802500, 0, 0, false, (byte) 5), new Decimal(1250, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14601250, 0, 0, false, (byte) 5), new Decimal(43200000, 0, 0, false, (byte) 5), new Decimal(43802500, 0, 0, false, (byte) 5), new Decimal(1250, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) }, { new Decimal(13700000, 0, 0, false, (byte) 5), new Decimal(17400000, 0, 0, false, (byte) 5), new Decimal(40000000, 0, 0, false, (byte) 5), new Decimal(48000000, 0, 0, false, (byte) 5), new Decimal(500, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14800500, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(45002500, 0, 0, false, (byte) 5), new Decimal(500, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14602000, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44002000, 0, 0, false, (byte) 5), new Decimal(2000, 0, 0, false, (byte) 5), new Decimal(2000, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14601250, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44002500, 0, 0, false, (byte) 5), new Decimal(1250, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14601250, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(44002500, 0, 0, false, (byte) 5), new Decimal(1250, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) }, { new Decimal(14400000, 0, 0, false, (byte) 5), new Decimal(14800500, 0, 0, false, (byte) 5), new Decimal(43000000, 0, 0, false, (byte) 5), new Decimal(45002500, 0, 0, false, (byte) 5), new Decimal(500, 0, 0, false, (byte) 5), new Decimal(2500, 0, 0, false, (byte) 5) } };
    private Button[] FuncSetArray = new Button[24];
    private TextBox[] FuncSetlist = new TextBox[4];
    private TextBox[] CallsignCodeArray = new TextBox[34];
    private ComboBox[] CallsignSsIdArray = new ComboBox[34];
    public const int P_MINL = 0;
    public const int P_MAXL = 1;
    public const int P_MINH = 2;
    public const int P_MAXH = 3;
    public const int P_STPL = 4;
    public const int P_STPH = 5;
    private Database db;
    private DataForm cDataForm;
    private IContainer components;
    private TabPage tab_AprsBcn;
    private GroupBox grb_AprsRinger;
    private ComboBox cmb_AprsRinger_MsgVc;
    private Label lbl_AprsRinger_MsgVc;
    private ComboBox cmb_AprsRinger_MyPacket;
    private Label lbl_AprsRinger_MyPacket;
    private ComboBox cmb_AprsRinger_RngRbgr;
    private Label lbl_AprsRinger_RngRbgr;
    private ComboBox cmb_AprsRinger_CllRngr;
    private Label lbl_AprsRinger_CllRngr;
    private ComboBox cmb_AprsRinger_RxMsg;
    private Label lbl_AprsRinger_RxMsg;
    private ComboBox cmb_AprsRinger_RxBcn;
    private Label lbl_AprsRinger_RxBcn;
    private ComboBox cmb_AprsRinger_TxMsg;
    private Label lbl_AprsRinger_TxMsg;
    private ComboBox cmb_AprsRinger_TxBcn;
    private Label lbl_AprsRinger_TxBcn;
    private GroupBox grb_AprsUnit;
    private ComboBox cmb_AprsUnit_Wind;
    private Label lbl_AprsUnit_Wind;
    private ComboBox cmb_AprsUnit_Rain;
    private Label lbl_AprsUnit_Rain;
    private ComboBox cmb_AprsUnit_Altitude;
    private Label lbl_AprsUnit_Altitude;
    private ComboBox cmb_AprsUnit_Temp;
    private Label lbl_AprsUnit_Temp;
    private ComboBox cmb_AprsUnit_Speed;
    private Label lbl_AprsUnit_Speed;
    private ComboBox cmb_AprsUnit_Distance;
    private Label lbl_AprsUnit_Distance;
    private ComboBox cmb_AprsUnit_Position;
    private Label lbl_AprsUnit_Position;
    private GroupBox grb_AprsFilter;
    private ComboBox cmb_AprsFilter_Altnet;
    private Label lbl_AprsFilter_Altnet;
    private ComboBox cmb_AprsFilter_Other;
    private Label lbl_AprsFilter_Other;
    private ComboBox cmb_AprsFilter_Status;
    private Label lbl_AprsFilter_Status;
    private ComboBox cmb_AprsFilter_Object;
    private Label lbl_AprsFilter_Object;
    private ComboBox cmb_AprsFilter_Item;
    private Label lbl_AprsFilter_Item;
    private ComboBox cmb_AprsFilter_Weather;
    private Label lbl_AprsFilter_Weather;
    private ComboBox cmb_AprsFilter_Position;
    private Label lbl_AprsFilter_Position;
    private ComboBox cmb_AprsFilter_MicE;
    private Label lbl_AprsFilter_MicE;
    private TabPage tab_AprsGps;
    private GroupBox grb_AprsMsgText;
    private TextBox txt_AprsMsgText_8;
    private RadioButton rdb_AprsMsgText_8_No;
    private TextBox txt_AprsMsgText_7;
    private RadioButton rdb_AprsMsgText_7_No;
    private TextBox txt_AprsMsgText_6;
    private RadioButton rdb_AprsMsgText_6_No;
    private TextBox txt_AprsMsgText_5;
    private TextBox txt_AprsMsgText_4;
    private TextBox txt_AprsMsgText_3;
    private TextBox txt_AprsMsgText_2;
    private TextBox txt_AprsMsgText_1;
    private RadioButton rdb_AprsMsgText_5_No;
    private RadioButton rdb_AprsMsgText_4_No;
    private RadioButton rdb_AprsMsgText_3_No;
    private RadioButton rdb_AprsMsgText_2_No;
    private RadioButton rdb_AprsMsgText_1_No;
    private GroupBox grb_MySymbol;
    private ComboBox cmb_MySymbol_42_Icn;
    private Button btn_MySymbol_2;
    private Button btn_MySymbol_3;
    private Button btn_MySymbol_1;
    private ComboBox cmb_MySymbol_41_Icn;
    private ComboBox cmb_MySymbol_3_Icn;
    private ComboBox cmb_MySymbol_2_Icn;
    private ComboBox cmb_MySymbol_1_Icn;
    private RadioButton rdb_MySymbol_4_Sel;
    private RadioButton rdb_MySymbol_3_Sel;
    private RadioButton rdb_MySymbol_2_Sel;
    private RadioButton rdb_MySymbol_1_Sel;
    private GroupBox grb_AprsMsgGroup;
    private TextBox txt_AprsMsgGroup_B3;
    private TextBox txt_AprsMsgGroup_B2;
    private TextBox txt_AprsMsgGroup_B1;
    private TextBox txt_AprsMsgGroup_G5;
    private TextBox txt_AprsMsgGroup_G4;
    private TextBox txt_AprsMsgGroup_G3;
    private TextBox txt_AprsMsgGroup_G2;
    private TextBox txt_AprsMsgGroup_G1;
    private GroupBox grb_MsgReply;
    private Label lbl_MsgReply_ReplyText;
    private Label lbl_MsgReply_CallSign;
    private ComboBox cmb_MsgReply_Reply;
    private Label lbl_MsgReply_Reply;
    private GroupBox grb_AprsCommon;
    private ComboBox cmb_AprsCommon_PstnCmnt;
    private Label lbl_AprsCommon_PstnCmnt;
    private TextBox txt_AprsCommon_CallsignCode;
    private Label lbl_AprsCommon_Callsign;
    private ComboBox cmb_AprsCommon_TxDelay;
    private Label lbl_AprsCommon_TxDelay;
    private ComboBox cmb_AprsCommon_Mute;
    private Label lbl_AprsCommon_Mute;
    private ComboBox cmb_AprsCommon_Modem;
    private Label lbl_AprsCommon_Modem;
    private TabPage tab_GmWiresX;
    private GroupBox grb_Category;
    private DataGridView dgv_Category;
    private GroupBox grb_WiresX;
    private ComboBox cmb_WiresX_DgID;
    private Label lbl_WiresX_DgID;
    private ComboBox cmb_WiresX_RptWiresFreq;
    private Label lbl_WiresX_RptWiresFreq;
    private GroupBox grb_Gm;
    private TextBox txt_Gm_CallSign;
    private Label lbl_Gm_CallSign;
    private GroupBox grb_Digital;
    private ComboBox cmb_Digital_LocationService;
    private Label lbl_Digital_LocationService;
    private ComboBox cmb_Digital_Popup;
    private Label lbl_Digital_Popup;
    private ComboBox cmb_Digital_RxDgID;
    private Label lbl_Digital_RxDgID;
    private TabPage tab_NormalSetting;
    private GroupBox grb_Config;
    private GroupBox grb_DtmfSelect;
    private DataGridView dgv_DtmfMemory;
    private GroupBox grb_Scan;
    private GroupBox grb_Display;
    private TabControl tbc_Setting;
    private GroupBox grb_Signaling;
    private ComboBox cmb_Config_GpsLog;
    private ComboBox cmb_Config_GpsDev;
    private ComboBox cmb_Config_GpsDtm;
    private ComboBox cmb_Config_Tot;
    private ComboBox cmb_Config_Apo;
    private ComboBox cmb_Config_Unit;
    private ComboBox cmb_Config_RxCovA;
    private Label lbl_Config_GpsLog;
    private Label lbl_Config_GpsDev;
    private Label lbl_Config_GpsDtm;
    private Label lbl_Config_Tot;
    private Label lbl_Config_Apo;
    private Label lbl_Config_Unit;
    private Label lbl_Config_RxCovA;
    private ComboBox cmb_Config_Beep;
    private ComboBox cmb_Config_AtRptShftA;
    private Label lbl_Config_Beep;
    private Label lbl_Config_AtRptShftA;
    private ComboBox cmb_Config_TimeZone;
    private Label lbl_Config_TimeZone;
    private ComboBox cmb_Config_DtTmFrmtHr;
    private ComboBox cmb_Config_DtTmFrmtDt;
    private Label lbl_Config_DtTmFrmt;
    private GroupBox groupBox2;
    private ComboBox cmb_Audio_SubBandMute;
    private ComboBox cmb_Audio_MicGain;
    private Label lbl_Audio_MicGain;
    private Label lbl_Audio_SubBandMute;
    private GroupBox grb_Option;
    private ComboBox cmb_Option_UsbCmrSize;
    private ComboBox cmb_Option_UsbCmrQlty;
    private Label lbl_Option_UsbCmrQlty;
    private Label lbl_Option_UsbCmrSize;
    private Label lbl_Scan_DWStopA;
    private Label lbl_Scan_ScanRsmA;
    private Label lbl_Scan_ScanDrctnA;
    private ComboBox cmb_Scan_DWStopA;
    private ComboBox cmb_Scan_ScanRsmA;
    private ComboBox cmb_Scan_ScanDrctnA;
    private ComboBox cmb_Display_TimeVdd;
    private ComboBox cmb_Display_Altitude;
    private ComboBox cmb_Display_LcdContrast;
    private ComboBox cmb_Display_TimerClk;
    private ComboBox cmb_Display_LcdBrigtness;
    private Label lbl_Display_Altitude;
    private ComboBox cmb_Display_BandScpB;
    private Label lbl_Display_TimerClk;
    private ComboBox cmb_Display_BgClr;
    private Label lbl_Display_GpsInfo;
    private ComboBox cmb_Display_TgtLctn;
    private Label lbl_Display_TgtLctn;
    private ComboBox cmb_Display_GpsInfo;
    private Label lbl_Display_BgClr;
    private Label lbl_Display_TimeVdd;
    private Label lbl_Display_BandScpB;
    private Label lbl_Display_LcdContrast;
    private Label lbl_Display_LcdBrigtness;
    private GroupBox groupBox6;
    private ComboBox cmb_Signaling_PageTx2;
    private ComboBox cmb_Signaling_BellRingerA;
    private ComboBox cmb_Signaling_SqlExA;
    private Label lbl_Signaling_BellRingerA;
    private Label lbl_Signaling_SqlExA;
    private ComboBox cmb_Signaling_AutDialer;
    private ComboBox cmb_Signaling_PageRx1;
    private ComboBox cmb_Signaling_PageRx2;
    private Label lbl_Signaling_AutDialer;
    private Label lbl_Signaling_PageCode;
    private ComboBox cmb_Signaling_PageTx1;
    private Label lbl_Signaling_PageRx1;
    private ComboBox cmb_Option_RxMute;
    private Label lbl_Option_RxMute;
    private ComboBox cmb_Option_VcMemLng;
    private ComboBox cmb_Option_VcMemVlm;
    private Label lbl_Option_VcMemVlm;
    private Label lbl_Option_VcMemLng;
    private ComboBox cmb_Option_VcMemPR;
    private ComboBox cmb_Option_VcMemAnnc;
    private Label lbl_Option_VcMemAnnc;
    private Label lbl_Option_VcMemPR;
    private Label lbl_Option_VcMem;
    private ComboBox cmb_Option_BltthVox;
    private Label lbl_Option_Bltth;
    private Label lbl_Option_BltthVox;
    private Label lbl_Option_UsbCmr;
    private ComboBox cmb_Option_BltthAudio;
    private ComboBox cmb_Option_BltthBttery;
    private Label lbl_Option_BltthBttery;
    private Label lbl_Option_BltthAudio;
    private Label lbl_Data_DataBandSelect;
    private Label lbl_Data_ComWpFilter;
    private Label lbl_Data_ComOutput;
    private Label lbl_Data_DBandAprs;
    private Label lbl_Data_DBandData;
    private ComboBox cmb_Data_DBandAprs;
    private ComboBox cmb_Data_DBandData;
    private ComboBox cmb_Data_ComWpFilter;
    private ComboBox cmb_Data_ComWpFormat;
    private ComboBox cmb_Data_ComOutput;
    private Label lbl_Data_ComWpFormat;
    private Label lbl_Data_ComSpeed;
    private ComboBox cmb_Data_ComSpeed;
    private Label lbl_Data_ComPortSetting;
    private GroupBox grb_FuncSet;
    private Button btn_FuncSet_Stop;
    private Button btn_FuncSet_Play;
    private Button btn_FuncSet_PTA;
    private Button btn_FuncSet_Rec;
    private Button btn_FuncSet_Voise;
    private Button btn_FuncSet_xClr;
    private Button btn_FuncSet_BeaconTx;
    private Button btn_FuncSet_Beacon;
    private Button btn_FuncSet_Msg;
    private Button btn_FuncSet_SList;
    private Button btn_FuncSet_Log;
    private Button btn_FuncSet_Home;
    private Button btn_FuncSet_Dtmf;
    private Button btn_FuncSet_SqlNoise;
    private Button btn_FuncSet_Dw;
    private Button btn_FuncSet_SSO;
    private Button btn_FuncSet_TxPwrHi;
    private Button btn_FuncSet_10Key;
    private Button btn_FuncSet_Rev;
    private Button btn_FuncSet_Scan;
    private Button btn_FuncSet_Scope;
    private Button btn_FuncSet_Mute;
    private Button btn_FuncSet_Sql;
    private Button btn_FuncSet_VM;
    private Label lbl_Data_DSqlcAprs;
    private Label lbl_Data_DSqlcData;
    private Label lbl_Data_DSqlc;
    private ComboBox cmb_Data_DSqlcData;
    private ComboBox cmb_Data_DSqlcAprs;
    private Label lbl_Data_DSpeedAprs;
    private ComboBox cmb_Data_DSqlcTx;
    private Label lbl_Data_DSqlcTx;
    private Label lbl_Data_DSpeedData;
    private Label cmb_Data_DSpeed;
    private ComboBox cmb_Data_DSpeedAprs;
    private ComboBox cmb_Data_DSpeedData;
    private Label lbl_Display_DisplaySelect;
    private TextBox txt_FuncSet_Array4;
    private TextBox txt_FuncSet_Array3;
    private TextBox txt_FuncSet_Array2;
    private TextBox txt_FuncSet_Array1;
    private Label lbl_Signaling_PageTx2;
    private Label lbl_Signaling_PageTx1;
    private Label lbl_Signaling_PageRx2;
    private Label lbl_WiresX_PresetFreq;
    private ComboBox cmb_Gm_RangeRinger;
    private Label lbl_Gm_RangeRinger;
    private ComboBox cmb_Digital_TxDgID;
    private Label lbl_Digital_TxDgID;
    private ComboBox cmb_Digital_AmsTxMode;
    private Label lbl_Digital_TxMode;
    private TextBox txt_MsgReply_ReplyText;
    private ComboBox cmb_AprsCommon_RtLmt;
    private Label lbl_AprsCommon_RtLmt;
    private ComboBox cmb_AprsCommon_Intrvl;
    private Label lbl_AprsCommon_Intrvl;
    private ComboBox cmb_AprsCommon_LwSpd;
    private Label lbl_AprsCommon_LwSpd;
    private ComboBox cmb_AprsCommon_Dcy;
    private Label lbl_AprsCommon_Dcy;
    private ComboBox cmb_AprsCommon_Prprtnl;
    private Label lbl_AprsCommon_Prprtnl;
    private ComboBox cmb_AprsCommon_Auto;
    private Label lbl_AprsCommon_Auto;
    private Label lbl_AprsCommon_BcnTx;
    private ComboBox cmb_AprsCommon_Alttd;
    private Label lbl_AprsCommon_Alttd;
    private ComboBox cmb_AprsCommon_SpdCrc;
    private Label lbl_AprsCommon_SpdCrc;
    private ComboBox cmb_AprsCommon_Ambgty;
    private Label lbl_AprsCommon_Ambgty;
    private Label lbl_AprsCommon_BcnInfoSlct;
    private ComboBox cmb_AprsCommon_Dst;
    private Label lbl_AprsCommon_Dst;
    private ComboBox cmb_AprsCommon_Cmps;
    private Label lbl_AprsCommon_Cmps;
    private GroupBox grp_AprsRingerCall;
    private Label lbl_AprsRingerCall_8;
    private Label lbl_AprsRingerCall_7;
    private Label lbl_AprsRingerCall_6;
    private Label lbl_AprsRingerCall_5;
    private Label lbl_AprsRingerCall_4;
    private Label lbl_AprsRingerCall_3;
    private Label lbl_AprsRingerCall_2;
    private Label lbl_AprsRingerCall_1;
    private TextBox txt_AprsRingerCallCode_8;
    private TextBox txt_AprsRingerCallCode_7;
    private TextBox txt_AprsRingerCallCode_1;
    private TextBox txt_AprsRingerCallCode_6;
    private TextBox txt_AprsRingerCallCode_2;
    private TextBox txt_AprsRingerCallCode_5;
    private TextBox txt_AprsRingerCallCode_3;
    private TextBox txt_AprsRingerCallCode_4;
    private ComboBox cmb_AprsUnit_Baro;
    private Label lbl_AprsUnit_Baro;
    private ComboBox cmb_AprsFilter_RangeLimit;
    private Label lbl_AprsFilter_RangeLimit;
    private Label lbl_Config_MicProgKeyP4;
    private Label lbl_Config_MicProgKeyP2;
    private Label lbl_Config_MicProgKeyP3;
    private ComboBox cmb_Config_MicProgKeyP4;
    private ComboBox cmb_Config_MicProgKeyP2;
    private ComboBox cmb_Config_MicProgKeyP3;
    private ComboBox cmb_Config_MicProgKeyP1;
    private Label lbl_Config_MicProgKeyP1;
    private Label lbl_Config_MicProgKey;
    private RadioButton rdb_FuncSet_Array4;
    private RadioButton rdb_FuncSet_Array3;
    private RadioButton rdb_FuncSet_Array2;
    private RadioButton rdb_FuncSet_Array1;
    private GroupBox grb_BeaconStatusText;
    private ComboBox cmb_BeaconStatusText_5_Mode;
    private ComboBox cmb_BeaconStatusText_4_Mode;
    private ComboBox cmb_BeaconStatusText_3_Mode;
    private ComboBox cmb_BeaconStatusText_2_Mode;
    private ComboBox cmb_BeaconStatusText_1_Mode;
    private ComboBox cmb_BeaconStatusText_TxRate;
    private Label lbl_BeaconStatusText_TxRate;
    private TextBox txt_BeaconStatusText_5;
    private TextBox txt_BeaconStatusText_4;
    private TextBox txt_BeaconStatusText_3;
    private TextBox txt_BeaconStatusText_2;
    private TextBox txt_BeaconStatusText_1;
    private RadioButton rdb_BeaconStatusText_5;
    private RadioButton rdb_BeaconStatusText_4;
    private RadioButton rdb_BeaconStatusText_3;
    private RadioButton rdb_BeaconStatusText_2;
    private RadioButton rdb_BeaconStatusText_1;
    private Label lbl_AprsMsgGroup_B3;
    private TextBox txt_AprsMsgGroup_G6;
    private Label lbl_AprsMsgGroup_B2;
    private Label lbl_AprsMsgGroup_B1;
    private Label lbl_AprsMsgGroup_G6;
    private Label lbl_AprsMsgGroup_G5;
    private Label lbl_AprsMsgGroup_G4;
    private Label lbl_AprsMsgGroup_G3;
    private Label lbl_AprsMsgGroup_G2;
    private Label lbl_AprsMsgGroup_G1;
    private RadioButton rdb_BeaconStatusText_Off;
    private GroupBox grb_DigiPath;
    private RadioButton rdb_DigiPath_F2;
    private TextBox txt_DigiPathCode_F28;
    private TextBox txt_DigiPathCode_F27;
    private TextBox txt_DigiPathCode_F26;
    private TextBox txt_DigiPathCode_F25;
    private TextBox txt_DigiPathCode_F24;
    private TextBox txt_DigiPathCode_F23;
    private TextBox txt_DigiPathCode_F22;
    private TextBox txt_DigiPathCode_F21;
    private Label label182;
    private Label label183;
    private Label label180;
    private Label label181;
    private Label label178;
    private Label label179;
    private Label label176;
    private Label label177;
    private Label label174;
    private Label label175;
    private Label label172;
    private Label label173;
    private Label label170;
    private Label label171;
    private Label label168;
    private Label label169;
    private Label label167;
    private Label label166;
    private RadioButton rdb_DigiPath_F1;
    private RadioButton rdb_DigiPath_P4;
    private RadioButton rdb_DigiPath_P3;
    private TextBox txt_DigiPathCode_F18;
    private TextBox txt_DigiPathCode_F17;
    private TextBox txt_DigiPathCode_F16;
    private TextBox txt_DigiPathCode_F15;
    private TextBox txt_DigiPathCode_F14;
    private TextBox txt_DigiPathCode_F13;
    private TextBox txt_DigiPathCode_F12;
    private TextBox txt_DigiPathCode_F11;
    private TextBox txt_DigiPathCode_P42;
    private TextBox txt_DigiPathCode_P41;
    private TextBox txt_DigiPathCode_P32;
    private TextBox txt_DigiPathCode_P31;
    private TextBox txt_DigiPathCode_P22;
    private TextBox txt_DigiPathCode_P21;
    private TextBox txt_DigiPathCode_P12;
    private TextBox txt_DigiPathCode_P11;
    private RadioButton rdb_DigiPath_P2;
    private RadioButton rdb_DigiPath_P1;
    private RadioButton rdb_DigiPath_2Wide;
    private RadioButton rdb_DigiPath_1Wide;
    private RadioButton rdb_DigiPath_Off;
    private GroupBox grb_MyPosition;
    private NumericUpDown nud_MyPosition_ManualLonMM2;
    private ComboBox cmb_MyPosition_ManualLon;
    private NumericUpDown nud_MyPosition_ManualLatMM2;
    private ComboBox cmb_MyPosition_ManualLat;
    private Label label233;
    private Label label230;
    private Label label234;
    private Label label229;
    private NumericUpDown nud_MyPosition_ManualLonMM1;
    private RadioButton rdb_MyPosition_Manual;
    private NumericUpDown nud_MyPosition_ManualLatMM1;
    private RadioButton rdb_MyPosition_Gps;
    private NumericUpDown nud_MyPosition_ManualLonDD;
    private NumericUpDown nud_MyPosition_ManualLatDD;
    private Label label232;
    private Label label231;
    private GroupBox grp_VoiceAleat;
    private ComboBox cmb_VoiceAleat_Dcs;
    private ComboBox cmb_VoiceAleat_ToneSql;
    private ComboBox cmb_VoiceAleat_VoiceAleat;
    private GroupBox grp_SortFilter;
    private ComboBox cmb_SortFilter_Filter;
    private ComboBox cmb_SortFilter_Sort;
    private GroupBox grp_AprsPopupColor;
    private ComboBox cmb_AprsPopupColor_MyPckt;
    private Label lbl_AprsPopupColor_MyPckt;
    private ComboBox cmb_AprsPopupColor_GrpBult;
    private Label lbl_AprsPopupColor_GrpBult;
    private ComboBox cmb_AprsPopupColor_Msg;
    private Label lbl_AprsPopupColor_Msg;
    private ComboBox cmb_AprsPopupColor_CllRngr;
    private Label lbl_AprsPopupColor_CllRngr;
    private ComboBox cmb_AprsPopupColor_RngRngr;
    private Label lbl_AprsPopupColor_RngRngr;
    private ComboBox cmb_AprsPopupColor_ObjItm;
    private Label lbl_AprsPopupColor_ObjItm;
    private ComboBox cmb_AprsPopupColor_Mbl;
    private Label lbl_AprsPopupColor_Mbl;
    private ComboBox cmb_AprsPopupColor_Bcn;
    private Label lbl_AprsPopupColor_Bcn;
    private GroupBox grb_AprsPopup;
    private ComboBox cmb_AprsPopup_Bcn;
    private Label lbl_AprsPopup_Bcn;
    private ComboBox cmb_AprsPopup_Msg;
    private Label lbl_AprsPopup_Msg;
    private ComboBox cmb_AprsPopup_MyPacket;
    private Label lbl_AprsPopup_MyPacket;
    private Label lbl_VoiceAleat_Dcs;
    private Label lbl_VoiceAleat_ToneSql;
    private Label lbl_VoiceAleat_VoiceAleat;
    private Label lbl_SortFilter_Filter;
    private Label lbl_SortFilter_Sort;
    private GroupBox grb_SmartBeaconing;
    private ComboBox cmb_SmartBeaconing_Select;
    private Label lbl_SmartBeaconing_Select;
    private Label label184;
    private Label label185;
    private Label label186;
    private Label label187;
    private Label label188;
    private Label label189;
    private Label label190;
    private Label label191;
    private Label label192;
    private Label label193;
    private Label label194;
    private Label label195;
    private Label label196;
    private Label label197;
    private Label label198;
    private Label label199;
    private Label label200;
    private Label label201;
    private GroupBox grb_SmartBeaconing1;
    private NumericUpDown nud_SmartBeaconing1_TurnTime;
    private Label lbl_SmartBeaconing1_TurnTimeUnit;
    private NumericUpDown nud_SmartBeaconing1_TurnSlope;
    private Label lbl_SmartBeaconing1_TurnAngleUnit;
    private NumericUpDown nud_SmartBeaconing1_TurnAngle;
    private Label lbl_SmartBeaconing1_FastRateUnit;
    private NumericUpDown nud_SmartBeaconing1_FastRate;
    private Label lbl_SmartBeaconing1_SlowRateUnit;
    private NumericUpDown nud_SmartBeaconing1_SlowRate;
    private Label lbl_SmartBeaconing1_LowSpeedUnit;
    private NumericUpDown nud_SmartBeaconing1_HighSpeed;
    private Label lbl_SmartBeaconing1_HighSpeedUnit;
    private NumericUpDown nud_SmartBeaconing1_LowSpeed;
    private Label lbl_SmartBeaconing1_Type;
    private Label lbl_SmartBeaconing1_LowSpeed;
    private Label lbl_SmartBeaconing1_TurnTime;
    private Label lbl_SmartBeaconing1_TurnSlope;
    private Label lbl_SmartBeaconing1_TurnAngle;
    private Label lbl_SmartBeaconing1_FastRate;
    private Label lbl_SmartBeaconing1_SlowRate;
    private Label lbl_SmartBeaconing1_HighSpeed;
    private GroupBox grb_SmartBeaconing2;
    private NumericUpDown nud_SmartBeaconing2_TurnTime;
    private Label lbl_SmartBeaconing2_TurnTimeUnit;
    private NumericUpDown nud_SmartBeaconing2_TurnSlope;
    private Label lbl_SmartBeaconing2_TurnAngleUnit;
    private NumericUpDown nud_SmartBeaconing2_TurnAngle;
    private Label lbl_SmartBeaconing2_FastRateUnit;
    private NumericUpDown nud_SmartBeaconing2_FastRate;
    private Label lbl_SmartBeaconing2_SlowRateUnit;
    private NumericUpDown nud_SmartBeaconing2_SlowRate;
    private Label lbl_SmartBeaconing2_LowSpeedUnit;
    private NumericUpDown nud_SmartBeaconing2_HighSpeed;
    private Label lbl_SmartBeaconing2_HighSpeedUnit;
    private NumericUpDown nud_SmartBeaconing2_LowSpeed;
    private Label lbl_SmartBeaconing2_Type;
    private Label lbl_SmartBeaconing2_LowSpeed;
    private Label lbl_SmartBeaconing2_TurnTime;
    private Label lbl_SmartBeaconing2_TurnSlope;
    private Label lbl_SmartBeaconing2_TurnAngle;
    private Label lbl_SmartBeaconing2_FastRate;
    private Label lbl_SmartBeaconing2_SlowRate;
    private Label lbl_SmartBeaconing2_HighSpeed;
    private GroupBox grb_SmartBeaconing3;
    private NumericUpDown nud_SmartBeaconing3_TurnTime;
    private Label lbl_SmartBeaconing3_TurnTimeUnit;
    private NumericUpDown nud_SmartBeaconing3_TurnSlope;
    private Label lbl_SmartBeaconing3_TurnAngleUnit;
    private NumericUpDown nud_SmartBeaconing3_TurnAngle;
    private Label lbl_SmartBeaconing3_FastRateUnit;
    private NumericUpDown nud_SmartBeaconing3_FastRate;
    private Label lbl_SmartBeaconing3_SlowRateUnit;
    private NumericUpDown nud_SmartBeaconing3_SlowRate;
    private Label lbl_SmartBeaconing3_SlowSpeedUnit;
    private NumericUpDown nud_SmartBeaconing3_HighSpeed;
    private Label lbl_SmartBeaconing3_HighSpeedUnit;
    private NumericUpDown nud_SmartBeaconing3_LowSpeed;
    private Label lbl_SmartBeaconing3_Type;
    private Label lbl_SmartBeaconing3_SlowSpeed;
    private Label lbl_SmartBeaconing3_TurnTime;
    private Label lbl_SmartBeaconing3_TurnSlope;
    private Label lbl_SmartBeaconing3_TurnAngle;
    private Label lbl_SmartBeaconing3_FastRate;
    private Label lbl_SmartBeaconing3_SlowRate;
    private Label lbl_SmartBeaconing3_HighSpeed;
    private NumericUpDown nud_WiresX_PresetFreq;
    private ComboBox cmb_AprsCommon_CallsignSsId;
    private ComboBox cmb_MsgReply_CallSignSsId;
    private TextBox txt_MsgReply_CallSignCode;
    private ComboBox cmb_DigiPathSsId_F28;
    private ComboBox cmb_DigiPathSsId_F27;
    private ComboBox cmb_DigiPathSsId_F26;
    private ComboBox cmb_DigiPathSsId_F25;
    private ComboBox cmb_DigiPathSsId_F24;
    private ComboBox cmb_DigiPathSsId_F23;
    private ComboBox cmb_DigiPathSsId_F22;
    private ComboBox cmb_DigiPathSsId_F21;
    private ComboBox cmb_DigiPathSsId_F18;
    private ComboBox cmb_DigiPathSsId_F17;
    private ComboBox cmb_DigiPathSsId_F16;
    private ComboBox cmb_DigiPathSsId_F15;
    private ComboBox cmb_DigiPathSsId_F14;
    private ComboBox cmb_DigiPathSsId_F13;
    private ComboBox cmb_DigiPathSsId_F12;
    private ComboBox cmb_DigiPathSsId_F11;
    private ComboBox cmb_DigiPathSsId_P42;
    private ComboBox cmb_DigiPathSsId_P32;
    private ComboBox cmb_DigiPathSsId_P22;
    private ComboBox cmb_DigiPathSsId_P12;
    private ComboBox cmb_DigiPathSsId_P41;
    private ComboBox cmb_DigiPathSsId_P31;
    private ComboBox cmb_DigiPathSsId_P21;
    private ComboBox cmb_DigiPathSsId_P11;
    private ComboBox cmb_AprsRingerCallSsId_8;
    private ComboBox cmb_AprsRingerCallSsId_7;
    private ComboBox cmb_AprsRingerCallSsId_6;
    private ComboBox cmb_AprsRingerCallSsId_5;
    private ComboBox cmb_AprsRingerCallSsId_4;
    private ComboBox cmb_AprsRingerCallSsId_3;
    private ComboBox cmb_AprsRingerCallSsId_2;
    private ComboBox cmb_AprsRingerCallSsId_1;
    private Label lbl_WiresX_PresetFreqUnit;
    private ComboBox cmb_Config_RxCovB;
    private ComboBox cmb_Config_AtRptShftB;
    private ComboBox cmb_Scan_DWStopB;
    private ComboBox cmb_Scan_ScanDrctnB;
    private ComboBox cmb_Scan_ScanRsmB;
    private ComboBox cmb_Signaling_SqlExB;
    private ComboBox cmb_Signaling_BellRingerB;
    private Label lbl_Signaling_BellRingerB;
    private Label lbl_Signaling_SqlExB;
    private Label lbl_Config_RxCovB;
    private Label lbl_Config_AtRptShftB;
    private Label lbl_Scan_ScanRsmB;
    private Label lbl_Scan_ScanDrctnB;
    private Label lbl_Scan_DWStopB;
    private ComboBox cmb_Digital_StandbyBeep;
    private Label lbl_Digital_StandbyBeep;
    private ComboBox cmb_Config_AtStepB;
    private ComboBox cmb_Config_AtStepA;
    private ComboBox cmb_Config_AtModeB;
    private ComboBox cmb_Config_AtModeA;
    private Label lbl_Config_AtStepB;
    private Label lbl_Config_AtStepA;
    private Label lbl_Config_AtModeB;
    private Label lbl_Config_AtModeA;
    private ComboBox cmb_Display_BandScpA;
    private Label lbl_Display_BandScpA;
    private ComboBox cmb_Signaling_WxAlrtB;
    private Label lbl_Signaling_WxAlrtB;
    private ComboBox cmb_Signaling_WxAlrtA;
    private Label lbl_Signaling_WxAlrtA;
    private GroupBox grp_MsgText;
    private DataGridView dgv_MsgText;
    private ComboBox cmb_WiresX_SearchSetup;
    private Label lbl_WiresX_SearchSetup;

    public static string[] GetMicPGMKey()
    {
      return Settings.Instance.MaskID != 2 ? SetForm.tbl_mpk_eng : SetForm.tbl_mpk_jpn;
    }

    public SetForm()
    {
    }

    public SetForm(DataForm dataform)
    {
      this.cDataForm = dataform;
      this.db = this.cDataForm.GetDB();
      this.InitializeComponent();
      string[] strArray = new string[3001];
      strArray[0] = "OFF";
      for (int index = 1; index < strArray.Length; ++index)
        strArray[index] = index.ToString() + "km";
      this.cmb_AprsFilter_RangeLimit.Items.Clear();
      this.cmb_AprsFilter_RangeLimit.Items.AddRange((object[]) strArray);
      this.cmb_Config_MicProgKeyP1.Items.Clear();
      this.cmb_Config_MicProgKeyP2.Items.Clear();
      this.cmb_Config_MicProgKeyP3.Items.Clear();
      this.cmb_Config_MicProgKeyP4.Items.Clear();
      this.cmb_Config_MicProgKeyP1.Items.AddRange((object[]) SetForm.GetMicPGMKey());
      this.cmb_Config_MicProgKeyP2.Items.AddRange((object[]) SetForm.GetMicPGMKey());
      this.cmb_Config_MicProgKeyP3.Items.AddRange((object[]) SetForm.GetMicPGMKey());
      this.cmb_Config_MicProgKeyP4.Items.AddRange((object[]) SetForm.GetMicPGMKey());
      bool flag = Settings.Instance.MaskID != 2;
      this.lbl_Signaling_WxAlrtA.Visible = flag;
      this.lbl_Signaling_WxAlrtB.Visible = flag;
      this.cmb_Signaling_WxAlrtA.Visible = flag;
      this.cmb_Signaling_WxAlrtB.Visible = flag;
      this.nud_WiresX_PresetFreq.Minimum = SetForm.tbl_PresetFreq[Settings.Instance.MtxPTN, 0];
      this.nud_WiresX_PresetFreq.Maximum = SetForm.tbl_PresetFreq[Settings.Instance.MtxPTN, 3] - SetForm.tbl_PresetFreq[Settings.Instance.MtxPTN, 5];
      this.nud_WiresX_PresetFreq.Increment = SetForm.tbl_PresetFreq[Settings.Instance.MtxPTN, 4];
      this.txt_AprsCommon_CallsignCode.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsCallSign_KeyPress);
      this.txt_MsgReply_CallSignCode.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgRplyCallSign_KeyPress);
      this.txt_Gm_CallSign.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_GmCallSign_KeyPress);
      this.txt_DigiPathCode_P11.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_P12.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_P21.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_P22.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_P31.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_P32.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_P41.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_P42.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F11.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F12.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F13.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F14.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F15.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F16.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F17.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F18.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F21.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F22.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F23.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F24.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F25.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F26.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F27.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_DigiPathCode_F28.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsDigiPath_KeyPress);
      this.txt_AprsRingerCallCode_1.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsRinger_KeyPress);
      this.txt_AprsRingerCallCode_2.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsRinger_KeyPress);
      this.txt_AprsRingerCallCode_3.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsRinger_KeyPress);
      this.txt_AprsRingerCallCode_4.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsRinger_KeyPress);
      this.txt_AprsRingerCallCode_5.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsRinger_KeyPress);
      this.txt_AprsRingerCallCode_6.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsRinger_KeyPress);
      this.txt_AprsRingerCallCode_7.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsRinger_KeyPress);
      this.txt_AprsRingerCallCode_8.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsRinger_KeyPress);
      this.txt_AprsMsgGroup_G1.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgGroup_KeyPress);
      this.txt_AprsMsgGroup_G2.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgGroup_KeyPress);
      this.txt_AprsMsgGroup_G3.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgGroup_KeyPress);
      this.txt_AprsMsgGroup_G4.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgGroup_KeyPress);
      this.txt_AprsMsgGroup_G5.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgGroup_KeyPress);
      this.txt_AprsMsgGroup_G6.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgGroup_KeyPress);
      this.txt_AprsMsgGroup_B1.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgGroup_KeyPress);
      this.txt_AprsMsgGroup_B2.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgGroup_KeyPress);
      this.txt_AprsMsgGroup_B3.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgGroup_KeyPress);
      this.txt_AprsMsgText_1.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgText_KeyPress);
      this.txt_AprsMsgText_2.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgText_KeyPress);
      this.txt_AprsMsgText_3.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgText_KeyPress);
      this.txt_AprsMsgText_4.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgText_KeyPress);
      this.txt_AprsMsgText_5.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgText_KeyPress);
      this.txt_AprsMsgText_6.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgText_KeyPress);
      this.txt_AprsMsgText_7.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgText_KeyPress);
      this.txt_AprsMsgText_8.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgText_KeyPress);
      this.txt_MsgReply_ReplyText.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsMsgRplyText_KeyPress);
      this.txt_BeaconStatusText_1.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsStatusText_KeyPress);
      this.txt_BeaconStatusText_2.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsStatusText_KeyPress);
      this.txt_BeaconStatusText_3.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsStatusText_KeyPress);
      this.txt_BeaconStatusText_4.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsStatusText_KeyPress);
      this.txt_BeaconStatusText_5.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_AprsStatusText_KeyPress);
      this.rdb_FuncSet_Array1.Checked = true;
      this.FuncSetArray[0] = this.btn_FuncSet_VM;
      this.FuncSetArray[1] = this.btn_FuncSet_Sql;
      this.FuncSetArray[2] = this.btn_FuncSet_Mute;
      this.FuncSetArray[3] = this.btn_FuncSet_Scope;
      this.FuncSetArray[4] = this.btn_FuncSet_Scan;
      this.FuncSetArray[5] = this.btn_FuncSet_Rev;
      this.FuncSetArray[6] = this.btn_FuncSet_10Key;
      this.FuncSetArray[7] = this.btn_FuncSet_TxPwrHi;
      this.FuncSetArray[8] = this.btn_FuncSet_SSO;
      this.FuncSetArray[9] = this.btn_FuncSet_Dw;
      this.FuncSetArray[10] = this.btn_FuncSet_SqlNoise;
      this.FuncSetArray[11] = this.btn_FuncSet_Dtmf;
      this.FuncSetArray[12] = this.btn_FuncSet_Home;
      this.FuncSetArray[13] = this.btn_FuncSet_Log;
      this.FuncSetArray[14] = this.btn_FuncSet_SList;
      this.FuncSetArray[15] = this.btn_FuncSet_Msg;
      this.FuncSetArray[16] = this.btn_FuncSet_Beacon;
      this.FuncSetArray[17] = this.btn_FuncSet_BeaconTx;
      this.FuncSetArray[18] = this.btn_FuncSet_Rec;
      this.FuncSetArray[19] = this.btn_FuncSet_xClr;
      this.FuncSetArray[20] = this.btn_FuncSet_PTA;
      this.FuncSetArray[21] = this.btn_FuncSet_Voise;
      this.FuncSetArray[22] = this.btn_FuncSet_Play;
      this.FuncSetArray[23] = this.btn_FuncSet_Stop;
      this.FuncSetlist[0] = this.txt_FuncSet_Array1;
      this.FuncSetlist[1] = this.txt_FuncSet_Array2;
      this.FuncSetlist[2] = this.txt_FuncSet_Array3;
      this.FuncSetlist[3] = this.txt_FuncSet_Array4;
      this.CallsignCodeArray[0] = this.txt_AprsCommon_CallsignCode;
      this.CallsignCodeArray[1] = this.txt_MsgReply_CallSignCode;
      this.CallsignCodeArray[2] = this.txt_DigiPathCode_P11;
      this.CallsignCodeArray[3] = this.txt_DigiPathCode_P12;
      this.CallsignCodeArray[4] = this.txt_DigiPathCode_P21;
      this.CallsignCodeArray[5] = this.txt_DigiPathCode_P22;
      this.CallsignCodeArray[6] = this.txt_DigiPathCode_P31;
      this.CallsignCodeArray[7] = this.txt_DigiPathCode_P32;
      this.CallsignCodeArray[8] = this.txt_DigiPathCode_P41;
      this.CallsignCodeArray[9] = this.txt_DigiPathCode_P42;
      this.CallsignCodeArray[10] = this.txt_DigiPathCode_F11;
      this.CallsignCodeArray[11] = this.txt_DigiPathCode_F12;
      this.CallsignCodeArray[12] = this.txt_DigiPathCode_F13;
      this.CallsignCodeArray[13] = this.txt_DigiPathCode_F14;
      this.CallsignCodeArray[14] = this.txt_DigiPathCode_F15;
      this.CallsignCodeArray[15] = this.txt_DigiPathCode_F16;
      this.CallsignCodeArray[16] = this.txt_DigiPathCode_F17;
      this.CallsignCodeArray[17] = this.txt_DigiPathCode_F18;
      this.CallsignCodeArray[18] = this.txt_DigiPathCode_F21;
      this.CallsignCodeArray[19] = this.txt_DigiPathCode_F22;
      this.CallsignCodeArray[20] = this.txt_DigiPathCode_F23;
      this.CallsignCodeArray[21] = this.txt_DigiPathCode_F24;
      this.CallsignCodeArray[22] = this.txt_DigiPathCode_F25;
      this.CallsignCodeArray[23] = this.txt_DigiPathCode_F26;
      this.CallsignCodeArray[24] = this.txt_DigiPathCode_F27;
      this.CallsignCodeArray[25] = this.txt_DigiPathCode_F28;
      this.CallsignCodeArray[26] = this.txt_AprsRingerCallCode_1;
      this.CallsignCodeArray[27] = this.txt_AprsRingerCallCode_2;
      this.CallsignCodeArray[28] = this.txt_AprsRingerCallCode_3;
      this.CallsignCodeArray[29] = this.txt_AprsRingerCallCode_4;
      this.CallsignCodeArray[30] = this.txt_AprsRingerCallCode_5;
      this.CallsignCodeArray[31] = this.txt_AprsRingerCallCode_6;
      this.CallsignCodeArray[32] = this.txt_AprsRingerCallCode_7;
      this.CallsignCodeArray[33] = this.txt_AprsRingerCallCode_8;
      this.CallsignSsIdArray[0] = this.cmb_AprsCommon_CallsignSsId;
      this.CallsignSsIdArray[1] = this.cmb_MsgReply_CallSignSsId;
      this.CallsignSsIdArray[2] = this.cmb_DigiPathSsId_P11;
      this.CallsignSsIdArray[3] = this.cmb_DigiPathSsId_P12;
      this.CallsignSsIdArray[4] = this.cmb_DigiPathSsId_P21;
      this.CallsignSsIdArray[5] = this.cmb_DigiPathSsId_P22;
      this.CallsignSsIdArray[6] = this.cmb_DigiPathSsId_P31;
      this.CallsignSsIdArray[7] = this.cmb_DigiPathSsId_P32;
      this.CallsignSsIdArray[8] = this.cmb_DigiPathSsId_P41;
      this.CallsignSsIdArray[9] = this.cmb_DigiPathSsId_P42;
      this.CallsignSsIdArray[10] = this.cmb_DigiPathSsId_F11;
      this.CallsignSsIdArray[11] = this.cmb_DigiPathSsId_F12;
      this.CallsignSsIdArray[12] = this.cmb_DigiPathSsId_F13;
      this.CallsignSsIdArray[13] = this.cmb_DigiPathSsId_F14;
      this.CallsignSsIdArray[14] = this.cmb_DigiPathSsId_F15;
      this.CallsignSsIdArray[15] = this.cmb_DigiPathSsId_F16;
      this.CallsignSsIdArray[16] = this.cmb_DigiPathSsId_F17;
      this.CallsignSsIdArray[17] = this.cmb_DigiPathSsId_F18;
      this.CallsignSsIdArray[18] = this.cmb_DigiPathSsId_F21;
      this.CallsignSsIdArray[19] = this.cmb_DigiPathSsId_F22;
      this.CallsignSsIdArray[20] = this.cmb_DigiPathSsId_F23;
      this.CallsignSsIdArray[21] = this.cmb_DigiPathSsId_F24;
      this.CallsignSsIdArray[22] = this.cmb_DigiPathSsId_F25;
      this.CallsignSsIdArray[23] = this.cmb_DigiPathSsId_F26;
      this.CallsignSsIdArray[24] = this.cmb_DigiPathSsId_F27;
      this.CallsignSsIdArray[25] = this.cmb_DigiPathSsId_F28;
      this.CallsignSsIdArray[26] = this.cmb_AprsRingerCallSsId_1;
      this.CallsignSsIdArray[27] = this.cmb_AprsRingerCallSsId_2;
      this.CallsignSsIdArray[28] = this.cmb_AprsRingerCallSsId_3;
      this.CallsignSsIdArray[29] = this.cmb_AprsRingerCallSsId_4;
      this.CallsignSsIdArray[30] = this.cmb_AprsRingerCallSsId_5;
      this.CallsignSsIdArray[31] = this.cmb_AprsRingerCallSsId_6;
      this.CallsignSsIdArray[32] = this.cmb_AprsRingerCallSsId_7;
      this.CallsignSsIdArray[33] = this.cmb_AprsRingerCallSsId_8;
    }

    private void SetForm_Load(object sender, EventArgs e)
    {
      ResourceManager resourceManager = new ResourceManager("Ftm400dAdms7.Strings", typeof (DataForm).Assembly);
      this.cmb_Config_DtTmFrmtDt.DataBindings.Add("SelectedIndex", (object) this.db, "Config_DtTmFrmtDt");
      this.cmb_Config_DtTmFrmtHr.DataBindings.Add("SelectedIndex", (object) this.db, "Config_DtTmFrmtHr");
      this.cmb_Config_TimeZone.DataBindings.Add("SelectedIndex", (object) this.db, "Config_TimeZone");
      this.cmb_Config_AtRptShftA.DataBindings.Add("SelectedIndex", (object) this.db, "Config_AtRptShftA");
      this.cmb_Config_AtRptShftB.DataBindings.Add("SelectedIndex", (object) this.db, "Config_AtRptShftB");
      this.cmb_Config_Beep.DataBindings.Add("SelectedIndex", (object) this.db, "Config_Beep");
      this.cmb_Config_MicProgKeyP1.DataBindings.Add("SelectedIndex", (object) this.db, "Config_MicProgKeyP1");
      this.cmb_Config_MicProgKeyP2.DataBindings.Add("SelectedIndex", (object) this.db, "Config_MicProgKeyP2");
      this.cmb_Config_MicProgKeyP3.DataBindings.Add("SelectedIndex", (object) this.db, "Config_MicProgKeyP3");
      this.cmb_Config_MicProgKeyP4.DataBindings.Add("SelectedIndex", (object) this.db, "Config_MicProgKeyP4");
      this.cmb_Config_RxCovA.DataBindings.Add("SelectedIndex", (object) this.db, "Config_RxCovA");
      this.cmb_Config_RxCovB.DataBindings.Add("SelectedIndex", (object) this.db, "Config_RxCovB");
      this.cmb_Config_Unit.DataBindings.Add("SelectedIndex", (object) this.db, "Config_Unit");
      this.cmb_Config_Apo.DataBindings.Add("SelectedIndex", (object) this.db, "Config_Apo");
      this.cmb_Config_Tot.DataBindings.Add("SelectedIndex", (object) this.db, "Config_Tot");
      this.cmb_Config_GpsDtm.DataBindings.Add("SelectedIndex", (object) this.db, "Config_GpsDtm");
      this.cmb_Config_GpsDev.DataBindings.Add("SelectedIndex", (object) this.db, "Config_GpsDev");
      this.cmb_Config_GpsLog.DataBindings.Add("SelectedIndex", (object) this.db, "Config_GpsLog");
      this.cmb_Config_AtModeA.DataBindings.Add("SelectedIndex", (object) this.db, "Config_AtModeA");
      this.cmb_Config_AtModeB.DataBindings.Add("SelectedIndex", (object) this.db, "Config_AtModeB");
      this.cmb_Config_AtStepA.DataBindings.Add("SelectedIndex", (object) this.db, "Config_AtStepA");
      this.cmb_Config_AtStepB.DataBindings.Add("SelectedIndex", (object) this.db, "Config_AtStepB");
      this.cmb_Scan_DWStopA.DataBindings.Add("SelectedIndex", (object) this.db, "Scan_DWStopA");
      this.cmb_Scan_DWStopB.DataBindings.Add("SelectedIndex", (object) this.db, "Scan_DWStopB");
      this.cmb_Scan_ScanDrctnA.DataBindings.Add("SelectedIndex", (object) this.db, "Scan_ScanDrctnA");
      this.cmb_Scan_ScanDrctnB.DataBindings.Add("SelectedIndex", (object) this.db, "Scan_ScanDrctnB");
      this.cmb_Scan_ScanRsmA.DataBindings.Add("SelectedIndex", (object) this.db, "Scan_ScanRsmA");
      this.cmb_Scan_ScanRsmB.DataBindings.Add("SelectedIndex", (object) this.db, "Scan_ScanRsmB");
      this.cmb_Display_Altitude.DataBindings.Add("SelectedIndex", (object) this.db, "Display_Altitude");
      this.cmb_Display_TimerClk.DataBindings.Add("SelectedIndex", (object) this.db, "Display_TimerClk");
      this.cmb_Display_GpsInfo.DataBindings.Add("SelectedIndex", (object) this.db, "Display_GpsInfo");
      this.cmb_Display_TgtLctn.DataBindings.Add("SelectedIndex", (object) this.db, "Display_TgtLctn");
      this.cmb_Display_BgClr.DataBindings.Add("SelectedIndex", (object) this.db, "Display_BgClr");
      this.cmb_Display_BandScpA.DataBindings.Add("SelectedIndex", (object) this.db, "Display_BandScpA");
      this.cmb_Display_BandScpB.DataBindings.Add("SelectedIndex", (object) this.db, "Display_BandScpB");
      this.cmb_Display_LcdBrigtness.DataBindings.Add("SelectedIndex", (object) this.db, "Display_LcdBrigtness");
      this.cmb_Display_LcdContrast.DataBindings.Add("SelectedIndex", (object) this.db, "Display_LcdContrast");
      this.cmb_Display_TimeVdd.DataBindings.Add("SelectedIndex", (object) this.db, "Display_TimeVdd");
      this.cmb_Data_ComSpeed.DataBindings.Add("SelectedIndex", (object) this.db, "Data_ComSpeed");
      this.cmb_Data_ComOutput.DataBindings.Add("SelectedIndex", (object) this.db, "Data_ComOutput");
      this.cmb_Data_ComWpFormat.DataBindings.Add("SelectedIndex", (object) this.db, "Data_ComWpFormat");
      this.cmb_Data_ComWpFilter.DataBindings.Add("SelectedIndex", (object) this.db, "Data_ComWpFilter");
      this.cmb_Data_DBandAprs.DataBindings.Add("SelectedIndex", (object) this.db, "Data_DBandAprs");
      this.cmb_Data_DBandData.DataBindings.Add("SelectedIndex", (object) this.db, "Data_DBandData");
      this.cmb_Data_DSpeedAprs.DataBindings.Add("SelectedIndex", (object) this.db, "Data_DSpeedAprs");
      this.cmb_Data_DSpeedData.DataBindings.Add("SelectedIndex", (object) this.db, "Data_DSpeedData");
      this.cmb_Data_DSqlcAprs.DataBindings.Add("SelectedIndex", (object) this.db, "Data_DSqlcAprs");
      this.cmb_Data_DSqlcData.DataBindings.Add("SelectedIndex", (object) this.db, "Data_DSqlcData");
      this.cmb_Data_DSqlcTx.DataBindings.Add("SelectedIndex", (object) this.db, "Data_DSqlcTx");
      this.cmb_Signaling_AutDialer.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_AutDialer");
      this.cmb_Signaling_PageRx1.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_PageRx1");
      this.cmb_Signaling_PageRx2.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_PageRx2");
      this.cmb_Signaling_PageTx1.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_PageTx1");
      this.cmb_Signaling_PageTx2.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_PageTx2");
      this.cmb_Signaling_BellRingerA.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_BellRingerA");
      this.cmb_Signaling_BellRingerB.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_BellRingerB");
      this.cmb_Signaling_SqlExA.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_SqlExA");
      this.cmb_Signaling_SqlExB.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_SqlExB");
      this.cmb_Signaling_WxAlrtA.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_WxAlrtA");
      this.cmb_Signaling_WxAlrtB.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_WxAlrtB");
      this.cmb_Audio_SubBandMute.DataBindings.Add("SelectedIndex", (object) this.db, "Audio_SubBandMute");
      this.cmb_Audio_MicGain.DataBindings.Add("SelectedIndex", (object) this.db, "Audio_MicGain");
      this.cmb_Option_UsbCmrSize.DataBindings.Add("SelectedIndex", (object) this.db, "Option_UsbCmrSize");
      this.cmb_Option_UsbCmrQlty.DataBindings.Add("SelectedIndex", (object) this.db, "Option_UsbCmrQlty");
      this.cmb_Option_BltthAudio.DataBindings.Add("SelectedIndex", (object) this.db, "Option_BltthAudio");
      this.cmb_Option_BltthBttery.DataBindings.Add("SelectedIndex", (object) this.db, "Option_BltthBttery");
      this.cmb_Option_BltthVox.DataBindings.Add("SelectedIndex", (object) this.db, "Option_BltthVox");
      this.cmb_Option_VcMemPR.DataBindings.Add("SelectedIndex", (object) this.db, "Option_VcMemPR");
      this.cmb_Option_VcMemAnnc.DataBindings.Add("SelectedIndex", (object) this.db, "Option_VcMemAnnc");
      this.cmb_Option_VcMemLng.DataBindings.Add("SelectedIndex", (object) this.db, "Option_VcMemLng");
      this.cmb_Option_VcMemVlm.DataBindings.Add("SelectedIndex", (object) this.db, "Option_VcMemVlm");
      this.cmb_Option_RxMute.DataBindings.Add("SelectedIndex", (object) this.db, "Option_RxMute");
      this.txt_FuncSet_Array1.Text = this.FuncSetArray[this.db.FuncSet_Array1].Text;
      this.txt_FuncSet_Array2.Text = this.FuncSetArray[this.db.FuncSet_Array2].Text;
      this.txt_FuncSet_Array3.Text = this.FuncSetArray[this.db.FuncSet_Array3].Text;
      this.txt_FuncSet_Array4.Text = this.FuncSetArray[this.db.FuncSet_Array4].Text;
      foreach (Button funcSet in this.FuncSetArray)
      {
        funcSet.Enabled = true;
        foreach (TextBox textBox in this.FuncSetlist)
        {
          if (funcSet.Text == textBox.Text)
            funcSet.Enabled = false;
        }
      }
      this.dgv_DtmfMemory.AutoGenerateColumns = false;
      this.dgv_DtmfMemory.EnableHeadersVisualStyles = false;
      this.dgv_DtmfMemory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgv_DtmfMemory.DataSource = (object) this.db.dtmfMemory;
      DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      viewTextBoxColumn1.DataPropertyName = "No";
      viewTextBoxColumn1.Name = resourceManager.GetString("DTMFCHANNELNUM");
      this.dgv_DtmfMemory.Columns.Add((DataGridViewColumn) viewTextBoxColumn1);
      this.dgv_DtmfMemory.Columns[0].Width = 70;
      this.dgv_DtmfMemory.Columns[0].ReadOnly = true;
      this.dgv_DtmfMemory.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.dgv_DtmfMemory.Columns[0].DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control);
      this.dgv_DtmfMemory.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      DataGridViewTextBoxColumn viewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      viewTextBoxColumn2.DataPropertyName = "CODE";
      viewTextBoxColumn2.Name = resourceManager.GetString("DTMFCODE");
      this.dgv_DtmfMemory.Columns.Add((DataGridViewColumn) viewTextBoxColumn2);
      this.dgv_DtmfMemory.Columns[1].Width = 140;
      this.dgv_DtmfMemory.Columns[1].ReadOnly = false;
      ((DataGridViewTextBoxColumn) this.dgv_DtmfMemory.Columns[1]).MaxInputLength = 16;
      this.dgv_DtmfMemory.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.cmb_Digital_AmsTxMode.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_AmsTxMode");
      this.cmb_Digital_RxDgID.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_RxDgID");
      this.cmb_Digital_TxDgID.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_TxDgID");
      this.cmb_Digital_Popup.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_Popup");
      this.cmb_Digital_LocationService.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_LocationService");
      this.cmb_Digital_StandbyBeep.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_StandbyBeep");
      this.cmb_Gm_RangeRinger.DataBindings.Add("SelectedIndex", (object) this.db, "Gm_RangeRinger");
      this.txt_Gm_CallSign.DataBindings.Add("Text", (object) this.db, "Gm_CallSign");
      this.cmb_WiresX_RptWiresFreq.DataBindings.Add("SelectedIndex", (object) this.db, "WiresX_RptWiresFreq");
      this.nud_WiresX_PresetFreq.DataBindings.Add("Value", (object) this.db, "WiresX_PresetFreq");
      this.cmb_WiresX_SearchSetup.DataBindings.Add("SelectedIndex", (object) this.db, "WiresX_SearchSetup");
      this.cmb_WiresX_DgID.DataBindings.Add("SelectedIndex", (object) this.db, "WiresX_DgID");
      this.dgv_Category.AutoGenerateColumns = false;
      this.dgv_Category.EnableHeadersVisualStyles = false;
      this.dgv_Category.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgv_Category.DataSource = (object) this.db.category;
      DataGridViewTextBoxColumn viewTextBoxColumn3 = new DataGridViewTextBoxColumn();
      viewTextBoxColumn3.DataPropertyName = "No";
      viewTextBoxColumn3.Name = resourceManager.GetString("CATEGORYNUM");
      this.dgv_Category.Columns.Add((DataGridViewColumn) viewTextBoxColumn3);
      this.dgv_Category.Columns[0].Width = 100;
      this.dgv_Category.Columns[0].ReadOnly = true;
      this.dgv_Category.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.dgv_Category.Columns[0].DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control);
      this.dgv_Category.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      DataGridViewTextBoxColumn viewTextBoxColumn4 = new DataGridViewTextBoxColumn();
      viewTextBoxColumn4.DataPropertyName = "Name";
      viewTextBoxColumn4.Name = resourceManager.GetString("CATEGORYNAME");
      this.dgv_Category.Columns.Add((DataGridViewColumn) viewTextBoxColumn4);
      this.dgv_Category.Columns[1].Width = 160;
      this.dgv_Category.Columns[1].ReadOnly = false;
      this.dgv_Category.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
      ((DataGridViewTextBoxColumn) this.dgv_Category.Columns[1]).MaxInputLength = 16;
      this.dgv_MsgText.AutoGenerateColumns = false;
      this.dgv_MsgText.EnableHeadersVisualStyles = false;
      this.dgv_MsgText.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgv_MsgText.DataSource = (object) this.db.messageText;
      DataGridViewTextBoxColumn viewTextBoxColumn5 = new DataGridViewTextBoxColumn();
      viewTextBoxColumn5.DataPropertyName = "No";
      viewTextBoxColumn5.Name = resourceManager.GetString("MSGNUM");
      this.dgv_MsgText.Columns.Add((DataGridViewColumn) viewTextBoxColumn5);
      this.dgv_MsgText.Columns[0].Width = 100;
      this.dgv_MsgText.Columns[0].ReadOnly = true;
      this.dgv_MsgText.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
      this.dgv_MsgText.Columns[0].DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control);
      this.dgv_MsgText.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      DataGridViewTextBoxColumn viewTextBoxColumn6 = new DataGridViewTextBoxColumn();
      viewTextBoxColumn6.DataPropertyName = "Message";
      viewTextBoxColumn6.Name = resourceManager.GetString("MSGMESSAGE");
      this.dgv_MsgText.Columns.Add((DataGridViewColumn) viewTextBoxColumn6);
      this.dgv_MsgText.Columns[1].Width = 560;
      this.dgv_MsgText.Columns[1].ReadOnly = false;
      this.dgv_MsgText.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
      ((DataGridViewTextBoxColumn) this.dgv_MsgText.Columns[1]).MaxInputLength = 80;
      this.cmb_AprsCommon_Cmps.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_Cmps");
      this.cmb_AprsCommon_Dst.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_Dst");
      this.cmb_AprsCommon_Modem.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_Modem");
      this.cmb_AprsCommon_Mute.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_Mute");
      this.cmb_AprsCommon_TxDelay.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_TxDelay");
      this.cmb_AprsCommon_Ambgty.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_Ambgty");
      this.cmb_AprsCommon_SpdCrc.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_SpdCrc");
      this.cmb_AprsCommon_Alttd.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_Alttd");
      this.cmb_AprsCommon_Auto.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_Auto");
      this.cmb_AprsCommon_Intrvl.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_Intrvl");
      this.cmb_AprsCommon_Prprtnl.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_Prprtnl");
      this.cmb_AprsCommon_Dcy.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_Dcy");
      this.cmb_AprsCommon_LwSpd.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_LwSpd");
      this.cmb_AprsCommon_RtLmt.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_RtLmt");
      this.txt_AprsCommon_CallsignCode.DataBindings.Add("Text", (object) this.db, "AprsCommon_CallsignCode");
      this.cmb_AprsCommon_CallsignSsId.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_CallsignSsId");
      this.cmb_AprsCommon_PstnCmnt.DataBindings.Add("SelectedIndex", (object) this.db, "AprsCommon_PstnCmnt");
      switch (this.db.MySymbol_Sel)
      {
        case 0:
          this.rdb_MySymbol_1_Sel.Checked = true;
          break;
        case 1:
          this.rdb_MySymbol_2_Sel.Checked = true;
          break;
        case 2:
          this.rdb_MySymbol_3_Sel.Checked = true;
          break;
        case 3:
          this.rdb_MySymbol_4_Sel.Checked = true;
          break;
      }
      this.cmb_MySymbol_1_Icn.DataBindings.Add("Text", (object) this.db, "MySymbol_1_Icn");
      this.cmb_MySymbol_2_Icn.DataBindings.Add("Text", (object) this.db, "MySymbol_2_Icn");
      this.cmb_MySymbol_3_Icn.DataBindings.Add("Text", (object) this.db, "MySymbol_3_Icn");
      this.cmb_MySymbol_41_Icn.DataBindings.Add("Text", (object) this.db, "MySymbol_41_Icn");
      this.cmb_MySymbol_42_Icn.DataBindings.Add("Text", (object) this.db, "MySymbol_42_Icn");
      this.txt_AprsMsgGroup_G1.DataBindings.Add("Text", (object) this.db, "AprsMsgGroup_G1");
      this.txt_AprsMsgGroup_G2.DataBindings.Add("Text", (object) this.db, "AprsMsgGroup_G2");
      this.txt_AprsMsgGroup_G3.DataBindings.Add("Text", (object) this.db, "AprsMsgGroup_G3");
      this.txt_AprsMsgGroup_G4.DataBindings.Add("Text", (object) this.db, "AprsMsgGroup_G4");
      this.txt_AprsMsgGroup_G5.DataBindings.Add("Text", (object) this.db, "AprsMsgGroup_G5");
      this.txt_AprsMsgGroup_G6.DataBindings.Add("Text", (object) this.db, "AprsMsgGroup_G6");
      this.txt_AprsMsgGroup_B1.DataBindings.Add("Text", (object) this.db, "AprsMsgGroup_B1");
      this.txt_AprsMsgGroup_B2.DataBindings.Add("Text", (object) this.db, "AprsMsgGroup_B2");
      this.txt_AprsMsgGroup_B3.DataBindings.Add("Text", (object) this.db, "AprsMsgGroup_B3");
      this.cmb_MsgReply_Reply.DataBindings.Add("SelectedIndex", (object) this.db, "MsgReply_Reply");
      this.txt_MsgReply_CallSignCode.DataBindings.Add("Text", (object) this.db, "MsgReply_CallSignCode");
      this.cmb_MsgReply_CallSignSsId.DataBindings.Add("SelectedIndex", (object) this.db, "MsgReply_CallSignSsId");
      this.txt_MsgReply_ReplyText.DataBindings.Add("Text", (object) this.db, "MsgReply_ReplyText");
      switch (this.db.AprsMsgText_Sel)
      {
        case 0:
          this.rdb_AprsMsgText_1_No.Checked = true;
          break;
        case 1:
          this.rdb_AprsMsgText_2_No.Checked = true;
          break;
        case 2:
          this.rdb_AprsMsgText_3_No.Checked = true;
          break;
        case 3:
          this.rdb_AprsMsgText_4_No.Checked = true;
          break;
        case 4:
          this.rdb_AprsMsgText_5_No.Checked = true;
          break;
        case 5:
          this.rdb_AprsMsgText_6_No.Checked = true;
          break;
        case 6:
          this.rdb_AprsMsgText_7_No.Checked = true;
          break;
        case 7:
          this.rdb_AprsMsgText_8_No.Checked = true;
          break;
      }
      this.txt_AprsMsgText_1.DataBindings.Add("Text", (object) this.db, "AprsMsgText_1");
      this.txt_AprsMsgText_2.DataBindings.Add("Text", (object) this.db, "AprsMsgText_2");
      this.txt_AprsMsgText_3.DataBindings.Add("Text", (object) this.db, "AprsMsgText_3");
      this.txt_AprsMsgText_4.DataBindings.Add("Text", (object) this.db, "AprsMsgText_4");
      this.txt_AprsMsgText_5.DataBindings.Add("Text", (object) this.db, "AprsMsgText_5");
      this.txt_AprsMsgText_6.DataBindings.Add("Text", (object) this.db, "AprsMsgText_6");
      this.txt_AprsMsgText_7.DataBindings.Add("Text", (object) this.db, "AprsMsgText_7");
      this.txt_AprsMsgText_8.DataBindings.Add("Text", (object) this.db, "AprsMsgText_8");
      this.cmb_VoiceAleat_VoiceAleat.DataBindings.Add("SelectedIndex", (object) this.db, "VoiceAleat_VoiceAleat");
      this.cmb_VoiceAleat_ToneSql.DataBindings.Add("SelectedIndex", (object) this.db, "VoiceAleat_ToneSql");
      this.cmb_VoiceAleat_Dcs.DataBindings.Add("SelectedIndex", (object) this.db, "VoiceAleat_Dcs");
      this.cmb_SortFilter_Sort.DataBindings.Add("SelectedIndex", (object) this.db, "SortFilter_Sort");
      this.cmb_SortFilter_Filter.DataBindings.Add("SelectedIndex", (object) this.db, "SortFilter_Filter");
      switch (this.db.MyPosition_Sel)
      {
        case 0:
          this.rdb_MyPosition_Gps.Checked = true;
          break;
        case 1:
          this.rdb_MyPosition_Manual.Checked = true;
          break;
      }
      this.cmb_MyPosition_ManualLat.DataBindings.Add("SelectedIndex", (object) this.db, "MyPosition_ManualLat");
      this.nud_MyPosition_ManualLatDD.DataBindings.Add("Value", (object) this.db, "MyPosition_ManualLatDD");
      this.nud_MyPosition_ManualLatMM1.DataBindings.Add("Value", (object) this.db, "MyPosition_ManualLatMM1");
      this.nud_MyPosition_ManualLatMM2.DataBindings.Add("Value", (object) this.db, "MyPosition_ManualLatMM2");
      this.cmb_MyPosition_ManualLon.DataBindings.Add("SelectedIndex", (object) this.db, "MyPosition_ManualLon");
      this.nud_MyPosition_ManualLonDD.DataBindings.Add("Value", (object) this.db, "MyPosition_ManualLonDD");
      this.nud_MyPosition_ManualLonMM1.DataBindings.Add("Value", (object) this.db, "MyPosition_ManualLonMM1");
      this.nud_MyPosition_ManualLonMM2.DataBindings.Add("Value", (object) this.db, "MyPosition_ManualLonMM2");
      this.cmb_AprsFilter_MicE.DataBindings.Add("SelectedIndex", (object) this.db, "AprsFilter_MicE");
      this.cmb_AprsFilter_Position.DataBindings.Add("SelectedIndex", (object) this.db, "AprsFilter_Position");
      this.cmb_AprsFilter_Weather.DataBindings.Add("SelectedIndex", (object) this.db, "AprsFilter_Weather");
      this.cmb_AprsFilter_Object.DataBindings.Add("SelectedIndex", (object) this.db, "AprsFilter_Object");
      this.cmb_AprsFilter_Item.DataBindings.Add("SelectedIndex", (object) this.db, "AprsFilter_Item");
      this.cmb_AprsFilter_Status.DataBindings.Add("SelectedIndex", (object) this.db, "AprsFilter_Status");
      this.cmb_AprsFilter_Other.DataBindings.Add("SelectedIndex", (object) this.db, "AprsFilter_Other");
      this.cmb_AprsFilter_RangeLimit.DataBindings.Add("SelectedIndex", (object) this.db, "AprsFilter_RangeLimit");
      this.cmb_AprsFilter_Altnet.DataBindings.Add("SelectedIndex", (object) this.db, "AprsFilter_Altnet");
      this.cmb_AprsUnit_Position.DataBindings.Add("SelectedIndex", (object) this.db, "AprsUnit_Position");
      this.cmb_AprsUnit_Distance.DataBindings.Add("SelectedIndex", (object) this.db, "AprsUnit_Distance");
      this.cmb_AprsUnit_Speed.DataBindings.Add("SelectedIndex", (object) this.db, "AprsUnit_Speed");
      this.cmb_AprsUnit_Altitude.DataBindings.Add("SelectedIndex", (object) this.db, "AprsUnit_Altitude");
      this.cmb_AprsUnit_Baro.DataBindings.Add("SelectedIndex", (object) this.db, "AprsUnit_Baro");
      this.cmb_AprsUnit_Temp.DataBindings.Add("SelectedIndex", (object) this.db, "AprsUnit_Temp");
      this.cmb_AprsUnit_Rain.DataBindings.Add("SelectedIndex", (object) this.db, "AprsUnit_Rain");
      this.cmb_AprsUnit_Wind.DataBindings.Add("SelectedIndex", (object) this.db, "AprsUnit_Wind");
      this.cmb_AprsPopup_Bcn.DataBindings.Add("SelectedIndex", (object) this.db, "AprsPopup_Bcn");
      this.cmb_AprsPopup_Msg.DataBindings.Add("SelectedIndex", (object) this.db, "AprsPopup_Msg");
      this.cmb_AprsPopup_MyPacket.DataBindings.Add("SelectedIndex", (object) this.db, "AprsPopup_MyPacket");
      this.cmb_AprsPopupColor_Bcn.DataBindings.Add("SelectedIndex", (object) this.db, "AprsPopupColor_Bcn");
      this.cmb_AprsPopupColor_Mbl.DataBindings.Add("SelectedIndex", (object) this.db, "AprsPopupColor_Mbl");
      this.cmb_AprsPopupColor_ObjItm.DataBindings.Add("SelectedIndex", (object) this.db, "AprsPopupColor_ObjItm");
      this.cmb_AprsPopupColor_CllRngr.DataBindings.Add("SelectedIndex", (object) this.db, "AprsPopupColor_CllRngr");
      this.cmb_AprsPopupColor_RngRngr.DataBindings.Add("SelectedIndex", (object) this.db, "AprsPopupColor_RngRngr");
      this.cmb_AprsPopupColor_Msg.DataBindings.Add("SelectedIndex", (object) this.db, "AprsPopupColor_Msg");
      this.cmb_AprsPopupColor_GrpBult.DataBindings.Add("SelectedIndex", (object) this.db, "AprsPopupColor_GrpBult");
      this.cmb_AprsPopupColor_MyPckt.DataBindings.Add("SelectedIndex", (object) this.db, "AprsPopupColor_MyPckt");
      this.cmb_AprsRinger_TxBcn.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRinger_TxBcn");
      this.cmb_AprsRinger_TxMsg.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRinger_TxMsg");
      this.cmb_AprsRinger_RxBcn.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRinger_RxBcn");
      this.cmb_AprsRinger_RxMsg.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRinger_RxMsg");
      this.cmb_AprsRinger_MyPacket.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRinger_MyPacket");
      this.cmb_AprsRinger_CllRngr.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRinger_CllRngr");
      this.cmb_AprsRinger_RngRbgr.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRinger_RngRbgr");
      this.cmb_AprsRinger_MsgVc.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRinger_MsgVc");
      this.txt_AprsRingerCallCode_1.DataBindings.Add("Text", (object) this.db, "AprsRingerCallCode_1");
      this.txt_AprsRingerCallCode_2.DataBindings.Add("Text", (object) this.db, "AprsRingerCallCode_2");
      this.txt_AprsRingerCallCode_3.DataBindings.Add("Text", (object) this.db, "AprsRingerCallCode_3");
      this.txt_AprsRingerCallCode_4.DataBindings.Add("Text", (object) this.db, "AprsRingerCallCode_4");
      this.txt_AprsRingerCallCode_5.DataBindings.Add("Text", (object) this.db, "AprsRingerCallCode_5");
      this.txt_AprsRingerCallCode_6.DataBindings.Add("Text", (object) this.db, "AprsRingerCallCode_6");
      this.txt_AprsRingerCallCode_7.DataBindings.Add("Text", (object) this.db, "AprsRingerCallCode_7");
      this.txt_AprsRingerCallCode_8.DataBindings.Add("Text", (object) this.db, "AprsRingerCallCode_8");
      this.cmb_AprsRingerCallSsId_1.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRingerCallSsId_1");
      this.cmb_AprsRingerCallSsId_2.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRingerCallSsId_2");
      this.cmb_AprsRingerCallSsId_3.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRingerCallSsId_3");
      this.cmb_AprsRingerCallSsId_4.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRingerCallSsId_4");
      this.cmb_AprsRingerCallSsId_5.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRingerCallSsId_5");
      this.cmb_AprsRingerCallSsId_6.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRingerCallSsId_6");
      this.cmb_AprsRingerCallSsId_7.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRingerCallSsId_7");
      this.cmb_AprsRingerCallSsId_8.DataBindings.Add("SelectedIndex", (object) this.db, "AprsRingerCallSsId_8");
      switch (this.db.BeaconStatusText_Sel)
      {
        case 0:
          this.rdb_BeaconStatusText_Off.Checked = true;
          break;
        case 1:
          this.rdb_BeaconStatusText_1.Checked = true;
          break;
        case 2:
          this.rdb_BeaconStatusText_2.Checked = true;
          break;
        case 3:
          this.rdb_BeaconStatusText_3.Checked = true;
          break;
        case 4:
          this.rdb_BeaconStatusText_4.Checked = true;
          break;
        case 5:
          this.rdb_BeaconStatusText_5.Checked = true;
          break;
      }
      this.cmb_BeaconStatusText_TxRate.DataBindings.Add("SelectedIndex", (object) this.db, "BeaconStatusText_TxRate");
      this.txt_BeaconStatusText_1.DataBindings.Add("Text", (object) this.db, "BeaconStatusText_1");
      this.txt_BeaconStatusText_2.DataBindings.Add("Text", (object) this.db, "BeaconStatusText_2");
      this.txt_BeaconStatusText_3.DataBindings.Add("Text", (object) this.db, "BeaconStatusText_3");
      this.txt_BeaconStatusText_4.DataBindings.Add("Text", (object) this.db, "BeaconStatusText_4");
      this.txt_BeaconStatusText_5.DataBindings.Add("Text", (object) this.db, "BeaconStatusText_5");
      this.cmb_BeaconStatusText_1_Mode.DataBindings.Add("SelectedIndex", (object) this.db, "BeaconStatusText_1_Mode");
      this.cmb_BeaconStatusText_2_Mode.DataBindings.Add("SelectedIndex", (object) this.db, "BeaconStatusText_2_Mode");
      this.cmb_BeaconStatusText_3_Mode.DataBindings.Add("SelectedIndex", (object) this.db, "BeaconStatusText_3_Mode");
      this.cmb_BeaconStatusText_4_Mode.DataBindings.Add("SelectedIndex", (object) this.db, "BeaconStatusText_4_Mode");
      this.cmb_BeaconStatusText_5_Mode.DataBindings.Add("SelectedIndex", (object) this.db, "BeaconStatusText_5_Mode");
      switch (this.db.DigiPath_Sel)
      {
        case 0:
          this.rdb_DigiPath_Off.Checked = true;
          break;
        case 1:
          this.rdb_DigiPath_1Wide.Checked = true;
          break;
        case 2:
          this.rdb_DigiPath_2Wide.Checked = true;
          break;
        case 3:
          this.rdb_DigiPath_P1.Checked = true;
          break;
        case 4:
          this.rdb_DigiPath_P2.Checked = true;
          break;
        case 5:
          this.rdb_DigiPath_P3.Checked = true;
          break;
        case 6:
          this.rdb_DigiPath_P4.Checked = true;
          break;
        case 7:
          this.rdb_DigiPath_F1.Checked = true;
          break;
        case 8:
          this.rdb_DigiPath_F2.Checked = true;
          break;
      }
      this.txt_DigiPathCode_P11.DataBindings.Add("Text", (object) this.db, "DigiPathCode_P11");
      this.txt_DigiPathCode_P12.DataBindings.Add("Text", (object) this.db, "DigiPathCode_P12");
      this.txt_DigiPathCode_P21.DataBindings.Add("Text", (object) this.db, "DigiPathCode_P21");
      this.txt_DigiPathCode_P22.DataBindings.Add("Text", (object) this.db, "DigiPathCode_P22");
      this.txt_DigiPathCode_P31.DataBindings.Add("Text", (object) this.db, "DigiPathCode_P31");
      this.txt_DigiPathCode_P32.DataBindings.Add("Text", (object) this.db, "DigiPathCode_P32");
      this.txt_DigiPathCode_P41.DataBindings.Add("Text", (object) this.db, "DigiPathCode_P41");
      this.txt_DigiPathCode_P42.DataBindings.Add("Text", (object) this.db, "DigiPathCode_P42");
      this.txt_DigiPathCode_F11.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F11");
      this.txt_DigiPathCode_F12.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F12");
      this.txt_DigiPathCode_F13.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F13");
      this.txt_DigiPathCode_F14.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F14");
      this.txt_DigiPathCode_F15.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F15");
      this.txt_DigiPathCode_F16.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F16");
      this.txt_DigiPathCode_F17.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F17");
      this.txt_DigiPathCode_F18.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F18");
      this.txt_DigiPathCode_F21.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F21");
      this.txt_DigiPathCode_F22.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F22");
      this.txt_DigiPathCode_F23.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F23");
      this.txt_DigiPathCode_F24.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F24");
      this.txt_DigiPathCode_F25.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F25");
      this.txt_DigiPathCode_F26.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F26");
      this.txt_DigiPathCode_F27.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F27");
      this.txt_DigiPathCode_F28.DataBindings.Add("Text", (object) this.db, "DigiPathCode_F28");
      this.cmb_DigiPathSsId_P11.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_P11");
      this.cmb_DigiPathSsId_P12.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_P12");
      this.cmb_DigiPathSsId_P21.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_P21");
      this.cmb_DigiPathSsId_P22.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_P22");
      this.cmb_DigiPathSsId_P31.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_P31");
      this.cmb_DigiPathSsId_P32.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_P32");
      this.cmb_DigiPathSsId_P41.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_P41");
      this.cmb_DigiPathSsId_P42.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_P42");
      this.cmb_DigiPathSsId_F11.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F11");
      this.cmb_DigiPathSsId_F12.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F12");
      this.cmb_DigiPathSsId_F13.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F13");
      this.cmb_DigiPathSsId_F14.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F14");
      this.cmb_DigiPathSsId_F15.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F15");
      this.cmb_DigiPathSsId_F16.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F16");
      this.cmb_DigiPathSsId_F17.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F17");
      this.cmb_DigiPathSsId_F18.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F18");
      this.cmb_DigiPathSsId_F21.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F21");
      this.cmb_DigiPathSsId_F22.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F22");
      this.cmb_DigiPathSsId_F23.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F23");
      this.cmb_DigiPathSsId_F24.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F24");
      this.cmb_DigiPathSsId_F25.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F25");
      this.cmb_DigiPathSsId_F26.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F26");
      this.cmb_DigiPathSsId_F27.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F27");
      this.cmb_DigiPathSsId_F28.DataBindings.Add("SelectedIndex", (object) this.db, "DigiPathSsId_F28");
      this.cmb_SmartBeaconing_Select.DataBindings.Add("SelectedIndex", (object) this.db, "SmartBeaconing_Select");
      this.nud_SmartBeaconing1_LowSpeed.DataBindings.Add("Value", (object) this.db, "SmartBeaconing1_LowSpeed");
      this.nud_SmartBeaconing1_HighSpeed.DataBindings.Add("Value", (object) this.db, "SmartBeaconing1_HighSpeed");
      this.nud_SmartBeaconing1_SlowRate.DataBindings.Add("Value", (object) this.db, "SmartBeaconing1_SlowRate");
      this.nud_SmartBeaconing1_FastRate.DataBindings.Add("Value", (object) this.db, "SmartBeaconing1_FastRate");
      this.nud_SmartBeaconing1_TurnAngle.DataBindings.Add("Value", (object) this.db, "SmartBeaconing1_TurnAngle");
      this.nud_SmartBeaconing1_TurnSlope.DataBindings.Add("Value", (object) this.db, "SmartBeaconing1_TurnSlope");
      this.nud_SmartBeaconing1_TurnTime.DataBindings.Add("Value", (object) this.db, "SmartBeaconing1_TurnTime");
      this.nud_SmartBeaconing2_LowSpeed.DataBindings.Add("Value", (object) this.db, "SmartBeaconing2_LowSpeed");
      this.nud_SmartBeaconing2_HighSpeed.DataBindings.Add("Value", (object) this.db, "SmartBeaconing2_HighSpeed");
      this.nud_SmartBeaconing2_SlowRate.DataBindings.Add("Value", (object) this.db, "SmartBeaconing2_SlowRate");
      this.nud_SmartBeaconing2_FastRate.DataBindings.Add("Value", (object) this.db, "SmartBeaconing2_FastRate");
      this.nud_SmartBeaconing2_TurnAngle.DataBindings.Add("Value", (object) this.db, "SmartBeaconing2_TurnAngle");
      this.nud_SmartBeaconing2_TurnSlope.DataBindings.Add("Value", (object) this.db, "SmartBeaconing2_TurnSlope");
      this.nud_SmartBeaconing2_TurnTime.DataBindings.Add("Value", (object) this.db, "SmartBeaconing2_TurnTime");
      this.nud_SmartBeaconing3_LowSpeed.DataBindings.Add("Value", (object) this.db, "SmartBeaconing3_LowSpeed");
      this.nud_SmartBeaconing3_HighSpeed.DataBindings.Add("Value", (object) this.db, "SmartBeaconing3_HighSpeed");
      this.nud_SmartBeaconing3_SlowRate.DataBindings.Add("Value", (object) this.db, "SmartBeaconing3_SlowRate");
      this.nud_SmartBeaconing3_FastRate.DataBindings.Add("Value", (object) this.db, "SmartBeaconing3_FastRate");
      this.nud_SmartBeaconing3_TurnAngle.DataBindings.Add("Value", (object) this.db, "SmartBeaconing3_TurnAngle");
      this.nud_SmartBeaconing3_TurnSlope.DataBindings.Add("Value", (object) this.db, "SmartBeaconing3_TurnSlope");
      this.nud_SmartBeaconing3_TurnTime.DataBindings.Add("Value", (object) this.db, "SmartBeaconing3_TurnTime");
      for (int index = 0; index < this.CallsignCodeArray.Length; ++index)
      {
        if (this.CallsignCodeArray[index].TextLength == 0)
        {
          this.CallsignSsIdArray[index].SelectedIndex = 0;
          this.CallsignSsIdArray[index].Enabled = false;
        }
        else
          this.CallsignSsIdArray[index].Enabled = true;
      }
    }

    private void dgvTxtBoxInit(DataGridView dgv, string rName)
    {
      ResourceManager resourceManager = new ResourceManager("Ftm400dAdms7.Strings", typeof (DataForm).Assembly);
      DataGridViewTextBoxColumn viewTextBoxColumn = new DataGridViewTextBoxColumn();
      viewTextBoxColumn.HeaderText = resourceManager.GetString(rName);
      dgv.Columns.Add((DataGridViewColumn) viewTextBoxColumn);
    }

    private void SetForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      this.tbc_Setting.Focus();
    }

    private void rdb_FuncSet_CheckedChanged(object sender, EventArgs e)
    {
      this.txt_FuncSet_Array1.BackColor = Color.FromKnownColor(KnownColor.Control);
      this.txt_FuncSet_Array2.BackColor = Color.FromKnownColor(KnownColor.Control);
      this.txt_FuncSet_Array3.BackColor = Color.FromKnownColor(KnownColor.Control);
      this.txt_FuncSet_Array4.BackColor = Color.FromKnownColor(KnownColor.Control);
      if (this.rdb_FuncSet_Array1.Checked)
        this.txt_FuncSet_Array1.BackColor = Color.FromKnownColor(KnownColor.Window);
      else if (this.rdb_FuncSet_Array2.Checked)
        this.txt_FuncSet_Array2.BackColor = Color.FromKnownColor(KnownColor.Window);
      else if (this.rdb_FuncSet_Array3.Checked)
      {
        this.txt_FuncSet_Array3.BackColor = Color.FromKnownColor(KnownColor.Window);
      }
      else
      {
        if (!this.rdb_FuncSet_Array4.Checked)
          return;
        this.txt_FuncSet_Array4.BackColor = Color.FromKnownColor(KnownColor.Window);
      }
    }

    private void btn_FuncSet_Click(object sender, EventArgs e)
    {
      if (this.rdb_FuncSet_Array1.Checked)
      {
        this.txt_FuncSet_Array1.Text = ((Control) sender).Text;
        for (int index = 0; index < this.FuncSetArray.Length; ++index)
        {
          if (this.txt_FuncSet_Array1.Text == this.FuncSetArray[index].Text)
            this.db.FuncSet_Array1 = index;
        }
      }
      else if (this.rdb_FuncSet_Array2.Checked)
      {
        this.txt_FuncSet_Array2.Text = ((Control) sender).Text;
        for (int index = 0; index < this.FuncSetArray.Length; ++index)
        {
          if (this.txt_FuncSet_Array2.Text == this.FuncSetArray[index].Text)
            this.db.FuncSet_Array2 = index;
        }
      }
      else if (this.rdb_FuncSet_Array3.Checked)
      {
        this.txt_FuncSet_Array3.Text = ((Control) sender).Text;
        for (int index = 0; index < this.FuncSetArray.Length; ++index)
        {
          if (this.txt_FuncSet_Array3.Text == this.FuncSetArray[index].Text)
            this.db.FuncSet_Array3 = index;
        }
      }
      else if (this.rdb_FuncSet_Array4.Checked)
      {
        this.txt_FuncSet_Array4.Text = ((Control) sender).Text;
        for (int index = 0; index < this.FuncSetArray.Length; ++index)
        {
          if (this.txt_FuncSet_Array4.Text == this.FuncSetArray[index].Text)
            this.db.FuncSet_Array4 = index;
        }
      }
      foreach (Button funcSet in this.FuncSetArray)
      {
        funcSet.Enabled = true;
        foreach (TextBox textBox in this.FuncSetlist)
        {
          if (funcSet.Text == textBox.Text)
            funcSet.Enabled = false;
        }
      }
    }

    private void rdb_MySymbol_CheckedChanged(object sender, EventArgs e)
    {
      int num = 0;
      if (this.rdb_MySymbol_1_Sel.Checked)
        num = 0;
      else if (this.rdb_MySymbol_2_Sel.Checked)
        num = 1;
      else if (this.rdb_MySymbol_3_Sel.Checked)
        num = 2;
      else if (this.rdb_MySymbol_4_Sel.Checked)
        num = 3;
      this.db.MySymbol_Sel = num;
    }

    private void rdb_AprsMsgText_CheckedChanged(object sender, EventArgs e)
    {
      int num = 0;
      if (this.rdb_AprsMsgText_1_No.Checked)
        num = 0;
      else if (this.rdb_AprsMsgText_2_No.Checked)
        num = 1;
      else if (this.rdb_AprsMsgText_3_No.Checked)
        num = 2;
      else if (this.rdb_AprsMsgText_4_No.Checked)
        num = 3;
      else if (this.rdb_AprsMsgText_5_No.Checked)
        num = 4;
      else if (this.rdb_AprsMsgText_6_No.Checked)
        num = 5;
      else if (this.rdb_AprsMsgText_7_No.Checked)
        num = 6;
      else if (this.rdb_AprsMsgText_8_No.Checked)
        num = 7;
      this.db.AprsMsgText_Sel = num;
    }

    private void rdb_MyPosition_CheckedChanged(object sender, EventArgs e)
    {
      int num = 0;
      if (this.rdb_MyPosition_Gps.Checked)
        num = 0;
      else if (this.rdb_MyPosition_Manual.Checked)
        num = 1;
      this.db.MyPosition_Sel = num;
    }

    private void rdb_BeaconStatusText_CheckedChanged(object sender, EventArgs e)
    {
      int num = 0;
      if (this.rdb_BeaconStatusText_Off.Checked)
        num = 0;
      else if (this.rdb_BeaconStatusText_1.Checked)
        num = 1;
      else if (this.rdb_BeaconStatusText_2.Checked)
        num = 2;
      else if (this.rdb_BeaconStatusText_3.Checked)
        num = 3;
      else if (this.rdb_BeaconStatusText_4.Checked)
        num = 4;
      else if (this.rdb_BeaconStatusText_5.Checked)
        num = 5;
      this.db.BeaconStatusText_Sel = num;
    }

    private void rdb_DigiPath_CheckedChanged(object sender, EventArgs e)
    {
      int num = 0;
      if (this.rdb_DigiPath_Off.Checked)
        num = 0;
      else if (this.rdb_DigiPath_1Wide.Checked)
        num = 1;
      else if (this.rdb_DigiPath_2Wide.Checked)
        num = 2;
      else if (this.rdb_DigiPath_P1.Checked)
        num = 3;
      else if (this.rdb_DigiPath_P2.Checked)
        num = 4;
      else if (this.rdb_DigiPath_P3.Checked)
        num = 5;
      else if (this.rdb_DigiPath_P4.Checked)
        num = 6;
      else if (this.rdb_DigiPath_F1.Checked)
        num = 7;
      else if (this.rdb_DigiPath_F2.Checked)
        num = 8;
      this.db.DigiPath_Sel = num;
    }

    private void btn_MySymbol_Click(object sender, EventArgs e)
    {
      int index = 0;
      if ((Button) sender == this.btn_MySymbol_1)
        index = this.cmb_MySymbol_1_Icn.SelectedIndex;
      else if ((Button) sender == this.btn_MySymbol_2)
        index = this.cmb_MySymbol_2_Icn.SelectedIndex;
      else if ((Button) sender == this.btn_MySymbol_3)
        index = this.cmb_MySymbol_3_Icn.SelectedIndex;
      SymbolForm symbolForm = new SymbolForm(index);
      int num = (int) symbolForm.ShowDialog();
      symbolForm.Dispose();
    }

    private void txt_CallsignCode_TextChanged(object sender, EventArgs e)
    {
      for (int index = 0; index < this.CallsignCodeArray.Length; ++index)
      {
        if ((TextBox) sender == this.CallsignCodeArray[index])
        {
          if (((TextBoxBase) sender).TextLength == 0)
          {
            this.CallsignSsIdArray[index].SelectedIndex = 0;
            switch (index)
            {
              case 0:
                this.db.AprsCommon_CallsignSsId = 0;
                break;
              case 1:
                this.db.MsgReply_CallSignSsId = 0;
                break;
              case 2:
                this.db.DigiPathSsId_P11 = 0;
                break;
              case 3:
                this.db.DigiPathSsId_P12 = 0;
                break;
              case 4:
                this.db.DigiPathSsId_P21 = 0;
                break;
              case 5:
                this.db.DigiPathSsId_P22 = 0;
                break;
              case 6:
                this.db.DigiPathSsId_P31 = 0;
                break;
              case 7:
                this.db.DigiPathSsId_P32 = 0;
                break;
              case 8:
                this.db.DigiPathSsId_P41 = 0;
                break;
              case 9:
                this.db.DigiPathSsId_P42 = 0;
                break;
              case 10:
                this.db.DigiPathSsId_F11 = 0;
                break;
              case 11:
                this.db.DigiPathSsId_F12 = 0;
                break;
              case 12:
                this.db.DigiPathSsId_F13 = 0;
                break;
              case 13:
                this.db.DigiPathSsId_F14 = 0;
                break;
              case 14:
                this.db.DigiPathSsId_F15 = 0;
                break;
              case 15:
                this.db.DigiPathSsId_F16 = 0;
                break;
              case 16:
                this.db.DigiPathSsId_F17 = 0;
                break;
              case 17:
                this.db.DigiPathSsId_F18 = 0;
                break;
              case 18:
                this.db.DigiPathSsId_F21 = 0;
                break;
              case 19:
                this.db.DigiPathSsId_F22 = 0;
                break;
              case 20:
                this.db.DigiPathSsId_F23 = 0;
                break;
              case 21:
                this.db.DigiPathSsId_F24 = 0;
                break;
              case 22:
                this.db.DigiPathSsId_F25 = 0;
                break;
              case 23:
                this.db.DigiPathSsId_F26 = 0;
                break;
              case 24:
                this.db.DigiPathSsId_F27 = 0;
                break;
              case 25:
                this.db.DigiPathSsId_F28 = 0;
                break;
              case 26:
                this.db.AprsRingerCallSsID_1 = 0;
                break;
              case 27:
                this.db.AprsRingerCallSsID_2 = 0;
                break;
              case 28:
                this.db.AprsRingerCallSsID_3 = 0;
                break;
              case 29:
                this.db.AprsRingerCallSsID_4 = 0;
                break;
              case 30:
                this.db.AprsRingerCallSsID_5 = 0;
                break;
              case 31:
                this.db.AprsRingerCallSsID_6 = 0;
                break;
              case 32:
                this.db.AprsRingerCallSsID_7 = 0;
                break;
              case 33:
                this.db.AprsRingerCallSsID_8 = 0;
                break;
            }
            this.CallsignSsIdArray[index].Enabled = false;
          }
          else
            this.CallsignSsIdArray[index].Enabled = true;
        }
      }
    }

    private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      if (dataGridView == this.dgv_DtmfMemory)
      {
        if (!(e.Control is DataGridViewTextBoxEditingControl))
          return;
        DataGridViewTextBoxEditingControl control = (DataGridViewTextBoxEditingControl) e.Control;
        control.KeyPress -= new KeyPressEventHandler(KeyPressCancel.txt_Dtmf_KeyPress);
        if (dataGridView.CurrentCell.ColumnIndex != 1)
          return;
        control.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_Dtmf_KeyPress);
      }
      else if (dataGridView == this.dgv_Category)
      {
        if (!(e.Control is DataGridViewTextBoxEditingControl))
          return;
        DataGridViewTextBoxEditingControl control = (DataGridViewTextBoxEditingControl) e.Control;
        control.KeyPress -= new KeyPressEventHandler(KeyPressCancel.txt_CategoryName_KeyPress);
        if (dataGridView.CurrentCell.ColumnIndex != 1)
          return;
        control.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_CategoryName_KeyPress);
      }
      else
      {
        if (dataGridView != this.dgv_MsgText || !(e.Control is DataGridViewTextBoxEditingControl))
          return;
        DataGridViewTextBoxEditingControl control = (DataGridViewTextBoxEditingControl) e.Control;
        control.KeyPress -= new KeyPressEventHandler(KeyPressCancel.txt_MessageText_KeyPress);
        if (dataGridView.CurrentCell.ColumnIndex != 1)
          return;
        control.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_MessageText_KeyPress);
      }
    }

    private bool isNullOrBlank(string str)
    {
      return str == "" || str == null;
    }

    private void changeMicPGMKeyList(ComboBox micProgKey)
    {
      string text = micProgKey.Text;
      micProgKey.Items.Clear();
      micProgKey.Items.AddRange((object[]) SetForm.GetMicPGMKey());
      if (Array.IndexOf<string>(SetForm.GetMicPGMKey(), text) == -1)
        micProgKey.Text = "OFF";
      else
        micProgKey.Text = text;
    }

    private void nud_WiresX_PresetFreq_ValueChanged(object sender, EventArgs e)
    {
      Decimal num = this.nud_WiresX_PresetFreq.Value;
      int mtxPtn = Settings.Instance.MtxPTN;
      if (SetForm.tbl_PresetFreq[mtxPtn, 0] <= num && num < SetForm.tbl_PresetFreq[mtxPtn, 1])
        this.nud_WiresX_PresetFreq.Increment = SetForm.tbl_PresetFreq[mtxPtn, 4];
      else if (SetForm.tbl_PresetFreq[mtxPtn, 2] <= num && num < SetForm.tbl_PresetFreq[mtxPtn, 3])
        this.nud_WiresX_PresetFreq.Increment = SetForm.tbl_PresetFreq[mtxPtn, 5];
      else if (num <= (SetForm.tbl_PresetFreq[mtxPtn, 1] + SetForm.tbl_PresetFreq[mtxPtn, 2]) / new Decimal(2))
      {
        this.nud_WiresX_PresetFreq.Value = SetForm.tbl_PresetFreq[mtxPtn, 2];
        this.nud_WiresX_PresetFreq.Increment = SetForm.tbl_PresetFreq[mtxPtn, 5];
      }
      else
      {
        if (!(num > (SetForm.tbl_PresetFreq[mtxPtn, 1] + SetForm.tbl_PresetFreq[mtxPtn, 2]) / new Decimal(2)))
          return;
        this.nud_WiresX_PresetFreq.Value = SetForm.tbl_PresetFreq[mtxPtn, 1] - SetForm.tbl_PresetFreq[mtxPtn, 4];
        this.nud_WiresX_PresetFreq.Increment = SetForm.tbl_PresetFreq[mtxPtn, 4];
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SetForm));
      this.tab_AprsBcn = new TabPage();
      this.grb_SmartBeaconing = new GroupBox();
      this.cmb_SmartBeaconing_Select = new ComboBox();
      this.lbl_SmartBeaconing_Select = new Label();
      this.label184 = new Label();
      this.label185 = new Label();
      this.label186 = new Label();
      this.label187 = new Label();
      this.label188 = new Label();
      this.label189 = new Label();
      this.label190 = new Label();
      this.label191 = new Label();
      this.label192 = new Label();
      this.label193 = new Label();
      this.label194 = new Label();
      this.label195 = new Label();
      this.label196 = new Label();
      this.label197 = new Label();
      this.label198 = new Label();
      this.label199 = new Label();
      this.label200 = new Label();
      this.label201 = new Label();
      this.grb_SmartBeaconing1 = new GroupBox();
      this.nud_SmartBeaconing1_TurnTime = new NumericUpDown();
      this.lbl_SmartBeaconing1_TurnTimeUnit = new Label();
      this.nud_SmartBeaconing1_TurnSlope = new NumericUpDown();
      this.lbl_SmartBeaconing1_TurnAngleUnit = new Label();
      this.nud_SmartBeaconing1_TurnAngle = new NumericUpDown();
      this.lbl_SmartBeaconing1_FastRateUnit = new Label();
      this.nud_SmartBeaconing1_FastRate = new NumericUpDown();
      this.lbl_SmartBeaconing1_SlowRateUnit = new Label();
      this.nud_SmartBeaconing1_SlowRate = new NumericUpDown();
      this.lbl_SmartBeaconing1_LowSpeedUnit = new Label();
      this.nud_SmartBeaconing1_HighSpeed = new NumericUpDown();
      this.lbl_SmartBeaconing1_HighSpeedUnit = new Label();
      this.nud_SmartBeaconing1_LowSpeed = new NumericUpDown();
      this.lbl_SmartBeaconing1_Type = new Label();
      this.lbl_SmartBeaconing1_LowSpeed = new Label();
      this.lbl_SmartBeaconing1_TurnTime = new Label();
      this.lbl_SmartBeaconing1_TurnSlope = new Label();
      this.lbl_SmartBeaconing1_TurnAngle = new Label();
      this.lbl_SmartBeaconing1_FastRate = new Label();
      this.lbl_SmartBeaconing1_SlowRate = new Label();
      this.lbl_SmartBeaconing1_HighSpeed = new Label();
      this.grb_SmartBeaconing2 = new GroupBox();
      this.nud_SmartBeaconing2_TurnTime = new NumericUpDown();
      this.lbl_SmartBeaconing2_TurnTimeUnit = new Label();
      this.nud_SmartBeaconing2_TurnSlope = new NumericUpDown();
      this.lbl_SmartBeaconing2_TurnAngleUnit = new Label();
      this.nud_SmartBeaconing2_TurnAngle = new NumericUpDown();
      this.lbl_SmartBeaconing2_FastRateUnit = new Label();
      this.nud_SmartBeaconing2_FastRate = new NumericUpDown();
      this.lbl_SmartBeaconing2_SlowRateUnit = new Label();
      this.nud_SmartBeaconing2_SlowRate = new NumericUpDown();
      this.lbl_SmartBeaconing2_LowSpeedUnit = new Label();
      this.nud_SmartBeaconing2_HighSpeed = new NumericUpDown();
      this.lbl_SmartBeaconing2_HighSpeedUnit = new Label();
      this.nud_SmartBeaconing2_LowSpeed = new NumericUpDown();
      this.lbl_SmartBeaconing2_Type = new Label();
      this.lbl_SmartBeaconing2_LowSpeed = new Label();
      this.lbl_SmartBeaconing2_TurnTime = new Label();
      this.lbl_SmartBeaconing2_TurnSlope = new Label();
      this.lbl_SmartBeaconing2_TurnAngle = new Label();
      this.lbl_SmartBeaconing2_FastRate = new Label();
      this.lbl_SmartBeaconing2_SlowRate = new Label();
      this.lbl_SmartBeaconing2_HighSpeed = new Label();
      this.grb_SmartBeaconing3 = new GroupBox();
      this.nud_SmartBeaconing3_TurnTime = new NumericUpDown();
      this.lbl_SmartBeaconing3_TurnTimeUnit = new Label();
      this.nud_SmartBeaconing3_TurnSlope = new NumericUpDown();
      this.lbl_SmartBeaconing3_TurnAngleUnit = new Label();
      this.nud_SmartBeaconing3_TurnAngle = new NumericUpDown();
      this.lbl_SmartBeaconing3_FastRateUnit = new Label();
      this.nud_SmartBeaconing3_FastRate = new NumericUpDown();
      this.lbl_SmartBeaconing3_SlowRateUnit = new Label();
      this.nud_SmartBeaconing3_SlowRate = new NumericUpDown();
      this.lbl_SmartBeaconing3_SlowSpeedUnit = new Label();
      this.nud_SmartBeaconing3_HighSpeed = new NumericUpDown();
      this.lbl_SmartBeaconing3_HighSpeedUnit = new Label();
      this.nud_SmartBeaconing3_LowSpeed = new NumericUpDown();
      this.lbl_SmartBeaconing3_Type = new Label();
      this.lbl_SmartBeaconing3_SlowSpeed = new Label();
      this.lbl_SmartBeaconing3_TurnTime = new Label();
      this.lbl_SmartBeaconing3_TurnSlope = new Label();
      this.lbl_SmartBeaconing3_TurnAngle = new Label();
      this.lbl_SmartBeaconing3_FastRate = new Label();
      this.lbl_SmartBeaconing3_SlowRate = new Label();
      this.lbl_SmartBeaconing3_HighSpeed = new Label();
      this.grb_BeaconStatusText = new GroupBox();
      this.rdb_BeaconStatusText_Off = new RadioButton();
      this.cmb_BeaconStatusText_5_Mode = new ComboBox();
      this.cmb_BeaconStatusText_4_Mode = new ComboBox();
      this.cmb_BeaconStatusText_3_Mode = new ComboBox();
      this.cmb_BeaconStatusText_2_Mode = new ComboBox();
      this.cmb_BeaconStatusText_1_Mode = new ComboBox();
      this.cmb_BeaconStatusText_TxRate = new ComboBox();
      this.lbl_BeaconStatusText_TxRate = new Label();
      this.txt_BeaconStatusText_5 = new TextBox();
      this.txt_BeaconStatusText_4 = new TextBox();
      this.txt_BeaconStatusText_3 = new TextBox();
      this.txt_BeaconStatusText_2 = new TextBox();
      this.txt_BeaconStatusText_1 = new TextBox();
      this.rdb_BeaconStatusText_5 = new RadioButton();
      this.rdb_BeaconStatusText_4 = new RadioButton();
      this.rdb_BeaconStatusText_3 = new RadioButton();
      this.rdb_BeaconStatusText_2 = new RadioButton();
      this.rdb_BeaconStatusText_1 = new RadioButton();
      this.grp_AprsRingerCall = new GroupBox();
      this.lbl_AprsRingerCall_8 = new Label();
      this.cmb_AprsRingerCallSsId_8 = new ComboBox();
      this.txt_AprsRingerCallCode_8 = new TextBox();
      this.cmb_AprsRingerCallSsId_7 = new ComboBox();
      this.txt_AprsRingerCallCode_7 = new TextBox();
      this.lbl_AprsRingerCall_7 = new Label();
      this.cmb_AprsRingerCallSsId_6 = new ComboBox();
      this.txt_AprsRingerCallCode_1 = new TextBox();
      this.cmb_AprsRingerCallSsId_5 = new ComboBox();
      this.txt_AprsRingerCallCode_6 = new TextBox();
      this.lbl_AprsRingerCall_6 = new Label();
      this.cmb_AprsRingerCallSsId_4 = new ComboBox();
      this.lbl_AprsRingerCall_1 = new Label();
      this.lbl_AprsRingerCall_3 = new Label();
      this.txt_AprsRingerCallCode_2 = new TextBox();
      this.lbl_AprsRingerCall_2 = new Label();
      this.cmb_AprsRingerCallSsId_3 = new ComboBox();
      this.lbl_AprsRingerCall_5 = new Label();
      this.txt_AprsRingerCallCode_5 = new TextBox();
      this.lbl_AprsRingerCall_4 = new Label();
      this.cmb_AprsRingerCallSsId_2 = new ComboBox();
      this.txt_AprsRingerCallCode_3 = new TextBox();
      this.cmb_AprsRingerCallSsId_1 = new ComboBox();
      this.txt_AprsRingerCallCode_4 = new TextBox();
      this.grb_AprsRinger = new GroupBox();
      this.cmb_AprsRinger_MsgVc = new ComboBox();
      this.lbl_AprsRinger_MsgVc = new Label();
      this.cmb_AprsRinger_MyPacket = new ComboBox();
      this.lbl_AprsRinger_MyPacket = new Label();
      this.cmb_AprsRinger_RngRbgr = new ComboBox();
      this.lbl_AprsRinger_RngRbgr = new Label();
      this.cmb_AprsRinger_CllRngr = new ComboBox();
      this.lbl_AprsRinger_CllRngr = new Label();
      this.cmb_AprsRinger_RxMsg = new ComboBox();
      this.lbl_AprsRinger_RxMsg = new Label();
      this.cmb_AprsRinger_RxBcn = new ComboBox();
      this.lbl_AprsRinger_RxBcn = new Label();
      this.cmb_AprsRinger_TxMsg = new ComboBox();
      this.lbl_AprsRinger_TxMsg = new Label();
      this.cmb_AprsRinger_TxBcn = new ComboBox();
      this.lbl_AprsRinger_TxBcn = new Label();
      this.grb_AprsUnit = new GroupBox();
      this.cmb_AprsUnit_Baro = new ComboBox();
      this.lbl_AprsUnit_Baro = new Label();
      this.cmb_AprsUnit_Wind = new ComboBox();
      this.lbl_AprsUnit_Wind = new Label();
      this.cmb_AprsUnit_Rain = new ComboBox();
      this.lbl_AprsUnit_Rain = new Label();
      this.cmb_AprsUnit_Altitude = new ComboBox();
      this.lbl_AprsUnit_Altitude = new Label();
      this.cmb_AprsUnit_Temp = new ComboBox();
      this.lbl_AprsUnit_Temp = new Label();
      this.cmb_AprsUnit_Speed = new ComboBox();
      this.lbl_AprsUnit_Speed = new Label();
      this.cmb_AprsUnit_Distance = new ComboBox();
      this.lbl_AprsUnit_Distance = new Label();
      this.cmb_AprsUnit_Position = new ComboBox();
      this.lbl_AprsUnit_Position = new Label();
      this.grb_AprsFilter = new GroupBox();
      this.cmb_AprsFilter_RangeLimit = new ComboBox();
      this.lbl_AprsFilter_RangeLimit = new Label();
      this.cmb_AprsFilter_Altnet = new ComboBox();
      this.lbl_AprsFilter_Altnet = new Label();
      this.cmb_AprsFilter_Other = new ComboBox();
      this.lbl_AprsFilter_Other = new Label();
      this.cmb_AprsFilter_Status = new ComboBox();
      this.lbl_AprsFilter_Status = new Label();
      this.cmb_AprsFilter_Object = new ComboBox();
      this.lbl_AprsFilter_Object = new Label();
      this.cmb_AprsFilter_Item = new ComboBox();
      this.lbl_AprsFilter_Item = new Label();
      this.cmb_AprsFilter_Weather = new ComboBox();
      this.lbl_AprsFilter_Weather = new Label();
      this.cmb_AprsFilter_Position = new ComboBox();
      this.lbl_AprsFilter_Position = new Label();
      this.cmb_AprsFilter_MicE = new ComboBox();
      this.lbl_AprsFilter_MicE = new Label();
      this.tab_AprsGps = new TabPage();
      this.grb_MyPosition = new GroupBox();
      this.nud_MyPosition_ManualLonMM2 = new NumericUpDown();
      this.cmb_MyPosition_ManualLon = new ComboBox();
      this.nud_MyPosition_ManualLatMM2 = new NumericUpDown();
      this.cmb_MyPosition_ManualLat = new ComboBox();
      this.label233 = new Label();
      this.label230 = new Label();
      this.label234 = new Label();
      this.label229 = new Label();
      this.nud_MyPosition_ManualLonMM1 = new NumericUpDown();
      this.rdb_MyPosition_Manual = new RadioButton();
      this.nud_MyPosition_ManualLatMM1 = new NumericUpDown();
      this.rdb_MyPosition_Gps = new RadioButton();
      this.nud_MyPosition_ManualLonDD = new NumericUpDown();
      this.nud_MyPosition_ManualLatDD = new NumericUpDown();
      this.label232 = new Label();
      this.label231 = new Label();
      this.grp_VoiceAleat = new GroupBox();
      this.lbl_VoiceAleat_Dcs = new Label();
      this.cmb_VoiceAleat_Dcs = new ComboBox();
      this.lbl_VoiceAleat_ToneSql = new Label();
      this.cmb_VoiceAleat_ToneSql = new ComboBox();
      this.lbl_VoiceAleat_VoiceAleat = new Label();
      this.cmb_VoiceAleat_VoiceAleat = new ComboBox();
      this.grp_SortFilter = new GroupBox();
      this.lbl_SortFilter_Filter = new Label();
      this.cmb_SortFilter_Filter = new ComboBox();
      this.lbl_SortFilter_Sort = new Label();
      this.cmb_SortFilter_Sort = new ComboBox();
      this.grp_AprsPopupColor = new GroupBox();
      this.cmb_AprsPopupColor_MyPckt = new ComboBox();
      this.lbl_AprsPopupColor_MyPckt = new Label();
      this.cmb_AprsPopupColor_GrpBult = new ComboBox();
      this.lbl_AprsPopupColor_GrpBult = new Label();
      this.cmb_AprsPopupColor_Msg = new ComboBox();
      this.lbl_AprsPopupColor_Msg = new Label();
      this.cmb_AprsPopupColor_CllRngr = new ComboBox();
      this.lbl_AprsPopupColor_CllRngr = new Label();
      this.cmb_AprsPopupColor_RngRngr = new ComboBox();
      this.lbl_AprsPopupColor_RngRngr = new Label();
      this.cmb_AprsPopupColor_ObjItm = new ComboBox();
      this.lbl_AprsPopupColor_ObjItm = new Label();
      this.cmb_AprsPopupColor_Mbl = new ComboBox();
      this.lbl_AprsPopupColor_Mbl = new Label();
      this.cmb_AprsPopupColor_Bcn = new ComboBox();
      this.lbl_AprsPopupColor_Bcn = new Label();
      this.grb_AprsPopup = new GroupBox();
      this.cmb_AprsPopup_Bcn = new ComboBox();
      this.lbl_AprsPopup_Bcn = new Label();
      this.cmb_AprsPopup_Msg = new ComboBox();
      this.lbl_AprsPopup_Msg = new Label();
      this.cmb_AprsPopup_MyPacket = new ComboBox();
      this.lbl_AprsPopup_MyPacket = new Label();
      this.grb_DigiPath = new GroupBox();
      this.cmb_DigiPathSsId_F28 = new ComboBox();
      this.cmb_DigiPathSsId_F27 = new ComboBox();
      this.cmb_DigiPathSsId_F26 = new ComboBox();
      this.cmb_DigiPathSsId_F25 = new ComboBox();
      this.cmb_DigiPathSsId_F24 = new ComboBox();
      this.cmb_DigiPathSsId_F23 = new ComboBox();
      this.cmb_DigiPathSsId_F22 = new ComboBox();
      this.cmb_DigiPathSsId_F21 = new ComboBox();
      this.cmb_DigiPathSsId_F18 = new ComboBox();
      this.cmb_DigiPathSsId_F17 = new ComboBox();
      this.cmb_DigiPathSsId_F16 = new ComboBox();
      this.cmb_DigiPathSsId_F15 = new ComboBox();
      this.cmb_DigiPathSsId_F14 = new ComboBox();
      this.cmb_DigiPathSsId_F13 = new ComboBox();
      this.cmb_DigiPathSsId_F12 = new ComboBox();
      this.cmb_DigiPathSsId_F11 = new ComboBox();
      this.cmb_DigiPathSsId_P42 = new ComboBox();
      this.cmb_DigiPathSsId_P32 = new ComboBox();
      this.cmb_DigiPathSsId_P22 = new ComboBox();
      this.cmb_DigiPathSsId_P12 = new ComboBox();
      this.cmb_DigiPathSsId_P41 = new ComboBox();
      this.cmb_DigiPathSsId_P31 = new ComboBox();
      this.cmb_DigiPathSsId_P21 = new ComboBox();
      this.cmb_DigiPathSsId_P11 = new ComboBox();
      this.rdb_DigiPath_F2 = new RadioButton();
      this.txt_DigiPathCode_F28 = new TextBox();
      this.txt_DigiPathCode_F27 = new TextBox();
      this.txt_DigiPathCode_F26 = new TextBox();
      this.txt_DigiPathCode_F25 = new TextBox();
      this.txt_DigiPathCode_F24 = new TextBox();
      this.txt_DigiPathCode_F23 = new TextBox();
      this.txt_DigiPathCode_F22 = new TextBox();
      this.txt_DigiPathCode_F21 = new TextBox();
      this.label182 = new Label();
      this.label183 = new Label();
      this.label180 = new Label();
      this.label181 = new Label();
      this.label178 = new Label();
      this.label179 = new Label();
      this.label176 = new Label();
      this.label177 = new Label();
      this.label174 = new Label();
      this.label175 = new Label();
      this.label172 = new Label();
      this.label173 = new Label();
      this.label170 = new Label();
      this.label171 = new Label();
      this.label168 = new Label();
      this.label169 = new Label();
      this.label167 = new Label();
      this.label166 = new Label();
      this.rdb_DigiPath_F1 = new RadioButton();
      this.rdb_DigiPath_P4 = new RadioButton();
      this.rdb_DigiPath_P3 = new RadioButton();
      this.txt_DigiPathCode_F18 = new TextBox();
      this.txt_DigiPathCode_F17 = new TextBox();
      this.txt_DigiPathCode_F16 = new TextBox();
      this.txt_DigiPathCode_F15 = new TextBox();
      this.txt_DigiPathCode_F14 = new TextBox();
      this.txt_DigiPathCode_F13 = new TextBox();
      this.txt_DigiPathCode_F12 = new TextBox();
      this.txt_DigiPathCode_F11 = new TextBox();
      this.txt_DigiPathCode_P42 = new TextBox();
      this.txt_DigiPathCode_P41 = new TextBox();
      this.txt_DigiPathCode_P32 = new TextBox();
      this.txt_DigiPathCode_P31 = new TextBox();
      this.txt_DigiPathCode_P22 = new TextBox();
      this.txt_DigiPathCode_P21 = new TextBox();
      this.txt_DigiPathCode_P12 = new TextBox();
      this.txt_DigiPathCode_P11 = new TextBox();
      this.rdb_DigiPath_P2 = new RadioButton();
      this.rdb_DigiPath_P1 = new RadioButton();
      this.rdb_DigiPath_2Wide = new RadioButton();
      this.rdb_DigiPath_1Wide = new RadioButton();
      this.rdb_DigiPath_Off = new RadioButton();
      this.grb_AprsMsgText = new GroupBox();
      this.txt_AprsMsgText_8 = new TextBox();
      this.rdb_AprsMsgText_8_No = new RadioButton();
      this.txt_AprsMsgText_7 = new TextBox();
      this.rdb_AprsMsgText_7_No = new RadioButton();
      this.txt_AprsMsgText_6 = new TextBox();
      this.rdb_AprsMsgText_6_No = new RadioButton();
      this.txt_AprsMsgText_5 = new TextBox();
      this.txt_AprsMsgText_4 = new TextBox();
      this.txt_AprsMsgText_3 = new TextBox();
      this.txt_AprsMsgText_2 = new TextBox();
      this.txt_AprsMsgText_1 = new TextBox();
      this.rdb_AprsMsgText_5_No = new RadioButton();
      this.rdb_AprsMsgText_4_No = new RadioButton();
      this.rdb_AprsMsgText_3_No = new RadioButton();
      this.rdb_AprsMsgText_2_No = new RadioButton();
      this.rdb_AprsMsgText_1_No = new RadioButton();
      this.grb_MySymbol = new GroupBox();
      this.cmb_MySymbol_42_Icn = new ComboBox();
      this.btn_MySymbol_2 = new Button();
      this.btn_MySymbol_3 = new Button();
      this.btn_MySymbol_1 = new Button();
      this.cmb_MySymbol_41_Icn = new ComboBox();
      this.cmb_MySymbol_3_Icn = new ComboBox();
      this.cmb_MySymbol_2_Icn = new ComboBox();
      this.cmb_MySymbol_1_Icn = new ComboBox();
      this.rdb_MySymbol_4_Sel = new RadioButton();
      this.rdb_MySymbol_3_Sel = new RadioButton();
      this.rdb_MySymbol_2_Sel = new RadioButton();
      this.rdb_MySymbol_1_Sel = new RadioButton();
      this.grb_AprsMsgGroup = new GroupBox();
      this.lbl_AprsMsgGroup_B3 = new Label();
      this.txt_AprsMsgGroup_G6 = new TextBox();
      this.lbl_AprsMsgGroup_B2 = new Label();
      this.txt_AprsMsgGroup_B3 = new TextBox();
      this.lbl_AprsMsgGroup_B1 = new Label();
      this.txt_AprsMsgGroup_B2 = new TextBox();
      this.lbl_AprsMsgGroup_G6 = new Label();
      this.txt_AprsMsgGroup_B1 = new TextBox();
      this.lbl_AprsMsgGroup_G5 = new Label();
      this.txt_AprsMsgGroup_G5 = new TextBox();
      this.lbl_AprsMsgGroup_G4 = new Label();
      this.txt_AprsMsgGroup_G4 = new TextBox();
      this.lbl_AprsMsgGroup_G3 = new Label();
      this.txt_AprsMsgGroup_G3 = new TextBox();
      this.lbl_AprsMsgGroup_G2 = new Label();
      this.txt_AprsMsgGroup_G2 = new TextBox();
      this.lbl_AprsMsgGroup_G1 = new Label();
      this.txt_AprsMsgGroup_G1 = new TextBox();
      this.grb_MsgReply = new GroupBox();
      this.cmb_MsgReply_CallSignSsId = new ComboBox();
      this.txt_MsgReply_CallSignCode = new TextBox();
      this.txt_MsgReply_ReplyText = new TextBox();
      this.lbl_MsgReply_ReplyText = new Label();
      this.lbl_MsgReply_CallSign = new Label();
      this.cmb_MsgReply_Reply = new ComboBox();
      this.lbl_MsgReply_Reply = new Label();
      this.grb_AprsCommon = new GroupBox();
      this.cmb_AprsCommon_CallsignSsId = new ComboBox();
      this.cmb_AprsCommon_RtLmt = new ComboBox();
      this.lbl_AprsCommon_RtLmt = new Label();
      this.cmb_AprsCommon_Intrvl = new ComboBox();
      this.lbl_AprsCommon_Intrvl = new Label();
      this.cmb_AprsCommon_LwSpd = new ComboBox();
      this.lbl_AprsCommon_LwSpd = new Label();
      this.cmb_AprsCommon_Dcy = new ComboBox();
      this.lbl_AprsCommon_Dcy = new Label();
      this.cmb_AprsCommon_Prprtnl = new ComboBox();
      this.lbl_AprsCommon_Prprtnl = new Label();
      this.cmb_AprsCommon_Auto = new ComboBox();
      this.lbl_AprsCommon_Auto = new Label();
      this.lbl_AprsCommon_BcnTx = new Label();
      this.cmb_AprsCommon_Alttd = new ComboBox();
      this.lbl_AprsCommon_Alttd = new Label();
      this.cmb_AprsCommon_SpdCrc = new ComboBox();
      this.lbl_AprsCommon_SpdCrc = new Label();
      this.cmb_AprsCommon_Ambgty = new ComboBox();
      this.lbl_AprsCommon_Ambgty = new Label();
      this.lbl_AprsCommon_BcnInfoSlct = new Label();
      this.cmb_AprsCommon_Dst = new ComboBox();
      this.lbl_AprsCommon_Dst = new Label();
      this.cmb_AprsCommon_PstnCmnt = new ComboBox();
      this.lbl_AprsCommon_PstnCmnt = new Label();
      this.txt_AprsCommon_CallsignCode = new TextBox();
      this.lbl_AprsCommon_Callsign = new Label();
      this.cmb_AprsCommon_TxDelay = new ComboBox();
      this.lbl_AprsCommon_TxDelay = new Label();
      this.cmb_AprsCommon_Mute = new ComboBox();
      this.lbl_AprsCommon_Mute = new Label();
      this.cmb_AprsCommon_Modem = new ComboBox();
      this.lbl_AprsCommon_Modem = new Label();
      this.cmb_AprsCommon_Cmps = new ComboBox();
      this.lbl_AprsCommon_Cmps = new Label();
      this.tab_GmWiresX = new TabPage();
      this.grp_MsgText = new GroupBox();
      this.dgv_MsgText = new DataGridView();
      this.grb_Category = new GroupBox();
      this.dgv_Category = new DataGridView();
      this.grb_WiresX = new GroupBox();
      this.lbl_WiresX_PresetFreqUnit = new Label();
      this.nud_WiresX_PresetFreq = new NumericUpDown();
      this.lbl_WiresX_PresetFreq = new Label();
      this.cmb_WiresX_DgID = new ComboBox();
      this.lbl_WiresX_DgID = new Label();
      this.cmb_WiresX_RptWiresFreq = new ComboBox();
      this.lbl_WiresX_RptWiresFreq = new Label();
      this.grb_Gm = new GroupBox();
      this.cmb_Gm_RangeRinger = new ComboBox();
      this.lbl_Gm_RangeRinger = new Label();
      this.txt_Gm_CallSign = new TextBox();
      this.lbl_Gm_CallSign = new Label();
      this.grb_Digital = new GroupBox();
      this.cmb_Digital_StandbyBeep = new ComboBox();
      this.lbl_Digital_StandbyBeep = new Label();
      this.cmb_Digital_TxDgID = new ComboBox();
      this.lbl_Digital_TxDgID = new Label();
      this.cmb_Digital_AmsTxMode = new ComboBox();
      this.lbl_Digital_TxMode = new Label();
      this.cmb_Digital_LocationService = new ComboBox();
      this.lbl_Digital_LocationService = new Label();
      this.cmb_Digital_Popup = new ComboBox();
      this.lbl_Digital_Popup = new Label();
      this.cmb_Digital_RxDgID = new ComboBox();
      this.lbl_Digital_RxDgID = new Label();
      this.tab_NormalSetting = new TabPage();
      this.grb_FuncSet = new GroupBox();
      this.rdb_FuncSet_Array4 = new RadioButton();
      this.rdb_FuncSet_Array3 = new RadioButton();
      this.rdb_FuncSet_Array2 = new RadioButton();
      this.rdb_FuncSet_Array1 = new RadioButton();
      this.txt_FuncSet_Array4 = new TextBox();
      this.txt_FuncSet_Array3 = new TextBox();
      this.txt_FuncSet_Array2 = new TextBox();
      this.txt_FuncSet_Array1 = new TextBox();
      this.btn_FuncSet_Stop = new Button();
      this.btn_FuncSet_Play = new Button();
      this.btn_FuncSet_PTA = new Button();
      this.btn_FuncSet_Rec = new Button();
      this.btn_FuncSet_Voise = new Button();
      this.btn_FuncSet_xClr = new Button();
      this.btn_FuncSet_BeaconTx = new Button();
      this.btn_FuncSet_Beacon = new Button();
      this.btn_FuncSet_Msg = new Button();
      this.btn_FuncSet_SList = new Button();
      this.btn_FuncSet_Log = new Button();
      this.btn_FuncSet_Home = new Button();
      this.btn_FuncSet_Dtmf = new Button();
      this.btn_FuncSet_SqlNoise = new Button();
      this.btn_FuncSet_Dw = new Button();
      this.btn_FuncSet_SSO = new Button();
      this.btn_FuncSet_TxPwrHi = new Button();
      this.btn_FuncSet_10Key = new Button();
      this.btn_FuncSet_Rev = new Button();
      this.btn_FuncSet_Scan = new Button();
      this.btn_FuncSet_Scope = new Button();
      this.btn_FuncSet_Mute = new Button();
      this.btn_FuncSet_Sql = new Button();
      this.btn_FuncSet_VM = new Button();
      this.groupBox6 = new GroupBox();
      this.cmb_Signaling_WxAlrtB = new ComboBox();
      this.lbl_Signaling_WxAlrtB = new Label();
      this.cmb_Signaling_WxAlrtA = new ComboBox();
      this.lbl_Signaling_WxAlrtA = new Label();
      this.lbl_Signaling_BellRingerB = new Label();
      this.lbl_Signaling_SqlExB = new Label();
      this.cmb_Signaling_SqlExB = new ComboBox();
      this.cmb_Signaling_BellRingerB = new ComboBox();
      this.lbl_Signaling_PageTx2 = new Label();
      this.lbl_Signaling_PageTx1 = new Label();
      this.lbl_Signaling_PageRx2 = new Label();
      this.cmb_Signaling_PageTx2 = new ComboBox();
      this.cmb_Signaling_BellRingerA = new ComboBox();
      this.cmb_Signaling_SqlExA = new ComboBox();
      this.lbl_Signaling_BellRingerA = new Label();
      this.lbl_Signaling_SqlExA = new Label();
      this.cmb_Signaling_AutDialer = new ComboBox();
      this.cmb_Signaling_PageRx1 = new ComboBox();
      this.cmb_Signaling_PageRx2 = new ComboBox();
      this.lbl_Signaling_AutDialer = new Label();
      this.lbl_Signaling_PageCode = new Label();
      this.cmb_Signaling_PageTx1 = new ComboBox();
      this.lbl_Signaling_PageRx1 = new Label();
      this.groupBox2 = new GroupBox();
      this.cmb_Audio_SubBandMute = new ComboBox();
      this.cmb_Audio_MicGain = new ComboBox();
      this.lbl_Audio_MicGain = new Label();
      this.lbl_Audio_SubBandMute = new Label();
      this.grb_Option = new GroupBox();
      this.cmb_Option_RxMute = new ComboBox();
      this.lbl_Option_RxMute = new Label();
      this.cmb_Option_VcMemLng = new ComboBox();
      this.cmb_Option_VcMemVlm = new ComboBox();
      this.lbl_Option_VcMemVlm = new Label();
      this.lbl_Option_VcMemLng = new Label();
      this.cmb_Option_VcMemPR = new ComboBox();
      this.cmb_Option_VcMemAnnc = new ComboBox();
      this.lbl_Option_VcMemAnnc = new Label();
      this.lbl_Option_VcMemPR = new Label();
      this.lbl_Option_VcMem = new Label();
      this.cmb_Option_BltthVox = new ComboBox();
      this.lbl_Option_Bltth = new Label();
      this.lbl_Option_BltthVox = new Label();
      this.lbl_Option_UsbCmr = new Label();
      this.cmb_Option_BltthAudio = new ComboBox();
      this.cmb_Option_BltthBttery = new ComboBox();
      this.cmb_Option_UsbCmrSize = new ComboBox();
      this.lbl_Option_BltthBttery = new Label();
      this.cmb_Option_UsbCmrQlty = new ComboBox();
      this.lbl_Option_BltthAudio = new Label();
      this.lbl_Option_UsbCmrQlty = new Label();
      this.lbl_Option_UsbCmrSize = new Label();
      this.grb_Config = new GroupBox();
      this.lbl_Config_AtStepB = new Label();
      this.lbl_Config_AtStepA = new Label();
      this.lbl_Config_AtModeB = new Label();
      this.lbl_Config_AtModeA = new Label();
      this.cmb_Config_AtStepB = new ComboBox();
      this.cmb_Config_AtStepA = new ComboBox();
      this.cmb_Config_AtModeB = new ComboBox();
      this.cmb_Config_AtModeA = new ComboBox();
      this.lbl_Config_RxCovB = new Label();
      this.lbl_Config_AtRptShftB = new Label();
      this.cmb_Config_RxCovB = new ComboBox();
      this.cmb_Config_AtRptShftB = new ComboBox();
      this.lbl_Config_MicProgKeyP4 = new Label();
      this.lbl_Config_MicProgKeyP2 = new Label();
      this.lbl_Config_MicProgKeyP3 = new Label();
      this.cmb_Config_MicProgKeyP4 = new ComboBox();
      this.cmb_Config_MicProgKeyP2 = new ComboBox();
      this.cmb_Config_MicProgKeyP3 = new ComboBox();
      this.cmb_Config_MicProgKeyP1 = new ComboBox();
      this.lbl_Config_MicProgKeyP1 = new Label();
      this.lbl_Config_MicProgKey = new Label();
      this.cmb_Config_GpsLog = new ComboBox();
      this.cmb_Config_GpsDev = new ComboBox();
      this.cmb_Config_GpsDtm = new ComboBox();
      this.cmb_Config_Tot = new ComboBox();
      this.cmb_Config_Apo = new ComboBox();
      this.cmb_Config_Unit = new ComboBox();
      this.cmb_Config_RxCovA = new ComboBox();
      this.cmb_Config_Beep = new ComboBox();
      this.lbl_Config_TimeZone = new Label();
      this.cmb_Config_TimeZone = new ComboBox();
      this.lbl_Config_AtRptShftA = new Label();
      this.lbl_Config_GpsLog = new Label();
      this.lbl_Config_Beep = new Label();
      this.lbl_Config_GpsDev = new Label();
      this.cmb_Config_AtRptShftA = new ComboBox();
      this.lbl_Config_GpsDtm = new Label();
      this.lbl_Config_Tot = new Label();
      this.lbl_Config_Apo = new Label();
      this.lbl_Config_Unit = new Label();
      this.lbl_Config_RxCovA = new Label();
      this.cmb_Config_DtTmFrmtHr = new ComboBox();
      this.cmb_Config_DtTmFrmtDt = new ComboBox();
      this.lbl_Config_DtTmFrmt = new Label();
      this.grb_DtmfSelect = new GroupBox();
      this.dgv_DtmfMemory = new DataGridView();
      this.grb_Scan = new GroupBox();
      this.lbl_Scan_ScanRsmB = new Label();
      this.lbl_Scan_ScanDrctnB = new Label();
      this.lbl_Scan_DWStopB = new Label();
      this.cmb_Scan_DWStopB = new ComboBox();
      this.cmb_Scan_ScanDrctnB = new ComboBox();
      this.cmb_Scan_ScanRsmB = new ComboBox();
      this.lbl_Scan_DWStopA = new Label();
      this.lbl_Scan_ScanRsmA = new Label();
      this.lbl_Scan_ScanDrctnA = new Label();
      this.cmb_Scan_DWStopA = new ComboBox();
      this.cmb_Scan_ScanRsmA = new ComboBox();
      this.cmb_Scan_ScanDrctnA = new ComboBox();
      this.grb_Signaling = new GroupBox();
      this.lbl_Data_DSqlcAprs = new Label();
      this.lbl_Data_DataBandSelect = new Label();
      this.lbl_Data_ComWpFilter = new Label();
      this.lbl_Data_DSqlcData = new Label();
      this.lbl_Data_ComOutput = new Label();
      this.lbl_Data_DBandAprs = new Label();
      this.lbl_Data_DSqlc = new Label();
      this.lbl_Data_DBandData = new Label();
      this.cmb_Data_DSqlcData = new ComboBox();
      this.cmb_Data_DBandAprs = new ComboBox();
      this.cmb_Data_DBandData = new ComboBox();
      this.cmb_Data_DSqlcAprs = new ComboBox();
      this.cmb_Data_ComWpFilter = new ComboBox();
      this.cmb_Data_ComWpFormat = new ComboBox();
      this.cmb_Data_ComOutput = new ComboBox();
      this.lbl_Data_DSpeedAprs = new Label();
      this.cmb_Data_DSqlcTx = new ComboBox();
      this.lbl_Data_ComWpFormat = new Label();
      this.lbl_Data_ComSpeed = new Label();
      this.lbl_Data_DSqlcTx = new Label();
      this.lbl_Data_DSpeedData = new Label();
      this.cmb_Data_ComSpeed = new ComboBox();
      this.lbl_Data_ComPortSetting = new Label();
      this.cmb_Data_DSpeed = new Label();
      this.cmb_Data_DSpeedAprs = new ComboBox();
      this.cmb_Data_DSpeedData = new ComboBox();
      this.grb_Display = new GroupBox();
      this.cmb_Display_BandScpA = new ComboBox();
      this.lbl_Display_BandScpA = new Label();
      this.lbl_Display_DisplaySelect = new Label();
      this.cmb_Display_TimeVdd = new ComboBox();
      this.cmb_Display_Altitude = new ComboBox();
      this.cmb_Display_LcdContrast = new ComboBox();
      this.cmb_Display_TimerClk = new ComboBox();
      this.cmb_Display_LcdBrigtness = new ComboBox();
      this.lbl_Display_Altitude = new Label();
      this.cmb_Display_BandScpB = new ComboBox();
      this.lbl_Display_TimerClk = new Label();
      this.cmb_Display_BgClr = new ComboBox();
      this.lbl_Display_GpsInfo = new Label();
      this.cmb_Display_TgtLctn = new ComboBox();
      this.lbl_Display_TgtLctn = new Label();
      this.cmb_Display_GpsInfo = new ComboBox();
      this.lbl_Display_BgClr = new Label();
      this.lbl_Display_TimeVdd = new Label();
      this.lbl_Display_BandScpB = new Label();
      this.lbl_Display_LcdContrast = new Label();
      this.lbl_Display_LcdBrigtness = new Label();
      this.tbc_Setting = new TabControl();
      this.cmb_WiresX_SearchSetup = new ComboBox();
      this.lbl_WiresX_SearchSetup = new Label();
      this.tab_AprsBcn.SuspendLayout();
      this.grb_SmartBeaconing.SuspendLayout();
      this.grb_SmartBeaconing1.SuspendLayout();
      this.nud_SmartBeaconing1_TurnTime.BeginInit();
      this.nud_SmartBeaconing1_TurnSlope.BeginInit();
      this.nud_SmartBeaconing1_TurnAngle.BeginInit();
      this.nud_SmartBeaconing1_FastRate.BeginInit();
      this.nud_SmartBeaconing1_SlowRate.BeginInit();
      this.nud_SmartBeaconing1_HighSpeed.BeginInit();
      this.nud_SmartBeaconing1_LowSpeed.BeginInit();
      this.grb_SmartBeaconing2.SuspendLayout();
      this.nud_SmartBeaconing2_TurnTime.BeginInit();
      this.nud_SmartBeaconing2_TurnSlope.BeginInit();
      this.nud_SmartBeaconing2_TurnAngle.BeginInit();
      this.nud_SmartBeaconing2_FastRate.BeginInit();
      this.nud_SmartBeaconing2_SlowRate.BeginInit();
      this.nud_SmartBeaconing2_HighSpeed.BeginInit();
      this.nud_SmartBeaconing2_LowSpeed.BeginInit();
      this.grb_SmartBeaconing3.SuspendLayout();
      this.nud_SmartBeaconing3_TurnTime.BeginInit();
      this.nud_SmartBeaconing3_TurnSlope.BeginInit();
      this.nud_SmartBeaconing3_TurnAngle.BeginInit();
      this.nud_SmartBeaconing3_FastRate.BeginInit();
      this.nud_SmartBeaconing3_SlowRate.BeginInit();
      this.nud_SmartBeaconing3_HighSpeed.BeginInit();
      this.nud_SmartBeaconing3_LowSpeed.BeginInit();
      this.grb_BeaconStatusText.SuspendLayout();
      this.grp_AprsRingerCall.SuspendLayout();
      this.grb_AprsRinger.SuspendLayout();
      this.grb_AprsUnit.SuspendLayout();
      this.grb_AprsFilter.SuspendLayout();
      this.tab_AprsGps.SuspendLayout();
      this.grb_MyPosition.SuspendLayout();
      this.nud_MyPosition_ManualLonMM2.BeginInit();
      this.nud_MyPosition_ManualLatMM2.BeginInit();
      this.nud_MyPosition_ManualLonMM1.BeginInit();
      this.nud_MyPosition_ManualLatMM1.BeginInit();
      this.nud_MyPosition_ManualLonDD.BeginInit();
      this.nud_MyPosition_ManualLatDD.BeginInit();
      this.grp_VoiceAleat.SuspendLayout();
      this.grp_SortFilter.SuspendLayout();
      this.grp_AprsPopupColor.SuspendLayout();
      this.grb_AprsPopup.SuspendLayout();
      this.grb_DigiPath.SuspendLayout();
      this.grb_AprsMsgText.SuspendLayout();
      this.grb_MySymbol.SuspendLayout();
      this.grb_AprsMsgGroup.SuspendLayout();
      this.grb_MsgReply.SuspendLayout();
      this.grb_AprsCommon.SuspendLayout();
      this.tab_GmWiresX.SuspendLayout();
      this.grp_MsgText.SuspendLayout();
      ((ISupportInitialize) this.dgv_MsgText).BeginInit();
      this.grb_Category.SuspendLayout();
      ((ISupportInitialize) this.dgv_Category).BeginInit();
      this.grb_WiresX.SuspendLayout();
      this.nud_WiresX_PresetFreq.BeginInit();
      this.grb_Gm.SuspendLayout();
      this.grb_Digital.SuspendLayout();
      this.tab_NormalSetting.SuspendLayout();
      this.grb_FuncSet.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.grb_Option.SuspendLayout();
      this.grb_Config.SuspendLayout();
      this.grb_DtmfSelect.SuspendLayout();
      ((ISupportInitialize) this.dgv_DtmfMemory).BeginInit();
      this.grb_Scan.SuspendLayout();
      this.grb_Signaling.SuspendLayout();
      this.grb_Display.SuspendLayout();
      this.tbc_Setting.SuspendLayout();
      this.SuspendLayout();
      this.tab_AprsBcn.BackColor = SystemColors.Control;
      this.tab_AprsBcn.Controls.Add((Control) this.grb_SmartBeaconing);
      this.tab_AprsBcn.Controls.Add((Control) this.grb_BeaconStatusText);
      this.tab_AprsBcn.Controls.Add((Control) this.grp_AprsRingerCall);
      this.tab_AprsBcn.Controls.Add((Control) this.grb_AprsRinger);
      this.tab_AprsBcn.Controls.Add((Control) this.grb_AprsUnit);
      this.tab_AprsBcn.Controls.Add((Control) this.grb_AprsFilter);
      componentResourceManager.ApplyResources((object) this.tab_AprsBcn, "tab_AprsBcn");
      this.tab_AprsBcn.Name = "tab_AprsBcn";
      this.grb_SmartBeaconing.Controls.Add((Control) this.cmb_SmartBeaconing_Select);
      this.grb_SmartBeaconing.Controls.Add((Control) this.lbl_SmartBeaconing_Select);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label184);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label185);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label186);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label187);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label188);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label189);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label190);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label191);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label192);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label193);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label194);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label195);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label196);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label197);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label198);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label199);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label200);
      this.grb_SmartBeaconing.Controls.Add((Control) this.label201);
      this.grb_SmartBeaconing.Controls.Add((Control) this.grb_SmartBeaconing1);
      this.grb_SmartBeaconing.Controls.Add((Control) this.grb_SmartBeaconing2);
      this.grb_SmartBeaconing.Controls.Add((Control) this.grb_SmartBeaconing3);
      componentResourceManager.ApplyResources((object) this.grb_SmartBeaconing, "grb_SmartBeaconing");
      this.grb_SmartBeaconing.Name = "grb_SmartBeaconing";
      this.grb_SmartBeaconing.TabStop = false;
      this.cmb_SmartBeaconing_Select.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_SmartBeaconing_Select, "cmb_SmartBeaconing_Select");
      this.cmb_SmartBeaconing_Select.FormattingEnabled = true;
      this.cmb_SmartBeaconing_Select.Items.AddRange(new object[4]
      {
        (object) componentResourceManager.GetString("cmb_SmartBeaconing_Select.Items"),
        (object) componentResourceManager.GetString("cmb_SmartBeaconing_Select.Items1"),
        (object) componentResourceManager.GetString("cmb_SmartBeaconing_Select.Items2"),
        (object) componentResourceManager.GetString("cmb_SmartBeaconing_Select.Items3")
      });
      this.cmb_SmartBeaconing_Select.Name = "cmb_SmartBeaconing_Select";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing_Select, "lbl_SmartBeaconing_Select");
      this.lbl_SmartBeaconing_Select.Name = "lbl_SmartBeaconing_Select";
      componentResourceManager.ApplyResources((object) this.label184, "label184");
      this.label184.Name = "label184";
      componentResourceManager.ApplyResources((object) this.label185, "label185");
      this.label185.Name = "label185";
      componentResourceManager.ApplyResources((object) this.label186, "label186");
      this.label186.Name = "label186";
      componentResourceManager.ApplyResources((object) this.label187, "label187");
      this.label187.Name = "label187";
      componentResourceManager.ApplyResources((object) this.label188, "label188");
      this.label188.Name = "label188";
      componentResourceManager.ApplyResources((object) this.label189, "label189");
      this.label189.Name = "label189";
      componentResourceManager.ApplyResources((object) this.label190, "label190");
      this.label190.Name = "label190";
      componentResourceManager.ApplyResources((object) this.label191, "label191");
      this.label191.Name = "label191";
      componentResourceManager.ApplyResources((object) this.label192, "label192");
      this.label192.Name = "label192";
      componentResourceManager.ApplyResources((object) this.label193, "label193");
      this.label193.Name = "label193";
      componentResourceManager.ApplyResources((object) this.label194, "label194");
      this.label194.Name = "label194";
      componentResourceManager.ApplyResources((object) this.label195, "label195");
      this.label195.Name = "label195";
      componentResourceManager.ApplyResources((object) this.label196, "label196");
      this.label196.Name = "label196";
      componentResourceManager.ApplyResources((object) this.label197, "label197");
      this.label197.Name = "label197";
      componentResourceManager.ApplyResources((object) this.label198, "label198");
      this.label198.Name = "label198";
      componentResourceManager.ApplyResources((object) this.label199, "label199");
      this.label199.Name = "label199";
      componentResourceManager.ApplyResources((object) this.label200, "label200");
      this.label200.Name = "label200";
      componentResourceManager.ApplyResources((object) this.label201, "label201");
      this.label201.Name = "label201";
      this.grb_SmartBeaconing1.Controls.Add((Control) this.nud_SmartBeaconing1_TurnTime);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_TurnTimeUnit);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.nud_SmartBeaconing1_TurnSlope);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_TurnAngleUnit);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.nud_SmartBeaconing1_TurnAngle);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_FastRateUnit);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.nud_SmartBeaconing1_FastRate);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_SlowRateUnit);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.nud_SmartBeaconing1_SlowRate);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_LowSpeedUnit);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.nud_SmartBeaconing1_HighSpeed);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_HighSpeedUnit);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.nud_SmartBeaconing1_LowSpeed);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_Type);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_LowSpeed);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_TurnTime);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_TurnSlope);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_TurnAngle);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_FastRate);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_SlowRate);
      this.grb_SmartBeaconing1.Controls.Add((Control) this.lbl_SmartBeaconing1_HighSpeed);
      componentResourceManager.ApplyResources((object) this.grb_SmartBeaconing1, "grb_SmartBeaconing1");
      this.grb_SmartBeaconing1.Name = "grb_SmartBeaconing1";
      this.grb_SmartBeaconing1.TabStop = false;
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing1_TurnTime, "nud_SmartBeaconing1_TurnTime");
      this.nud_SmartBeaconing1_TurnTime.Maximum = new Decimal(new int[4]
      {
        180,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing1_TurnTime.Minimum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing1_TurnTime.Name = "nud_SmartBeaconing1_TurnTime";
      this.nud_SmartBeaconing1_TurnTime.Value = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_TurnTimeUnit, "lbl_SmartBeaconing1_TurnTimeUnit");
      this.lbl_SmartBeaconing1_TurnTimeUnit.Name = "lbl_SmartBeaconing1_TurnTimeUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing1_TurnSlope, "nud_SmartBeaconing1_TurnSlope");
      this.nud_SmartBeaconing1_TurnSlope.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing1_TurnSlope.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing1_TurnSlope.Name = "nud_SmartBeaconing1_TurnSlope";
      this.nud_SmartBeaconing1_TurnSlope.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_TurnAngleUnit, "lbl_SmartBeaconing1_TurnAngleUnit");
      this.lbl_SmartBeaconing1_TurnAngleUnit.Name = "lbl_SmartBeaconing1_TurnAngleUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing1_TurnAngle, "nud_SmartBeaconing1_TurnAngle");
      this.nud_SmartBeaconing1_TurnAngle.Maximum = new Decimal(new int[4]
      {
        90,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing1_TurnAngle.Minimum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing1_TurnAngle.Name = "nud_SmartBeaconing1_TurnAngle";
      this.nud_SmartBeaconing1_TurnAngle.Value = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_FastRateUnit, "lbl_SmartBeaconing1_FastRateUnit");
      this.lbl_SmartBeaconing1_FastRateUnit.Name = "lbl_SmartBeaconing1_FastRateUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing1_FastRate, "nud_SmartBeaconing1_FastRate");
      this.nud_SmartBeaconing1_FastRate.Maximum = new Decimal(new int[4]
      {
        180,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing1_FastRate.Minimum = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing1_FastRate.Name = "nud_SmartBeaconing1_FastRate";
      this.nud_SmartBeaconing1_FastRate.Value = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_SlowRateUnit, "lbl_SmartBeaconing1_SlowRateUnit");
      this.lbl_SmartBeaconing1_SlowRateUnit.Name = "lbl_SmartBeaconing1_SlowRateUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing1_SlowRate, "nud_SmartBeaconing1_SlowRate");
      this.nud_SmartBeaconing1_SlowRate.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing1_SlowRate.Name = "nud_SmartBeaconing1_SlowRate";
      this.nud_SmartBeaconing1_SlowRate.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_LowSpeedUnit, "lbl_SmartBeaconing1_LowSpeedUnit");
      this.lbl_SmartBeaconing1_LowSpeedUnit.Name = "lbl_SmartBeaconing1_LowSpeedUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing1_HighSpeed, "nud_SmartBeaconing1_HighSpeed");
      this.nud_SmartBeaconing1_HighSpeed.Maximum = new Decimal(new int[4]
      {
        90,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing1_HighSpeed.Minimum = new Decimal(new int[4]
      {
        3,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing1_HighSpeed.Name = "nud_SmartBeaconing1_HighSpeed";
      this.nud_SmartBeaconing1_HighSpeed.Value = new Decimal(new int[4]
      {
        3,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_HighSpeedUnit, "lbl_SmartBeaconing1_HighSpeedUnit");
      this.lbl_SmartBeaconing1_HighSpeedUnit.Name = "lbl_SmartBeaconing1_HighSpeedUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing1_LowSpeed, "nud_SmartBeaconing1_LowSpeed");
      this.nud_SmartBeaconing1_LowSpeed.Maximum = new Decimal(new int[4]
      {
        30,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing1_LowSpeed.Minimum = new Decimal(new int[4]
      {
        2,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing1_LowSpeed.Name = "nud_SmartBeaconing1_LowSpeed";
      this.nud_SmartBeaconing1_LowSpeed.Value = new Decimal(new int[4]
      {
        2,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_Type, "lbl_SmartBeaconing1_Type");
      this.lbl_SmartBeaconing1_Type.Name = "lbl_SmartBeaconing1_Type";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_LowSpeed, "lbl_SmartBeaconing1_LowSpeed");
      this.lbl_SmartBeaconing1_LowSpeed.Name = "lbl_SmartBeaconing1_LowSpeed";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_TurnTime, "lbl_SmartBeaconing1_TurnTime");
      this.lbl_SmartBeaconing1_TurnTime.Name = "lbl_SmartBeaconing1_TurnTime";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_TurnSlope, "lbl_SmartBeaconing1_TurnSlope");
      this.lbl_SmartBeaconing1_TurnSlope.Name = "lbl_SmartBeaconing1_TurnSlope";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_TurnAngle, "lbl_SmartBeaconing1_TurnAngle");
      this.lbl_SmartBeaconing1_TurnAngle.Name = "lbl_SmartBeaconing1_TurnAngle";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_FastRate, "lbl_SmartBeaconing1_FastRate");
      this.lbl_SmartBeaconing1_FastRate.Name = "lbl_SmartBeaconing1_FastRate";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_SlowRate, "lbl_SmartBeaconing1_SlowRate");
      this.lbl_SmartBeaconing1_SlowRate.Name = "lbl_SmartBeaconing1_SlowRate";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing1_HighSpeed, "lbl_SmartBeaconing1_HighSpeed");
      this.lbl_SmartBeaconing1_HighSpeed.Name = "lbl_SmartBeaconing1_HighSpeed";
      this.grb_SmartBeaconing2.Controls.Add((Control) this.nud_SmartBeaconing2_TurnTime);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_TurnTimeUnit);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.nud_SmartBeaconing2_TurnSlope);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_TurnAngleUnit);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.nud_SmartBeaconing2_TurnAngle);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_FastRateUnit);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.nud_SmartBeaconing2_FastRate);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_SlowRateUnit);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.nud_SmartBeaconing2_SlowRate);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_LowSpeedUnit);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.nud_SmartBeaconing2_HighSpeed);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_HighSpeedUnit);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.nud_SmartBeaconing2_LowSpeed);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_Type);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_LowSpeed);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_TurnTime);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_TurnSlope);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_TurnAngle);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_FastRate);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_SlowRate);
      this.grb_SmartBeaconing2.Controls.Add((Control) this.lbl_SmartBeaconing2_HighSpeed);
      componentResourceManager.ApplyResources((object) this.grb_SmartBeaconing2, "grb_SmartBeaconing2");
      this.grb_SmartBeaconing2.Name = "grb_SmartBeaconing2";
      this.grb_SmartBeaconing2.TabStop = false;
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing2_TurnTime, "nud_SmartBeaconing2_TurnTime");
      this.nud_SmartBeaconing2_TurnTime.Maximum = new Decimal(new int[4]
      {
        180,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing2_TurnTime.Minimum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing2_TurnTime.Name = "nud_SmartBeaconing2_TurnTime";
      this.nud_SmartBeaconing2_TurnTime.Value = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_TurnTimeUnit, "lbl_SmartBeaconing2_TurnTimeUnit");
      this.lbl_SmartBeaconing2_TurnTimeUnit.Name = "lbl_SmartBeaconing2_TurnTimeUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing2_TurnSlope, "nud_SmartBeaconing2_TurnSlope");
      this.nud_SmartBeaconing2_TurnSlope.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing2_TurnSlope.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing2_TurnSlope.Name = "nud_SmartBeaconing2_TurnSlope";
      this.nud_SmartBeaconing2_TurnSlope.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_TurnAngleUnit, "lbl_SmartBeaconing2_TurnAngleUnit");
      this.lbl_SmartBeaconing2_TurnAngleUnit.Name = "lbl_SmartBeaconing2_TurnAngleUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing2_TurnAngle, "nud_SmartBeaconing2_TurnAngle");
      this.nud_SmartBeaconing2_TurnAngle.Maximum = new Decimal(new int[4]
      {
        90,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing2_TurnAngle.Minimum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing2_TurnAngle.Name = "nud_SmartBeaconing2_TurnAngle";
      this.nud_SmartBeaconing2_TurnAngle.Value = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_FastRateUnit, "lbl_SmartBeaconing2_FastRateUnit");
      this.lbl_SmartBeaconing2_FastRateUnit.Name = "lbl_SmartBeaconing2_FastRateUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing2_FastRate, "nud_SmartBeaconing2_FastRate");
      this.nud_SmartBeaconing2_FastRate.Maximum = new Decimal(new int[4]
      {
        180,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing2_FastRate.Minimum = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing2_FastRate.Name = "nud_SmartBeaconing2_FastRate";
      this.nud_SmartBeaconing2_FastRate.Value = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_SlowRateUnit, "lbl_SmartBeaconing2_SlowRateUnit");
      this.lbl_SmartBeaconing2_SlowRateUnit.Name = "lbl_SmartBeaconing2_SlowRateUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing2_SlowRate, "nud_SmartBeaconing2_SlowRate");
      this.nud_SmartBeaconing2_SlowRate.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing2_SlowRate.Name = "nud_SmartBeaconing2_SlowRate";
      this.nud_SmartBeaconing2_SlowRate.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_LowSpeedUnit, "lbl_SmartBeaconing2_LowSpeedUnit");
      this.lbl_SmartBeaconing2_LowSpeedUnit.Name = "lbl_SmartBeaconing2_LowSpeedUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing2_HighSpeed, "nud_SmartBeaconing2_HighSpeed");
      this.nud_SmartBeaconing2_HighSpeed.Maximum = new Decimal(new int[4]
      {
        90,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing2_HighSpeed.Minimum = new Decimal(new int[4]
      {
        3,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing2_HighSpeed.Name = "nud_SmartBeaconing2_HighSpeed";
      this.nud_SmartBeaconing2_HighSpeed.Value = new Decimal(new int[4]
      {
        3,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_HighSpeedUnit, "lbl_SmartBeaconing2_HighSpeedUnit");
      this.lbl_SmartBeaconing2_HighSpeedUnit.Name = "lbl_SmartBeaconing2_HighSpeedUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing2_LowSpeed, "nud_SmartBeaconing2_LowSpeed");
      this.nud_SmartBeaconing2_LowSpeed.Maximum = new Decimal(new int[4]
      {
        30,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing2_LowSpeed.Minimum = new Decimal(new int[4]
      {
        2,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing2_LowSpeed.Name = "nud_SmartBeaconing2_LowSpeed";
      this.nud_SmartBeaconing2_LowSpeed.Value = new Decimal(new int[4]
      {
        2,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_Type, "lbl_SmartBeaconing2_Type");
      this.lbl_SmartBeaconing2_Type.Name = "lbl_SmartBeaconing2_Type";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_LowSpeed, "lbl_SmartBeaconing2_LowSpeed");
      this.lbl_SmartBeaconing2_LowSpeed.Name = "lbl_SmartBeaconing2_LowSpeed";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_TurnTime, "lbl_SmartBeaconing2_TurnTime");
      this.lbl_SmartBeaconing2_TurnTime.Name = "lbl_SmartBeaconing2_TurnTime";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_TurnSlope, "lbl_SmartBeaconing2_TurnSlope");
      this.lbl_SmartBeaconing2_TurnSlope.Name = "lbl_SmartBeaconing2_TurnSlope";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_TurnAngle, "lbl_SmartBeaconing2_TurnAngle");
      this.lbl_SmartBeaconing2_TurnAngle.Name = "lbl_SmartBeaconing2_TurnAngle";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_FastRate, "lbl_SmartBeaconing2_FastRate");
      this.lbl_SmartBeaconing2_FastRate.Name = "lbl_SmartBeaconing2_FastRate";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_SlowRate, "lbl_SmartBeaconing2_SlowRate");
      this.lbl_SmartBeaconing2_SlowRate.Name = "lbl_SmartBeaconing2_SlowRate";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing2_HighSpeed, "lbl_SmartBeaconing2_HighSpeed");
      this.lbl_SmartBeaconing2_HighSpeed.Name = "lbl_SmartBeaconing2_HighSpeed";
      this.grb_SmartBeaconing3.Controls.Add((Control) this.nud_SmartBeaconing3_TurnTime);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_TurnTimeUnit);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.nud_SmartBeaconing3_TurnSlope);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_TurnAngleUnit);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.nud_SmartBeaconing3_TurnAngle);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_FastRateUnit);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.nud_SmartBeaconing3_FastRate);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_SlowRateUnit);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.nud_SmartBeaconing3_SlowRate);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_SlowSpeedUnit);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.nud_SmartBeaconing3_HighSpeed);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_HighSpeedUnit);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.nud_SmartBeaconing3_LowSpeed);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_Type);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_SlowSpeed);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_TurnTime);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_TurnSlope);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_TurnAngle);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_FastRate);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_SlowRate);
      this.grb_SmartBeaconing3.Controls.Add((Control) this.lbl_SmartBeaconing3_HighSpeed);
      componentResourceManager.ApplyResources((object) this.grb_SmartBeaconing3, "grb_SmartBeaconing3");
      this.grb_SmartBeaconing3.Name = "grb_SmartBeaconing3";
      this.grb_SmartBeaconing3.TabStop = false;
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing3_TurnTime, "nud_SmartBeaconing3_TurnTime");
      this.nud_SmartBeaconing3_TurnTime.Maximum = new Decimal(new int[4]
      {
        180,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing3_TurnTime.Minimum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing3_TurnTime.Name = "nud_SmartBeaconing3_TurnTime";
      this.nud_SmartBeaconing3_TurnTime.Value = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_TurnTimeUnit, "lbl_SmartBeaconing3_TurnTimeUnit");
      this.lbl_SmartBeaconing3_TurnTimeUnit.Name = "lbl_SmartBeaconing3_TurnTimeUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing3_TurnSlope, "nud_SmartBeaconing3_TurnSlope");
      this.nud_SmartBeaconing3_TurnSlope.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing3_TurnSlope.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing3_TurnSlope.Name = "nud_SmartBeaconing3_TurnSlope";
      this.nud_SmartBeaconing3_TurnSlope.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_TurnAngleUnit, "lbl_SmartBeaconing3_TurnAngleUnit");
      this.lbl_SmartBeaconing3_TurnAngleUnit.Name = "lbl_SmartBeaconing3_TurnAngleUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing3_TurnAngle, "nud_SmartBeaconing3_TurnAngle");
      this.nud_SmartBeaconing3_TurnAngle.Maximum = new Decimal(new int[4]
      {
        90,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing3_TurnAngle.Minimum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing3_TurnAngle.Name = "nud_SmartBeaconing3_TurnAngle";
      this.nud_SmartBeaconing3_TurnAngle.Value = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_FastRateUnit, "lbl_SmartBeaconing3_FastRateUnit");
      this.lbl_SmartBeaconing3_FastRateUnit.Name = "lbl_SmartBeaconing3_FastRateUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing3_FastRate, "nud_SmartBeaconing3_FastRate");
      this.nud_SmartBeaconing3_FastRate.Maximum = new Decimal(new int[4]
      {
        180,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing3_FastRate.Minimum = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing3_FastRate.Name = "nud_SmartBeaconing3_FastRate";
      this.nud_SmartBeaconing3_FastRate.Value = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_SlowRateUnit, "lbl_SmartBeaconing3_SlowRateUnit");
      this.lbl_SmartBeaconing3_SlowRateUnit.Name = "lbl_SmartBeaconing3_SlowRateUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing3_SlowRate, "nud_SmartBeaconing3_SlowRate");
      this.nud_SmartBeaconing3_SlowRate.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing3_SlowRate.Name = "nud_SmartBeaconing3_SlowRate";
      this.nud_SmartBeaconing3_SlowRate.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_SlowSpeedUnit, "lbl_SmartBeaconing3_SlowSpeedUnit");
      this.lbl_SmartBeaconing3_SlowSpeedUnit.Name = "lbl_SmartBeaconing3_SlowSpeedUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing3_HighSpeed, "nud_SmartBeaconing3_HighSpeed");
      this.nud_SmartBeaconing3_HighSpeed.Maximum = new Decimal(new int[4]
      {
        90,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing3_HighSpeed.Minimum = new Decimal(new int[4]
      {
        3,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing3_HighSpeed.Name = "nud_SmartBeaconing3_HighSpeed";
      this.nud_SmartBeaconing3_HighSpeed.Value = new Decimal(new int[4]
      {
        3,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_HighSpeedUnit, "lbl_SmartBeaconing3_HighSpeedUnit");
      this.lbl_SmartBeaconing3_HighSpeedUnit.Name = "lbl_SmartBeaconing3_HighSpeedUnit";
      componentResourceManager.ApplyResources((object) this.nud_SmartBeaconing3_LowSpeed, "nud_SmartBeaconing3_LowSpeed");
      this.nud_SmartBeaconing3_LowSpeed.Maximum = new Decimal(new int[4]
      {
        30,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing3_LowSpeed.Minimum = new Decimal(new int[4]
      {
        2,
        0,
        0,
        0
      });
      this.nud_SmartBeaconing3_LowSpeed.Name = "nud_SmartBeaconing3_LowSpeed";
      this.nud_SmartBeaconing3_LowSpeed.Value = new Decimal(new int[4]
      {
        2,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_Type, "lbl_SmartBeaconing3_Type");
      this.lbl_SmartBeaconing3_Type.Name = "lbl_SmartBeaconing3_Type";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_SlowSpeed, "lbl_SmartBeaconing3_SlowSpeed");
      this.lbl_SmartBeaconing3_SlowSpeed.Name = "lbl_SmartBeaconing3_SlowSpeed";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_TurnTime, "lbl_SmartBeaconing3_TurnTime");
      this.lbl_SmartBeaconing3_TurnTime.Name = "lbl_SmartBeaconing3_TurnTime";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_TurnSlope, "lbl_SmartBeaconing3_TurnSlope");
      this.lbl_SmartBeaconing3_TurnSlope.Name = "lbl_SmartBeaconing3_TurnSlope";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_TurnAngle, "lbl_SmartBeaconing3_TurnAngle");
      this.lbl_SmartBeaconing3_TurnAngle.Name = "lbl_SmartBeaconing3_TurnAngle";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_FastRate, "lbl_SmartBeaconing3_FastRate");
      this.lbl_SmartBeaconing3_FastRate.Name = "lbl_SmartBeaconing3_FastRate";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_SlowRate, "lbl_SmartBeaconing3_SlowRate");
      this.lbl_SmartBeaconing3_SlowRate.Name = "lbl_SmartBeaconing3_SlowRate";
      componentResourceManager.ApplyResources((object) this.lbl_SmartBeaconing3_HighSpeed, "lbl_SmartBeaconing3_HighSpeed");
      this.lbl_SmartBeaconing3_HighSpeed.Name = "lbl_SmartBeaconing3_HighSpeed";
      this.grb_BeaconStatusText.Controls.Add((Control) this.rdb_BeaconStatusText_Off);
      this.grb_BeaconStatusText.Controls.Add((Control) this.cmb_BeaconStatusText_5_Mode);
      this.grb_BeaconStatusText.Controls.Add((Control) this.cmb_BeaconStatusText_4_Mode);
      this.grb_BeaconStatusText.Controls.Add((Control) this.cmb_BeaconStatusText_3_Mode);
      this.grb_BeaconStatusText.Controls.Add((Control) this.cmb_BeaconStatusText_2_Mode);
      this.grb_BeaconStatusText.Controls.Add((Control) this.cmb_BeaconStatusText_1_Mode);
      this.grb_BeaconStatusText.Controls.Add((Control) this.cmb_BeaconStatusText_TxRate);
      this.grb_BeaconStatusText.Controls.Add((Control) this.lbl_BeaconStatusText_TxRate);
      this.grb_BeaconStatusText.Controls.Add((Control) this.txt_BeaconStatusText_5);
      this.grb_BeaconStatusText.Controls.Add((Control) this.txt_BeaconStatusText_4);
      this.grb_BeaconStatusText.Controls.Add((Control) this.txt_BeaconStatusText_3);
      this.grb_BeaconStatusText.Controls.Add((Control) this.txt_BeaconStatusText_2);
      this.grb_BeaconStatusText.Controls.Add((Control) this.txt_BeaconStatusText_1);
      this.grb_BeaconStatusText.Controls.Add((Control) this.rdb_BeaconStatusText_5);
      this.grb_BeaconStatusText.Controls.Add((Control) this.rdb_BeaconStatusText_4);
      this.grb_BeaconStatusText.Controls.Add((Control) this.rdb_BeaconStatusText_3);
      this.grb_BeaconStatusText.Controls.Add((Control) this.rdb_BeaconStatusText_2);
      this.grb_BeaconStatusText.Controls.Add((Control) this.rdb_BeaconStatusText_1);
      componentResourceManager.ApplyResources((object) this.grb_BeaconStatusText, "grb_BeaconStatusText");
      this.grb_BeaconStatusText.Name = "grb_BeaconStatusText";
      this.grb_BeaconStatusText.TabStop = false;
      componentResourceManager.ApplyResources((object) this.rdb_BeaconStatusText_Off, "rdb_BeaconStatusText_Off");
      this.rdb_BeaconStatusText_Off.Name = "rdb_BeaconStatusText_Off";
      this.rdb_BeaconStatusText_Off.TabStop = true;
      this.rdb_BeaconStatusText_Off.UseVisualStyleBackColor = true;
      this.rdb_BeaconStatusText_Off.CheckedChanged += new EventHandler(this.rdb_BeaconStatusText_CheckedChanged);
      this.cmb_BeaconStatusText_5_Mode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_BeaconStatusText_5_Mode, "cmb_BeaconStatusText_5_Mode");
      this.cmb_BeaconStatusText_5_Mode.FormattingEnabled = true;
      this.cmb_BeaconStatusText_5_Mode.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_5_Mode.Items"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_5_Mode.Items1"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_5_Mode.Items2")
      });
      this.cmb_BeaconStatusText_5_Mode.Name = "cmb_BeaconStatusText_5_Mode";
      this.cmb_BeaconStatusText_4_Mode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_BeaconStatusText_4_Mode, "cmb_BeaconStatusText_4_Mode");
      this.cmb_BeaconStatusText_4_Mode.FormattingEnabled = true;
      this.cmb_BeaconStatusText_4_Mode.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_4_Mode.Items"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_4_Mode.Items1"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_4_Mode.Items2")
      });
      this.cmb_BeaconStatusText_4_Mode.Name = "cmb_BeaconStatusText_4_Mode";
      this.cmb_BeaconStatusText_3_Mode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_BeaconStatusText_3_Mode, "cmb_BeaconStatusText_3_Mode");
      this.cmb_BeaconStatusText_3_Mode.FormattingEnabled = true;
      this.cmb_BeaconStatusText_3_Mode.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_3_Mode.Items"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_3_Mode.Items1"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_3_Mode.Items2")
      });
      this.cmb_BeaconStatusText_3_Mode.Name = "cmb_BeaconStatusText_3_Mode";
      this.cmb_BeaconStatusText_2_Mode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_BeaconStatusText_2_Mode, "cmb_BeaconStatusText_2_Mode");
      this.cmb_BeaconStatusText_2_Mode.FormattingEnabled = true;
      this.cmb_BeaconStatusText_2_Mode.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_2_Mode.Items"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_2_Mode.Items1"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_2_Mode.Items2")
      });
      this.cmb_BeaconStatusText_2_Mode.Name = "cmb_BeaconStatusText_2_Mode";
      this.cmb_BeaconStatusText_1_Mode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_BeaconStatusText_1_Mode, "cmb_BeaconStatusText_1_Mode");
      this.cmb_BeaconStatusText_1_Mode.FormattingEnabled = true;
      this.cmb_BeaconStatusText_1_Mode.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_1_Mode.Items"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_1_Mode.Items1"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_1_Mode.Items2")
      });
      this.cmb_BeaconStatusText_1_Mode.Name = "cmb_BeaconStatusText_1_Mode";
      this.cmb_BeaconStatusText_TxRate.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_BeaconStatusText_TxRate, "cmb_BeaconStatusText_TxRate");
      this.cmb_BeaconStatusText_TxRate.FormattingEnabled = true;
      this.cmb_BeaconStatusText_TxRate.Items.AddRange(new object[15]
      {
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items1"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items2"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items3"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items4"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items5"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items6"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items7"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items8"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items9"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items10"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items11"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items12"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items13"),
        (object) componentResourceManager.GetString("cmb_BeaconStatusText_TxRate.Items14")
      });
      this.cmb_BeaconStatusText_TxRate.Name = "cmb_BeaconStatusText_TxRate";
      componentResourceManager.ApplyResources((object) this.lbl_BeaconStatusText_TxRate, "lbl_BeaconStatusText_TxRate");
      this.lbl_BeaconStatusText_TxRate.Name = "lbl_BeaconStatusText_TxRate";
      componentResourceManager.ApplyResources((object) this.txt_BeaconStatusText_5, "txt_BeaconStatusText_5");
      this.txt_BeaconStatusText_5.Name = "txt_BeaconStatusText_5";
      componentResourceManager.ApplyResources((object) this.txt_BeaconStatusText_4, "txt_BeaconStatusText_4");
      this.txt_BeaconStatusText_4.Name = "txt_BeaconStatusText_4";
      componentResourceManager.ApplyResources((object) this.txt_BeaconStatusText_3, "txt_BeaconStatusText_3");
      this.txt_BeaconStatusText_3.Name = "txt_BeaconStatusText_3";
      componentResourceManager.ApplyResources((object) this.txt_BeaconStatusText_2, "txt_BeaconStatusText_2");
      this.txt_BeaconStatusText_2.Name = "txt_BeaconStatusText_2";
      componentResourceManager.ApplyResources((object) this.txt_BeaconStatusText_1, "txt_BeaconStatusText_1");
      this.txt_BeaconStatusText_1.Name = "txt_BeaconStatusText_1";
      componentResourceManager.ApplyResources((object) this.rdb_BeaconStatusText_5, "rdb_BeaconStatusText_5");
      this.rdb_BeaconStatusText_5.Name = "rdb_BeaconStatusText_5";
      this.rdb_BeaconStatusText_5.TabStop = true;
      this.rdb_BeaconStatusText_5.UseVisualStyleBackColor = true;
      this.rdb_BeaconStatusText_5.CheckedChanged += new EventHandler(this.rdb_BeaconStatusText_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_BeaconStatusText_4, "rdb_BeaconStatusText_4");
      this.rdb_BeaconStatusText_4.Name = "rdb_BeaconStatusText_4";
      this.rdb_BeaconStatusText_4.TabStop = true;
      this.rdb_BeaconStatusText_4.UseVisualStyleBackColor = true;
      this.rdb_BeaconStatusText_4.CheckedChanged += new EventHandler(this.rdb_BeaconStatusText_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_BeaconStatusText_3, "rdb_BeaconStatusText_3");
      this.rdb_BeaconStatusText_3.Name = "rdb_BeaconStatusText_3";
      this.rdb_BeaconStatusText_3.TabStop = true;
      this.rdb_BeaconStatusText_3.UseVisualStyleBackColor = true;
      this.rdb_BeaconStatusText_3.CheckedChanged += new EventHandler(this.rdb_BeaconStatusText_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_BeaconStatusText_2, "rdb_BeaconStatusText_2");
      this.rdb_BeaconStatusText_2.Name = "rdb_BeaconStatusText_2";
      this.rdb_BeaconStatusText_2.TabStop = true;
      this.rdb_BeaconStatusText_2.UseVisualStyleBackColor = true;
      this.rdb_BeaconStatusText_2.CheckedChanged += new EventHandler(this.rdb_BeaconStatusText_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_BeaconStatusText_1, "rdb_BeaconStatusText_1");
      this.rdb_BeaconStatusText_1.Name = "rdb_BeaconStatusText_1";
      this.rdb_BeaconStatusText_1.TabStop = true;
      this.rdb_BeaconStatusText_1.UseVisualStyleBackColor = true;
      this.rdb_BeaconStatusText_1.CheckedChanged += new EventHandler(this.rdb_BeaconStatusText_CheckedChanged);
      this.grp_AprsRingerCall.Controls.Add((Control) this.lbl_AprsRingerCall_8);
      this.grp_AprsRingerCall.Controls.Add((Control) this.cmb_AprsRingerCallSsId_8);
      this.grp_AprsRingerCall.Controls.Add((Control) this.txt_AprsRingerCallCode_8);
      this.grp_AprsRingerCall.Controls.Add((Control) this.cmb_AprsRingerCallSsId_7);
      this.grp_AprsRingerCall.Controls.Add((Control) this.txt_AprsRingerCallCode_7);
      this.grp_AprsRingerCall.Controls.Add((Control) this.lbl_AprsRingerCall_7);
      this.grp_AprsRingerCall.Controls.Add((Control) this.cmb_AprsRingerCallSsId_6);
      this.grp_AprsRingerCall.Controls.Add((Control) this.txt_AprsRingerCallCode_1);
      this.grp_AprsRingerCall.Controls.Add((Control) this.cmb_AprsRingerCallSsId_5);
      this.grp_AprsRingerCall.Controls.Add((Control) this.txt_AprsRingerCallCode_6);
      this.grp_AprsRingerCall.Controls.Add((Control) this.lbl_AprsRingerCall_6);
      this.grp_AprsRingerCall.Controls.Add((Control) this.cmb_AprsRingerCallSsId_4);
      this.grp_AprsRingerCall.Controls.Add((Control) this.lbl_AprsRingerCall_1);
      this.grp_AprsRingerCall.Controls.Add((Control) this.lbl_AprsRingerCall_3);
      this.grp_AprsRingerCall.Controls.Add((Control) this.txt_AprsRingerCallCode_2);
      this.grp_AprsRingerCall.Controls.Add((Control) this.lbl_AprsRingerCall_2);
      this.grp_AprsRingerCall.Controls.Add((Control) this.cmb_AprsRingerCallSsId_3);
      this.grp_AprsRingerCall.Controls.Add((Control) this.lbl_AprsRingerCall_5);
      this.grp_AprsRingerCall.Controls.Add((Control) this.txt_AprsRingerCallCode_5);
      this.grp_AprsRingerCall.Controls.Add((Control) this.lbl_AprsRingerCall_4);
      this.grp_AprsRingerCall.Controls.Add((Control) this.cmb_AprsRingerCallSsId_2);
      this.grp_AprsRingerCall.Controls.Add((Control) this.txt_AprsRingerCallCode_3);
      this.grp_AprsRingerCall.Controls.Add((Control) this.cmb_AprsRingerCallSsId_1);
      this.grp_AprsRingerCall.Controls.Add((Control) this.txt_AprsRingerCallCode_4);
      componentResourceManager.ApplyResources((object) this.grp_AprsRingerCall, "grp_AprsRingerCall");
      this.grp_AprsRingerCall.Name = "grp_AprsRingerCall";
      this.grp_AprsRingerCall.TabStop = false;
      componentResourceManager.ApplyResources((object) this.lbl_AprsRingerCall_8, "lbl_AprsRingerCall_8");
      this.lbl_AprsRingerCall_8.Name = "lbl_AprsRingerCall_8";
      this.cmb_AprsRingerCallSsId_8.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRingerCallSsId_8, "cmb_AprsRingerCallSsId_8");
      this.cmb_AprsRingerCallSsId_8.FormattingEnabled = true;
      this.cmb_AprsRingerCallSsId_8.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items9"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items10"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items11"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items12"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items13"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items14"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_8.Items15")
      });
      this.cmb_AprsRingerCallSsId_8.Name = "cmb_AprsRingerCallSsId_8";
      this.txt_AprsRingerCallCode_8.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsRingerCallCode_8, "txt_AprsRingerCallCode_8");
      this.txt_AprsRingerCallCode_8.Name = "txt_AprsRingerCallCode_8";
      this.txt_AprsRingerCallCode_8.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.cmb_AprsRingerCallSsId_7.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRingerCallSsId_7, "cmb_AprsRingerCallSsId_7");
      this.cmb_AprsRingerCallSsId_7.FormattingEnabled = true;
      this.cmb_AprsRingerCallSsId_7.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items9"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items10"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items11"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items12"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items13"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items14"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_7.Items15")
      });
      this.cmb_AprsRingerCallSsId_7.Name = "cmb_AprsRingerCallSsId_7";
      this.txt_AprsRingerCallCode_7.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsRingerCallCode_7, "txt_AprsRingerCallCode_7");
      this.txt_AprsRingerCallCode_7.Name = "txt_AprsRingerCallCode_7";
      this.txt_AprsRingerCallCode_7.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      componentResourceManager.ApplyResources((object) this.lbl_AprsRingerCall_7, "lbl_AprsRingerCall_7");
      this.lbl_AprsRingerCall_7.Name = "lbl_AprsRingerCall_7";
      this.cmb_AprsRingerCallSsId_6.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRingerCallSsId_6, "cmb_AprsRingerCallSsId_6");
      this.cmb_AprsRingerCallSsId_6.FormattingEnabled = true;
      this.cmb_AprsRingerCallSsId_6.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items9"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items10"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items11"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items12"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items13"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items14"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_6.Items15")
      });
      this.cmb_AprsRingerCallSsId_6.Name = "cmb_AprsRingerCallSsId_6";
      this.txt_AprsRingerCallCode_1.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsRingerCallCode_1, "txt_AprsRingerCallCode_1");
      this.txt_AprsRingerCallCode_1.Name = "txt_AprsRingerCallCode_1";
      this.txt_AprsRingerCallCode_1.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.cmb_AprsRingerCallSsId_5.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRingerCallSsId_5, "cmb_AprsRingerCallSsId_5");
      this.cmb_AprsRingerCallSsId_5.FormattingEnabled = true;
      this.cmb_AprsRingerCallSsId_5.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items9"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items10"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items11"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items12"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items13"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items14"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_5.Items15")
      });
      this.cmb_AprsRingerCallSsId_5.Name = "cmb_AprsRingerCallSsId_5";
      this.txt_AprsRingerCallCode_6.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsRingerCallCode_6, "txt_AprsRingerCallCode_6");
      this.txt_AprsRingerCallCode_6.Name = "txt_AprsRingerCallCode_6";
      this.txt_AprsRingerCallCode_6.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      componentResourceManager.ApplyResources((object) this.lbl_AprsRingerCall_6, "lbl_AprsRingerCall_6");
      this.lbl_AprsRingerCall_6.Name = "lbl_AprsRingerCall_6";
      this.cmb_AprsRingerCallSsId_4.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRingerCallSsId_4, "cmb_AprsRingerCallSsId_4");
      this.cmb_AprsRingerCallSsId_4.FormattingEnabled = true;
      this.cmb_AprsRingerCallSsId_4.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items9"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items10"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items11"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items12"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items13"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items14"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_4.Items15")
      });
      this.cmb_AprsRingerCallSsId_4.Name = "cmb_AprsRingerCallSsId_4";
      componentResourceManager.ApplyResources((object) this.lbl_AprsRingerCall_1, "lbl_AprsRingerCall_1");
      this.lbl_AprsRingerCall_1.Name = "lbl_AprsRingerCall_1";
      componentResourceManager.ApplyResources((object) this.lbl_AprsRingerCall_3, "lbl_AprsRingerCall_3");
      this.lbl_AprsRingerCall_3.Name = "lbl_AprsRingerCall_3";
      this.txt_AprsRingerCallCode_2.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsRingerCallCode_2, "txt_AprsRingerCallCode_2");
      this.txt_AprsRingerCallCode_2.Name = "txt_AprsRingerCallCode_2";
      this.txt_AprsRingerCallCode_2.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      componentResourceManager.ApplyResources((object) this.lbl_AprsRingerCall_2, "lbl_AprsRingerCall_2");
      this.lbl_AprsRingerCall_2.Name = "lbl_AprsRingerCall_2";
      this.cmb_AprsRingerCallSsId_3.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRingerCallSsId_3, "cmb_AprsRingerCallSsId_3");
      this.cmb_AprsRingerCallSsId_3.FormattingEnabled = true;
      this.cmb_AprsRingerCallSsId_3.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items9"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items10"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items11"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items12"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items13"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items14"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_3.Items15")
      });
      this.cmb_AprsRingerCallSsId_3.Name = "cmb_AprsRingerCallSsId_3";
      componentResourceManager.ApplyResources((object) this.lbl_AprsRingerCall_5, "lbl_AprsRingerCall_5");
      this.lbl_AprsRingerCall_5.Name = "lbl_AprsRingerCall_5";
      this.txt_AprsRingerCallCode_5.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsRingerCallCode_5, "txt_AprsRingerCallCode_5");
      this.txt_AprsRingerCallCode_5.Name = "txt_AprsRingerCallCode_5";
      this.txt_AprsRingerCallCode_5.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      componentResourceManager.ApplyResources((object) this.lbl_AprsRingerCall_4, "lbl_AprsRingerCall_4");
      this.lbl_AprsRingerCall_4.Name = "lbl_AprsRingerCall_4";
      this.cmb_AprsRingerCallSsId_2.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRingerCallSsId_2, "cmb_AprsRingerCallSsId_2");
      this.cmb_AprsRingerCallSsId_2.FormattingEnabled = true;
      this.cmb_AprsRingerCallSsId_2.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items9"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items10"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items11"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items12"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items13"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items14"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_2.Items15")
      });
      this.cmb_AprsRingerCallSsId_2.Name = "cmb_AprsRingerCallSsId_2";
      this.txt_AprsRingerCallCode_3.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsRingerCallCode_3, "txt_AprsRingerCallCode_3");
      this.txt_AprsRingerCallCode_3.Name = "txt_AprsRingerCallCode_3";
      this.txt_AprsRingerCallCode_3.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.cmb_AprsRingerCallSsId_1.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRingerCallSsId_1, "cmb_AprsRingerCallSsId_1");
      this.cmb_AprsRingerCallSsId_1.FormattingEnabled = true;
      this.cmb_AprsRingerCallSsId_1.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items9"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items10"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items11"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items12"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items13"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items14"),
        (object) componentResourceManager.GetString("cmb_AprsRingerCallSsId_1.Items15")
      });
      this.cmb_AprsRingerCallSsId_1.Name = "cmb_AprsRingerCallSsId_1";
      this.txt_AprsRingerCallCode_4.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsRingerCallCode_4, "txt_AprsRingerCallCode_4");
      this.txt_AprsRingerCallCode_4.Name = "txt_AprsRingerCallCode_4";
      this.txt_AprsRingerCallCode_4.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.grb_AprsRinger.Controls.Add((Control) this.cmb_AprsRinger_MsgVc);
      this.grb_AprsRinger.Controls.Add((Control) this.lbl_AprsRinger_MsgVc);
      this.grb_AprsRinger.Controls.Add((Control) this.cmb_AprsRinger_MyPacket);
      this.grb_AprsRinger.Controls.Add((Control) this.lbl_AprsRinger_MyPacket);
      this.grb_AprsRinger.Controls.Add((Control) this.cmb_AprsRinger_RngRbgr);
      this.grb_AprsRinger.Controls.Add((Control) this.lbl_AprsRinger_RngRbgr);
      this.grb_AprsRinger.Controls.Add((Control) this.cmb_AprsRinger_CllRngr);
      this.grb_AprsRinger.Controls.Add((Control) this.lbl_AprsRinger_CllRngr);
      this.grb_AprsRinger.Controls.Add((Control) this.cmb_AprsRinger_RxMsg);
      this.grb_AprsRinger.Controls.Add((Control) this.lbl_AprsRinger_RxMsg);
      this.grb_AprsRinger.Controls.Add((Control) this.cmb_AprsRinger_RxBcn);
      this.grb_AprsRinger.Controls.Add((Control) this.lbl_AprsRinger_RxBcn);
      this.grb_AprsRinger.Controls.Add((Control) this.cmb_AprsRinger_TxMsg);
      this.grb_AprsRinger.Controls.Add((Control) this.lbl_AprsRinger_TxMsg);
      this.grb_AprsRinger.Controls.Add((Control) this.cmb_AprsRinger_TxBcn);
      this.grb_AprsRinger.Controls.Add((Control) this.lbl_AprsRinger_TxBcn);
      componentResourceManager.ApplyResources((object) this.grb_AprsRinger, "grb_AprsRinger");
      this.grb_AprsRinger.Name = "grb_AprsRinger";
      this.grb_AprsRinger.TabStop = false;
      this.cmb_AprsRinger_MsgVc.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRinger_MsgVc, "cmb_AprsRinger_MsgVc");
      this.cmb_AprsRinger_MsgVc.FormattingEnabled = true;
      this.cmb_AprsRinger_MsgVc.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsRinger_MsgVc.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_MsgVc.Items1")
      });
      this.cmb_AprsRinger_MsgVc.Name = "cmb_AprsRinger_MsgVc";
      componentResourceManager.ApplyResources((object) this.lbl_AprsRinger_MsgVc, "lbl_AprsRinger_MsgVc");
      this.lbl_AprsRinger_MsgVc.Name = "lbl_AprsRinger_MsgVc";
      this.cmb_AprsRinger_MyPacket.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRinger_MyPacket, "cmb_AprsRinger_MyPacket");
      this.cmb_AprsRinger_MyPacket.FormattingEnabled = true;
      this.cmb_AprsRinger_MyPacket.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsRinger_MyPacket.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_MyPacket.Items1")
      });
      this.cmb_AprsRinger_MyPacket.Name = "cmb_AprsRinger_MyPacket";
      componentResourceManager.ApplyResources((object) this.lbl_AprsRinger_MyPacket, "lbl_AprsRinger_MyPacket");
      this.lbl_AprsRinger_MyPacket.Name = "lbl_AprsRinger_MyPacket";
      this.cmb_AprsRinger_RngRbgr.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRinger_RngRbgr, "cmb_AprsRinger_RngRbgr");
      this.cmb_AprsRinger_RngRbgr.FormattingEnabled = true;
      this.cmb_AprsRinger_RngRbgr.Items.AddRange(new object[101]
      {
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items9"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items10"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items11"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items12"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items13"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items14"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items15"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items16"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items17"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items18"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items19"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items20"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items21"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items22"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items23"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items24"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items25"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items26"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items27"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items28"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items29"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items30"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items31"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items32"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items33"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items34"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items35"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items36"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items37"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items38"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items39"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items40"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items41"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items42"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items43"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items44"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items45"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items46"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items47"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items48"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items49"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items50"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items51"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items52"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items53"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items54"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items55"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items56"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items57"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items58"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items59"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items60"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items61"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items62"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items63"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items64"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items65"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items66"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items67"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items68"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items69"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items70"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items71"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items72"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items73"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items74"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items75"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items76"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items77"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items78"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items79"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items80"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items81"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items82"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items83"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items84"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items85"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items86"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items87"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items88"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items89"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items90"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items91"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items92"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items93"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items94"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items95"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items96"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items97"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items98"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items99"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RngRbgr.Items100")
      });
      this.cmb_AprsRinger_RngRbgr.Name = "cmb_AprsRinger_RngRbgr";
      componentResourceManager.ApplyResources((object) this.lbl_AprsRinger_RngRbgr, "lbl_AprsRinger_RngRbgr");
      this.lbl_AprsRinger_RngRbgr.Name = "lbl_AprsRinger_RngRbgr";
      this.cmb_AprsRinger_CllRngr.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRinger_CllRngr, "cmb_AprsRinger_CllRngr");
      this.cmb_AprsRinger_CllRngr.FormattingEnabled = true;
      this.cmb_AprsRinger_CllRngr.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsRinger_CllRngr.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_CllRngr.Items1")
      });
      this.cmb_AprsRinger_CllRngr.Name = "cmb_AprsRinger_CllRngr";
      componentResourceManager.ApplyResources((object) this.lbl_AprsRinger_CllRngr, "lbl_AprsRinger_CllRngr");
      this.lbl_AprsRinger_CllRngr.Name = "lbl_AprsRinger_CllRngr";
      this.cmb_AprsRinger_RxMsg.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRinger_RxMsg, "cmb_AprsRinger_RxMsg");
      this.cmb_AprsRinger_RxMsg.FormattingEnabled = true;
      this.cmb_AprsRinger_RxMsg.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsRinger_RxMsg.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RxMsg.Items1")
      });
      this.cmb_AprsRinger_RxMsg.Name = "cmb_AprsRinger_RxMsg";
      componentResourceManager.ApplyResources((object) this.lbl_AprsRinger_RxMsg, "lbl_AprsRinger_RxMsg");
      this.lbl_AprsRinger_RxMsg.Name = "lbl_AprsRinger_RxMsg";
      this.cmb_AprsRinger_RxBcn.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRinger_RxBcn, "cmb_AprsRinger_RxBcn");
      this.cmb_AprsRinger_RxBcn.FormattingEnabled = true;
      this.cmb_AprsRinger_RxBcn.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsRinger_RxBcn.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_RxBcn.Items1")
      });
      this.cmb_AprsRinger_RxBcn.Name = "cmb_AprsRinger_RxBcn";
      componentResourceManager.ApplyResources((object) this.lbl_AprsRinger_RxBcn, "lbl_AprsRinger_RxBcn");
      this.lbl_AprsRinger_RxBcn.Name = "lbl_AprsRinger_RxBcn";
      this.cmb_AprsRinger_TxMsg.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRinger_TxMsg, "cmb_AprsRinger_TxMsg");
      this.cmb_AprsRinger_TxMsg.FormattingEnabled = true;
      this.cmb_AprsRinger_TxMsg.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsRinger_TxMsg.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_TxMsg.Items1")
      });
      this.cmb_AprsRinger_TxMsg.Name = "cmb_AprsRinger_TxMsg";
      componentResourceManager.ApplyResources((object) this.lbl_AprsRinger_TxMsg, "lbl_AprsRinger_TxMsg");
      this.lbl_AprsRinger_TxMsg.Name = "lbl_AprsRinger_TxMsg";
      this.cmb_AprsRinger_TxBcn.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsRinger_TxBcn, "cmb_AprsRinger_TxBcn");
      this.cmb_AprsRinger_TxBcn.FormattingEnabled = true;
      this.cmb_AprsRinger_TxBcn.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsRinger_TxBcn.Items"),
        (object) componentResourceManager.GetString("cmb_AprsRinger_TxBcn.Items1")
      });
      this.cmb_AprsRinger_TxBcn.Name = "cmb_AprsRinger_TxBcn";
      componentResourceManager.ApplyResources((object) this.lbl_AprsRinger_TxBcn, "lbl_AprsRinger_TxBcn");
      this.lbl_AprsRinger_TxBcn.Name = "lbl_AprsRinger_TxBcn";
      this.grb_AprsUnit.Controls.Add((Control) this.cmb_AprsUnit_Baro);
      this.grb_AprsUnit.Controls.Add((Control) this.lbl_AprsUnit_Baro);
      this.grb_AprsUnit.Controls.Add((Control) this.cmb_AprsUnit_Wind);
      this.grb_AprsUnit.Controls.Add((Control) this.lbl_AprsUnit_Wind);
      this.grb_AprsUnit.Controls.Add((Control) this.cmb_AprsUnit_Rain);
      this.grb_AprsUnit.Controls.Add((Control) this.lbl_AprsUnit_Rain);
      this.grb_AprsUnit.Controls.Add((Control) this.cmb_AprsUnit_Altitude);
      this.grb_AprsUnit.Controls.Add((Control) this.lbl_AprsUnit_Altitude);
      this.grb_AprsUnit.Controls.Add((Control) this.cmb_AprsUnit_Temp);
      this.grb_AprsUnit.Controls.Add((Control) this.lbl_AprsUnit_Temp);
      this.grb_AprsUnit.Controls.Add((Control) this.cmb_AprsUnit_Speed);
      this.grb_AprsUnit.Controls.Add((Control) this.lbl_AprsUnit_Speed);
      this.grb_AprsUnit.Controls.Add((Control) this.cmb_AprsUnit_Distance);
      this.grb_AprsUnit.Controls.Add((Control) this.lbl_AprsUnit_Distance);
      this.grb_AprsUnit.Controls.Add((Control) this.cmb_AprsUnit_Position);
      this.grb_AprsUnit.Controls.Add((Control) this.lbl_AprsUnit_Position);
      componentResourceManager.ApplyResources((object) this.grb_AprsUnit, "grb_AprsUnit");
      this.grb_AprsUnit.Name = "grb_AprsUnit";
      this.grb_AprsUnit.TabStop = false;
      this.cmb_AprsUnit_Baro.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsUnit_Baro, "cmb_AprsUnit_Baro");
      this.cmb_AprsUnit_Baro.FormattingEnabled = true;
      this.cmb_AprsUnit_Baro.Items.AddRange(new object[4]
      {
        (object) componentResourceManager.GetString("cmb_AprsUnit_Baro.Items"),
        (object) componentResourceManager.GetString("cmb_AprsUnit_Baro.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsUnit_Baro.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsUnit_Baro.Items3")
      });
      this.cmb_AprsUnit_Baro.Name = "cmb_AprsUnit_Baro";
      componentResourceManager.ApplyResources((object) this.lbl_AprsUnit_Baro, "lbl_AprsUnit_Baro");
      this.lbl_AprsUnit_Baro.Name = "lbl_AprsUnit_Baro";
      this.cmb_AprsUnit_Wind.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsUnit_Wind, "cmb_AprsUnit_Wind");
      this.cmb_AprsUnit_Wind.FormattingEnabled = true;
      this.cmb_AprsUnit_Wind.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_AprsUnit_Wind.Items"),
        (object) componentResourceManager.GetString("cmb_AprsUnit_Wind.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsUnit_Wind.Items2")
      });
      this.cmb_AprsUnit_Wind.Name = "cmb_AprsUnit_Wind";
      componentResourceManager.ApplyResources((object) this.lbl_AprsUnit_Wind, "lbl_AprsUnit_Wind");
      this.lbl_AprsUnit_Wind.Name = "lbl_AprsUnit_Wind";
      this.cmb_AprsUnit_Rain.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsUnit_Rain, "cmb_AprsUnit_Rain");
      this.cmb_AprsUnit_Rain.FormattingEnabled = true;
      this.cmb_AprsUnit_Rain.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsUnit_Rain.Items"),
        (object) componentResourceManager.GetString("cmb_AprsUnit_Rain.Items1")
      });
      this.cmb_AprsUnit_Rain.Name = "cmb_AprsUnit_Rain";
      componentResourceManager.ApplyResources((object) this.lbl_AprsUnit_Rain, "lbl_AprsUnit_Rain");
      this.lbl_AprsUnit_Rain.Name = "lbl_AprsUnit_Rain";
      this.cmb_AprsUnit_Altitude.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsUnit_Altitude, "cmb_AprsUnit_Altitude");
      this.cmb_AprsUnit_Altitude.FormattingEnabled = true;
      this.cmb_AprsUnit_Altitude.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsUnit_Altitude.Items"),
        (object) componentResourceManager.GetString("cmb_AprsUnit_Altitude.Items1")
      });
      this.cmb_AprsUnit_Altitude.Name = "cmb_AprsUnit_Altitude";
      componentResourceManager.ApplyResources((object) this.lbl_AprsUnit_Altitude, "lbl_AprsUnit_Altitude");
      this.lbl_AprsUnit_Altitude.Name = "lbl_AprsUnit_Altitude";
      this.cmb_AprsUnit_Temp.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsUnit_Temp, "cmb_AprsUnit_Temp");
      this.cmb_AprsUnit_Temp.FormattingEnabled = true;
      this.cmb_AprsUnit_Temp.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsUnit_Temp.Items"),
        (object) componentResourceManager.GetString("cmb_AprsUnit_Temp.Items1")
      });
      this.cmb_AprsUnit_Temp.Name = "cmb_AprsUnit_Temp";
      componentResourceManager.ApplyResources((object) this.lbl_AprsUnit_Temp, "lbl_AprsUnit_Temp");
      this.lbl_AprsUnit_Temp.Name = "lbl_AprsUnit_Temp";
      this.cmb_AprsUnit_Speed.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsUnit_Speed, "cmb_AprsUnit_Speed");
      this.cmb_AprsUnit_Speed.FormattingEnabled = true;
      this.cmb_AprsUnit_Speed.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_AprsUnit_Speed.Items"),
        (object) componentResourceManager.GetString("cmb_AprsUnit_Speed.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsUnit_Speed.Items2")
      });
      this.cmb_AprsUnit_Speed.Name = "cmb_AprsUnit_Speed";
      componentResourceManager.ApplyResources((object) this.lbl_AprsUnit_Speed, "lbl_AprsUnit_Speed");
      this.lbl_AprsUnit_Speed.Name = "lbl_AprsUnit_Speed";
      this.cmb_AprsUnit_Distance.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsUnit_Distance, "cmb_AprsUnit_Distance");
      this.cmb_AprsUnit_Distance.FormattingEnabled = true;
      this.cmb_AprsUnit_Distance.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsUnit_Distance.Items"),
        (object) componentResourceManager.GetString("cmb_AprsUnit_Distance.Items1")
      });
      this.cmb_AprsUnit_Distance.Name = "cmb_AprsUnit_Distance";
      componentResourceManager.ApplyResources((object) this.lbl_AprsUnit_Distance, "lbl_AprsUnit_Distance");
      this.lbl_AprsUnit_Distance.Name = "lbl_AprsUnit_Distance";
      this.cmb_AprsUnit_Position.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsUnit_Position, "cmb_AprsUnit_Position");
      this.cmb_AprsUnit_Position.FormattingEnabled = true;
      this.cmb_AprsUnit_Position.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsUnit_Position.Items"),
        (object) componentResourceManager.GetString("cmb_AprsUnit_Position.Items1")
      });
      this.cmb_AprsUnit_Position.Name = "cmb_AprsUnit_Position";
      componentResourceManager.ApplyResources((object) this.lbl_AprsUnit_Position, "lbl_AprsUnit_Position");
      this.lbl_AprsUnit_Position.Name = "lbl_AprsUnit_Position";
      this.grb_AprsFilter.Controls.Add((Control) this.cmb_AprsFilter_RangeLimit);
      this.grb_AprsFilter.Controls.Add((Control) this.lbl_AprsFilter_RangeLimit);
      this.grb_AprsFilter.Controls.Add((Control) this.cmb_AprsFilter_Altnet);
      this.grb_AprsFilter.Controls.Add((Control) this.lbl_AprsFilter_Altnet);
      this.grb_AprsFilter.Controls.Add((Control) this.cmb_AprsFilter_Other);
      this.grb_AprsFilter.Controls.Add((Control) this.lbl_AprsFilter_Other);
      this.grb_AprsFilter.Controls.Add((Control) this.cmb_AprsFilter_Status);
      this.grb_AprsFilter.Controls.Add((Control) this.lbl_AprsFilter_Status);
      this.grb_AprsFilter.Controls.Add((Control) this.cmb_AprsFilter_Object);
      this.grb_AprsFilter.Controls.Add((Control) this.lbl_AprsFilter_Object);
      this.grb_AprsFilter.Controls.Add((Control) this.cmb_AprsFilter_Item);
      this.grb_AprsFilter.Controls.Add((Control) this.lbl_AprsFilter_Item);
      this.grb_AprsFilter.Controls.Add((Control) this.cmb_AprsFilter_Weather);
      this.grb_AprsFilter.Controls.Add((Control) this.lbl_AprsFilter_Weather);
      this.grb_AprsFilter.Controls.Add((Control) this.cmb_AprsFilter_Position);
      this.grb_AprsFilter.Controls.Add((Control) this.lbl_AprsFilter_Position);
      this.grb_AprsFilter.Controls.Add((Control) this.cmb_AprsFilter_MicE);
      this.grb_AprsFilter.Controls.Add((Control) this.lbl_AprsFilter_MicE);
      componentResourceManager.ApplyResources((object) this.grb_AprsFilter, "grb_AprsFilter");
      this.grb_AprsFilter.Name = "grb_AprsFilter";
      this.grb_AprsFilter.TabStop = false;
      this.cmb_AprsFilter_RangeLimit.BackColor = SystemColors.Window;
      this.cmb_AprsFilter_RangeLimit.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsFilter_RangeLimit, "cmb_AprsFilter_RangeLimit");
      this.cmb_AprsFilter_RangeLimit.FormattingEnabled = true;
      this.cmb_AprsFilter_RangeLimit.Name = "cmb_AprsFilter_RangeLimit";
      componentResourceManager.ApplyResources((object) this.lbl_AprsFilter_RangeLimit, "lbl_AprsFilter_RangeLimit");
      this.lbl_AprsFilter_RangeLimit.Name = "lbl_AprsFilter_RangeLimit";
      this.cmb_AprsFilter_Altnet.BackColor = SystemColors.Window;
      this.cmb_AprsFilter_Altnet.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsFilter_Altnet, "cmb_AprsFilter_Altnet");
      this.cmb_AprsFilter_Altnet.FormattingEnabled = true;
      this.cmb_AprsFilter_Altnet.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsFilter_Altnet.Items"),
        (object) componentResourceManager.GetString("cmb_AprsFilter_Altnet.Items1")
      });
      this.cmb_AprsFilter_Altnet.Name = "cmb_AprsFilter_Altnet";
      componentResourceManager.ApplyResources((object) this.lbl_AprsFilter_Altnet, "lbl_AprsFilter_Altnet");
      this.lbl_AprsFilter_Altnet.Name = "lbl_AprsFilter_Altnet";
      this.cmb_AprsFilter_Other.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsFilter_Other, "cmb_AprsFilter_Other");
      this.cmb_AprsFilter_Other.FormattingEnabled = true;
      this.cmb_AprsFilter_Other.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsFilter_Other.Items"),
        (object) componentResourceManager.GetString("cmb_AprsFilter_Other.Items1")
      });
      this.cmb_AprsFilter_Other.Name = "cmb_AprsFilter_Other";
      componentResourceManager.ApplyResources((object) this.lbl_AprsFilter_Other, "lbl_AprsFilter_Other");
      this.lbl_AprsFilter_Other.Name = "lbl_AprsFilter_Other";
      this.cmb_AprsFilter_Status.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsFilter_Status, "cmb_AprsFilter_Status");
      this.cmb_AprsFilter_Status.FormattingEnabled = true;
      this.cmb_AprsFilter_Status.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsFilter_Status.Items"),
        (object) componentResourceManager.GetString("cmb_AprsFilter_Status.Items1")
      });
      this.cmb_AprsFilter_Status.Name = "cmb_AprsFilter_Status";
      componentResourceManager.ApplyResources((object) this.lbl_AprsFilter_Status, "lbl_AprsFilter_Status");
      this.lbl_AprsFilter_Status.Name = "lbl_AprsFilter_Status";
      this.cmb_AprsFilter_Object.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsFilter_Object, "cmb_AprsFilter_Object");
      this.cmb_AprsFilter_Object.FormattingEnabled = true;
      this.cmb_AprsFilter_Object.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsFilter_Object.Items"),
        (object) componentResourceManager.GetString("cmb_AprsFilter_Object.Items1")
      });
      this.cmb_AprsFilter_Object.Name = "cmb_AprsFilter_Object";
      componentResourceManager.ApplyResources((object) this.lbl_AprsFilter_Object, "lbl_AprsFilter_Object");
      this.lbl_AprsFilter_Object.Name = "lbl_AprsFilter_Object";
      this.cmb_AprsFilter_Item.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsFilter_Item, "cmb_AprsFilter_Item");
      this.cmb_AprsFilter_Item.FormattingEnabled = true;
      this.cmb_AprsFilter_Item.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsFilter_Item.Items"),
        (object) componentResourceManager.GetString("cmb_AprsFilter_Item.Items1")
      });
      this.cmb_AprsFilter_Item.Name = "cmb_AprsFilter_Item";
      componentResourceManager.ApplyResources((object) this.lbl_AprsFilter_Item, "lbl_AprsFilter_Item");
      this.lbl_AprsFilter_Item.Name = "lbl_AprsFilter_Item";
      this.cmb_AprsFilter_Weather.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsFilter_Weather, "cmb_AprsFilter_Weather");
      this.cmb_AprsFilter_Weather.FormattingEnabled = true;
      this.cmb_AprsFilter_Weather.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsFilter_Weather.Items"),
        (object) componentResourceManager.GetString("cmb_AprsFilter_Weather.Items1")
      });
      this.cmb_AprsFilter_Weather.Name = "cmb_AprsFilter_Weather";
      componentResourceManager.ApplyResources((object) this.lbl_AprsFilter_Weather, "lbl_AprsFilter_Weather");
      this.lbl_AprsFilter_Weather.Name = "lbl_AprsFilter_Weather";
      this.cmb_AprsFilter_Position.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsFilter_Position, "cmb_AprsFilter_Position");
      this.cmb_AprsFilter_Position.FormattingEnabled = true;
      this.cmb_AprsFilter_Position.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsFilter_Position.Items"),
        (object) componentResourceManager.GetString("cmb_AprsFilter_Position.Items1")
      });
      this.cmb_AprsFilter_Position.Name = "cmb_AprsFilter_Position";
      componentResourceManager.ApplyResources((object) this.lbl_AprsFilter_Position, "lbl_AprsFilter_Position");
      this.lbl_AprsFilter_Position.Name = "lbl_AprsFilter_Position";
      this.cmb_AprsFilter_MicE.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsFilter_MicE, "cmb_AprsFilter_MicE");
      this.cmb_AprsFilter_MicE.FormattingEnabled = true;
      this.cmb_AprsFilter_MicE.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsFilter_MicE.Items"),
        (object) componentResourceManager.GetString("cmb_AprsFilter_MicE.Items1")
      });
      this.cmb_AprsFilter_MicE.Name = "cmb_AprsFilter_MicE";
      componentResourceManager.ApplyResources((object) this.lbl_AprsFilter_MicE, "lbl_AprsFilter_MicE");
      this.lbl_AprsFilter_MicE.Name = "lbl_AprsFilter_MicE";
      componentResourceManager.ApplyResources((object) this.tab_AprsGps, "tab_AprsGps");
      this.tab_AprsGps.BackColor = SystemColors.Control;
      this.tab_AprsGps.Controls.Add((Control) this.grb_MyPosition);
      this.tab_AprsGps.Controls.Add((Control) this.grp_VoiceAleat);
      this.tab_AprsGps.Controls.Add((Control) this.grp_SortFilter);
      this.tab_AprsGps.Controls.Add((Control) this.grp_AprsPopupColor);
      this.tab_AprsGps.Controls.Add((Control) this.grb_AprsPopup);
      this.tab_AprsGps.Controls.Add((Control) this.grb_DigiPath);
      this.tab_AprsGps.Controls.Add((Control) this.grb_AprsMsgText);
      this.tab_AprsGps.Controls.Add((Control) this.grb_MySymbol);
      this.tab_AprsGps.Controls.Add((Control) this.grb_AprsMsgGroup);
      this.tab_AprsGps.Controls.Add((Control) this.grb_MsgReply);
      this.tab_AprsGps.Controls.Add((Control) this.grb_AprsCommon);
      this.tab_AprsGps.Name = "tab_AprsGps";
      this.grb_MyPosition.Controls.Add((Control) this.nud_MyPosition_ManualLonMM2);
      this.grb_MyPosition.Controls.Add((Control) this.cmb_MyPosition_ManualLon);
      this.grb_MyPosition.Controls.Add((Control) this.nud_MyPosition_ManualLatMM2);
      this.grb_MyPosition.Controls.Add((Control) this.cmb_MyPosition_ManualLat);
      this.grb_MyPosition.Controls.Add((Control) this.label233);
      this.grb_MyPosition.Controls.Add((Control) this.label230);
      this.grb_MyPosition.Controls.Add((Control) this.label234);
      this.grb_MyPosition.Controls.Add((Control) this.label229);
      this.grb_MyPosition.Controls.Add((Control) this.nud_MyPosition_ManualLonMM1);
      this.grb_MyPosition.Controls.Add((Control) this.rdb_MyPosition_Manual);
      this.grb_MyPosition.Controls.Add((Control) this.nud_MyPosition_ManualLatMM1);
      this.grb_MyPosition.Controls.Add((Control) this.rdb_MyPosition_Gps);
      this.grb_MyPosition.Controls.Add((Control) this.nud_MyPosition_ManualLonDD);
      this.grb_MyPosition.Controls.Add((Control) this.nud_MyPosition_ManualLatDD);
      this.grb_MyPosition.Controls.Add((Control) this.label232);
      this.grb_MyPosition.Controls.Add((Control) this.label231);
      componentResourceManager.ApplyResources((object) this.grb_MyPosition, "grb_MyPosition");
      this.grb_MyPosition.Name = "grb_MyPosition";
      this.grb_MyPosition.TabStop = false;
      componentResourceManager.ApplyResources((object) this.nud_MyPosition_ManualLonMM2, "nud_MyPosition_ManualLonMM2");
      this.nud_MyPosition_ManualLonMM2.Maximum = new Decimal(new int[4]
      {
        99,
        0,
        0,
        0
      });
      this.nud_MyPosition_ManualLonMM2.Name = "nud_MyPosition_ManualLonMM2";
      this.cmb_MyPosition_ManualLon.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_MyPosition_ManualLon, "cmb_MyPosition_ManualLon");
      this.cmb_MyPosition_ManualLon.FormattingEnabled = true;
      this.cmb_MyPosition_ManualLon.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_MyPosition_ManualLon.Items"),
        (object) componentResourceManager.GetString("cmb_MyPosition_ManualLon.Items1")
      });
      this.cmb_MyPosition_ManualLon.Name = "cmb_MyPosition_ManualLon";
      componentResourceManager.ApplyResources((object) this.nud_MyPosition_ManualLatMM2, "nud_MyPosition_ManualLatMM2");
      this.nud_MyPosition_ManualLatMM2.Maximum = new Decimal(new int[4]
      {
        99,
        0,
        0,
        0
      });
      this.nud_MyPosition_ManualLatMM2.Name = "nud_MyPosition_ManualLatMM2";
      this.cmb_MyPosition_ManualLat.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_MyPosition_ManualLat, "cmb_MyPosition_ManualLat");
      this.cmb_MyPosition_ManualLat.FormattingEnabled = true;
      this.cmb_MyPosition_ManualLat.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_MyPosition_ManualLat.Items"),
        (object) componentResourceManager.GetString("cmb_MyPosition_ManualLat.Items1")
      });
      this.cmb_MyPosition_ManualLat.Name = "cmb_MyPosition_ManualLat";
      componentResourceManager.ApplyResources((object) this.label233, "label233");
      this.label233.Name = "label233";
      componentResourceManager.ApplyResources((object) this.label230, "label230");
      this.label230.Name = "label230";
      componentResourceManager.ApplyResources((object) this.label234, "label234");
      this.label234.Name = "label234";
      componentResourceManager.ApplyResources((object) this.label229, "label229");
      this.label229.Name = "label229";
      componentResourceManager.ApplyResources((object) this.nud_MyPosition_ManualLonMM1, "nud_MyPosition_ManualLonMM1");
      this.nud_MyPosition_ManualLonMM1.Maximum = new Decimal(new int[4]
      {
        59,
        0,
        0,
        0
      });
      this.nud_MyPosition_ManualLonMM1.Name = "nud_MyPosition_ManualLonMM1";
      componentResourceManager.ApplyResources((object) this.rdb_MyPosition_Manual, "rdb_MyPosition_Manual");
      this.rdb_MyPosition_Manual.Name = "rdb_MyPosition_Manual";
      this.rdb_MyPosition_Manual.TabStop = true;
      this.rdb_MyPosition_Manual.UseVisualStyleBackColor = true;
      this.rdb_MyPosition_Manual.CheckedChanged += new EventHandler(this.rdb_MyPosition_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.nud_MyPosition_ManualLatMM1, "nud_MyPosition_ManualLatMM1");
      this.nud_MyPosition_ManualLatMM1.Maximum = new Decimal(new int[4]
      {
        59,
        0,
        0,
        0
      });
      this.nud_MyPosition_ManualLatMM1.Name = "nud_MyPosition_ManualLatMM1";
      componentResourceManager.ApplyResources((object) this.rdb_MyPosition_Gps, "rdb_MyPosition_Gps");
      this.rdb_MyPosition_Gps.Name = "rdb_MyPosition_Gps";
      this.rdb_MyPosition_Gps.TabStop = true;
      this.rdb_MyPosition_Gps.UseVisualStyleBackColor = true;
      this.rdb_MyPosition_Gps.CheckedChanged += new EventHandler(this.rdb_MyPosition_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.nud_MyPosition_ManualLonDD, "nud_MyPosition_ManualLonDD");
      this.nud_MyPosition_ManualLonDD.Maximum = new Decimal(new int[4]
      {
        179,
        0,
        0,
        0
      });
      this.nud_MyPosition_ManualLonDD.Name = "nud_MyPosition_ManualLonDD";
      componentResourceManager.ApplyResources((object) this.nud_MyPosition_ManualLatDD, "nud_MyPosition_ManualLatDD");
      this.nud_MyPosition_ManualLatDD.Maximum = new Decimal(new int[4]
      {
        89,
        0,
        0,
        0
      });
      this.nud_MyPosition_ManualLatDD.Name = "nud_MyPosition_ManualLatDD";
      componentResourceManager.ApplyResources((object) this.label232, "label232");
      this.label232.Name = "label232";
      componentResourceManager.ApplyResources((object) this.label231, "label231");
      this.label231.Name = "label231";
      this.grp_VoiceAleat.Controls.Add((Control) this.lbl_VoiceAleat_Dcs);
      this.grp_VoiceAleat.Controls.Add((Control) this.cmb_VoiceAleat_Dcs);
      this.grp_VoiceAleat.Controls.Add((Control) this.lbl_VoiceAleat_ToneSql);
      this.grp_VoiceAleat.Controls.Add((Control) this.cmb_VoiceAleat_ToneSql);
      this.grp_VoiceAleat.Controls.Add((Control) this.lbl_VoiceAleat_VoiceAleat);
      this.grp_VoiceAleat.Controls.Add((Control) this.cmb_VoiceAleat_VoiceAleat);
      componentResourceManager.ApplyResources((object) this.grp_VoiceAleat, "grp_VoiceAleat");
      this.grp_VoiceAleat.Name = "grp_VoiceAleat";
      this.grp_VoiceAleat.TabStop = false;
      componentResourceManager.ApplyResources((object) this.lbl_VoiceAleat_Dcs, "lbl_VoiceAleat_Dcs");
      this.lbl_VoiceAleat_Dcs.Name = "lbl_VoiceAleat_Dcs";
      this.cmb_VoiceAleat_Dcs.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_VoiceAleat_Dcs, "cmb_VoiceAleat_Dcs");
      this.cmb_VoiceAleat_Dcs.FormattingEnabled = true;
      this.cmb_VoiceAleat_Dcs.Items.AddRange(new object[104]
      {
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items1"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items2"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items3"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items4"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items5"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items6"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items7"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items8"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items9"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items10"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items11"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items12"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items13"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items14"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items15"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items16"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items17"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items18"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items19"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items20"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items21"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items22"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items23"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items24"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items25"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items26"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items27"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items28"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items29"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items30"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items31"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items32"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items33"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items34"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items35"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items36"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items37"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items38"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items39"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items40"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items41"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items42"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items43"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items44"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items45"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items46"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items47"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items48"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items49"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items50"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items51"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items52"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items53"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items54"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items55"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items56"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items57"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items58"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items59"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items60"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items61"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items62"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items63"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items64"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items65"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items66"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items67"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items68"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items69"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items70"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items71"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items72"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items73"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items74"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items75"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items76"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items77"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items78"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items79"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items80"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items81"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items82"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items83"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items84"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items85"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items86"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items87"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items88"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items89"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items90"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items91"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items92"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items93"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items94"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items95"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items96"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items97"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items98"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items99"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items100"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items101"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items102"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_Dcs.Items103")
      });
      this.cmb_VoiceAleat_Dcs.Name = "cmb_VoiceAleat_Dcs";
      componentResourceManager.ApplyResources((object) this.lbl_VoiceAleat_ToneSql, "lbl_VoiceAleat_ToneSql");
      this.lbl_VoiceAleat_ToneSql.Name = "lbl_VoiceAleat_ToneSql";
      this.cmb_VoiceAleat_ToneSql.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_VoiceAleat_ToneSql, "cmb_VoiceAleat_ToneSql");
      this.cmb_VoiceAleat_ToneSql.FormattingEnabled = true;
      this.cmb_VoiceAleat_ToneSql.Items.AddRange(new object[50]
      {
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items1"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items2"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items3"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items4"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items5"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items6"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items7"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items8"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items9"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items10"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items11"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items12"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items13"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items14"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items15"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items16"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items17"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items18"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items19"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items20"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items21"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items22"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items23"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items24"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items25"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items26"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items27"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items28"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items29"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items30"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items31"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items32"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items33"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items34"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items35"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items36"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items37"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items38"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items39"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items40"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items41"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items42"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items43"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items44"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items45"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items46"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items47"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items48"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_ToneSql.Items49")
      });
      this.cmb_VoiceAleat_ToneSql.Name = "cmb_VoiceAleat_ToneSql";
      componentResourceManager.ApplyResources((object) this.lbl_VoiceAleat_VoiceAleat, "lbl_VoiceAleat_VoiceAleat");
      this.lbl_VoiceAleat_VoiceAleat.Name = "lbl_VoiceAleat_VoiceAleat";
      this.cmb_VoiceAleat_VoiceAleat.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_VoiceAleat_VoiceAleat, "cmb_VoiceAleat_VoiceAleat");
      this.cmb_VoiceAleat_VoiceAleat.FormattingEnabled = true;
      this.cmb_VoiceAleat_VoiceAleat.Items.AddRange(new object[5]
      {
        (object) componentResourceManager.GetString("cmb_VoiceAleat_VoiceAleat.Items"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_VoiceAleat.Items1"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_VoiceAleat.Items2"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_VoiceAleat.Items3"),
        (object) componentResourceManager.GetString("cmb_VoiceAleat_VoiceAleat.Items4")
      });
      this.cmb_VoiceAleat_VoiceAleat.Name = "cmb_VoiceAleat_VoiceAleat";
      this.grp_SortFilter.Controls.Add((Control) this.lbl_SortFilter_Filter);
      this.grp_SortFilter.Controls.Add((Control) this.cmb_SortFilter_Filter);
      this.grp_SortFilter.Controls.Add((Control) this.lbl_SortFilter_Sort);
      this.grp_SortFilter.Controls.Add((Control) this.cmb_SortFilter_Sort);
      componentResourceManager.ApplyResources((object) this.grp_SortFilter, "grp_SortFilter");
      this.grp_SortFilter.Name = "grp_SortFilter";
      this.grp_SortFilter.TabStop = false;
      componentResourceManager.ApplyResources((object) this.lbl_SortFilter_Filter, "lbl_SortFilter_Filter");
      this.lbl_SortFilter_Filter.Name = "lbl_SortFilter_Filter";
      this.cmb_SortFilter_Filter.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_SortFilter_Filter, "cmb_SortFilter_Filter");
      this.cmb_SortFilter_Filter.FormattingEnabled = true;
      this.cmb_SortFilter_Filter.Items.AddRange(new object[13]
      {
        (object) componentResourceManager.GetString("cmb_SortFilter_Filter.Items"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Filter.Items1"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Filter.Items2"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Filter.Items3"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Filter.Items4"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Filter.Items5"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Filter.Items6"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Filter.Items7"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Filter.Items8"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Filter.Items9"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Filter.Items10"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Filter.Items11"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Filter.Items12")
      });
      this.cmb_SortFilter_Filter.Name = "cmb_SortFilter_Filter";
      componentResourceManager.ApplyResources((object) this.lbl_SortFilter_Sort, "lbl_SortFilter_Sort");
      this.lbl_SortFilter_Sort.Name = "lbl_SortFilter_Sort";
      this.cmb_SortFilter_Sort.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_SortFilter_Sort, "cmb_SortFilter_Sort");
      this.cmb_SortFilter_Sort.FormattingEnabled = true;
      this.cmb_SortFilter_Sort.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_SortFilter_Sort.Items"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Sort.Items1"),
        (object) componentResourceManager.GetString("cmb_SortFilter_Sort.Items2")
      });
      this.cmb_SortFilter_Sort.Name = "cmb_SortFilter_Sort";
      this.grp_AprsPopupColor.Controls.Add((Control) this.cmb_AprsPopupColor_MyPckt);
      this.grp_AprsPopupColor.Controls.Add((Control) this.lbl_AprsPopupColor_MyPckt);
      this.grp_AprsPopupColor.Controls.Add((Control) this.cmb_AprsPopupColor_GrpBult);
      this.grp_AprsPopupColor.Controls.Add((Control) this.lbl_AprsPopupColor_GrpBult);
      this.grp_AprsPopupColor.Controls.Add((Control) this.cmb_AprsPopupColor_Msg);
      this.grp_AprsPopupColor.Controls.Add((Control) this.lbl_AprsPopupColor_Msg);
      this.grp_AprsPopupColor.Controls.Add((Control) this.cmb_AprsPopupColor_CllRngr);
      this.grp_AprsPopupColor.Controls.Add((Control) this.lbl_AprsPopupColor_CllRngr);
      this.grp_AprsPopupColor.Controls.Add((Control) this.cmb_AprsPopupColor_RngRngr);
      this.grp_AprsPopupColor.Controls.Add((Control) this.lbl_AprsPopupColor_RngRngr);
      this.grp_AprsPopupColor.Controls.Add((Control) this.cmb_AprsPopupColor_ObjItm);
      this.grp_AprsPopupColor.Controls.Add((Control) this.lbl_AprsPopupColor_ObjItm);
      this.grp_AprsPopupColor.Controls.Add((Control) this.cmb_AprsPopupColor_Mbl);
      this.grp_AprsPopupColor.Controls.Add((Control) this.lbl_AprsPopupColor_Mbl);
      this.grp_AprsPopupColor.Controls.Add((Control) this.cmb_AprsPopupColor_Bcn);
      this.grp_AprsPopupColor.Controls.Add((Control) this.lbl_AprsPopupColor_Bcn);
      componentResourceManager.ApplyResources((object) this.grp_AprsPopupColor, "grp_AprsPopupColor");
      this.grp_AprsPopupColor.Name = "grp_AprsPopupColor";
      this.grp_AprsPopupColor.TabStop = false;
      this.cmb_AprsPopupColor_MyPckt.BackColor = SystemColors.Window;
      this.cmb_AprsPopupColor_MyPckt.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsPopupColor_MyPckt, "cmb_AprsPopupColor_MyPckt");
      this.cmb_AprsPopupColor_MyPckt.FormattingEnabled = true;
      this.cmb_AprsPopupColor_MyPckt.Items.AddRange(new object[9]
      {
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_MyPckt.Items"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_MyPckt.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_MyPckt.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_MyPckt.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_MyPckt.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_MyPckt.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_MyPckt.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_MyPckt.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_MyPckt.Items8")
      });
      this.cmb_AprsPopupColor_MyPckt.Name = "cmb_AprsPopupColor_MyPckt";
      componentResourceManager.ApplyResources((object) this.lbl_AprsPopupColor_MyPckt, "lbl_AprsPopupColor_MyPckt");
      this.lbl_AprsPopupColor_MyPckt.Name = "lbl_AprsPopupColor_MyPckt";
      this.cmb_AprsPopupColor_GrpBult.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsPopupColor_GrpBult, "cmb_AprsPopupColor_GrpBult");
      this.cmb_AprsPopupColor_GrpBult.FormattingEnabled = true;
      this.cmb_AprsPopupColor_GrpBult.Items.AddRange(new object[9]
      {
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_GrpBult.Items"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_GrpBult.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_GrpBult.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_GrpBult.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_GrpBult.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_GrpBult.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_GrpBult.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_GrpBult.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_GrpBult.Items8")
      });
      this.cmb_AprsPopupColor_GrpBult.Name = "cmb_AprsPopupColor_GrpBult";
      componentResourceManager.ApplyResources((object) this.lbl_AprsPopupColor_GrpBult, "lbl_AprsPopupColor_GrpBult");
      this.lbl_AprsPopupColor_GrpBult.Name = "lbl_AprsPopupColor_GrpBult";
      this.cmb_AprsPopupColor_Msg.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsPopupColor_Msg, "cmb_AprsPopupColor_Msg");
      this.cmb_AprsPopupColor_Msg.FormattingEnabled = true;
      this.cmb_AprsPopupColor_Msg.Items.AddRange(new object[9]
      {
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Msg.Items"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Msg.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Msg.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Msg.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Msg.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Msg.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Msg.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Msg.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Msg.Items8")
      });
      this.cmb_AprsPopupColor_Msg.Name = "cmb_AprsPopupColor_Msg";
      componentResourceManager.ApplyResources((object) this.lbl_AprsPopupColor_Msg, "lbl_AprsPopupColor_Msg");
      this.lbl_AprsPopupColor_Msg.Name = "lbl_AprsPopupColor_Msg";
      this.cmb_AprsPopupColor_CllRngr.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsPopupColor_CllRngr, "cmb_AprsPopupColor_CllRngr");
      this.cmb_AprsPopupColor_CllRngr.FormattingEnabled = true;
      this.cmb_AprsPopupColor_CllRngr.Items.AddRange(new object[9]
      {
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_CllRngr.Items"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_CllRngr.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_CllRngr.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_CllRngr.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_CllRngr.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_CllRngr.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_CllRngr.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_CllRngr.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_CllRngr.Items8")
      });
      this.cmb_AprsPopupColor_CllRngr.Name = "cmb_AprsPopupColor_CllRngr";
      componentResourceManager.ApplyResources((object) this.lbl_AprsPopupColor_CllRngr, "lbl_AprsPopupColor_CllRngr");
      this.lbl_AprsPopupColor_CllRngr.Name = "lbl_AprsPopupColor_CllRngr";
      this.cmb_AprsPopupColor_RngRngr.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsPopupColor_RngRngr, "cmb_AprsPopupColor_RngRngr");
      this.cmb_AprsPopupColor_RngRngr.FormattingEnabled = true;
      this.cmb_AprsPopupColor_RngRngr.Items.AddRange(new object[9]
      {
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_RngRngr.Items"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_RngRngr.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_RngRngr.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_RngRngr.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_RngRngr.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_RngRngr.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_RngRngr.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_RngRngr.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_RngRngr.Items8")
      });
      this.cmb_AprsPopupColor_RngRngr.Name = "cmb_AprsPopupColor_RngRngr";
      componentResourceManager.ApplyResources((object) this.lbl_AprsPopupColor_RngRngr, "lbl_AprsPopupColor_RngRngr");
      this.lbl_AprsPopupColor_RngRngr.Name = "lbl_AprsPopupColor_RngRngr";
      this.cmb_AprsPopupColor_ObjItm.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsPopupColor_ObjItm, "cmb_AprsPopupColor_ObjItm");
      this.cmb_AprsPopupColor_ObjItm.FormattingEnabled = true;
      this.cmb_AprsPopupColor_ObjItm.Items.AddRange(new object[9]
      {
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_ObjItm.Items"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_ObjItm.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_ObjItm.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_ObjItm.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_ObjItm.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_ObjItm.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_ObjItm.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_ObjItm.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_ObjItm.Items8")
      });
      this.cmb_AprsPopupColor_ObjItm.Name = "cmb_AprsPopupColor_ObjItm";
      componentResourceManager.ApplyResources((object) this.lbl_AprsPopupColor_ObjItm, "lbl_AprsPopupColor_ObjItm");
      this.lbl_AprsPopupColor_ObjItm.Name = "lbl_AprsPopupColor_ObjItm";
      this.cmb_AprsPopupColor_Mbl.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsPopupColor_Mbl, "cmb_AprsPopupColor_Mbl");
      this.cmb_AprsPopupColor_Mbl.FormattingEnabled = true;
      this.cmb_AprsPopupColor_Mbl.Items.AddRange(new object[9]
      {
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Mbl.Items"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Mbl.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Mbl.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Mbl.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Mbl.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Mbl.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Mbl.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Mbl.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Mbl.Items8")
      });
      this.cmb_AprsPopupColor_Mbl.Name = "cmb_AprsPopupColor_Mbl";
      componentResourceManager.ApplyResources((object) this.lbl_AprsPopupColor_Mbl, "lbl_AprsPopupColor_Mbl");
      this.lbl_AprsPopupColor_Mbl.Name = "lbl_AprsPopupColor_Mbl";
      this.cmb_AprsPopupColor_Bcn.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsPopupColor_Bcn, "cmb_AprsPopupColor_Bcn");
      this.cmb_AprsPopupColor_Bcn.FormattingEnabled = true;
      this.cmb_AprsPopupColor_Bcn.Items.AddRange(new object[9]
      {
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Bcn.Items"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Bcn.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Bcn.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Bcn.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Bcn.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Bcn.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Bcn.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Bcn.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsPopupColor_Bcn.Items8")
      });
      this.cmb_AprsPopupColor_Bcn.Name = "cmb_AprsPopupColor_Bcn";
      componentResourceManager.ApplyResources((object) this.lbl_AprsPopupColor_Bcn, "lbl_AprsPopupColor_Bcn");
      this.lbl_AprsPopupColor_Bcn.Name = "lbl_AprsPopupColor_Bcn";
      this.grb_AprsPopup.Controls.Add((Control) this.cmb_AprsPopup_Bcn);
      this.grb_AprsPopup.Controls.Add((Control) this.lbl_AprsPopup_Bcn);
      this.grb_AprsPopup.Controls.Add((Control) this.cmb_AprsPopup_Msg);
      this.grb_AprsPopup.Controls.Add((Control) this.lbl_AprsPopup_Msg);
      this.grb_AprsPopup.Controls.Add((Control) this.cmb_AprsPopup_MyPacket);
      this.grb_AprsPopup.Controls.Add((Control) this.lbl_AprsPopup_MyPacket);
      componentResourceManager.ApplyResources((object) this.grb_AprsPopup, "grb_AprsPopup");
      this.grb_AprsPopup.Name = "grb_AprsPopup";
      this.grb_AprsPopup.TabStop = false;
      this.cmb_AprsPopup_Bcn.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsPopup_Bcn, "cmb_AprsPopup_Bcn");
      this.cmb_AprsPopup_Bcn.FormattingEnabled = true;
      this.cmb_AprsPopup_Bcn.Items.AddRange(new object[5]
      {
        (object) componentResourceManager.GetString("cmb_AprsPopup_Bcn.Items"),
        (object) componentResourceManager.GetString("cmb_AprsPopup_Bcn.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsPopup_Bcn.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsPopup_Bcn.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsPopup_Bcn.Items4")
      });
      this.cmb_AprsPopup_Bcn.Name = "cmb_AprsPopup_Bcn";
      componentResourceManager.ApplyResources((object) this.lbl_AprsPopup_Bcn, "lbl_AprsPopup_Bcn");
      this.lbl_AprsPopup_Bcn.Name = "lbl_AprsPopup_Bcn";
      this.cmb_AprsPopup_Msg.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsPopup_Msg, "cmb_AprsPopup_Msg");
      this.cmb_AprsPopup_Msg.FormattingEnabled = true;
      this.cmb_AprsPopup_Msg.Items.AddRange(new object[5]
      {
        (object) componentResourceManager.GetString("cmb_AprsPopup_Msg.Items"),
        (object) componentResourceManager.GetString("cmb_AprsPopup_Msg.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsPopup_Msg.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsPopup_Msg.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsPopup_Msg.Items4")
      });
      this.cmb_AprsPopup_Msg.Name = "cmb_AprsPopup_Msg";
      componentResourceManager.ApplyResources((object) this.lbl_AprsPopup_Msg, "lbl_AprsPopup_Msg");
      this.lbl_AprsPopup_Msg.Name = "lbl_AprsPopup_Msg";
      this.cmb_AprsPopup_MyPacket.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsPopup_MyPacket, "cmb_AprsPopup_MyPacket");
      this.cmb_AprsPopup_MyPacket.FormattingEnabled = true;
      this.cmb_AprsPopup_MyPacket.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsPopup_MyPacket.Items"),
        (object) componentResourceManager.GetString("cmb_AprsPopup_MyPacket.Items1")
      });
      this.cmb_AprsPopup_MyPacket.Name = "cmb_AprsPopup_MyPacket";
      componentResourceManager.ApplyResources((object) this.lbl_AprsPopup_MyPacket, "lbl_AprsPopup_MyPacket");
      this.lbl_AprsPopup_MyPacket.Name = "lbl_AprsPopup_MyPacket";
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F28);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F27);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F26);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F25);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F24);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F23);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F22);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F21);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F18);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F17);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F16);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F15);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F14);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F13);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F12);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_F11);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_P42);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_P32);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_P22);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_P12);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_P41);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_P31);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_P21);
      this.grb_DigiPath.Controls.Add((Control) this.cmb_DigiPathSsId_P11);
      this.grb_DigiPath.Controls.Add((Control) this.rdb_DigiPath_F2);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F28);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F27);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F26);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F25);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F24);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F23);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F22);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F21);
      this.grb_DigiPath.Controls.Add((Control) this.label182);
      this.grb_DigiPath.Controls.Add((Control) this.label183);
      this.grb_DigiPath.Controls.Add((Control) this.label180);
      this.grb_DigiPath.Controls.Add((Control) this.label181);
      this.grb_DigiPath.Controls.Add((Control) this.label178);
      this.grb_DigiPath.Controls.Add((Control) this.label179);
      this.grb_DigiPath.Controls.Add((Control) this.label176);
      this.grb_DigiPath.Controls.Add((Control) this.label177);
      this.grb_DigiPath.Controls.Add((Control) this.label174);
      this.grb_DigiPath.Controls.Add((Control) this.label175);
      this.grb_DigiPath.Controls.Add((Control) this.label172);
      this.grb_DigiPath.Controls.Add((Control) this.label173);
      this.grb_DigiPath.Controls.Add((Control) this.label170);
      this.grb_DigiPath.Controls.Add((Control) this.label171);
      this.grb_DigiPath.Controls.Add((Control) this.label168);
      this.grb_DigiPath.Controls.Add((Control) this.label169);
      this.grb_DigiPath.Controls.Add((Control) this.label167);
      this.grb_DigiPath.Controls.Add((Control) this.label166);
      this.grb_DigiPath.Controls.Add((Control) this.rdb_DigiPath_F1);
      this.grb_DigiPath.Controls.Add((Control) this.rdb_DigiPath_P4);
      this.grb_DigiPath.Controls.Add((Control) this.rdb_DigiPath_P3);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F18);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F17);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F16);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F15);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F14);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F13);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F12);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_F11);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_P42);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_P41);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_P32);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_P31);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_P22);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_P21);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_P12);
      this.grb_DigiPath.Controls.Add((Control) this.txt_DigiPathCode_P11);
      this.grb_DigiPath.Controls.Add((Control) this.rdb_DigiPath_P2);
      this.grb_DigiPath.Controls.Add((Control) this.rdb_DigiPath_P1);
      this.grb_DigiPath.Controls.Add((Control) this.rdb_DigiPath_2Wide);
      this.grb_DigiPath.Controls.Add((Control) this.rdb_DigiPath_1Wide);
      this.grb_DigiPath.Controls.Add((Control) this.rdb_DigiPath_Off);
      componentResourceManager.ApplyResources((object) this.grb_DigiPath, "grb_DigiPath");
      this.grb_DigiPath.Name = "grb_DigiPath";
      this.grb_DigiPath.TabStop = false;
      this.cmb_DigiPathSsId_F28.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F28, "cmb_DigiPathSsId_F28");
      this.cmb_DigiPathSsId_F28.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F28.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F28.Items15")
      });
      this.cmb_DigiPathSsId_F28.Name = "cmb_DigiPathSsId_F28";
      this.cmb_DigiPathSsId_F27.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F27, "cmb_DigiPathSsId_F27");
      this.cmb_DigiPathSsId_F27.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F27.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F27.Items15")
      });
      this.cmb_DigiPathSsId_F27.Name = "cmb_DigiPathSsId_F27";
      this.cmb_DigiPathSsId_F26.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F26, "cmb_DigiPathSsId_F26");
      this.cmb_DigiPathSsId_F26.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F26.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F26.Items15")
      });
      this.cmb_DigiPathSsId_F26.Name = "cmb_DigiPathSsId_F26";
      this.cmb_DigiPathSsId_F25.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F25, "cmb_DigiPathSsId_F25");
      this.cmb_DigiPathSsId_F25.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F25.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F25.Items15")
      });
      this.cmb_DigiPathSsId_F25.Name = "cmb_DigiPathSsId_F25";
      this.cmb_DigiPathSsId_F24.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F24, "cmb_DigiPathSsId_F24");
      this.cmb_DigiPathSsId_F24.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F24.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F24.Items15")
      });
      this.cmb_DigiPathSsId_F24.Name = "cmb_DigiPathSsId_F24";
      this.cmb_DigiPathSsId_F23.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F23, "cmb_DigiPathSsId_F23");
      this.cmb_DigiPathSsId_F23.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F23.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F23.Items15")
      });
      this.cmb_DigiPathSsId_F23.Name = "cmb_DigiPathSsId_F23";
      this.cmb_DigiPathSsId_F22.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F22, "cmb_DigiPathSsId_F22");
      this.cmb_DigiPathSsId_F22.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F22.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F22.Items15")
      });
      this.cmb_DigiPathSsId_F22.Name = "cmb_DigiPathSsId_F22";
      this.cmb_DigiPathSsId_F21.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F21, "cmb_DigiPathSsId_F21");
      this.cmb_DigiPathSsId_F21.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F21.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F21.Items15")
      });
      this.cmb_DigiPathSsId_F21.Name = "cmb_DigiPathSsId_F21";
      this.cmb_DigiPathSsId_F18.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F18, "cmb_DigiPathSsId_F18");
      this.cmb_DigiPathSsId_F18.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F18.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F18.Items15")
      });
      this.cmb_DigiPathSsId_F18.Name = "cmb_DigiPathSsId_F18";
      this.cmb_DigiPathSsId_F17.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F17, "cmb_DigiPathSsId_F17");
      this.cmb_DigiPathSsId_F17.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F17.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F17.Items15")
      });
      this.cmb_DigiPathSsId_F17.Name = "cmb_DigiPathSsId_F17";
      this.cmb_DigiPathSsId_F16.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F16, "cmb_DigiPathSsId_F16");
      this.cmb_DigiPathSsId_F16.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F16.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F16.Items15")
      });
      this.cmb_DigiPathSsId_F16.Name = "cmb_DigiPathSsId_F16";
      this.cmb_DigiPathSsId_F15.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F15, "cmb_DigiPathSsId_F15");
      this.cmb_DigiPathSsId_F15.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F15.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F15.Items15")
      });
      this.cmb_DigiPathSsId_F15.Name = "cmb_DigiPathSsId_F15";
      this.cmb_DigiPathSsId_F14.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F14, "cmb_DigiPathSsId_F14");
      this.cmb_DigiPathSsId_F14.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F14.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F14.Items15")
      });
      this.cmb_DigiPathSsId_F14.Name = "cmb_DigiPathSsId_F14";
      this.cmb_DigiPathSsId_F13.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F13, "cmb_DigiPathSsId_F13");
      this.cmb_DigiPathSsId_F13.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F13.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F13.Items15")
      });
      this.cmb_DigiPathSsId_F13.Name = "cmb_DigiPathSsId_F13";
      this.cmb_DigiPathSsId_F12.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F12, "cmb_DigiPathSsId_F12");
      this.cmb_DigiPathSsId_F12.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F12.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F12.Items15")
      });
      this.cmb_DigiPathSsId_F12.Name = "cmb_DigiPathSsId_F12";
      this.cmb_DigiPathSsId_F11.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_F11, "cmb_DigiPathSsId_F11");
      this.cmb_DigiPathSsId_F11.FormattingEnabled = true;
      this.cmb_DigiPathSsId_F11.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_F11.Items15")
      });
      this.cmb_DigiPathSsId_F11.Name = "cmb_DigiPathSsId_F11";
      this.cmb_DigiPathSsId_P42.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_P42, "cmb_DigiPathSsId_P42");
      this.cmb_DigiPathSsId_P42.FormattingEnabled = true;
      this.cmb_DigiPathSsId_P42.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P42.Items15")
      });
      this.cmb_DigiPathSsId_P42.Name = "cmb_DigiPathSsId_P42";
      this.cmb_DigiPathSsId_P32.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_P32, "cmb_DigiPathSsId_P32");
      this.cmb_DigiPathSsId_P32.FormattingEnabled = true;
      this.cmb_DigiPathSsId_P32.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P32.Items15")
      });
      this.cmb_DigiPathSsId_P32.Name = "cmb_DigiPathSsId_P32";
      this.cmb_DigiPathSsId_P22.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_P22, "cmb_DigiPathSsId_P22");
      this.cmb_DigiPathSsId_P22.FormattingEnabled = true;
      this.cmb_DigiPathSsId_P22.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P22.Items15")
      });
      this.cmb_DigiPathSsId_P22.Name = "cmb_DigiPathSsId_P22";
      this.cmb_DigiPathSsId_P12.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_P12, "cmb_DigiPathSsId_P12");
      this.cmb_DigiPathSsId_P12.FormattingEnabled = true;
      this.cmb_DigiPathSsId_P12.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P12.Items15")
      });
      this.cmb_DigiPathSsId_P12.Name = "cmb_DigiPathSsId_P12";
      this.cmb_DigiPathSsId_P41.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_P41, "cmb_DigiPathSsId_P41");
      this.cmb_DigiPathSsId_P41.FormattingEnabled = true;
      this.cmb_DigiPathSsId_P41.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P41.Items15")
      });
      this.cmb_DigiPathSsId_P41.Name = "cmb_DigiPathSsId_P41";
      this.cmb_DigiPathSsId_P31.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_P31, "cmb_DigiPathSsId_P31");
      this.cmb_DigiPathSsId_P31.FormattingEnabled = true;
      this.cmb_DigiPathSsId_P31.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P31.Items15")
      });
      this.cmb_DigiPathSsId_P31.Name = "cmb_DigiPathSsId_P31";
      this.cmb_DigiPathSsId_P21.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_P21, "cmb_DigiPathSsId_P21");
      this.cmb_DigiPathSsId_P21.FormattingEnabled = true;
      this.cmb_DigiPathSsId_P21.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P21.Items15")
      });
      this.cmb_DigiPathSsId_P21.Name = "cmb_DigiPathSsId_P21";
      this.cmb_DigiPathSsId_P11.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_DigiPathSsId_P11, "cmb_DigiPathSsId_P11");
      this.cmb_DigiPathSsId_P11.FormattingEnabled = true;
      this.cmb_DigiPathSsId_P11.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items1"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items2"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items3"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items4"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items5"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items6"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items7"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items8"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items9"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items10"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items11"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items12"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items13"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items14"),
        (object) componentResourceManager.GetString("cmb_DigiPathSsId_P11.Items15")
      });
      this.cmb_DigiPathSsId_P11.Name = "cmb_DigiPathSsId_P11";
      componentResourceManager.ApplyResources((object) this.rdb_DigiPath_F2, "rdb_DigiPath_F2");
      this.rdb_DigiPath_F2.Name = "rdb_DigiPath_F2";
      this.rdb_DigiPath_F2.TabStop = true;
      this.rdb_DigiPath_F2.UseVisualStyleBackColor = true;
      this.rdb_DigiPath_F2.CheckedChanged += new EventHandler(this.rdb_DigiPath_CheckedChanged);
      this.txt_DigiPathCode_F28.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F28, "txt_DigiPathCode_F28");
      this.txt_DigiPathCode_F28.Name = "txt_DigiPathCode_F28";
      this.txt_DigiPathCode_F28.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F27.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F27, "txt_DigiPathCode_F27");
      this.txt_DigiPathCode_F27.Name = "txt_DigiPathCode_F27";
      this.txt_DigiPathCode_F27.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F26.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F26, "txt_DigiPathCode_F26");
      this.txt_DigiPathCode_F26.Name = "txt_DigiPathCode_F26";
      this.txt_DigiPathCode_F26.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F25.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F25, "txt_DigiPathCode_F25");
      this.txt_DigiPathCode_F25.Name = "txt_DigiPathCode_F25";
      this.txt_DigiPathCode_F25.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F24.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F24, "txt_DigiPathCode_F24");
      this.txt_DigiPathCode_F24.Name = "txt_DigiPathCode_F24";
      this.txt_DigiPathCode_F24.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F23.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F23, "txt_DigiPathCode_F23");
      this.txt_DigiPathCode_F23.Name = "txt_DigiPathCode_F23";
      this.txt_DigiPathCode_F23.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F22.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F22, "txt_DigiPathCode_F22");
      this.txt_DigiPathCode_F22.Name = "txt_DigiPathCode_F22";
      this.txt_DigiPathCode_F22.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F21.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F21, "txt_DigiPathCode_F21");
      this.txt_DigiPathCode_F21.Name = "txt_DigiPathCode_F21";
      this.txt_DigiPathCode_F21.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      componentResourceManager.ApplyResources((object) this.label182, "label182");
      this.label182.Name = "label182";
      componentResourceManager.ApplyResources((object) this.label183, "label183");
      this.label183.Name = "label183";
      componentResourceManager.ApplyResources((object) this.label180, "label180");
      this.label180.Name = "label180";
      componentResourceManager.ApplyResources((object) this.label181, "label181");
      this.label181.Name = "label181";
      componentResourceManager.ApplyResources((object) this.label178, "label178");
      this.label178.Name = "label178";
      componentResourceManager.ApplyResources((object) this.label179, "label179");
      this.label179.Name = "label179";
      componentResourceManager.ApplyResources((object) this.label176, "label176");
      this.label176.Name = "label176";
      componentResourceManager.ApplyResources((object) this.label177, "label177");
      this.label177.Name = "label177";
      componentResourceManager.ApplyResources((object) this.label174, "label174");
      this.label174.Name = "label174";
      componentResourceManager.ApplyResources((object) this.label175, "label175");
      this.label175.Name = "label175";
      componentResourceManager.ApplyResources((object) this.label172, "label172");
      this.label172.Name = "label172";
      componentResourceManager.ApplyResources((object) this.label173, "label173");
      this.label173.Name = "label173";
      componentResourceManager.ApplyResources((object) this.label170, "label170");
      this.label170.Name = "label170";
      componentResourceManager.ApplyResources((object) this.label171, "label171");
      this.label171.Name = "label171";
      componentResourceManager.ApplyResources((object) this.label168, "label168");
      this.label168.Name = "label168";
      componentResourceManager.ApplyResources((object) this.label169, "label169");
      this.label169.Name = "label169";
      componentResourceManager.ApplyResources((object) this.label167, "label167");
      this.label167.Name = "label167";
      componentResourceManager.ApplyResources((object) this.label166, "label166");
      this.label166.Name = "label166";
      componentResourceManager.ApplyResources((object) this.rdb_DigiPath_F1, "rdb_DigiPath_F1");
      this.rdb_DigiPath_F1.Name = "rdb_DigiPath_F1";
      this.rdb_DigiPath_F1.TabStop = true;
      this.rdb_DigiPath_F1.UseVisualStyleBackColor = true;
      this.rdb_DigiPath_F1.CheckedChanged += new EventHandler(this.rdb_DigiPath_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_DigiPath_P4, "rdb_DigiPath_P4");
      this.rdb_DigiPath_P4.Name = "rdb_DigiPath_P4";
      this.rdb_DigiPath_P4.TabStop = true;
      this.rdb_DigiPath_P4.UseVisualStyleBackColor = true;
      this.rdb_DigiPath_P4.CheckedChanged += new EventHandler(this.rdb_DigiPath_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_DigiPath_P3, "rdb_DigiPath_P3");
      this.rdb_DigiPath_P3.Name = "rdb_DigiPath_P3";
      this.rdb_DigiPath_P3.TabStop = true;
      this.rdb_DigiPath_P3.UseVisualStyleBackColor = true;
      this.rdb_DigiPath_P3.CheckedChanged += new EventHandler(this.rdb_DigiPath_CheckedChanged);
      this.txt_DigiPathCode_F18.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F18, "txt_DigiPathCode_F18");
      this.txt_DigiPathCode_F18.Name = "txt_DigiPathCode_F18";
      this.txt_DigiPathCode_F18.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F17.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F17, "txt_DigiPathCode_F17");
      this.txt_DigiPathCode_F17.Name = "txt_DigiPathCode_F17";
      this.txt_DigiPathCode_F17.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F16.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F16, "txt_DigiPathCode_F16");
      this.txt_DigiPathCode_F16.Name = "txt_DigiPathCode_F16";
      this.txt_DigiPathCode_F16.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F15.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F15, "txt_DigiPathCode_F15");
      this.txt_DigiPathCode_F15.Name = "txt_DigiPathCode_F15";
      this.txt_DigiPathCode_F15.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F14.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F14, "txt_DigiPathCode_F14");
      this.txt_DigiPathCode_F14.Name = "txt_DigiPathCode_F14";
      this.txt_DigiPathCode_F14.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F13.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F13, "txt_DigiPathCode_F13");
      this.txt_DigiPathCode_F13.Name = "txt_DigiPathCode_F13";
      this.txt_DigiPathCode_F13.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F12.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F12, "txt_DigiPathCode_F12");
      this.txt_DigiPathCode_F12.Name = "txt_DigiPathCode_F12";
      this.txt_DigiPathCode_F12.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_F11.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_F11, "txt_DigiPathCode_F11");
      this.txt_DigiPathCode_F11.Name = "txt_DigiPathCode_F11";
      this.txt_DigiPathCode_F11.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_P42.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_P42, "txt_DigiPathCode_P42");
      this.txt_DigiPathCode_P42.Name = "txt_DigiPathCode_P42";
      this.txt_DigiPathCode_P42.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_P41.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_P41, "txt_DigiPathCode_P41");
      this.txt_DigiPathCode_P41.Name = "txt_DigiPathCode_P41";
      this.txt_DigiPathCode_P41.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_P32.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_P32, "txt_DigiPathCode_P32");
      this.txt_DigiPathCode_P32.Name = "txt_DigiPathCode_P32";
      this.txt_DigiPathCode_P32.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_P31.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_P31, "txt_DigiPathCode_P31");
      this.txt_DigiPathCode_P31.Name = "txt_DigiPathCode_P31";
      this.txt_DigiPathCode_P31.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_P22.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_P22, "txt_DigiPathCode_P22");
      this.txt_DigiPathCode_P22.Name = "txt_DigiPathCode_P22";
      this.txt_DigiPathCode_P22.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_P21.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_P21, "txt_DigiPathCode_P21");
      this.txt_DigiPathCode_P21.Name = "txt_DigiPathCode_P21";
      this.txt_DigiPathCode_P21.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_P12.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_P12, "txt_DigiPathCode_P12");
      this.txt_DigiPathCode_P12.Name = "txt_DigiPathCode_P12";
      this.txt_DigiPathCode_P12.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      this.txt_DigiPathCode_P11.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_DigiPathCode_P11, "txt_DigiPathCode_P11");
      this.txt_DigiPathCode_P11.Name = "txt_DigiPathCode_P11";
      this.txt_DigiPathCode_P11.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      componentResourceManager.ApplyResources((object) this.rdb_DigiPath_P2, "rdb_DigiPath_P2");
      this.rdb_DigiPath_P2.Name = "rdb_DigiPath_P2";
      this.rdb_DigiPath_P2.TabStop = true;
      this.rdb_DigiPath_P2.UseVisualStyleBackColor = true;
      this.rdb_DigiPath_P2.CheckedChanged += new EventHandler(this.rdb_DigiPath_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_DigiPath_P1, "rdb_DigiPath_P1");
      this.rdb_DigiPath_P1.Name = "rdb_DigiPath_P1";
      this.rdb_DigiPath_P1.TabStop = true;
      this.rdb_DigiPath_P1.UseVisualStyleBackColor = true;
      this.rdb_DigiPath_P1.CheckedChanged += new EventHandler(this.rdb_DigiPath_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_DigiPath_2Wide, "rdb_DigiPath_2Wide");
      this.rdb_DigiPath_2Wide.Name = "rdb_DigiPath_2Wide";
      this.rdb_DigiPath_2Wide.TabStop = true;
      this.rdb_DigiPath_2Wide.UseVisualStyleBackColor = true;
      this.rdb_DigiPath_2Wide.CheckedChanged += new EventHandler(this.rdb_DigiPath_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_DigiPath_1Wide, "rdb_DigiPath_1Wide");
      this.rdb_DigiPath_1Wide.Name = "rdb_DigiPath_1Wide";
      this.rdb_DigiPath_1Wide.TabStop = true;
      this.rdb_DigiPath_1Wide.UseVisualStyleBackColor = true;
      this.rdb_DigiPath_1Wide.CheckedChanged += new EventHandler(this.rdb_DigiPath_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_DigiPath_Off, "rdb_DigiPath_Off");
      this.rdb_DigiPath_Off.Name = "rdb_DigiPath_Off";
      this.rdb_DigiPath_Off.TabStop = true;
      this.rdb_DigiPath_Off.UseVisualStyleBackColor = true;
      this.rdb_DigiPath_Off.CheckedChanged += new EventHandler(this.rdb_DigiPath_CheckedChanged);
      this.grb_AprsMsgText.Controls.Add((Control) this.txt_AprsMsgText_8);
      this.grb_AprsMsgText.Controls.Add((Control) this.rdb_AprsMsgText_8_No);
      this.grb_AprsMsgText.Controls.Add((Control) this.txt_AprsMsgText_7);
      this.grb_AprsMsgText.Controls.Add((Control) this.rdb_AprsMsgText_7_No);
      this.grb_AprsMsgText.Controls.Add((Control) this.txt_AprsMsgText_6);
      this.grb_AprsMsgText.Controls.Add((Control) this.rdb_AprsMsgText_6_No);
      this.grb_AprsMsgText.Controls.Add((Control) this.txt_AprsMsgText_5);
      this.grb_AprsMsgText.Controls.Add((Control) this.txt_AprsMsgText_4);
      this.grb_AprsMsgText.Controls.Add((Control) this.txt_AprsMsgText_3);
      this.grb_AprsMsgText.Controls.Add((Control) this.txt_AprsMsgText_2);
      this.grb_AprsMsgText.Controls.Add((Control) this.txt_AprsMsgText_1);
      this.grb_AprsMsgText.Controls.Add((Control) this.rdb_AprsMsgText_5_No);
      this.grb_AprsMsgText.Controls.Add((Control) this.rdb_AprsMsgText_4_No);
      this.grb_AprsMsgText.Controls.Add((Control) this.rdb_AprsMsgText_3_No);
      this.grb_AprsMsgText.Controls.Add((Control) this.rdb_AprsMsgText_2_No);
      this.grb_AprsMsgText.Controls.Add((Control) this.rdb_AprsMsgText_1_No);
      componentResourceManager.ApplyResources((object) this.grb_AprsMsgText, "grb_AprsMsgText");
      this.grb_AprsMsgText.Name = "grb_AprsMsgText";
      this.grb_AprsMsgText.TabStop = false;
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgText_8, "txt_AprsMsgText_8");
      this.txt_AprsMsgText_8.Name = "txt_AprsMsgText_8";
      componentResourceManager.ApplyResources((object) this.rdb_AprsMsgText_8_No, "rdb_AprsMsgText_8_No");
      this.rdb_AprsMsgText_8_No.Name = "rdb_AprsMsgText_8_No";
      this.rdb_AprsMsgText_8_No.TabStop = true;
      this.rdb_AprsMsgText_8_No.UseVisualStyleBackColor = true;
      this.rdb_AprsMsgText_8_No.CheckedChanged += new EventHandler(this.rdb_AprsMsgText_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgText_7, "txt_AprsMsgText_7");
      this.txt_AprsMsgText_7.Name = "txt_AprsMsgText_7";
      componentResourceManager.ApplyResources((object) this.rdb_AprsMsgText_7_No, "rdb_AprsMsgText_7_No");
      this.rdb_AprsMsgText_7_No.Name = "rdb_AprsMsgText_7_No";
      this.rdb_AprsMsgText_7_No.TabStop = true;
      this.rdb_AprsMsgText_7_No.UseVisualStyleBackColor = true;
      this.rdb_AprsMsgText_7_No.CheckedChanged += new EventHandler(this.rdb_AprsMsgText_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgText_6, "txt_AprsMsgText_6");
      this.txt_AprsMsgText_6.Name = "txt_AprsMsgText_6";
      componentResourceManager.ApplyResources((object) this.rdb_AprsMsgText_6_No, "rdb_AprsMsgText_6_No");
      this.rdb_AprsMsgText_6_No.Name = "rdb_AprsMsgText_6_No";
      this.rdb_AprsMsgText_6_No.TabStop = true;
      this.rdb_AprsMsgText_6_No.UseVisualStyleBackColor = true;
      this.rdb_AprsMsgText_6_No.CheckedChanged += new EventHandler(this.rdb_AprsMsgText_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgText_5, "txt_AprsMsgText_5");
      this.txt_AprsMsgText_5.Name = "txt_AprsMsgText_5";
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgText_4, "txt_AprsMsgText_4");
      this.txt_AprsMsgText_4.Name = "txt_AprsMsgText_4";
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgText_3, "txt_AprsMsgText_3");
      this.txt_AprsMsgText_3.Name = "txt_AprsMsgText_3";
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgText_2, "txt_AprsMsgText_2");
      this.txt_AprsMsgText_2.Name = "txt_AprsMsgText_2";
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgText_1, "txt_AprsMsgText_1");
      this.txt_AprsMsgText_1.Name = "txt_AprsMsgText_1";
      componentResourceManager.ApplyResources((object) this.rdb_AprsMsgText_5_No, "rdb_AprsMsgText_5_No");
      this.rdb_AprsMsgText_5_No.Name = "rdb_AprsMsgText_5_No";
      this.rdb_AprsMsgText_5_No.TabStop = true;
      this.rdb_AprsMsgText_5_No.UseVisualStyleBackColor = true;
      this.rdb_AprsMsgText_5_No.CheckedChanged += new EventHandler(this.rdb_AprsMsgText_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_AprsMsgText_4_No, "rdb_AprsMsgText_4_No");
      this.rdb_AprsMsgText_4_No.Name = "rdb_AprsMsgText_4_No";
      this.rdb_AprsMsgText_4_No.TabStop = true;
      this.rdb_AprsMsgText_4_No.UseVisualStyleBackColor = true;
      this.rdb_AprsMsgText_4_No.CheckedChanged += new EventHandler(this.rdb_AprsMsgText_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_AprsMsgText_3_No, "rdb_AprsMsgText_3_No");
      this.rdb_AprsMsgText_3_No.Name = "rdb_AprsMsgText_3_No";
      this.rdb_AprsMsgText_3_No.TabStop = true;
      this.rdb_AprsMsgText_3_No.UseVisualStyleBackColor = true;
      this.rdb_AprsMsgText_3_No.CheckedChanged += new EventHandler(this.rdb_AprsMsgText_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_AprsMsgText_2_No, "rdb_AprsMsgText_2_No");
      this.rdb_AprsMsgText_2_No.Name = "rdb_AprsMsgText_2_No";
      this.rdb_AprsMsgText_2_No.TabStop = true;
      this.rdb_AprsMsgText_2_No.UseVisualStyleBackColor = true;
      this.rdb_AprsMsgText_2_No.CheckedChanged += new EventHandler(this.rdb_AprsMsgText_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_AprsMsgText_1_No, "rdb_AprsMsgText_1_No");
      this.rdb_AprsMsgText_1_No.Name = "rdb_AprsMsgText_1_No";
      this.rdb_AprsMsgText_1_No.TabStop = true;
      this.rdb_AprsMsgText_1_No.UseVisualStyleBackColor = true;
      this.rdb_AprsMsgText_1_No.CheckedChanged += new EventHandler(this.rdb_AprsMsgText_CheckedChanged);
      this.grb_MySymbol.Controls.Add((Control) this.cmb_MySymbol_42_Icn);
      this.grb_MySymbol.Controls.Add((Control) this.btn_MySymbol_2);
      this.grb_MySymbol.Controls.Add((Control) this.btn_MySymbol_3);
      this.grb_MySymbol.Controls.Add((Control) this.btn_MySymbol_1);
      this.grb_MySymbol.Controls.Add((Control) this.cmb_MySymbol_41_Icn);
      this.grb_MySymbol.Controls.Add((Control) this.cmb_MySymbol_3_Icn);
      this.grb_MySymbol.Controls.Add((Control) this.cmb_MySymbol_2_Icn);
      this.grb_MySymbol.Controls.Add((Control) this.cmb_MySymbol_1_Icn);
      this.grb_MySymbol.Controls.Add((Control) this.rdb_MySymbol_4_Sel);
      this.grb_MySymbol.Controls.Add((Control) this.rdb_MySymbol_3_Sel);
      this.grb_MySymbol.Controls.Add((Control) this.rdb_MySymbol_2_Sel);
      this.grb_MySymbol.Controls.Add((Control) this.rdb_MySymbol_1_Sel);
      componentResourceManager.ApplyResources((object) this.grb_MySymbol, "grb_MySymbol");
      this.grb_MySymbol.Name = "grb_MySymbol";
      this.grb_MySymbol.TabStop = false;
      this.cmb_MySymbol_42_Icn.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_MySymbol_42_Icn, "cmb_MySymbol_42_Icn");
      this.cmb_MySymbol_42_Icn.FormattingEnabled = true;
      this.cmb_MySymbol_42_Icn.Items.AddRange(new object[94]
      {
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items1"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items2"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items3"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items4"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items5"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items6"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items7"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items8"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items9"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items10"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items11"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items12"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items13"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items14"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items15"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items16"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items17"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items18"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items19"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items20"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items21"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items22"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items23"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items24"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items25"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items26"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items27"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items28"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items29"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items30"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items31"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items32"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items33"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items34"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items35"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items36"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items37"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items38"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items39"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items40"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items41"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items42"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items43"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items44"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items45"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items46"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items47"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items48"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items49"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items50"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items51"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items52"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items53"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items54"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items55"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items56"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items57"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items58"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items59"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items60"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items61"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items62"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items63"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items64"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items65"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items66"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items67"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items68"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items69"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items70"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items71"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items72"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items73"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items74"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items75"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items76"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items77"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items78"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items79"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items80"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items81"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items82"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items83"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items84"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items85"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items86"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items87"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items88"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items89"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items90"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items91"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items92"),
        (object) componentResourceManager.GetString("cmb_MySymbol_42_Icn.Items93")
      });
      this.cmb_MySymbol_42_Icn.Name = "cmb_MySymbol_42_Icn";
      componentResourceManager.ApplyResources((object) this.btn_MySymbol_2, "btn_MySymbol_2");
      this.btn_MySymbol_2.Name = "btn_MySymbol_2";
      this.btn_MySymbol_2.UseVisualStyleBackColor = true;
      this.btn_MySymbol_2.Click += new EventHandler(this.btn_MySymbol_Click);
      componentResourceManager.ApplyResources((object) this.btn_MySymbol_3, "btn_MySymbol_3");
      this.btn_MySymbol_3.Name = "btn_MySymbol_3";
      this.btn_MySymbol_3.UseVisualStyleBackColor = true;
      this.btn_MySymbol_3.Click += new EventHandler(this.btn_MySymbol_Click);
      componentResourceManager.ApplyResources((object) this.btn_MySymbol_1, "btn_MySymbol_1");
      this.btn_MySymbol_1.Name = "btn_MySymbol_1";
      this.btn_MySymbol_1.UseVisualStyleBackColor = true;
      this.btn_MySymbol_1.Click += new EventHandler(this.btn_MySymbol_Click);
      this.cmb_MySymbol_41_Icn.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_MySymbol_41_Icn, "cmb_MySymbol_41_Icn");
      this.cmb_MySymbol_41_Icn.FormattingEnabled = true;
      this.cmb_MySymbol_41_Icn.Items.AddRange(new object[64]
      {
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items1"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items2"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items3"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items4"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items5"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items6"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items7"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items8"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items9"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items10"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items11"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items12"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items13"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items14"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items15"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items16"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items17"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items18"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items19"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items20"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items21"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items22"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items23"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items24"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items25"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items26"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items27"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items28"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items29"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items30"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items31"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items32"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items33"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items34"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items35"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items36"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items37"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items38"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items39"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items40"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items41"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items42"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items43"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items44"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items45"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items46"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items47"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items48"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items49"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items50"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items51"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items52"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items53"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items54"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items55"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items56"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items57"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items58"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items59"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items60"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items61"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items62"),
        (object) componentResourceManager.GetString("cmb_MySymbol_41_Icn.Items63")
      });
      this.cmb_MySymbol_41_Icn.Name = "cmb_MySymbol_41_Icn";
      this.cmb_MySymbol_3_Icn.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_MySymbol_3_Icn, "cmb_MySymbol_3_Icn");
      this.cmb_MySymbol_3_Icn.FormattingEnabled = true;
      this.cmb_MySymbol_3_Icn.Items.AddRange(new object[67]
      {
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items1"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items2"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items3"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items4"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items5"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items6"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items7"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items8"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items9"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items10"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items11"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items12"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items13"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items14"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items15"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items16"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items17"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items18"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items19"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items20"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items21"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items22"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items23"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items24"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items25"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items26"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items27"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items28"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items29"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items30"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items31"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items32"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items33"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items34"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items35"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items36"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items37"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items38"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items39"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items40"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items41"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items42"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items43"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items44"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items45"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items46"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items47"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items48"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items49"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items50"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items51"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items52"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items53"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items54"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items55"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items56"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items57"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items58"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items59"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items60"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items61"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items62"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items63"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items64"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items65"),
        (object) componentResourceManager.GetString("cmb_MySymbol_3_Icn.Items66")
      });
      this.cmb_MySymbol_3_Icn.Name = "cmb_MySymbol_3_Icn";
      this.cmb_MySymbol_2_Icn.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_MySymbol_2_Icn, "cmb_MySymbol_2_Icn");
      this.cmb_MySymbol_2_Icn.FormattingEnabled = true;
      this.cmb_MySymbol_2_Icn.Items.AddRange(new object[67]
      {
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items1"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items2"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items3"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items4"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items5"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items6"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items7"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items8"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items9"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items10"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items11"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items12"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items13"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items14"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items15"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items16"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items17"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items18"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items19"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items20"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items21"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items22"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items23"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items24"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items25"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items26"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items27"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items28"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items29"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items30"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items31"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items32"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items33"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items34"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items35"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items36"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items37"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items38"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items39"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items40"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items41"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items42"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items43"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items44"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items45"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items46"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items47"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items48"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items49"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items50"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items51"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items52"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items53"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items54"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items55"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items56"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items57"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items58"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items59"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items60"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items61"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items62"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items63"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items64"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items65"),
        (object) componentResourceManager.GetString("cmb_MySymbol_2_Icn.Items66")
      });
      this.cmb_MySymbol_2_Icn.Name = "cmb_MySymbol_2_Icn";
      this.cmb_MySymbol_1_Icn.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_MySymbol_1_Icn, "cmb_MySymbol_1_Icn");
      this.cmb_MySymbol_1_Icn.FormattingEnabled = true;
      this.cmb_MySymbol_1_Icn.Items.AddRange(new object[67]
      {
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items1"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items2"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items3"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items4"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items5"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items6"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items7"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items8"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items9"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items10"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items11"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items12"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items13"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items14"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items15"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items16"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items17"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items18"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items19"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items20"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items21"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items22"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items23"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items24"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items25"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items26"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items27"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items28"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items29"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items30"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items31"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items32"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items33"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items34"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items35"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items36"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items37"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items38"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items39"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items40"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items41"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items42"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items43"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items44"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items45"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items46"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items47"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items48"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items49"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items50"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items51"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items52"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items53"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items54"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items55"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items56"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items57"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items58"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items59"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items60"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items61"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items62"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items63"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items64"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items65"),
        (object) componentResourceManager.GetString("cmb_MySymbol_1_Icn.Items66")
      });
      this.cmb_MySymbol_1_Icn.Name = "cmb_MySymbol_1_Icn";
      componentResourceManager.ApplyResources((object) this.rdb_MySymbol_4_Sel, "rdb_MySymbol_4_Sel");
      this.rdb_MySymbol_4_Sel.Name = "rdb_MySymbol_4_Sel";
      this.rdb_MySymbol_4_Sel.TabStop = true;
      this.rdb_MySymbol_4_Sel.UseVisualStyleBackColor = true;
      this.rdb_MySymbol_4_Sel.CheckedChanged += new EventHandler(this.rdb_MySymbol_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_MySymbol_3_Sel, "rdb_MySymbol_3_Sel");
      this.rdb_MySymbol_3_Sel.Name = "rdb_MySymbol_3_Sel";
      this.rdb_MySymbol_3_Sel.TabStop = true;
      this.rdb_MySymbol_3_Sel.UseVisualStyleBackColor = true;
      this.rdb_MySymbol_3_Sel.CheckedChanged += new EventHandler(this.rdb_MySymbol_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_MySymbol_2_Sel, "rdb_MySymbol_2_Sel");
      this.rdb_MySymbol_2_Sel.Name = "rdb_MySymbol_2_Sel";
      this.rdb_MySymbol_2_Sel.TabStop = true;
      this.rdb_MySymbol_2_Sel.UseVisualStyleBackColor = true;
      this.rdb_MySymbol_2_Sel.CheckedChanged += new EventHandler(this.rdb_MySymbol_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_MySymbol_1_Sel, "rdb_MySymbol_1_Sel");
      this.rdb_MySymbol_1_Sel.Name = "rdb_MySymbol_1_Sel";
      this.rdb_MySymbol_1_Sel.TabStop = true;
      this.rdb_MySymbol_1_Sel.UseVisualStyleBackColor = true;
      this.rdb_MySymbol_1_Sel.CheckedChanged += new EventHandler(this.rdb_MySymbol_CheckedChanged);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.lbl_AprsMsgGroup_B3);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.txt_AprsMsgGroup_G6);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.lbl_AprsMsgGroup_B2);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.txt_AprsMsgGroup_B3);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.lbl_AprsMsgGroup_B1);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.txt_AprsMsgGroup_B2);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.lbl_AprsMsgGroup_G6);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.txt_AprsMsgGroup_B1);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.lbl_AprsMsgGroup_G5);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.txt_AprsMsgGroup_G5);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.lbl_AprsMsgGroup_G4);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.txt_AprsMsgGroup_G4);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.lbl_AprsMsgGroup_G3);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.txt_AprsMsgGroup_G3);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.lbl_AprsMsgGroup_G2);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.txt_AprsMsgGroup_G2);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.lbl_AprsMsgGroup_G1);
      this.grb_AprsMsgGroup.Controls.Add((Control) this.txt_AprsMsgGroup_G1);
      componentResourceManager.ApplyResources((object) this.grb_AprsMsgGroup, "grb_AprsMsgGroup");
      this.grb_AprsMsgGroup.Name = "grb_AprsMsgGroup";
      this.grb_AprsMsgGroup.TabStop = false;
      componentResourceManager.ApplyResources((object) this.lbl_AprsMsgGroup_B3, "lbl_AprsMsgGroup_B3");
      this.lbl_AprsMsgGroup_B3.Name = "lbl_AprsMsgGroup_B3";
      this.txt_AprsMsgGroup_G6.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgGroup_G6, "txt_AprsMsgGroup_G6");
      this.txt_AprsMsgGroup_G6.Name = "txt_AprsMsgGroup_G6";
      componentResourceManager.ApplyResources((object) this.lbl_AprsMsgGroup_B2, "lbl_AprsMsgGroup_B2");
      this.lbl_AprsMsgGroup_B2.Name = "lbl_AprsMsgGroup_B2";
      this.txt_AprsMsgGroup_B3.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgGroup_B3, "txt_AprsMsgGroup_B3");
      this.txt_AprsMsgGroup_B3.Name = "txt_AprsMsgGroup_B3";
      componentResourceManager.ApplyResources((object) this.lbl_AprsMsgGroup_B1, "lbl_AprsMsgGroup_B1");
      this.lbl_AprsMsgGroup_B1.Name = "lbl_AprsMsgGroup_B1";
      this.txt_AprsMsgGroup_B2.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgGroup_B2, "txt_AprsMsgGroup_B2");
      this.txt_AprsMsgGroup_B2.Name = "txt_AprsMsgGroup_B2";
      componentResourceManager.ApplyResources((object) this.lbl_AprsMsgGroup_G6, "lbl_AprsMsgGroup_G6");
      this.lbl_AprsMsgGroup_G6.Name = "lbl_AprsMsgGroup_G6";
      this.txt_AprsMsgGroup_B1.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgGroup_B1, "txt_AprsMsgGroup_B1");
      this.txt_AprsMsgGroup_B1.Name = "txt_AprsMsgGroup_B1";
      componentResourceManager.ApplyResources((object) this.lbl_AprsMsgGroup_G5, "lbl_AprsMsgGroup_G5");
      this.lbl_AprsMsgGroup_G5.Name = "lbl_AprsMsgGroup_G5";
      this.txt_AprsMsgGroup_G5.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgGroup_G5, "txt_AprsMsgGroup_G5");
      this.txt_AprsMsgGroup_G5.Name = "txt_AprsMsgGroup_G5";
      componentResourceManager.ApplyResources((object) this.lbl_AprsMsgGroup_G4, "lbl_AprsMsgGroup_G4");
      this.lbl_AprsMsgGroup_G4.Name = "lbl_AprsMsgGroup_G4";
      this.txt_AprsMsgGroup_G4.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgGroup_G4, "txt_AprsMsgGroup_G4");
      this.txt_AprsMsgGroup_G4.Name = "txt_AprsMsgGroup_G4";
      componentResourceManager.ApplyResources((object) this.lbl_AprsMsgGroup_G3, "lbl_AprsMsgGroup_G3");
      this.lbl_AprsMsgGroup_G3.Name = "lbl_AprsMsgGroup_G3";
      this.txt_AprsMsgGroup_G3.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgGroup_G3, "txt_AprsMsgGroup_G3");
      this.txt_AprsMsgGroup_G3.Name = "txt_AprsMsgGroup_G3";
      componentResourceManager.ApplyResources((object) this.lbl_AprsMsgGroup_G2, "lbl_AprsMsgGroup_G2");
      this.lbl_AprsMsgGroup_G2.Name = "lbl_AprsMsgGroup_G2";
      this.txt_AprsMsgGroup_G2.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgGroup_G2, "txt_AprsMsgGroup_G2");
      this.txt_AprsMsgGroup_G2.Name = "txt_AprsMsgGroup_G2";
      componentResourceManager.ApplyResources((object) this.lbl_AprsMsgGroup_G1, "lbl_AprsMsgGroup_G1");
      this.lbl_AprsMsgGroup_G1.Name = "lbl_AprsMsgGroup_G1";
      this.txt_AprsMsgGroup_G1.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsMsgGroup_G1, "txt_AprsMsgGroup_G1");
      this.txt_AprsMsgGroup_G1.Name = "txt_AprsMsgGroup_G1";
      this.grb_MsgReply.Controls.Add((Control) this.cmb_MsgReply_CallSignSsId);
      this.grb_MsgReply.Controls.Add((Control) this.txt_MsgReply_CallSignCode);
      this.grb_MsgReply.Controls.Add((Control) this.txt_MsgReply_ReplyText);
      this.grb_MsgReply.Controls.Add((Control) this.lbl_MsgReply_ReplyText);
      this.grb_MsgReply.Controls.Add((Control) this.lbl_MsgReply_CallSign);
      this.grb_MsgReply.Controls.Add((Control) this.cmb_MsgReply_Reply);
      this.grb_MsgReply.Controls.Add((Control) this.lbl_MsgReply_Reply);
      componentResourceManager.ApplyResources((object) this.grb_MsgReply, "grb_MsgReply");
      this.grb_MsgReply.Name = "grb_MsgReply";
      this.grb_MsgReply.TabStop = false;
      this.cmb_MsgReply_CallSignSsId.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_MsgReply_CallSignSsId, "cmb_MsgReply_CallSignSsId");
      this.cmb_MsgReply_CallSignSsId.FormattingEnabled = true;
      this.cmb_MsgReply_CallSignSsId.Items.AddRange(new object[17]
      {
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items1"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items2"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items3"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items4"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items5"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items6"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items7"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items8"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items9"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items10"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items11"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items12"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items13"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items14"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items15"),
        (object) componentResourceManager.GetString("cmb_MsgReply_CallSignSsId.Items16")
      });
      this.cmb_MsgReply_CallSignSsId.Name = "cmb_MsgReply_CallSignSsId";
      this.txt_MsgReply_CallSignCode.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_MsgReply_CallSignCode, "txt_MsgReply_CallSignCode");
      this.txt_MsgReply_CallSignCode.Name = "txt_MsgReply_CallSignCode";
      this.txt_MsgReply_CallSignCode.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      componentResourceManager.ApplyResources((object) this.txt_MsgReply_ReplyText, "txt_MsgReply_ReplyText");
      this.txt_MsgReply_ReplyText.Name = "txt_MsgReply_ReplyText";
      componentResourceManager.ApplyResources((object) this.lbl_MsgReply_ReplyText, "lbl_MsgReply_ReplyText");
      this.lbl_MsgReply_ReplyText.Name = "lbl_MsgReply_ReplyText";
      componentResourceManager.ApplyResources((object) this.lbl_MsgReply_CallSign, "lbl_MsgReply_CallSign");
      this.lbl_MsgReply_CallSign.Name = "lbl_MsgReply_CallSign";
      this.cmb_MsgReply_Reply.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_MsgReply_Reply, "cmb_MsgReply_Reply");
      this.cmb_MsgReply_Reply.FormattingEnabled = true;
      this.cmb_MsgReply_Reply.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_MsgReply_Reply.Items"),
        (object) componentResourceManager.GetString("cmb_MsgReply_Reply.Items1")
      });
      this.cmb_MsgReply_Reply.Name = "cmb_MsgReply_Reply";
      componentResourceManager.ApplyResources((object) this.lbl_MsgReply_Reply, "lbl_MsgReply_Reply");
      this.lbl_MsgReply_Reply.Name = "lbl_MsgReply_Reply";
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_CallsignSsId);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_RtLmt);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_RtLmt);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_Intrvl);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_Intrvl);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_LwSpd);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_LwSpd);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_Dcy);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_Dcy);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_Prprtnl);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_Prprtnl);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_Auto);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_Auto);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_BcnTx);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_Alttd);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_Alttd);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_SpdCrc);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_SpdCrc);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_Ambgty);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_Ambgty);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_BcnInfoSlct);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_Dst);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_Dst);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_PstnCmnt);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_PstnCmnt);
      this.grb_AprsCommon.Controls.Add((Control) this.txt_AprsCommon_CallsignCode);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_Callsign);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_TxDelay);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_TxDelay);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_Mute);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_Mute);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_Modem);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_Modem);
      this.grb_AprsCommon.Controls.Add((Control) this.cmb_AprsCommon_Cmps);
      this.grb_AprsCommon.Controls.Add((Control) this.lbl_AprsCommon_Cmps);
      componentResourceManager.ApplyResources((object) this.grb_AprsCommon, "grb_AprsCommon");
      this.grb_AprsCommon.Name = "grb_AprsCommon";
      this.grb_AprsCommon.TabStop = false;
      this.cmb_AprsCommon_CallsignSsId.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_CallsignSsId, "cmb_AprsCommon_CallsignSsId");
      this.cmb_AprsCommon_CallsignSsId.FormattingEnabled = true;
      this.cmb_AprsCommon_CallsignSsId.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items9"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items10"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items11"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items12"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items13"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items14"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_CallsignSsId.Items15")
      });
      this.cmb_AprsCommon_CallsignSsId.Name = "cmb_AprsCommon_CallsignSsId";
      this.cmb_AprsCommon_RtLmt.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_RtLmt, "cmb_AprsCommon_RtLmt");
      this.cmb_AprsCommon_RtLmt.FormattingEnabled = true;
      this.cmb_AprsCommon_RtLmt.Items.AddRange(new object[176]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items9"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items10"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items11"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items12"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items13"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items14"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items15"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items16"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items17"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items18"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items19"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items20"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items21"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items22"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items23"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items24"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items25"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items26"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items27"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items28"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items29"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items30"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items31"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items32"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items33"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items34"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items35"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items36"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items37"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items38"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items39"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items40"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items41"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items42"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items43"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items44"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items45"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items46"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items47"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items48"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items49"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items50"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items51"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items52"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items53"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items54"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items55"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items56"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items57"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items58"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items59"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items60"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items61"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items62"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items63"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items64"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items65"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items66"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items67"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items68"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items69"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items70"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items71"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items72"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items73"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items74"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items75"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items76"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items77"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items78"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items79"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items80"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items81"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items82"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items83"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items84"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items85"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items86"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items87"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items88"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items89"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items90"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items91"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items92"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items93"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items94"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items95"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items96"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items97"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items98"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items99"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items100"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items101"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items102"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items103"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items104"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items105"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items106"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items107"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items108"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items109"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items110"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items111"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items112"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items113"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items114"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items115"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items116"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items117"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items118"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items119"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items120"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items121"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items122"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items123"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items124"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items125"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items126"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items127"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items128"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items129"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items130"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items131"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items132"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items133"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items134"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items135"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items136"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items137"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items138"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items139"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items140"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items141"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items142"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items143"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items144"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items145"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items146"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items147"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items148"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items149"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items150"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items151"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items152"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items153"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items154"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items155"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items156"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items157"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items158"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items159"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items160"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items161"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items162"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items163"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items164"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items165"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items166"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items167"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items168"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items169"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items170"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items171"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items172"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items173"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items174"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_RtLmt.Items175")
      });
      this.cmb_AprsCommon_RtLmt.Name = "cmb_AprsCommon_RtLmt";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_RtLmt, "lbl_AprsCommon_RtLmt");
      this.lbl_AprsCommon_RtLmt.Name = "lbl_AprsCommon_RtLmt";
      this.cmb_AprsCommon_Intrvl.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_Intrvl, "cmb_AprsCommon_Intrvl");
      this.cmb_AprsCommon_Intrvl.FormattingEnabled = true;
      this.cmb_AprsCommon_Intrvl.Items.AddRange(new object[10]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_Intrvl.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Intrvl.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Intrvl.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Intrvl.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Intrvl.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Intrvl.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Intrvl.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Intrvl.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Intrvl.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Intrvl.Items9")
      });
      this.cmb_AprsCommon_Intrvl.Name = "cmb_AprsCommon_Intrvl";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_Intrvl, "lbl_AprsCommon_Intrvl");
      this.lbl_AprsCommon_Intrvl.Name = "lbl_AprsCommon_Intrvl";
      this.cmb_AprsCommon_LwSpd.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_LwSpd, "cmb_AprsCommon_LwSpd");
      this.cmb_AprsCommon_LwSpd.FormattingEnabled = true;
      this.cmb_AprsCommon_LwSpd.Items.AddRange(new object[99]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items9"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items10"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items11"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items12"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items13"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items14"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items15"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items16"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items17"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items18"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items19"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items20"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items21"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items22"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items23"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items24"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items25"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items26"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items27"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items28"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items29"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items30"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items31"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items32"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items33"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items34"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items35"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items36"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items37"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items38"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items39"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items40"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items41"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items42"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items43"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items44"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items45"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items46"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items47"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items48"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items49"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items50"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items51"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items52"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items53"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items54"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items55"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items56"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items57"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items58"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items59"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items60"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items61"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items62"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items63"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items64"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items65"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items66"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items67"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items68"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items69"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items70"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items71"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items72"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items73"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items74"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items75"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items76"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items77"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items78"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items79"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items80"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items81"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items82"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items83"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items84"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items85"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items86"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items87"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items88"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items89"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items90"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items91"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items92"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items93"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items94"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items95"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items96"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items97"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_LwSpd.Items98")
      });
      this.cmb_AprsCommon_LwSpd.Name = "cmb_AprsCommon_LwSpd";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_LwSpd, "lbl_AprsCommon_LwSpd");
      this.lbl_AprsCommon_LwSpd.Name = "lbl_AprsCommon_LwSpd";
      this.cmb_AprsCommon_Dcy.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_Dcy, "cmb_AprsCommon_Dcy");
      this.cmb_AprsCommon_Dcy.FormattingEnabled = true;
      this.cmb_AprsCommon_Dcy.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_Dcy.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Dcy.Items1")
      });
      this.cmb_AprsCommon_Dcy.Name = "cmb_AprsCommon_Dcy";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_Dcy, "lbl_AprsCommon_Dcy");
      this.lbl_AprsCommon_Dcy.Name = "lbl_AprsCommon_Dcy";
      this.cmb_AprsCommon_Prprtnl.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_Prprtnl, "cmb_AprsCommon_Prprtnl");
      this.cmb_AprsCommon_Prprtnl.FormattingEnabled = true;
      this.cmb_AprsCommon_Prprtnl.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_Prprtnl.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Prprtnl.Items1")
      });
      this.cmb_AprsCommon_Prprtnl.Name = "cmb_AprsCommon_Prprtnl";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_Prprtnl, "lbl_AprsCommon_Prprtnl");
      this.lbl_AprsCommon_Prprtnl.Name = "lbl_AprsCommon_Prprtnl";
      this.cmb_AprsCommon_Auto.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_Auto, "cmb_AprsCommon_Auto");
      this.cmb_AprsCommon_Auto.FormattingEnabled = true;
      this.cmb_AprsCommon_Auto.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_Auto.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Auto.Items1")
      });
      this.cmb_AprsCommon_Auto.Name = "cmb_AprsCommon_Auto";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_Auto, "lbl_AprsCommon_Auto");
      this.lbl_AprsCommon_Auto.Name = "lbl_AprsCommon_Auto";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_BcnTx, "lbl_AprsCommon_BcnTx");
      this.lbl_AprsCommon_BcnTx.Name = "lbl_AprsCommon_BcnTx";
      this.cmb_AprsCommon_Alttd.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_Alttd, "cmb_AprsCommon_Alttd");
      this.cmb_AprsCommon_Alttd.FormattingEnabled = true;
      this.cmb_AprsCommon_Alttd.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_Alttd.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Alttd.Items1")
      });
      this.cmb_AprsCommon_Alttd.Name = "cmb_AprsCommon_Alttd";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_Alttd, "lbl_AprsCommon_Alttd");
      this.lbl_AprsCommon_Alttd.Name = "lbl_AprsCommon_Alttd";
      this.cmb_AprsCommon_SpdCrc.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_SpdCrc, "cmb_AprsCommon_SpdCrc");
      this.cmb_AprsCommon_SpdCrc.FormattingEnabled = true;
      this.cmb_AprsCommon_SpdCrc.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_SpdCrc.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_SpdCrc.Items1")
      });
      this.cmb_AprsCommon_SpdCrc.Name = "cmb_AprsCommon_SpdCrc";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_SpdCrc, "lbl_AprsCommon_SpdCrc");
      this.lbl_AprsCommon_SpdCrc.Name = "lbl_AprsCommon_SpdCrc";
      this.cmb_AprsCommon_Ambgty.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_Ambgty, "cmb_AprsCommon_Ambgty");
      this.cmb_AprsCommon_Ambgty.FormattingEnabled = true;
      this.cmb_AprsCommon_Ambgty.Items.AddRange(new object[5]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_Ambgty.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Ambgty.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Ambgty.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Ambgty.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Ambgty.Items4")
      });
      this.cmb_AprsCommon_Ambgty.Name = "cmb_AprsCommon_Ambgty";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_Ambgty, "lbl_AprsCommon_Ambgty");
      this.lbl_AprsCommon_Ambgty.Name = "lbl_AprsCommon_Ambgty";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_BcnInfoSlct, "lbl_AprsCommon_BcnInfoSlct");
      this.lbl_AprsCommon_BcnInfoSlct.Name = "lbl_AprsCommon_BcnInfoSlct";
      this.cmb_AprsCommon_Dst.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_Dst, "cmb_AprsCommon_Dst");
      this.cmb_AprsCommon_Dst.FormattingEnabled = true;
      this.cmb_AprsCommon_Dst.Items.AddRange(new object[1]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_Dst.Items")
      });
      this.cmb_AprsCommon_Dst.Name = "cmb_AprsCommon_Dst";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_Dst, "lbl_AprsCommon_Dst");
      this.lbl_AprsCommon_Dst.Name = "lbl_AprsCommon_Dst";
      this.cmb_AprsCommon_PstnCmnt.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_PstnCmnt, "cmb_AprsCommon_PstnCmnt");
      this.cmb_AprsCommon_PstnCmnt.FormattingEnabled = true;
      this.cmb_AprsCommon_PstnCmnt.Items.AddRange(new object[15]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items8"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items9"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items10"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items11"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items12"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items13"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_PstnCmnt.Items14")
      });
      this.cmb_AprsCommon_PstnCmnt.Name = "cmb_AprsCommon_PstnCmnt";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_PstnCmnt, "lbl_AprsCommon_PstnCmnt");
      this.lbl_AprsCommon_PstnCmnt.Name = "lbl_AprsCommon_PstnCmnt";
      this.txt_AprsCommon_CallsignCode.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_AprsCommon_CallsignCode, "txt_AprsCommon_CallsignCode");
      this.txt_AprsCommon_CallsignCode.Name = "txt_AprsCommon_CallsignCode";
      this.txt_AprsCommon_CallsignCode.TextChanged += new EventHandler(this.txt_CallsignCode_TextChanged);
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_Callsign, "lbl_AprsCommon_Callsign");
      this.lbl_AprsCommon_Callsign.Name = "lbl_AprsCommon_Callsign";
      this.cmb_AprsCommon_TxDelay.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_TxDelay, "cmb_AprsCommon_TxDelay");
      this.cmb_AprsCommon_TxDelay.FormattingEnabled = true;
      this.cmb_AprsCommon_TxDelay.Items.AddRange(new object[9]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_TxDelay.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_TxDelay.Items1"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_TxDelay.Items2"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_TxDelay.Items3"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_TxDelay.Items4"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_TxDelay.Items5"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_TxDelay.Items6"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_TxDelay.Items7"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_TxDelay.Items8")
      });
      this.cmb_AprsCommon_TxDelay.Name = "cmb_AprsCommon_TxDelay";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_TxDelay, "lbl_AprsCommon_TxDelay");
      this.lbl_AprsCommon_TxDelay.Name = "lbl_AprsCommon_TxDelay";
      this.cmb_AprsCommon_Mute.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_Mute, "cmb_AprsCommon_Mute");
      this.cmb_AprsCommon_Mute.FormattingEnabled = true;
      this.cmb_AprsCommon_Mute.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_Mute.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Mute.Items1")
      });
      this.cmb_AprsCommon_Mute.Name = "cmb_AprsCommon_Mute";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_Mute, "lbl_AprsCommon_Mute");
      this.lbl_AprsCommon_Mute.Name = "lbl_AprsCommon_Mute";
      this.cmb_AprsCommon_Modem.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_Modem, "cmb_AprsCommon_Modem");
      this.cmb_AprsCommon_Modem.FormattingEnabled = true;
      this.cmb_AprsCommon_Modem.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_Modem.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Modem.Items1")
      });
      this.cmb_AprsCommon_Modem.Name = "cmb_AprsCommon_Modem";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_Modem, "lbl_AprsCommon_Modem");
      this.lbl_AprsCommon_Modem.Name = "lbl_AprsCommon_Modem";
      this.cmb_AprsCommon_Cmps.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_AprsCommon_Cmps, "cmb_AprsCommon_Cmps");
      this.cmb_AprsCommon_Cmps.FormattingEnabled = true;
      this.cmb_AprsCommon_Cmps.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_AprsCommon_Cmps.Items"),
        (object) componentResourceManager.GetString("cmb_AprsCommon_Cmps.Items1")
      });
      this.cmb_AprsCommon_Cmps.Name = "cmb_AprsCommon_Cmps";
      componentResourceManager.ApplyResources((object) this.lbl_AprsCommon_Cmps, "lbl_AprsCommon_Cmps");
      this.lbl_AprsCommon_Cmps.Name = "lbl_AprsCommon_Cmps";
      componentResourceManager.ApplyResources((object) this.tab_GmWiresX, "tab_GmWiresX");
      this.tab_GmWiresX.BackColor = SystemColors.Control;
      this.tab_GmWiresX.Controls.Add((Control) this.grp_MsgText);
      this.tab_GmWiresX.Controls.Add((Control) this.grb_Category);
      this.tab_GmWiresX.Controls.Add((Control) this.grb_WiresX);
      this.tab_GmWiresX.Controls.Add((Control) this.grb_Gm);
      this.tab_GmWiresX.Controls.Add((Control) this.grb_Digital);
      this.tab_GmWiresX.Name = "tab_GmWiresX";
      this.grp_MsgText.Controls.Add((Control) this.dgv_MsgText);
      componentResourceManager.ApplyResources((object) this.grp_MsgText, "grp_MsgText");
      this.grp_MsgText.Name = "grp_MsgText";
      this.grp_MsgText.TabStop = false;
      this.dgv_MsgText.AllowUserToAddRows = false;
      this.dgv_MsgText.AllowUserToDeleteRows = false;
      this.dgv_MsgText.AllowUserToResizeColumns = false;
      this.dgv_MsgText.AllowUserToResizeRows = false;
      this.dgv_MsgText.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      componentResourceManager.ApplyResources((object) this.dgv_MsgText, "dgv_MsgText");
      this.dgv_MsgText.MultiSelect = false;
      this.dgv_MsgText.Name = "dgv_MsgText";
      this.dgv_MsgText.RowHeadersVisible = false;
      this.dgv_MsgText.RowTemplate.Height = 21;
      this.dgv_MsgText.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
      this.grb_Category.Controls.Add((Control) this.dgv_Category);
      componentResourceManager.ApplyResources((object) this.grb_Category, "grb_Category");
      this.grb_Category.Name = "grb_Category";
      this.grb_Category.TabStop = false;
      this.dgv_Category.AllowUserToAddRows = false;
      this.dgv_Category.AllowUserToDeleteRows = false;
      this.dgv_Category.AllowUserToResizeColumns = false;
      this.dgv_Category.AllowUserToResizeRows = false;
      this.dgv_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      componentResourceManager.ApplyResources((object) this.dgv_Category, "dgv_Category");
      this.dgv_Category.MultiSelect = false;
      this.dgv_Category.Name = "dgv_Category";
      this.dgv_Category.RowHeadersVisible = false;
      this.dgv_Category.RowTemplate.Height = 21;
      this.dgv_Category.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
      this.grb_WiresX.Controls.Add((Control) this.cmb_WiresX_SearchSetup);
      this.grb_WiresX.Controls.Add((Control) this.lbl_WiresX_SearchSetup);
      this.grb_WiresX.Controls.Add((Control) this.lbl_WiresX_PresetFreqUnit);
      this.grb_WiresX.Controls.Add((Control) this.nud_WiresX_PresetFreq);
      this.grb_WiresX.Controls.Add((Control) this.lbl_WiresX_PresetFreq);
      this.grb_WiresX.Controls.Add((Control) this.cmb_WiresX_DgID);
      this.grb_WiresX.Controls.Add((Control) this.lbl_WiresX_DgID);
      this.grb_WiresX.Controls.Add((Control) this.cmb_WiresX_RptWiresFreq);
      this.grb_WiresX.Controls.Add((Control) this.lbl_WiresX_RptWiresFreq);
      componentResourceManager.ApplyResources((object) this.grb_WiresX, "grb_WiresX");
      this.grb_WiresX.Name = "grb_WiresX";
      this.grb_WiresX.TabStop = false;
      componentResourceManager.ApplyResources((object) this.lbl_WiresX_PresetFreqUnit, "lbl_WiresX_PresetFreqUnit");
      this.lbl_WiresX_PresetFreqUnit.Name = "lbl_WiresX_PresetFreqUnit";
      this.nud_WiresX_PresetFreq.BackColor = SystemColors.Window;
      this.nud_WiresX_PresetFreq.DecimalPlaces = 5;
      this.nud_WiresX_PresetFreq.Increment = new Decimal(new int[4]
      {
        2000,
        0,
        0,
        327680
      });
      componentResourceManager.ApplyResources((object) this.nud_WiresX_PresetFreq, "nud_WiresX_PresetFreq");
      this.nud_WiresX_PresetFreq.Maximum = new Decimal(new int[4]
      {
        14600000,
        0,
        0,
        327680
      });
      this.nud_WiresX_PresetFreq.Minimum = new Decimal(new int[4]
      {
        14000000,
        0,
        0,
        327680
      });
      this.nud_WiresX_PresetFreq.Name = "nud_WiresX_PresetFreq";
      this.nud_WiresX_PresetFreq.ReadOnly = true;
      this.nud_WiresX_PresetFreq.Value = new Decimal(new int[4]
      {
        14000000,
        0,
        0,
        327680
      });
      this.nud_WiresX_PresetFreq.ValueChanged += new EventHandler(this.nud_WiresX_PresetFreq_ValueChanged);
      componentResourceManager.ApplyResources((object) this.lbl_WiresX_PresetFreq, "lbl_WiresX_PresetFreq");
      this.lbl_WiresX_PresetFreq.Name = "lbl_WiresX_PresetFreq";
      this.cmb_WiresX_DgID.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_WiresX_DgID, "cmb_WiresX_DgID");
      this.cmb_WiresX_DgID.FormattingEnabled = true;
      this.cmb_WiresX_DgID.Items.AddRange(new object[100]
      {
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items1"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items2"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items3"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items4"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items5"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items6"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items7"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items8"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items9"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items10"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items11"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items12"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items13"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items14"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items15"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items16"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items17"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items18"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items19"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items20"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items21"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items22"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items23"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items24"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items25"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items26"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items27"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items28"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items29"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items30"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items31"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items32"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items33"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items34"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items35"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items36"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items37"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items38"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items39"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items40"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items41"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items42"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items43"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items44"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items45"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items46"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items47"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items48"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items49"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items50"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items51"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items52"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items53"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items54"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items55"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items56"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items57"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items58"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items59"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items60"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items61"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items62"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items63"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items64"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items65"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items66"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items67"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items68"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items69"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items70"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items71"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items72"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items73"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items74"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items75"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items76"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items77"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items78"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items79"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items80"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items81"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items82"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items83"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items84"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items85"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items86"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items87"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items88"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items89"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items90"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items91"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items92"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items93"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items94"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items95"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items96"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items97"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items98"),
        (object) componentResourceManager.GetString("cmb_WiresX_DgID.Items99")
      });
      this.cmb_WiresX_DgID.Name = "cmb_WiresX_DgID";
      componentResourceManager.ApplyResources((object) this.lbl_WiresX_DgID, "lbl_WiresX_DgID");
      this.lbl_WiresX_DgID.Name = "lbl_WiresX_DgID";
      this.cmb_WiresX_RptWiresFreq.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_WiresX_RptWiresFreq, "cmb_WiresX_RptWiresFreq");
      this.cmb_WiresX_RptWiresFreq.FormattingEnabled = true;
      this.cmb_WiresX_RptWiresFreq.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_WiresX_RptWiresFreq.Items"),
        (object) componentResourceManager.GetString("cmb_WiresX_RptWiresFreq.Items1")
      });
      this.cmb_WiresX_RptWiresFreq.Name = "cmb_WiresX_RptWiresFreq";
      componentResourceManager.ApplyResources((object) this.lbl_WiresX_RptWiresFreq, "lbl_WiresX_RptWiresFreq");
      this.lbl_WiresX_RptWiresFreq.Name = "lbl_WiresX_RptWiresFreq";
      this.grb_Gm.Controls.Add((Control) this.cmb_Gm_RangeRinger);
      this.grb_Gm.Controls.Add((Control) this.lbl_Gm_RangeRinger);
      this.grb_Gm.Controls.Add((Control) this.txt_Gm_CallSign);
      this.grb_Gm.Controls.Add((Control) this.lbl_Gm_CallSign);
      componentResourceManager.ApplyResources((object) this.grb_Gm, "grb_Gm");
      this.grb_Gm.Name = "grb_Gm";
      this.grb_Gm.TabStop = false;
      this.cmb_Gm_RangeRinger.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Gm_RangeRinger, "cmb_Gm_RangeRinger");
      this.cmb_Gm_RangeRinger.FormattingEnabled = true;
      this.cmb_Gm_RangeRinger.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Gm_RangeRinger.Items"),
        (object) componentResourceManager.GetString("cmb_Gm_RangeRinger.Items1")
      });
      this.cmb_Gm_RangeRinger.Name = "cmb_Gm_RangeRinger";
      componentResourceManager.ApplyResources((object) this.lbl_Gm_RangeRinger, "lbl_Gm_RangeRinger");
      this.lbl_Gm_RangeRinger.Name = "lbl_Gm_RangeRinger";
      this.txt_Gm_CallSign.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_Gm_CallSign, "txt_Gm_CallSign");
      this.txt_Gm_CallSign.Name = "txt_Gm_CallSign";
      componentResourceManager.ApplyResources((object) this.lbl_Gm_CallSign, "lbl_Gm_CallSign");
      this.lbl_Gm_CallSign.Name = "lbl_Gm_CallSign";
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_StandbyBeep);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_StandbyBeep);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_TxDgID);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_TxDgID);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_AmsTxMode);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_TxMode);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_LocationService);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_LocationService);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_Popup);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_Popup);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_RxDgID);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_RxDgID);
      componentResourceManager.ApplyResources((object) this.grb_Digital, "grb_Digital");
      this.grb_Digital.Name = "grb_Digital";
      this.grb_Digital.TabStop = false;
      this.cmb_Digital_StandbyBeep.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_StandbyBeep, "cmb_Digital_StandbyBeep");
      this.cmb_Digital_StandbyBeep.FormattingEnabled = true;
      this.cmb_Digital_StandbyBeep.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Digital_StandbyBeep.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_StandbyBeep.Items1")
      });
      this.cmb_Digital_StandbyBeep.Name = "cmb_Digital_StandbyBeep";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_StandbyBeep, "lbl_Digital_StandbyBeep");
      this.lbl_Digital_StandbyBeep.Name = "lbl_Digital_StandbyBeep";
      this.cmb_Digital_TxDgID.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_TxDgID, "cmb_Digital_TxDgID");
      this.cmb_Digital_TxDgID.FormattingEnabled = true;
      this.cmb_Digital_TxDgID.Items.AddRange(new object[100]
      {
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items1"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items2"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items3"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items4"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items5"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items6"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items7"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items8"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items9"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items10"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items11"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items12"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items13"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items14"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items15"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items16"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items17"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items18"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items19"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items20"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items21"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items22"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items23"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items24"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items25"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items26"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items27"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items28"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items29"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items30"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items31"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items32"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items33"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items34"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items35"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items36"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items37"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items38"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items39"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items40"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items41"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items42"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items43"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items44"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items45"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items46"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items47"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items48"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items49"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items50"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items51"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items52"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items53"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items54"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items55"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items56"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items57"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items58"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items59"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items60"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items61"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items62"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items63"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items64"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items65"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items66"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items67"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items68"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items69"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items70"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items71"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items72"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items73"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items74"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items75"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items76"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items77"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items78"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items79"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items80"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items81"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items82"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items83"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items84"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items85"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items86"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items87"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items88"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items89"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items90"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items91"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items92"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items93"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items94"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items95"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items96"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items97"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items98"),
        (object) componentResourceManager.GetString("cmb_Digital_TxDgID.Items99")
      });
      this.cmb_Digital_TxDgID.Name = "cmb_Digital_TxDgID";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_TxDgID, "lbl_Digital_TxDgID");
      this.lbl_Digital_TxDgID.Name = "lbl_Digital_TxDgID";
      this.cmb_Digital_AmsTxMode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_AmsTxMode, "cmb_Digital_AmsTxMode");
      this.cmb_Digital_AmsTxMode.FormattingEnabled = true;
      this.cmb_Digital_AmsTxMode.Items.AddRange(new object[5]
      {
        (object) componentResourceManager.GetString("cmb_Digital_AmsTxMode.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_AmsTxMode.Items1"),
        (object) componentResourceManager.GetString("cmb_Digital_AmsTxMode.Items2"),
        (object) componentResourceManager.GetString("cmb_Digital_AmsTxMode.Items3"),
        (object) componentResourceManager.GetString("cmb_Digital_AmsTxMode.Items4")
      });
      this.cmb_Digital_AmsTxMode.Name = "cmb_Digital_AmsTxMode";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_TxMode, "lbl_Digital_TxMode");
      this.lbl_Digital_TxMode.Name = "lbl_Digital_TxMode";
      this.cmb_Digital_LocationService.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_LocationService, "cmb_Digital_LocationService");
      this.cmb_Digital_LocationService.FormattingEnabled = true;
      this.cmb_Digital_LocationService.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Digital_LocationService.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_LocationService.Items1")
      });
      this.cmb_Digital_LocationService.Name = "cmb_Digital_LocationService";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_LocationService, "lbl_Digital_LocationService");
      this.lbl_Digital_LocationService.Name = "lbl_Digital_LocationService";
      this.cmb_Digital_Popup.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_Popup, "cmb_Digital_Popup");
      this.cmb_Digital_Popup.FormattingEnabled = true;
      this.cmb_Digital_Popup.Items.AddRange(new object[10]
      {
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items1"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items2"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items3"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items4"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items5"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items6"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items7"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items8"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items9")
      });
      this.cmb_Digital_Popup.Name = "cmb_Digital_Popup";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_Popup, "lbl_Digital_Popup");
      this.lbl_Digital_Popup.Name = "lbl_Digital_Popup";
      this.cmb_Digital_RxDgID.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_RxDgID, "cmb_Digital_RxDgID");
      this.cmb_Digital_RxDgID.FormattingEnabled = true;
      this.cmb_Digital_RxDgID.Items.AddRange(new object[100]
      {
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items1"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items2"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items3"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items4"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items5"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items6"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items7"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items8"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items9"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items10"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items11"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items12"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items13"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items14"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items15"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items16"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items17"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items18"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items19"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items20"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items21"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items22"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items23"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items24"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items25"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items26"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items27"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items28"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items29"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items30"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items31"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items32"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items33"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items34"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items35"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items36"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items37"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items38"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items39"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items40"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items41"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items42"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items43"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items44"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items45"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items46"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items47"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items48"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items49"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items50"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items51"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items52"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items53"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items54"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items55"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items56"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items57"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items58"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items59"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items60"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items61"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items62"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items63"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items64"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items65"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items66"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items67"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items68"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items69"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items70"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items71"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items72"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items73"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items74"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items75"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items76"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items77"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items78"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items79"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items80"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items81"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items82"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items83"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items84"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items85"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items86"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items87"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items88"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items89"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items90"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items91"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items92"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items93"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items94"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items95"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items96"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items97"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items98"),
        (object) componentResourceManager.GetString("cmb_Digital_RxDgID.Items99")
      });
      this.cmb_Digital_RxDgID.Name = "cmb_Digital_RxDgID";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_RxDgID, "lbl_Digital_RxDgID");
      this.lbl_Digital_RxDgID.Name = "lbl_Digital_RxDgID";
      componentResourceManager.ApplyResources((object) this.tab_NormalSetting, "tab_NormalSetting");
      this.tab_NormalSetting.BackColor = SystemColors.Control;
      this.tab_NormalSetting.Controls.Add((Control) this.grb_FuncSet);
      this.tab_NormalSetting.Controls.Add((Control) this.groupBox6);
      this.tab_NormalSetting.Controls.Add((Control) this.groupBox2);
      this.tab_NormalSetting.Controls.Add((Control) this.grb_Option);
      this.tab_NormalSetting.Controls.Add((Control) this.grb_Config);
      this.tab_NormalSetting.Controls.Add((Control) this.grb_DtmfSelect);
      this.tab_NormalSetting.Controls.Add((Control) this.grb_Scan);
      this.tab_NormalSetting.Controls.Add((Control) this.grb_Signaling);
      this.tab_NormalSetting.Controls.Add((Control) this.grb_Display);
      this.tab_NormalSetting.Name = "tab_NormalSetting";
      this.grb_FuncSet.Controls.Add((Control) this.rdb_FuncSet_Array4);
      this.grb_FuncSet.Controls.Add((Control) this.rdb_FuncSet_Array3);
      this.grb_FuncSet.Controls.Add((Control) this.rdb_FuncSet_Array2);
      this.grb_FuncSet.Controls.Add((Control) this.rdb_FuncSet_Array1);
      this.grb_FuncSet.Controls.Add((Control) this.txt_FuncSet_Array4);
      this.grb_FuncSet.Controls.Add((Control) this.txt_FuncSet_Array3);
      this.grb_FuncSet.Controls.Add((Control) this.txt_FuncSet_Array2);
      this.grb_FuncSet.Controls.Add((Control) this.txt_FuncSet_Array1);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Stop);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Play);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_PTA);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Rec);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Voise);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_xClr);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_BeaconTx);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Beacon);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Msg);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_SList);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Log);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Home);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Dtmf);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_SqlNoise);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Dw);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_SSO);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_TxPwrHi);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_10Key);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Rev);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Scan);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Scope);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Mute);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_Sql);
      this.grb_FuncSet.Controls.Add((Control) this.btn_FuncSet_VM);
      componentResourceManager.ApplyResources((object) this.grb_FuncSet, "grb_FuncSet");
      this.grb_FuncSet.Name = "grb_FuncSet";
      this.grb_FuncSet.TabStop = false;
      componentResourceManager.ApplyResources((object) this.rdb_FuncSet_Array4, "rdb_FuncSet_Array4");
      this.rdb_FuncSet_Array4.Name = "rdb_FuncSet_Array4";
      this.rdb_FuncSet_Array4.UseVisualStyleBackColor = true;
      this.rdb_FuncSet_Array4.CheckedChanged += new EventHandler(this.rdb_FuncSet_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_FuncSet_Array3, "rdb_FuncSet_Array3");
      this.rdb_FuncSet_Array3.Name = "rdb_FuncSet_Array3";
      this.rdb_FuncSet_Array3.UseVisualStyleBackColor = true;
      this.rdb_FuncSet_Array3.CheckedChanged += new EventHandler(this.rdb_FuncSet_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_FuncSet_Array2, "rdb_FuncSet_Array2");
      this.rdb_FuncSet_Array2.Name = "rdb_FuncSet_Array2";
      this.rdb_FuncSet_Array2.UseVisualStyleBackColor = true;
      this.rdb_FuncSet_Array2.CheckedChanged += new EventHandler(this.rdb_FuncSet_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.rdb_FuncSet_Array1, "rdb_FuncSet_Array1");
      this.rdb_FuncSet_Array1.Name = "rdb_FuncSet_Array1";
      this.rdb_FuncSet_Array1.UseVisualStyleBackColor = true;
      this.rdb_FuncSet_Array1.CheckedChanged += new EventHandler(this.rdb_FuncSet_CheckedChanged);
      this.txt_FuncSet_Array4.BackColor = SystemColors.Window;
      componentResourceManager.ApplyResources((object) this.txt_FuncSet_Array4, "txt_FuncSet_Array4");
      this.txt_FuncSet_Array4.Name = "txt_FuncSet_Array4";
      this.txt_FuncSet_Array4.ReadOnly = true;
      this.txt_FuncSet_Array3.BackColor = SystemColors.Window;
      componentResourceManager.ApplyResources((object) this.txt_FuncSet_Array3, "txt_FuncSet_Array3");
      this.txt_FuncSet_Array3.Name = "txt_FuncSet_Array3";
      this.txt_FuncSet_Array3.ReadOnly = true;
      this.txt_FuncSet_Array2.BackColor = SystemColors.Window;
      componentResourceManager.ApplyResources((object) this.txt_FuncSet_Array2, "txt_FuncSet_Array2");
      this.txt_FuncSet_Array2.Name = "txt_FuncSet_Array2";
      this.txt_FuncSet_Array2.ReadOnly = true;
      this.txt_FuncSet_Array1.BackColor = SystemColors.Window;
      componentResourceManager.ApplyResources((object) this.txt_FuncSet_Array1, "txt_FuncSet_Array1");
      this.txt_FuncSet_Array1.Name = "txt_FuncSet_Array1";
      this.txt_FuncSet_Array1.ReadOnly = true;
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Stop, "btn_FuncSet_Stop");
      this.btn_FuncSet_Stop.Name = "btn_FuncSet_Stop";
      this.btn_FuncSet_Stop.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Stop.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Play, "btn_FuncSet_Play");
      this.btn_FuncSet_Play.Name = "btn_FuncSet_Play";
      this.btn_FuncSet_Play.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Play.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_PTA, "btn_FuncSet_PTA");
      this.btn_FuncSet_PTA.Name = "btn_FuncSet_PTA";
      this.btn_FuncSet_PTA.UseVisualStyleBackColor = true;
      this.btn_FuncSet_PTA.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Rec, "btn_FuncSet_Rec");
      this.btn_FuncSet_Rec.Name = "btn_FuncSet_Rec";
      this.btn_FuncSet_Rec.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Rec.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Voise, "btn_FuncSet_Voise");
      this.btn_FuncSet_Voise.Name = "btn_FuncSet_Voise";
      this.btn_FuncSet_Voise.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Voise.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_xClr, "btn_FuncSet_xClr");
      this.btn_FuncSet_xClr.Name = "btn_FuncSet_xClr";
      this.btn_FuncSet_xClr.UseVisualStyleBackColor = true;
      this.btn_FuncSet_xClr.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_BeaconTx, "btn_FuncSet_BeaconTx");
      this.btn_FuncSet_BeaconTx.Name = "btn_FuncSet_BeaconTx";
      this.btn_FuncSet_BeaconTx.UseVisualStyleBackColor = true;
      this.btn_FuncSet_BeaconTx.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Beacon, "btn_FuncSet_Beacon");
      this.btn_FuncSet_Beacon.Name = "btn_FuncSet_Beacon";
      this.btn_FuncSet_Beacon.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Beacon.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Msg, "btn_FuncSet_Msg");
      this.btn_FuncSet_Msg.Name = "btn_FuncSet_Msg";
      this.btn_FuncSet_Msg.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Msg.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_SList, "btn_FuncSet_SList");
      this.btn_FuncSet_SList.Name = "btn_FuncSet_SList";
      this.btn_FuncSet_SList.UseVisualStyleBackColor = true;
      this.btn_FuncSet_SList.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Log, "btn_FuncSet_Log");
      this.btn_FuncSet_Log.Name = "btn_FuncSet_Log";
      this.btn_FuncSet_Log.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Log.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Home, "btn_FuncSet_Home");
      this.btn_FuncSet_Home.Name = "btn_FuncSet_Home";
      this.btn_FuncSet_Home.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Home.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Dtmf, "btn_FuncSet_Dtmf");
      this.btn_FuncSet_Dtmf.Name = "btn_FuncSet_Dtmf";
      this.btn_FuncSet_Dtmf.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Dtmf.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_SqlNoise, "btn_FuncSet_SqlNoise");
      this.btn_FuncSet_SqlNoise.Name = "btn_FuncSet_SqlNoise";
      this.btn_FuncSet_SqlNoise.UseVisualStyleBackColor = true;
      this.btn_FuncSet_SqlNoise.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Dw, "btn_FuncSet_Dw");
      this.btn_FuncSet_Dw.Name = "btn_FuncSet_Dw";
      this.btn_FuncSet_Dw.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Dw.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_SSO, "btn_FuncSet_SSO");
      this.btn_FuncSet_SSO.Name = "btn_FuncSet_SSO";
      this.btn_FuncSet_SSO.UseVisualStyleBackColor = true;
      this.btn_FuncSet_SSO.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_TxPwrHi, "btn_FuncSet_TxPwrHi");
      this.btn_FuncSet_TxPwrHi.Name = "btn_FuncSet_TxPwrHi";
      this.btn_FuncSet_TxPwrHi.UseVisualStyleBackColor = true;
      this.btn_FuncSet_TxPwrHi.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_10Key, "btn_FuncSet_10Key");
      this.btn_FuncSet_10Key.Name = "btn_FuncSet_10Key";
      this.btn_FuncSet_10Key.UseVisualStyleBackColor = true;
      this.btn_FuncSet_10Key.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Rev, "btn_FuncSet_Rev");
      this.btn_FuncSet_Rev.Name = "btn_FuncSet_Rev";
      this.btn_FuncSet_Rev.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Rev.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Scan, "btn_FuncSet_Scan");
      this.btn_FuncSet_Scan.Name = "btn_FuncSet_Scan";
      this.btn_FuncSet_Scan.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Scan.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Scope, "btn_FuncSet_Scope");
      this.btn_FuncSet_Scope.Name = "btn_FuncSet_Scope";
      this.btn_FuncSet_Scope.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Scope.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Mute, "btn_FuncSet_Mute");
      this.btn_FuncSet_Mute.Name = "btn_FuncSet_Mute";
      this.btn_FuncSet_Mute.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Mute.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_Sql, "btn_FuncSet_Sql");
      this.btn_FuncSet_Sql.Name = "btn_FuncSet_Sql";
      this.btn_FuncSet_Sql.UseVisualStyleBackColor = true;
      this.btn_FuncSet_Sql.Click += new EventHandler(this.btn_FuncSet_Click);
      componentResourceManager.ApplyResources((object) this.btn_FuncSet_VM, "btn_FuncSet_VM");
      this.btn_FuncSet_VM.Name = "btn_FuncSet_VM";
      this.btn_FuncSet_VM.UseVisualStyleBackColor = true;
      this.btn_FuncSet_VM.Click += new EventHandler(this.btn_FuncSet_Click);
      this.groupBox6.Controls.Add((Control) this.cmb_Signaling_WxAlrtB);
      this.groupBox6.Controls.Add((Control) this.lbl_Signaling_WxAlrtB);
      this.groupBox6.Controls.Add((Control) this.cmb_Signaling_WxAlrtA);
      this.groupBox6.Controls.Add((Control) this.lbl_Signaling_WxAlrtA);
      this.groupBox6.Controls.Add((Control) this.lbl_Signaling_BellRingerB);
      this.groupBox6.Controls.Add((Control) this.lbl_Signaling_SqlExB);
      this.groupBox6.Controls.Add((Control) this.cmb_Signaling_SqlExB);
      this.groupBox6.Controls.Add((Control) this.cmb_Signaling_BellRingerB);
      this.groupBox6.Controls.Add((Control) this.lbl_Signaling_PageTx2);
      this.groupBox6.Controls.Add((Control) this.lbl_Signaling_PageTx1);
      this.groupBox6.Controls.Add((Control) this.lbl_Signaling_PageRx2);
      this.groupBox6.Controls.Add((Control) this.cmb_Signaling_PageTx2);
      this.groupBox6.Controls.Add((Control) this.cmb_Signaling_BellRingerA);
      this.groupBox6.Controls.Add((Control) this.cmb_Signaling_SqlExA);
      this.groupBox6.Controls.Add((Control) this.lbl_Signaling_BellRingerA);
      this.groupBox6.Controls.Add((Control) this.lbl_Signaling_SqlExA);
      this.groupBox6.Controls.Add((Control) this.cmb_Signaling_AutDialer);
      this.groupBox6.Controls.Add((Control) this.cmb_Signaling_PageRx1);
      this.groupBox6.Controls.Add((Control) this.cmb_Signaling_PageRx2);
      this.groupBox6.Controls.Add((Control) this.lbl_Signaling_AutDialer);
      this.groupBox6.Controls.Add((Control) this.lbl_Signaling_PageCode);
      this.groupBox6.Controls.Add((Control) this.cmb_Signaling_PageTx1);
      this.groupBox6.Controls.Add((Control) this.lbl_Signaling_PageRx1);
      componentResourceManager.ApplyResources((object) this.groupBox6, "groupBox6");
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.TabStop = false;
      this.cmb_Signaling_WxAlrtB.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_WxAlrtB, "cmb_Signaling_WxAlrtB");
      this.cmb_Signaling_WxAlrtB.FormattingEnabled = true;
      this.cmb_Signaling_WxAlrtB.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_WxAlrtB.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_WxAlrtB.Items1")
      });
      this.cmb_Signaling_WxAlrtB.Name = "cmb_Signaling_WxAlrtB";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_WxAlrtB, "lbl_Signaling_WxAlrtB");
      this.lbl_Signaling_WxAlrtB.Name = "lbl_Signaling_WxAlrtB";
      this.cmb_Signaling_WxAlrtA.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_WxAlrtA, "cmb_Signaling_WxAlrtA");
      this.cmb_Signaling_WxAlrtA.FormattingEnabled = true;
      this.cmb_Signaling_WxAlrtA.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_WxAlrtA.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_WxAlrtA.Items1")
      });
      this.cmb_Signaling_WxAlrtA.Name = "cmb_Signaling_WxAlrtA";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_WxAlrtA, "lbl_Signaling_WxAlrtA");
      this.lbl_Signaling_WxAlrtA.Name = "lbl_Signaling_WxAlrtA";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_BellRingerB, "lbl_Signaling_BellRingerB");
      this.lbl_Signaling_BellRingerB.Name = "lbl_Signaling_BellRingerB";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_SqlExB, "lbl_Signaling_SqlExB");
      this.lbl_Signaling_SqlExB.Name = "lbl_Signaling_SqlExB";
      this.cmb_Signaling_SqlExB.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_SqlExB, "cmb_Signaling_SqlExB");
      this.cmb_Signaling_SqlExB.FormattingEnabled = true;
      this.cmb_Signaling_SqlExB.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_SqlExB.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlExB.Items1")
      });
      this.cmb_Signaling_SqlExB.Name = "cmb_Signaling_SqlExB";
      this.cmb_Signaling_BellRingerB.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_BellRingerB, "cmb_Signaling_BellRingerB");
      this.cmb_Signaling_BellRingerB.FormattingEnabled = true;
      this.cmb_Signaling_BellRingerB.Items.AddRange(new object[6]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_BellRingerB.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_BellRingerB.Items1"),
        (object) componentResourceManager.GetString("cmb_Signaling_BellRingerB.Items2"),
        (object) componentResourceManager.GetString("cmb_Signaling_BellRingerB.Items3"),
        (object) componentResourceManager.GetString("cmb_Signaling_BellRingerB.Items4"),
        (object) componentResourceManager.GetString("cmb_Signaling_BellRingerB.Items5")
      });
      this.cmb_Signaling_BellRingerB.Name = "cmb_Signaling_BellRingerB";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_PageTx2, "lbl_Signaling_PageTx2");
      this.lbl_Signaling_PageTx2.Name = "lbl_Signaling_PageTx2";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_PageTx1, "lbl_Signaling_PageTx1");
      this.lbl_Signaling_PageTx1.Name = "lbl_Signaling_PageTx1";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_PageRx2, "lbl_Signaling_PageRx2");
      this.lbl_Signaling_PageRx2.Name = "lbl_Signaling_PageRx2";
      this.cmb_Signaling_PageTx2.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_PageTx2, "cmb_Signaling_PageTx2");
      this.cmb_Signaling_PageTx2.FormattingEnabled = true;
      this.cmb_Signaling_PageTx2.Items.AddRange(new object[50]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items1"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items2"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items3"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items4"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items5"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items6"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items7"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items8"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items9"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items10"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items11"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items12"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items13"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items14"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items15"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items16"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items17"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items18"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items19"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items20"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items21"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items22"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items23"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items24"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items25"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items26"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items27"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items28"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items29"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items30"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items31"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items32"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items33"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items34"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items35"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items36"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items37"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items38"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items39"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items40"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items41"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items42"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items43"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items44"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items45"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items46"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items47"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items48"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx2.Items49")
      });
      this.cmb_Signaling_PageTx2.Name = "cmb_Signaling_PageTx2";
      this.cmb_Signaling_BellRingerA.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_BellRingerA, "cmb_Signaling_BellRingerA");
      this.cmb_Signaling_BellRingerA.FormattingEnabled = true;
      this.cmb_Signaling_BellRingerA.Items.AddRange(new object[6]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_BellRingerA.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_BellRingerA.Items1"),
        (object) componentResourceManager.GetString("cmb_Signaling_BellRingerA.Items2"),
        (object) componentResourceManager.GetString("cmb_Signaling_BellRingerA.Items3"),
        (object) componentResourceManager.GetString("cmb_Signaling_BellRingerA.Items4"),
        (object) componentResourceManager.GetString("cmb_Signaling_BellRingerA.Items5")
      });
      this.cmb_Signaling_BellRingerA.Name = "cmb_Signaling_BellRingerA";
      this.cmb_Signaling_SqlExA.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_SqlExA, "cmb_Signaling_SqlExA");
      this.cmb_Signaling_SqlExA.FormattingEnabled = true;
      this.cmb_Signaling_SqlExA.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_SqlExA.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlExA.Items1")
      });
      this.cmb_Signaling_SqlExA.Name = "cmb_Signaling_SqlExA";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_BellRingerA, "lbl_Signaling_BellRingerA");
      this.lbl_Signaling_BellRingerA.Name = "lbl_Signaling_BellRingerA";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_SqlExA, "lbl_Signaling_SqlExA");
      this.lbl_Signaling_SqlExA.Name = "lbl_Signaling_SqlExA";
      this.cmb_Signaling_AutDialer.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_AutDialer, "cmb_Signaling_AutDialer");
      this.cmb_Signaling_AutDialer.FormattingEnabled = true;
      this.cmb_Signaling_AutDialer.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_AutDialer.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_AutDialer.Items1")
      });
      this.cmb_Signaling_AutDialer.Name = "cmb_Signaling_AutDialer";
      this.cmb_Signaling_PageRx1.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_PageRx1, "cmb_Signaling_PageRx1");
      this.cmb_Signaling_PageRx1.FormattingEnabled = true;
      this.cmb_Signaling_PageRx1.Items.AddRange(new object[50]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items1"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items2"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items3"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items4"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items5"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items6"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items7"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items8"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items9"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items10"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items11"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items12"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items13"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items14"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items15"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items16"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items17"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items18"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items19"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items20"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items21"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items22"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items23"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items24"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items25"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items26"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items27"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items28"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items29"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items30"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items31"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items32"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items33"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items34"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items35"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items36"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items37"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items38"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items39"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items40"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items41"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items42"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items43"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items44"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items45"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items46"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items47"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items48"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx1.Items49")
      });
      this.cmb_Signaling_PageRx1.Name = "cmb_Signaling_PageRx1";
      this.cmb_Signaling_PageRx2.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_PageRx2, "cmb_Signaling_PageRx2");
      this.cmb_Signaling_PageRx2.FormattingEnabled = true;
      this.cmb_Signaling_PageRx2.Items.AddRange(new object[50]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items1"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items2"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items3"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items4"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items5"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items6"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items7"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items8"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items9"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items10"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items11"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items12"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items13"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items14"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items15"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items16"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items17"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items18"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items19"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items20"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items21"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items22"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items23"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items24"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items25"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items26"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items27"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items28"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items29"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items30"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items31"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items32"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items33"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items34"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items35"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items36"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items37"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items38"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items39"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items40"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items41"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items42"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items43"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items44"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items45"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items46"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items47"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items48"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageRx2.Items49")
      });
      this.cmb_Signaling_PageRx2.Name = "cmb_Signaling_PageRx2";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_AutDialer, "lbl_Signaling_AutDialer");
      this.lbl_Signaling_AutDialer.Name = "lbl_Signaling_AutDialer";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_PageCode, "lbl_Signaling_PageCode");
      this.lbl_Signaling_PageCode.Name = "lbl_Signaling_PageCode";
      this.cmb_Signaling_PageTx1.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_PageTx1, "cmb_Signaling_PageTx1");
      this.cmb_Signaling_PageTx1.FormattingEnabled = true;
      this.cmb_Signaling_PageTx1.Items.AddRange(new object[50]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items1"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items2"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items3"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items4"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items5"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items6"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items7"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items8"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items9"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items10"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items11"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items12"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items13"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items14"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items15"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items16"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items17"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items18"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items19"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items20"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items21"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items22"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items23"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items24"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items25"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items26"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items27"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items28"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items29"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items30"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items31"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items32"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items33"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items34"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items35"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items36"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items37"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items38"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items39"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items40"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items41"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items42"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items43"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items44"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items45"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items46"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items47"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items48"),
        (object) componentResourceManager.GetString("cmb_Signaling_PageTx1.Items49")
      });
      this.cmb_Signaling_PageTx1.Name = "cmb_Signaling_PageTx1";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_PageRx1, "lbl_Signaling_PageRx1");
      this.lbl_Signaling_PageRx1.Name = "lbl_Signaling_PageRx1";
      this.groupBox2.Controls.Add((Control) this.cmb_Audio_SubBandMute);
      this.groupBox2.Controls.Add((Control) this.cmb_Audio_MicGain);
      this.groupBox2.Controls.Add((Control) this.lbl_Audio_MicGain);
      this.groupBox2.Controls.Add((Control) this.lbl_Audio_SubBandMute);
      componentResourceManager.ApplyResources((object) this.groupBox2, "groupBox2");
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.TabStop = false;
      this.cmb_Audio_SubBandMute.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Audio_SubBandMute, "cmb_Audio_SubBandMute");
      this.cmb_Audio_SubBandMute.FormattingEnabled = true;
      this.cmb_Audio_SubBandMute.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Audio_SubBandMute.Items"),
        (object) componentResourceManager.GetString("cmb_Audio_SubBandMute.Items1")
      });
      this.cmb_Audio_SubBandMute.Name = "cmb_Audio_SubBandMute";
      this.cmb_Audio_MicGain.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Audio_MicGain, "cmb_Audio_MicGain");
      this.cmb_Audio_MicGain.FormattingEnabled = true;
      this.cmb_Audio_MicGain.Items.AddRange(new object[5]
      {
        (object) componentResourceManager.GetString("cmb_Audio_MicGain.Items"),
        (object) componentResourceManager.GetString("cmb_Audio_MicGain.Items1"),
        (object) componentResourceManager.GetString("cmb_Audio_MicGain.Items2"),
        (object) componentResourceManager.GetString("cmb_Audio_MicGain.Items3"),
        (object) componentResourceManager.GetString("cmb_Audio_MicGain.Items4")
      });
      this.cmb_Audio_MicGain.Name = "cmb_Audio_MicGain";
      componentResourceManager.ApplyResources((object) this.lbl_Audio_MicGain, "lbl_Audio_MicGain");
      this.lbl_Audio_MicGain.Name = "lbl_Audio_MicGain";
      componentResourceManager.ApplyResources((object) this.lbl_Audio_SubBandMute, "lbl_Audio_SubBandMute");
      this.lbl_Audio_SubBandMute.Name = "lbl_Audio_SubBandMute";
      this.grb_Option.Controls.Add((Control) this.cmb_Option_RxMute);
      this.grb_Option.Controls.Add((Control) this.lbl_Option_RxMute);
      this.grb_Option.Controls.Add((Control) this.cmb_Option_VcMemLng);
      this.grb_Option.Controls.Add((Control) this.cmb_Option_VcMemVlm);
      this.grb_Option.Controls.Add((Control) this.lbl_Option_VcMemVlm);
      this.grb_Option.Controls.Add((Control) this.lbl_Option_VcMemLng);
      this.grb_Option.Controls.Add((Control) this.cmb_Option_VcMemPR);
      this.grb_Option.Controls.Add((Control) this.cmb_Option_VcMemAnnc);
      this.grb_Option.Controls.Add((Control) this.lbl_Option_VcMemAnnc);
      this.grb_Option.Controls.Add((Control) this.lbl_Option_VcMemPR);
      this.grb_Option.Controls.Add((Control) this.lbl_Option_VcMem);
      this.grb_Option.Controls.Add((Control) this.cmb_Option_BltthVox);
      this.grb_Option.Controls.Add((Control) this.lbl_Option_Bltth);
      this.grb_Option.Controls.Add((Control) this.lbl_Option_BltthVox);
      this.grb_Option.Controls.Add((Control) this.lbl_Option_UsbCmr);
      this.grb_Option.Controls.Add((Control) this.cmb_Option_BltthAudio);
      this.grb_Option.Controls.Add((Control) this.cmb_Option_BltthBttery);
      this.grb_Option.Controls.Add((Control) this.cmb_Option_UsbCmrSize);
      this.grb_Option.Controls.Add((Control) this.lbl_Option_BltthBttery);
      this.grb_Option.Controls.Add((Control) this.cmb_Option_UsbCmrQlty);
      this.grb_Option.Controls.Add((Control) this.lbl_Option_BltthAudio);
      this.grb_Option.Controls.Add((Control) this.lbl_Option_UsbCmrQlty);
      this.grb_Option.Controls.Add((Control) this.lbl_Option_UsbCmrSize);
      componentResourceManager.ApplyResources((object) this.grb_Option, "grb_Option");
      this.grb_Option.Name = "grb_Option";
      this.grb_Option.TabStop = false;
      this.cmb_Option_RxMute.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Option_RxMute, "cmb_Option_RxMute");
      this.cmb_Option_RxMute.FormattingEnabled = true;
      this.cmb_Option_RxMute.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Option_RxMute.Items"),
        (object) componentResourceManager.GetString("cmb_Option_RxMute.Items1")
      });
      this.cmb_Option_RxMute.Name = "cmb_Option_RxMute";
      componentResourceManager.ApplyResources((object) this.lbl_Option_RxMute, "lbl_Option_RxMute");
      this.lbl_Option_RxMute.Name = "lbl_Option_RxMute";
      this.cmb_Option_VcMemLng.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Option_VcMemLng, "cmb_Option_VcMemLng");
      this.cmb_Option_VcMemLng.FormattingEnabled = true;
      this.cmb_Option_VcMemLng.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Option_VcMemLng.Items"),
        (object) componentResourceManager.GetString("cmb_Option_VcMemLng.Items1")
      });
      this.cmb_Option_VcMemLng.Name = "cmb_Option_VcMemLng";
      this.cmb_Option_VcMemVlm.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Option_VcMemVlm, "cmb_Option_VcMemVlm");
      this.cmb_Option_VcMemVlm.FormattingEnabled = true;
      this.cmb_Option_VcMemVlm.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_Option_VcMemVlm.Items"),
        (object) componentResourceManager.GetString("cmb_Option_VcMemVlm.Items1"),
        (object) componentResourceManager.GetString("cmb_Option_VcMemVlm.Items2")
      });
      this.cmb_Option_VcMemVlm.Name = "cmb_Option_VcMemVlm";
      componentResourceManager.ApplyResources((object) this.lbl_Option_VcMemVlm, "lbl_Option_VcMemVlm");
      this.lbl_Option_VcMemVlm.Name = "lbl_Option_VcMemVlm";
      componentResourceManager.ApplyResources((object) this.lbl_Option_VcMemLng, "lbl_Option_VcMemLng");
      this.lbl_Option_VcMemLng.Name = "lbl_Option_VcMemLng";
      this.cmb_Option_VcMemPR.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Option_VcMemPR, "cmb_Option_VcMemPR");
      this.cmb_Option_VcMemPR.FormattingEnabled = true;
      this.cmb_Option_VcMemPR.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Option_VcMemPR.Items"),
        (object) componentResourceManager.GetString("cmb_Option_VcMemPR.Items1")
      });
      this.cmb_Option_VcMemPR.Name = "cmb_Option_VcMemPR";
      this.cmb_Option_VcMemAnnc.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Option_VcMemAnnc, "cmb_Option_VcMemAnnc");
      this.cmb_Option_VcMemAnnc.FormattingEnabled = true;
      this.cmb_Option_VcMemAnnc.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_Option_VcMemAnnc.Items"),
        (object) componentResourceManager.GetString("cmb_Option_VcMemAnnc.Items1"),
        (object) componentResourceManager.GetString("cmb_Option_VcMemAnnc.Items2")
      });
      this.cmb_Option_VcMemAnnc.Name = "cmb_Option_VcMemAnnc";
      componentResourceManager.ApplyResources((object) this.lbl_Option_VcMemAnnc, "lbl_Option_VcMemAnnc");
      this.lbl_Option_VcMemAnnc.Name = "lbl_Option_VcMemAnnc";
      componentResourceManager.ApplyResources((object) this.lbl_Option_VcMemPR, "lbl_Option_VcMemPR");
      this.lbl_Option_VcMemPR.Name = "lbl_Option_VcMemPR";
      componentResourceManager.ApplyResources((object) this.lbl_Option_VcMem, "lbl_Option_VcMem");
      this.lbl_Option_VcMem.Name = "lbl_Option_VcMem";
      this.cmb_Option_BltthVox.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Option_BltthVox, "cmb_Option_BltthVox");
      this.cmb_Option_BltthVox.FormattingEnabled = true;
      this.cmb_Option_BltthVox.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_Option_BltthVox.Items"),
        (object) componentResourceManager.GetString("cmb_Option_BltthVox.Items1"),
        (object) componentResourceManager.GetString("cmb_Option_BltthVox.Items2")
      });
      this.cmb_Option_BltthVox.Name = "cmb_Option_BltthVox";
      componentResourceManager.ApplyResources((object) this.lbl_Option_Bltth, "lbl_Option_Bltth");
      this.lbl_Option_Bltth.Name = "lbl_Option_Bltth";
      componentResourceManager.ApplyResources((object) this.lbl_Option_BltthVox, "lbl_Option_BltthVox");
      this.lbl_Option_BltthVox.Name = "lbl_Option_BltthVox";
      componentResourceManager.ApplyResources((object) this.lbl_Option_UsbCmr, "lbl_Option_UsbCmr");
      this.lbl_Option_UsbCmr.Name = "lbl_Option_UsbCmr";
      this.cmb_Option_BltthAudio.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Option_BltthAudio, "cmb_Option_BltthAudio");
      this.cmb_Option_BltthAudio.FormattingEnabled = true;
      this.cmb_Option_BltthAudio.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Option_BltthAudio.Items"),
        (object) componentResourceManager.GetString("cmb_Option_BltthAudio.Items1")
      });
      this.cmb_Option_BltthAudio.Name = "cmb_Option_BltthAudio";
      this.cmb_Option_BltthBttery.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Option_BltthBttery, "cmb_Option_BltthBttery");
      this.cmb_Option_BltthBttery.FormattingEnabled = true;
      this.cmb_Option_BltthBttery.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Option_BltthBttery.Items"),
        (object) componentResourceManager.GetString("cmb_Option_BltthBttery.Items1")
      });
      this.cmb_Option_BltthBttery.Name = "cmb_Option_BltthBttery";
      this.cmb_Option_UsbCmrSize.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Option_UsbCmrSize, "cmb_Option_UsbCmrSize");
      this.cmb_Option_UsbCmrSize.FormattingEnabled = true;
      this.cmb_Option_UsbCmrSize.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Option_UsbCmrSize.Items"),
        (object) componentResourceManager.GetString("cmb_Option_UsbCmrSize.Items1")
      });
      this.cmb_Option_UsbCmrSize.Name = "cmb_Option_UsbCmrSize";
      componentResourceManager.ApplyResources((object) this.lbl_Option_BltthBttery, "lbl_Option_BltthBttery");
      this.lbl_Option_BltthBttery.Name = "lbl_Option_BltthBttery";
      this.cmb_Option_UsbCmrQlty.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Option_UsbCmrQlty, "cmb_Option_UsbCmrQlty");
      this.cmb_Option_UsbCmrQlty.FormattingEnabled = true;
      this.cmb_Option_UsbCmrQlty.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_Option_UsbCmrQlty.Items"),
        (object) componentResourceManager.GetString("cmb_Option_UsbCmrQlty.Items1"),
        (object) componentResourceManager.GetString("cmb_Option_UsbCmrQlty.Items2")
      });
      this.cmb_Option_UsbCmrQlty.Name = "cmb_Option_UsbCmrQlty";
      componentResourceManager.ApplyResources((object) this.lbl_Option_BltthAudio, "lbl_Option_BltthAudio");
      this.lbl_Option_BltthAudio.Name = "lbl_Option_BltthAudio";
      componentResourceManager.ApplyResources((object) this.lbl_Option_UsbCmrQlty, "lbl_Option_UsbCmrQlty");
      this.lbl_Option_UsbCmrQlty.Name = "lbl_Option_UsbCmrQlty";
      componentResourceManager.ApplyResources((object) this.lbl_Option_UsbCmrSize, "lbl_Option_UsbCmrSize");
      this.lbl_Option_UsbCmrSize.Name = "lbl_Option_UsbCmrSize";
      this.grb_Config.Controls.Add((Control) this.lbl_Config_AtStepB);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_AtStepA);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_AtModeB);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_AtModeA);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_AtStepB);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_AtStepA);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_AtModeB);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_AtModeA);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_RxCovB);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_AtRptShftB);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_RxCovB);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_AtRptShftB);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_MicProgKeyP4);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_MicProgKeyP2);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_MicProgKeyP3);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_MicProgKeyP4);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_MicProgKeyP2);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_MicProgKeyP3);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_MicProgKeyP1);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_MicProgKeyP1);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_MicProgKey);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_GpsLog);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_GpsDev);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_GpsDtm);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_Tot);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_Apo);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_Unit);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_RxCovA);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_Beep);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_TimeZone);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_TimeZone);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_AtRptShftA);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_GpsLog);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_Beep);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_GpsDev);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_AtRptShftA);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_GpsDtm);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_Tot);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_Apo);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_Unit);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_RxCovA);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_DtTmFrmtHr);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_DtTmFrmtDt);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_DtTmFrmt);
      componentResourceManager.ApplyResources((object) this.grb_Config, "grb_Config");
      this.grb_Config.Name = "grb_Config";
      this.grb_Config.TabStop = false;
      componentResourceManager.ApplyResources((object) this.lbl_Config_AtStepB, "lbl_Config_AtStepB");
      this.lbl_Config_AtStepB.Name = "lbl_Config_AtStepB";
      componentResourceManager.ApplyResources((object) this.lbl_Config_AtStepA, "lbl_Config_AtStepA");
      this.lbl_Config_AtStepA.Name = "lbl_Config_AtStepA";
      componentResourceManager.ApplyResources((object) this.lbl_Config_AtModeB, "lbl_Config_AtModeB");
      this.lbl_Config_AtModeB.Name = "lbl_Config_AtModeB";
      componentResourceManager.ApplyResources((object) this.lbl_Config_AtModeA, "lbl_Config_AtModeA");
      this.lbl_Config_AtModeA.Name = "lbl_Config_AtModeA";
      this.cmb_Config_AtStepB.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_AtStepB, "cmb_Config_AtStepB");
      this.cmb_Config_AtStepB.FormattingEnabled = true;
      this.cmb_Config_AtStepB.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_AtStepB.Items"),
        (object) componentResourceManager.GetString("cmb_Config_AtStepB.Items1")
      });
      this.cmb_Config_AtStepB.Name = "cmb_Config_AtStepB";
      this.cmb_Config_AtStepA.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_AtStepA, "cmb_Config_AtStepA");
      this.cmb_Config_AtStepA.FormattingEnabled = true;
      this.cmb_Config_AtStepA.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_AtStepA.Items"),
        (object) componentResourceManager.GetString("cmb_Config_AtStepA.Items1")
      });
      this.cmb_Config_AtStepA.Name = "cmb_Config_AtStepA";
      this.cmb_Config_AtModeB.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_AtModeB, "cmb_Config_AtModeB");
      this.cmb_Config_AtModeB.FormattingEnabled = true;
      this.cmb_Config_AtModeB.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_AtModeB.Items"),
        (object) componentResourceManager.GetString("cmb_Config_AtModeB.Items1")
      });
      this.cmb_Config_AtModeB.Name = "cmb_Config_AtModeB";
      this.cmb_Config_AtModeA.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_AtModeA, "cmb_Config_AtModeA");
      this.cmb_Config_AtModeA.FormattingEnabled = true;
      this.cmb_Config_AtModeA.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_AtModeA.Items"),
        (object) componentResourceManager.GetString("cmb_Config_AtModeA.Items1")
      });
      this.cmb_Config_AtModeA.Name = "cmb_Config_AtModeA";
      componentResourceManager.ApplyResources((object) this.lbl_Config_RxCovB, "lbl_Config_RxCovB");
      this.lbl_Config_RxCovB.Name = "lbl_Config_RxCovB";
      componentResourceManager.ApplyResources((object) this.lbl_Config_AtRptShftB, "lbl_Config_AtRptShftB");
      this.lbl_Config_AtRptShftB.Name = "lbl_Config_AtRptShftB";
      this.cmb_Config_RxCovB.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_RxCovB, "cmb_Config_RxCovB");
      this.cmb_Config_RxCovB.FormattingEnabled = true;
      this.cmb_Config_RxCovB.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_RxCovB.Items"),
        (object) componentResourceManager.GetString("cmb_Config_RxCovB.Items1")
      });
      this.cmb_Config_RxCovB.Name = "cmb_Config_RxCovB";
      this.cmb_Config_AtRptShftB.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_AtRptShftB, "cmb_Config_AtRptShftB");
      this.cmb_Config_AtRptShftB.FormattingEnabled = true;
      this.cmb_Config_AtRptShftB.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_AtRptShftB.Items"),
        (object) componentResourceManager.GetString("cmb_Config_AtRptShftB.Items1")
      });
      this.cmb_Config_AtRptShftB.Name = "cmb_Config_AtRptShftB";
      componentResourceManager.ApplyResources((object) this.lbl_Config_MicProgKeyP4, "lbl_Config_MicProgKeyP4");
      this.lbl_Config_MicProgKeyP4.Name = "lbl_Config_MicProgKeyP4";
      componentResourceManager.ApplyResources((object) this.lbl_Config_MicProgKeyP2, "lbl_Config_MicProgKeyP2");
      this.lbl_Config_MicProgKeyP2.Name = "lbl_Config_MicProgKeyP2";
      componentResourceManager.ApplyResources((object) this.lbl_Config_MicProgKeyP3, "lbl_Config_MicProgKeyP3");
      this.lbl_Config_MicProgKeyP3.Name = "lbl_Config_MicProgKeyP3";
      this.cmb_Config_MicProgKeyP4.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_MicProgKeyP4, "cmb_Config_MicProgKeyP4");
      this.cmb_Config_MicProgKeyP4.FormattingEnabled = true;
      this.cmb_Config_MicProgKeyP4.Items.AddRange(new object[19]
      {
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items6"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items7"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items8"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items9"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items10"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items11"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items12"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items13"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items14"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items15"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items16"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items17"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP4.Items18")
      });
      this.cmb_Config_MicProgKeyP4.Name = "cmb_Config_MicProgKeyP4";
      this.cmb_Config_MicProgKeyP2.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_MicProgKeyP2, "cmb_Config_MicProgKeyP2");
      this.cmb_Config_MicProgKeyP2.FormattingEnabled = true;
      this.cmb_Config_MicProgKeyP2.Items.AddRange(new object[19]
      {
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items6"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items7"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items8"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items9"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items10"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items11"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items12"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items13"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items14"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items15"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items16"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items17"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP2.Items18")
      });
      this.cmb_Config_MicProgKeyP2.Name = "cmb_Config_MicProgKeyP2";
      this.cmb_Config_MicProgKeyP3.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_MicProgKeyP3, "cmb_Config_MicProgKeyP3");
      this.cmb_Config_MicProgKeyP3.FormattingEnabled = true;
      this.cmb_Config_MicProgKeyP3.Items.AddRange(new object[19]
      {
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items6"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items7"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items8"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items9"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items10"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items11"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items12"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items13"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items14"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items15"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items16"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items17"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP3.Items18")
      });
      this.cmb_Config_MicProgKeyP3.Name = "cmb_Config_MicProgKeyP3";
      this.cmb_Config_MicProgKeyP1.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_MicProgKeyP1, "cmb_Config_MicProgKeyP1");
      this.cmb_Config_MicProgKeyP1.FormattingEnabled = true;
      this.cmb_Config_MicProgKeyP1.Items.AddRange(new object[19]
      {
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items6"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items7"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items8"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items9"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items10"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items11"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items12"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items13"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items14"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items15"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items16"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items17"),
        (object) componentResourceManager.GetString("cmb_Config_MicProgKeyP1.Items18")
      });
      this.cmb_Config_MicProgKeyP1.Name = "cmb_Config_MicProgKeyP1";
      componentResourceManager.ApplyResources((object) this.lbl_Config_MicProgKeyP1, "lbl_Config_MicProgKeyP1");
      this.lbl_Config_MicProgKeyP1.Name = "lbl_Config_MicProgKeyP1";
      componentResourceManager.ApplyResources((object) this.lbl_Config_MicProgKey, "lbl_Config_MicProgKey");
      this.lbl_Config_MicProgKey.Name = "lbl_Config_MicProgKey";
      this.cmb_Config_GpsLog.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_GpsLog, "cmb_Config_GpsLog");
      this.cmb_Config_GpsLog.FormattingEnabled = true;
      this.cmb_Config_GpsLog.Items.AddRange(new object[7]
      {
        (object) componentResourceManager.GetString("cmb_Config_GpsLog.Items"),
        (object) componentResourceManager.GetString("cmb_Config_GpsLog.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_GpsLog.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_GpsLog.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_GpsLog.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_GpsLog.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_GpsLog.Items6")
      });
      this.cmb_Config_GpsLog.Name = "cmb_Config_GpsLog";
      this.cmb_Config_GpsDev.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_GpsDev, "cmb_Config_GpsDev");
      this.cmb_Config_GpsDev.FormattingEnabled = true;
      this.cmb_Config_GpsDev.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_GpsDev.Items"),
        (object) componentResourceManager.GetString("cmb_Config_GpsDev.Items1")
      });
      this.cmb_Config_GpsDev.Name = "cmb_Config_GpsDev";
      this.cmb_Config_GpsDtm.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_GpsDtm, "cmb_Config_GpsDtm");
      this.cmb_Config_GpsDtm.FormattingEnabled = true;
      this.cmb_Config_GpsDtm.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_GpsDtm.Items"),
        (object) componentResourceManager.GetString("cmb_Config_GpsDtm.Items1")
      });
      this.cmb_Config_GpsDtm.Name = "cmb_Config_GpsDtm";
      this.cmb_Config_Tot.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_Tot, "cmb_Config_Tot");
      this.cmb_Config_Tot.FormattingEnabled = true;
      this.cmb_Config_Tot.Items.AddRange(new object[9]
      {
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items6"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items7"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items8")
      });
      this.cmb_Config_Tot.Name = "cmb_Config_Tot";
      this.cmb_Config_Apo.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_Apo, "cmb_Config_Apo");
      this.cmb_Config_Apo.FormattingEnabled = true;
      this.cmb_Config_Apo.Items.AddRange(new object[15]
      {
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items6"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items7"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items8"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items9"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items10"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items11"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items12"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items13"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items14")
      });
      this.cmb_Config_Apo.Name = "cmb_Config_Apo";
      this.cmb_Config_Unit.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_Unit, "cmb_Config_Unit");
      this.cmb_Config_Unit.FormattingEnabled = true;
      this.cmb_Config_Unit.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_Unit.Items"),
        (object) componentResourceManager.GetString("cmb_Config_Unit.Items1")
      });
      this.cmb_Config_Unit.Name = "cmb_Config_Unit";
      this.cmb_Config_RxCovA.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_RxCovA, "cmb_Config_RxCovA");
      this.cmb_Config_RxCovA.FormattingEnabled = true;
      this.cmb_Config_RxCovA.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_RxCovA.Items"),
        (object) componentResourceManager.GetString("cmb_Config_RxCovA.Items1")
      });
      this.cmb_Config_RxCovA.Name = "cmb_Config_RxCovA";
      this.cmb_Config_Beep.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_Beep, "cmb_Config_Beep");
      this.cmb_Config_Beep.FormattingEnabled = true;
      this.cmb_Config_Beep.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_Config_Beep.Items"),
        (object) componentResourceManager.GetString("cmb_Config_Beep.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_Beep.Items2")
      });
      this.cmb_Config_Beep.Name = "cmb_Config_Beep";
      componentResourceManager.ApplyResources((object) this.lbl_Config_TimeZone, "lbl_Config_TimeZone");
      this.lbl_Config_TimeZone.Name = "lbl_Config_TimeZone";
      this.cmb_Config_TimeZone.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_TimeZone, "cmb_Config_TimeZone");
      this.cmb_Config_TimeZone.FormattingEnabled = true;
      this.cmb_Config_TimeZone.Items.AddRange(new object[57]
      {
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items6"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items7"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items8"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items9"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items10"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items11"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items12"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items13"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items14"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items15"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items16"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items17"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items18"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items19"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items20"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items21"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items22"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items23"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items24"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items25"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items26"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items27"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items28"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items29"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items30"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items31"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items32"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items33"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items34"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items35"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items36"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items37"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items38"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items39"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items40"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items41"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items42"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items43"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items44"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items45"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items46"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items47"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items48"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items49"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items50"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items51"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items52"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items53"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items54"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items55"),
        (object) componentResourceManager.GetString("cmb_Config_TimeZone.Items56")
      });
      this.cmb_Config_TimeZone.Name = "cmb_Config_TimeZone";
      componentResourceManager.ApplyResources((object) this.lbl_Config_AtRptShftA, "lbl_Config_AtRptShftA");
      this.lbl_Config_AtRptShftA.Name = "lbl_Config_AtRptShftA";
      componentResourceManager.ApplyResources((object) this.lbl_Config_GpsLog, "lbl_Config_GpsLog");
      this.lbl_Config_GpsLog.Name = "lbl_Config_GpsLog";
      componentResourceManager.ApplyResources((object) this.lbl_Config_Beep, "lbl_Config_Beep");
      this.lbl_Config_Beep.Name = "lbl_Config_Beep";
      componentResourceManager.ApplyResources((object) this.lbl_Config_GpsDev, "lbl_Config_GpsDev");
      this.lbl_Config_GpsDev.Name = "lbl_Config_GpsDev";
      this.cmb_Config_AtRptShftA.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_AtRptShftA, "cmb_Config_AtRptShftA");
      this.cmb_Config_AtRptShftA.FormattingEnabled = true;
      this.cmb_Config_AtRptShftA.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_AtRptShftA.Items"),
        (object) componentResourceManager.GetString("cmb_Config_AtRptShftA.Items1")
      });
      this.cmb_Config_AtRptShftA.Name = "cmb_Config_AtRptShftA";
      componentResourceManager.ApplyResources((object) this.lbl_Config_GpsDtm, "lbl_Config_GpsDtm");
      this.lbl_Config_GpsDtm.Name = "lbl_Config_GpsDtm";
      componentResourceManager.ApplyResources((object) this.lbl_Config_Tot, "lbl_Config_Tot");
      this.lbl_Config_Tot.Name = "lbl_Config_Tot";
      componentResourceManager.ApplyResources((object) this.lbl_Config_Apo, "lbl_Config_Apo");
      this.lbl_Config_Apo.Name = "lbl_Config_Apo";
      componentResourceManager.ApplyResources((object) this.lbl_Config_Unit, "lbl_Config_Unit");
      this.lbl_Config_Unit.Name = "lbl_Config_Unit";
      componentResourceManager.ApplyResources((object) this.lbl_Config_RxCovA, "lbl_Config_RxCovA");
      this.lbl_Config_RxCovA.Name = "lbl_Config_RxCovA";
      this.cmb_Config_DtTmFrmtHr.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_DtTmFrmtHr, "cmb_Config_DtTmFrmtHr");
      this.cmb_Config_DtTmFrmtHr.FormattingEnabled = true;
      this.cmb_Config_DtTmFrmtHr.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_DtTmFrmtHr.Items"),
        (object) componentResourceManager.GetString("cmb_Config_DtTmFrmtHr.Items1")
      });
      this.cmb_Config_DtTmFrmtHr.Name = "cmb_Config_DtTmFrmtHr";
      this.cmb_Config_DtTmFrmtDt.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_DtTmFrmtDt, "cmb_Config_DtTmFrmtDt");
      this.cmb_Config_DtTmFrmtDt.FormattingEnabled = true;
      this.cmb_Config_DtTmFrmtDt.Items.AddRange(new object[4]
      {
        (object) componentResourceManager.GetString("cmb_Config_DtTmFrmtDt.Items"),
        (object) componentResourceManager.GetString("cmb_Config_DtTmFrmtDt.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_DtTmFrmtDt.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_DtTmFrmtDt.Items3")
      });
      this.cmb_Config_DtTmFrmtDt.Name = "cmb_Config_DtTmFrmtDt";
      componentResourceManager.ApplyResources((object) this.lbl_Config_DtTmFrmt, "lbl_Config_DtTmFrmt");
      this.lbl_Config_DtTmFrmt.Name = "lbl_Config_DtTmFrmt";
      this.grb_DtmfSelect.Controls.Add((Control) this.dgv_DtmfMemory);
      componentResourceManager.ApplyResources((object) this.grb_DtmfSelect, "grb_DtmfSelect");
      this.grb_DtmfSelect.Name = "grb_DtmfSelect";
      this.grb_DtmfSelect.TabStop = false;
      this.dgv_DtmfMemory.AllowUserToAddRows = false;
      this.dgv_DtmfMemory.AllowUserToDeleteRows = false;
      this.dgv_DtmfMemory.AllowUserToResizeColumns = false;
      this.dgv_DtmfMemory.AllowUserToResizeRows = false;
      this.dgv_DtmfMemory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      componentResourceManager.ApplyResources((object) this.dgv_DtmfMemory, "dgv_DtmfMemory");
      this.dgv_DtmfMemory.MultiSelect = false;
      this.dgv_DtmfMemory.Name = "dgv_DtmfMemory";
      this.dgv_DtmfMemory.RowHeadersVisible = false;
      this.dgv_DtmfMemory.RowTemplate.Height = 21;
      this.dgv_DtmfMemory.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
      this.grb_Scan.Controls.Add((Control) this.lbl_Scan_ScanRsmB);
      this.grb_Scan.Controls.Add((Control) this.lbl_Scan_ScanDrctnB);
      this.grb_Scan.Controls.Add((Control) this.lbl_Scan_DWStopB);
      this.grb_Scan.Controls.Add((Control) this.cmb_Scan_DWStopB);
      this.grb_Scan.Controls.Add((Control) this.cmb_Scan_ScanDrctnB);
      this.grb_Scan.Controls.Add((Control) this.cmb_Scan_ScanRsmB);
      this.grb_Scan.Controls.Add((Control) this.lbl_Scan_DWStopA);
      this.grb_Scan.Controls.Add((Control) this.lbl_Scan_ScanRsmA);
      this.grb_Scan.Controls.Add((Control) this.lbl_Scan_ScanDrctnA);
      this.grb_Scan.Controls.Add((Control) this.cmb_Scan_DWStopA);
      this.grb_Scan.Controls.Add((Control) this.cmb_Scan_ScanRsmA);
      this.grb_Scan.Controls.Add((Control) this.cmb_Scan_ScanDrctnA);
      componentResourceManager.ApplyResources((object) this.grb_Scan, "grb_Scan");
      this.grb_Scan.Name = "grb_Scan";
      this.grb_Scan.TabStop = false;
      componentResourceManager.ApplyResources((object) this.lbl_Scan_ScanRsmB, "lbl_Scan_ScanRsmB");
      this.lbl_Scan_ScanRsmB.Name = "lbl_Scan_ScanRsmB";
      componentResourceManager.ApplyResources((object) this.lbl_Scan_ScanDrctnB, "lbl_Scan_ScanDrctnB");
      this.lbl_Scan_ScanDrctnB.Name = "lbl_Scan_ScanDrctnB";
      componentResourceManager.ApplyResources((object) this.lbl_Scan_DWStopB, "lbl_Scan_DWStopB");
      this.lbl_Scan_DWStopB.Name = "lbl_Scan_DWStopB";
      this.cmb_Scan_DWStopB.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Scan_DWStopB, "cmb_Scan_DWStopB");
      this.cmb_Scan_DWStopB.FormattingEnabled = true;
      this.cmb_Scan_DWStopB.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Scan_DWStopB.Items"),
        (object) componentResourceManager.GetString("cmb_Scan_DWStopB.Items1")
      });
      this.cmb_Scan_DWStopB.Name = "cmb_Scan_DWStopB";
      this.cmb_Scan_ScanDrctnB.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Scan_ScanDrctnB, "cmb_Scan_ScanDrctnB");
      this.cmb_Scan_ScanDrctnB.FormattingEnabled = true;
      this.cmb_Scan_ScanDrctnB.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Scan_ScanDrctnB.Items"),
        (object) componentResourceManager.GetString("cmb_Scan_ScanDrctnB.Items1")
      });
      this.cmb_Scan_ScanDrctnB.Name = "cmb_Scan_ScanDrctnB";
      this.cmb_Scan_ScanRsmB.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Scan_ScanRsmB, "cmb_Scan_ScanRsmB");
      this.cmb_Scan_ScanRsmB.FormattingEnabled = true;
      this.cmb_Scan_ScanRsmB.Items.AddRange(new object[5]
      {
        (object) componentResourceManager.GetString("cmb_Scan_ScanRsmB.Items"),
        (object) componentResourceManager.GetString("cmb_Scan_ScanRsmB.Items1"),
        (object) componentResourceManager.GetString("cmb_Scan_ScanRsmB.Items2"),
        (object) componentResourceManager.GetString("cmb_Scan_ScanRsmB.Items3"),
        (object) componentResourceManager.GetString("cmb_Scan_ScanRsmB.Items4")
      });
      this.cmb_Scan_ScanRsmB.Name = "cmb_Scan_ScanRsmB";
      componentResourceManager.ApplyResources((object) this.lbl_Scan_DWStopA, "lbl_Scan_DWStopA");
      this.lbl_Scan_DWStopA.Name = "lbl_Scan_DWStopA";
      componentResourceManager.ApplyResources((object) this.lbl_Scan_ScanRsmA, "lbl_Scan_ScanRsmA");
      this.lbl_Scan_ScanRsmA.Name = "lbl_Scan_ScanRsmA";
      componentResourceManager.ApplyResources((object) this.lbl_Scan_ScanDrctnA, "lbl_Scan_ScanDrctnA");
      this.lbl_Scan_ScanDrctnA.Name = "lbl_Scan_ScanDrctnA";
      this.cmb_Scan_DWStopA.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Scan_DWStopA, "cmb_Scan_DWStopA");
      this.cmb_Scan_DWStopA.FormattingEnabled = true;
      this.cmb_Scan_DWStopA.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Scan_DWStopA.Items"),
        (object) componentResourceManager.GetString("cmb_Scan_DWStopA.Items1")
      });
      this.cmb_Scan_DWStopA.Name = "cmb_Scan_DWStopA";
      this.cmb_Scan_ScanRsmA.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Scan_ScanRsmA, "cmb_Scan_ScanRsmA");
      this.cmb_Scan_ScanRsmA.FormattingEnabled = true;
      this.cmb_Scan_ScanRsmA.Items.AddRange(new object[5]
      {
        (object) componentResourceManager.GetString("cmb_Scan_ScanRsmA.Items"),
        (object) componentResourceManager.GetString("cmb_Scan_ScanRsmA.Items1"),
        (object) componentResourceManager.GetString("cmb_Scan_ScanRsmA.Items2"),
        (object) componentResourceManager.GetString("cmb_Scan_ScanRsmA.Items3"),
        (object) componentResourceManager.GetString("cmb_Scan_ScanRsmA.Items4")
      });
      this.cmb_Scan_ScanRsmA.Name = "cmb_Scan_ScanRsmA";
      this.cmb_Scan_ScanDrctnA.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Scan_ScanDrctnA, "cmb_Scan_ScanDrctnA");
      this.cmb_Scan_ScanDrctnA.FormattingEnabled = true;
      this.cmb_Scan_ScanDrctnA.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Scan_ScanDrctnA.Items"),
        (object) componentResourceManager.GetString("cmb_Scan_ScanDrctnA.Items1")
      });
      this.cmb_Scan_ScanDrctnA.Name = "cmb_Scan_ScanDrctnA";
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_DSqlcAprs);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_DataBandSelect);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_ComWpFilter);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_DSqlcData);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_ComOutput);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_DBandAprs);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_DSqlc);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_DBandData);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Data_DSqlcData);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Data_DBandAprs);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Data_DBandData);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Data_DSqlcAprs);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Data_ComWpFilter);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Data_ComWpFormat);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Data_ComOutput);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_DSpeedAprs);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Data_DSqlcTx);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_ComWpFormat);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_ComSpeed);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_DSqlcTx);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_DSpeedData);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Data_ComSpeed);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Data_ComPortSetting);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Data_DSpeed);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Data_DSpeedAprs);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Data_DSpeedData);
      componentResourceManager.ApplyResources((object) this.grb_Signaling, "grb_Signaling");
      this.grb_Signaling.Name = "grb_Signaling";
      this.grb_Signaling.TabStop = false;
      componentResourceManager.ApplyResources((object) this.lbl_Data_DSqlcAprs, "lbl_Data_DSqlcAprs");
      this.lbl_Data_DSqlcAprs.Name = "lbl_Data_DSqlcAprs";
      componentResourceManager.ApplyResources((object) this.lbl_Data_DataBandSelect, "lbl_Data_DataBandSelect");
      this.lbl_Data_DataBandSelect.Name = "lbl_Data_DataBandSelect";
      componentResourceManager.ApplyResources((object) this.lbl_Data_ComWpFilter, "lbl_Data_ComWpFilter");
      this.lbl_Data_ComWpFilter.Name = "lbl_Data_ComWpFilter";
      componentResourceManager.ApplyResources((object) this.lbl_Data_DSqlcData, "lbl_Data_DSqlcData");
      this.lbl_Data_DSqlcData.Name = "lbl_Data_DSqlcData";
      componentResourceManager.ApplyResources((object) this.lbl_Data_ComOutput, "lbl_Data_ComOutput");
      this.lbl_Data_ComOutput.Name = "lbl_Data_ComOutput";
      componentResourceManager.ApplyResources((object) this.lbl_Data_DBandAprs, "lbl_Data_DBandAprs");
      this.lbl_Data_DBandAprs.Name = "lbl_Data_DBandAprs";
      componentResourceManager.ApplyResources((object) this.lbl_Data_DSqlc, "lbl_Data_DSqlc");
      this.lbl_Data_DSqlc.Name = "lbl_Data_DSqlc";
      componentResourceManager.ApplyResources((object) this.lbl_Data_DBandData, "lbl_Data_DBandData");
      this.lbl_Data_DBandData.Name = "lbl_Data_DBandData";
      this.cmb_Data_DSqlcData.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Data_DSqlcData, "cmb_Data_DSqlcData");
      this.cmb_Data_DSqlcData.FormattingEnabled = true;
      this.cmb_Data_DSqlcData.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Data_DSqlcData.Items"),
        (object) componentResourceManager.GetString("cmb_Data_DSqlcData.Items1")
      });
      this.cmb_Data_DSqlcData.Name = "cmb_Data_DSqlcData";
      this.cmb_Data_DBandAprs.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Data_DBandAprs, "cmb_Data_DBandAprs");
      this.cmb_Data_DBandAprs.FormattingEnabled = true;
      this.cmb_Data_DBandAprs.Items.AddRange(new object[6]
      {
        (object) componentResourceManager.GetString("cmb_Data_DBandAprs.Items"),
        (object) componentResourceManager.GetString("cmb_Data_DBandAprs.Items1"),
        (object) componentResourceManager.GetString("cmb_Data_DBandAprs.Items2"),
        (object) componentResourceManager.GetString("cmb_Data_DBandAprs.Items3"),
        (object) componentResourceManager.GetString("cmb_Data_DBandAprs.Items4"),
        (object) componentResourceManager.GetString("cmb_Data_DBandAprs.Items5")
      });
      this.cmb_Data_DBandAprs.Name = "cmb_Data_DBandAprs";
      this.cmb_Data_DBandData.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Data_DBandData, "cmb_Data_DBandData");
      this.cmb_Data_DBandData.FormattingEnabled = true;
      this.cmb_Data_DBandData.Items.AddRange(new object[6]
      {
        (object) componentResourceManager.GetString("cmb_Data_DBandData.Items"),
        (object) componentResourceManager.GetString("cmb_Data_DBandData.Items1"),
        (object) componentResourceManager.GetString("cmb_Data_DBandData.Items2"),
        (object) componentResourceManager.GetString("cmb_Data_DBandData.Items3"),
        (object) componentResourceManager.GetString("cmb_Data_DBandData.Items4"),
        (object) componentResourceManager.GetString("cmb_Data_DBandData.Items5")
      });
      this.cmb_Data_DBandData.Name = "cmb_Data_DBandData";
      this.cmb_Data_DSqlcAprs.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Data_DSqlcAprs, "cmb_Data_DSqlcAprs");
      this.cmb_Data_DSqlcAprs.FormattingEnabled = true;
      this.cmb_Data_DSqlcAprs.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Data_DSqlcAprs.Items"),
        (object) componentResourceManager.GetString("cmb_Data_DSqlcAprs.Items1")
      });
      this.cmb_Data_DSqlcAprs.Name = "cmb_Data_DSqlcAprs";
      this.cmb_Data_ComWpFilter.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Data_ComWpFilter, "cmb_Data_ComWpFilter");
      this.cmb_Data_ComWpFilter.FormattingEnabled = true;
      this.cmb_Data_ComWpFilter.Items.AddRange(new object[10]
      {
        (object) componentResourceManager.GetString("cmb_Data_ComWpFilter.Items"),
        (object) componentResourceManager.GetString("cmb_Data_ComWpFilter.Items1"),
        (object) componentResourceManager.GetString("cmb_Data_ComWpFilter.Items2"),
        (object) componentResourceManager.GetString("cmb_Data_ComWpFilter.Items3"),
        (object) componentResourceManager.GetString("cmb_Data_ComWpFilter.Items4"),
        (object) componentResourceManager.GetString("cmb_Data_ComWpFilter.Items5"),
        (object) componentResourceManager.GetString("cmb_Data_ComWpFilter.Items6"),
        (object) componentResourceManager.GetString("cmb_Data_ComWpFilter.Items7"),
        (object) componentResourceManager.GetString("cmb_Data_ComWpFilter.Items8"),
        (object) componentResourceManager.GetString("cmb_Data_ComWpFilter.Items9")
      });
      this.cmb_Data_ComWpFilter.Name = "cmb_Data_ComWpFilter";
      this.cmb_Data_ComWpFormat.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Data_ComWpFormat, "cmb_Data_ComWpFormat");
      this.cmb_Data_ComWpFormat.FormattingEnabled = true;
      this.cmb_Data_ComWpFormat.Items.AddRange(new object[4]
      {
        (object) componentResourceManager.GetString("cmb_Data_ComWpFormat.Items"),
        (object) componentResourceManager.GetString("cmb_Data_ComWpFormat.Items1"),
        (object) componentResourceManager.GetString("cmb_Data_ComWpFormat.Items2"),
        (object) componentResourceManager.GetString("cmb_Data_ComWpFormat.Items3")
      });
      this.cmb_Data_ComWpFormat.Name = "cmb_Data_ComWpFormat";
      this.cmb_Data_ComOutput.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Data_ComOutput, "cmb_Data_ComOutput");
      this.cmb_Data_ComOutput.FormattingEnabled = true;
      this.cmb_Data_ComOutput.Items.AddRange(new object[4]
      {
        (object) componentResourceManager.GetString("cmb_Data_ComOutput.Items"),
        (object) componentResourceManager.GetString("cmb_Data_ComOutput.Items1"),
        (object) componentResourceManager.GetString("cmb_Data_ComOutput.Items2"),
        (object) componentResourceManager.GetString("cmb_Data_ComOutput.Items3")
      });
      this.cmb_Data_ComOutput.Name = "cmb_Data_ComOutput";
      componentResourceManager.ApplyResources((object) this.lbl_Data_DSpeedAprs, "lbl_Data_DSpeedAprs");
      this.lbl_Data_DSpeedAprs.Name = "lbl_Data_DSpeedAprs";
      this.cmb_Data_DSqlcTx.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Data_DSqlcTx, "cmb_Data_DSqlcTx");
      this.cmb_Data_DSqlcTx.FormattingEnabled = true;
      this.cmb_Data_DSqlcTx.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Data_DSqlcTx.Items"),
        (object) componentResourceManager.GetString("cmb_Data_DSqlcTx.Items1")
      });
      this.cmb_Data_DSqlcTx.Name = "cmb_Data_DSqlcTx";
      componentResourceManager.ApplyResources((object) this.lbl_Data_ComWpFormat, "lbl_Data_ComWpFormat");
      this.lbl_Data_ComWpFormat.Name = "lbl_Data_ComWpFormat";
      componentResourceManager.ApplyResources((object) this.lbl_Data_ComSpeed, "lbl_Data_ComSpeed");
      this.lbl_Data_ComSpeed.Name = "lbl_Data_ComSpeed";
      componentResourceManager.ApplyResources((object) this.lbl_Data_DSqlcTx, "lbl_Data_DSqlcTx");
      this.lbl_Data_DSqlcTx.Name = "lbl_Data_DSqlcTx";
      componentResourceManager.ApplyResources((object) this.lbl_Data_DSpeedData, "lbl_Data_DSpeedData");
      this.lbl_Data_DSpeedData.Name = "lbl_Data_DSpeedData";
      this.cmb_Data_ComSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Data_ComSpeed, "cmb_Data_ComSpeed");
      this.cmb_Data_ComSpeed.FormattingEnabled = true;
      this.cmb_Data_ComSpeed.Items.AddRange(new object[5]
      {
        (object) componentResourceManager.GetString("cmb_Data_ComSpeed.Items"),
        (object) componentResourceManager.GetString("cmb_Data_ComSpeed.Items1"),
        (object) componentResourceManager.GetString("cmb_Data_ComSpeed.Items2"),
        (object) componentResourceManager.GetString("cmb_Data_ComSpeed.Items3"),
        (object) componentResourceManager.GetString("cmb_Data_ComSpeed.Items4")
      });
      this.cmb_Data_ComSpeed.Name = "cmb_Data_ComSpeed";
      componentResourceManager.ApplyResources((object) this.lbl_Data_ComPortSetting, "lbl_Data_ComPortSetting");
      this.lbl_Data_ComPortSetting.Name = "lbl_Data_ComPortSetting";
      componentResourceManager.ApplyResources((object) this.cmb_Data_DSpeed, "cmb_Data_DSpeed");
      this.cmb_Data_DSpeed.Name = "cmb_Data_DSpeed";
      this.cmb_Data_DSpeedAprs.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Data_DSpeedAprs, "cmb_Data_DSpeedAprs");
      this.cmb_Data_DSpeedAprs.FormattingEnabled = true;
      this.cmb_Data_DSpeedAprs.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Data_DSpeedAprs.Items"),
        (object) componentResourceManager.GetString("cmb_Data_DSpeedAprs.Items1")
      });
      this.cmb_Data_DSpeedAprs.Name = "cmb_Data_DSpeedAprs";
      this.cmb_Data_DSpeedData.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Data_DSpeedData, "cmb_Data_DSpeedData");
      this.cmb_Data_DSpeedData.FormattingEnabled = true;
      this.cmb_Data_DSpeedData.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Data_DSpeedData.Items"),
        (object) componentResourceManager.GetString("cmb_Data_DSpeedData.Items1")
      });
      this.cmb_Data_DSpeedData.Name = "cmb_Data_DSpeedData";
      this.grb_Display.Controls.Add((Control) this.cmb_Display_BandScpA);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_BandScpA);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_DisplaySelect);
      this.grb_Display.Controls.Add((Control) this.cmb_Display_TimeVdd);
      this.grb_Display.Controls.Add((Control) this.cmb_Display_Altitude);
      this.grb_Display.Controls.Add((Control) this.cmb_Display_LcdContrast);
      this.grb_Display.Controls.Add((Control) this.cmb_Display_TimerClk);
      this.grb_Display.Controls.Add((Control) this.cmb_Display_LcdBrigtness);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_Altitude);
      this.grb_Display.Controls.Add((Control) this.cmb_Display_BandScpB);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_TimerClk);
      this.grb_Display.Controls.Add((Control) this.cmb_Display_BgClr);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_GpsInfo);
      this.grb_Display.Controls.Add((Control) this.cmb_Display_TgtLctn);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_TgtLctn);
      this.grb_Display.Controls.Add((Control) this.cmb_Display_GpsInfo);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_BgClr);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_TimeVdd);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_BandScpB);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_LcdContrast);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_LcdBrigtness);
      componentResourceManager.ApplyResources((object) this.grb_Display, "grb_Display");
      this.grb_Display.Name = "grb_Display";
      this.grb_Display.TabStop = false;
      this.cmb_Display_BandScpA.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_BandScpA, "cmb_Display_BandScpA");
      this.cmb_Display_BandScpA.FormattingEnabled = true;
      this.cmb_Display_BandScpA.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Display_BandScpA.Items"),
        (object) componentResourceManager.GetString("cmb_Display_BandScpA.Items1")
      });
      this.cmb_Display_BandScpA.Name = "cmb_Display_BandScpA";
      componentResourceManager.ApplyResources((object) this.lbl_Display_BandScpA, "lbl_Display_BandScpA");
      this.lbl_Display_BandScpA.Name = "lbl_Display_BandScpA";
      componentResourceManager.ApplyResources((object) this.lbl_Display_DisplaySelect, "lbl_Display_DisplaySelect");
      this.lbl_Display_DisplaySelect.Name = "lbl_Display_DisplaySelect";
      this.cmb_Display_TimeVdd.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_TimeVdd, "cmb_Display_TimeVdd");
      this.cmb_Display_TimeVdd.FormattingEnabled = true;
      this.cmb_Display_TimeVdd.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Display_TimeVdd.Items"),
        (object) componentResourceManager.GetString("cmb_Display_TimeVdd.Items1")
      });
      this.cmb_Display_TimeVdd.Name = "cmb_Display_TimeVdd";
      this.cmb_Display_Altitude.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_Altitude, "cmb_Display_Altitude");
      this.cmb_Display_Altitude.FormattingEnabled = true;
      this.cmb_Display_Altitude.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Display_Altitude.Items"),
        (object) componentResourceManager.GetString("cmb_Display_Altitude.Items1")
      });
      this.cmb_Display_Altitude.Name = "cmb_Display_Altitude";
      this.cmb_Display_LcdContrast.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_LcdContrast, "cmb_Display_LcdContrast");
      this.cmb_Display_LcdContrast.FormattingEnabled = true;
      this.cmb_Display_LcdContrast.Items.AddRange(new object[7]
      {
        (object) componentResourceManager.GetString("cmb_Display_LcdContrast.Items"),
        (object) componentResourceManager.GetString("cmb_Display_LcdContrast.Items1"),
        (object) componentResourceManager.GetString("cmb_Display_LcdContrast.Items2"),
        (object) componentResourceManager.GetString("cmb_Display_LcdContrast.Items3"),
        (object) componentResourceManager.GetString("cmb_Display_LcdContrast.Items4"),
        (object) componentResourceManager.GetString("cmb_Display_LcdContrast.Items5"),
        (object) componentResourceManager.GetString("cmb_Display_LcdContrast.Items6")
      });
      this.cmb_Display_LcdContrast.Name = "cmb_Display_LcdContrast";
      this.cmb_Display_TimerClk.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_TimerClk, "cmb_Display_TimerClk");
      this.cmb_Display_TimerClk.FormattingEnabled = true;
      this.cmb_Display_TimerClk.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Display_TimerClk.Items"),
        (object) componentResourceManager.GetString("cmb_Display_TimerClk.Items1")
      });
      this.cmb_Display_TimerClk.Name = "cmb_Display_TimerClk";
      this.cmb_Display_LcdBrigtness.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_LcdBrigtness, "cmb_Display_LcdBrigtness");
      this.cmb_Display_LcdBrigtness.FormattingEnabled = true;
      this.cmb_Display_LcdBrigtness.Items.AddRange(new object[7]
      {
        (object) componentResourceManager.GetString("cmb_Display_LcdBrigtness.Items"),
        (object) componentResourceManager.GetString("cmb_Display_LcdBrigtness.Items1"),
        (object) componentResourceManager.GetString("cmb_Display_LcdBrigtness.Items2"),
        (object) componentResourceManager.GetString("cmb_Display_LcdBrigtness.Items3"),
        (object) componentResourceManager.GetString("cmb_Display_LcdBrigtness.Items4"),
        (object) componentResourceManager.GetString("cmb_Display_LcdBrigtness.Items5"),
        (object) componentResourceManager.GetString("cmb_Display_LcdBrigtness.Items6")
      });
      this.cmb_Display_LcdBrigtness.Name = "cmb_Display_LcdBrigtness";
      componentResourceManager.ApplyResources((object) this.lbl_Display_Altitude, "lbl_Display_Altitude");
      this.lbl_Display_Altitude.Name = "lbl_Display_Altitude";
      this.cmb_Display_BandScpB.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_BandScpB, "cmb_Display_BandScpB");
      this.cmb_Display_BandScpB.FormattingEnabled = true;
      this.cmb_Display_BandScpB.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Display_BandScpB.Items"),
        (object) componentResourceManager.GetString("cmb_Display_BandScpB.Items1")
      });
      this.cmb_Display_BandScpB.Name = "cmb_Display_BandScpB";
      componentResourceManager.ApplyResources((object) this.lbl_Display_TimerClk, "lbl_Display_TimerClk");
      this.lbl_Display_TimerClk.Name = "lbl_Display_TimerClk";
      this.cmb_Display_BgClr.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_BgClr, "cmb_Display_BgClr");
      this.cmb_Display_BgClr.FormattingEnabled = true;
      this.cmb_Display_BgClr.Items.AddRange(new object[6]
      {
        (object) componentResourceManager.GetString("cmb_Display_BgClr.Items"),
        (object) componentResourceManager.GetString("cmb_Display_BgClr.Items1"),
        (object) componentResourceManager.GetString("cmb_Display_BgClr.Items2"),
        (object) componentResourceManager.GetString("cmb_Display_BgClr.Items3"),
        (object) componentResourceManager.GetString("cmb_Display_BgClr.Items4"),
        (object) componentResourceManager.GetString("cmb_Display_BgClr.Items5")
      });
      this.cmb_Display_BgClr.Name = "cmb_Display_BgClr";
      componentResourceManager.ApplyResources((object) this.lbl_Display_GpsInfo, "lbl_Display_GpsInfo");
      this.lbl_Display_GpsInfo.Name = "lbl_Display_GpsInfo";
      this.cmb_Display_TgtLctn.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_TgtLctn, "cmb_Display_TgtLctn");
      this.cmb_Display_TgtLctn.FormattingEnabled = true;
      this.cmb_Display_TgtLctn.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Display_TgtLctn.Items"),
        (object) componentResourceManager.GetString("cmb_Display_TgtLctn.Items1")
      });
      this.cmb_Display_TgtLctn.Name = "cmb_Display_TgtLctn";
      componentResourceManager.ApplyResources((object) this.lbl_Display_TgtLctn, "lbl_Display_TgtLctn");
      this.lbl_Display_TgtLctn.Name = "lbl_Display_TgtLctn";
      this.cmb_Display_GpsInfo.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_GpsInfo, "cmb_Display_GpsInfo");
      this.cmb_Display_GpsInfo.FormattingEnabled = true;
      this.cmb_Display_GpsInfo.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Display_GpsInfo.Items"),
        (object) componentResourceManager.GetString("cmb_Display_GpsInfo.Items1")
      });
      this.cmb_Display_GpsInfo.Name = "cmb_Display_GpsInfo";
      componentResourceManager.ApplyResources((object) this.lbl_Display_BgClr, "lbl_Display_BgClr");
      this.lbl_Display_BgClr.Name = "lbl_Display_BgClr";
      componentResourceManager.ApplyResources((object) this.lbl_Display_TimeVdd, "lbl_Display_TimeVdd");
      this.lbl_Display_TimeVdd.Name = "lbl_Display_TimeVdd";
      componentResourceManager.ApplyResources((object) this.lbl_Display_BandScpB, "lbl_Display_BandScpB");
      this.lbl_Display_BandScpB.Name = "lbl_Display_BandScpB";
      componentResourceManager.ApplyResources((object) this.lbl_Display_LcdContrast, "lbl_Display_LcdContrast");
      this.lbl_Display_LcdContrast.Name = "lbl_Display_LcdContrast";
      componentResourceManager.ApplyResources((object) this.lbl_Display_LcdBrigtness, "lbl_Display_LcdBrigtness");
      this.lbl_Display_LcdBrigtness.Name = "lbl_Display_LcdBrigtness";
      this.tbc_Setting.Controls.Add((Control) this.tab_NormalSetting);
      this.tbc_Setting.Controls.Add((Control) this.tab_GmWiresX);
      this.tbc_Setting.Controls.Add((Control) this.tab_AprsGps);
      this.tbc_Setting.Controls.Add((Control) this.tab_AprsBcn);
      componentResourceManager.ApplyResources((object) this.tbc_Setting, "tbc_Setting");
      this.tbc_Setting.Name = "tbc_Setting";
      this.tbc_Setting.SelectedIndex = 0;
      this.cmb_WiresX_SearchSetup.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_WiresX_SearchSetup, "cmb_WiresX_SearchSetup");
      this.cmb_WiresX_SearchSetup.FormattingEnabled = true;
      this.cmb_WiresX_SearchSetup.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_WiresX_SearchSetup.Items"),
        (object) componentResourceManager.GetString("cmb_WiresX_SearchSetup.Items1")
      });
      this.cmb_WiresX_SearchSetup.Name = "cmb_WiresX_SearchSetup";
      componentResourceManager.ApplyResources((object) this.lbl_WiresX_SearchSetup, "lbl_WiresX_SearchSetup");
      this.lbl_WiresX_SearchSetup.Name = "lbl_WiresX_SearchSetup";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.tbc_Setting);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (SetForm);
      this.ShowIcon = false;
      this.FormClosed += new FormClosedEventHandler(this.SetForm_FormClosed);
      this.Load += new EventHandler(this.SetForm_Load);
      this.tab_AprsBcn.ResumeLayout(false);
      this.grb_SmartBeaconing.ResumeLayout(false);
      this.grb_SmartBeaconing.PerformLayout();
      this.grb_SmartBeaconing1.ResumeLayout(false);
      this.grb_SmartBeaconing1.PerformLayout();
      this.nud_SmartBeaconing1_TurnTime.EndInit();
      this.nud_SmartBeaconing1_TurnSlope.EndInit();
      this.nud_SmartBeaconing1_TurnAngle.EndInit();
      this.nud_SmartBeaconing1_FastRate.EndInit();
      this.nud_SmartBeaconing1_SlowRate.EndInit();
      this.nud_SmartBeaconing1_HighSpeed.EndInit();
      this.nud_SmartBeaconing1_LowSpeed.EndInit();
      this.grb_SmartBeaconing2.ResumeLayout(false);
      this.grb_SmartBeaconing2.PerformLayout();
      this.nud_SmartBeaconing2_TurnTime.EndInit();
      this.nud_SmartBeaconing2_TurnSlope.EndInit();
      this.nud_SmartBeaconing2_TurnAngle.EndInit();
      this.nud_SmartBeaconing2_FastRate.EndInit();
      this.nud_SmartBeaconing2_SlowRate.EndInit();
      this.nud_SmartBeaconing2_HighSpeed.EndInit();
      this.nud_SmartBeaconing2_LowSpeed.EndInit();
      this.grb_SmartBeaconing3.ResumeLayout(false);
      this.grb_SmartBeaconing3.PerformLayout();
      this.nud_SmartBeaconing3_TurnTime.EndInit();
      this.nud_SmartBeaconing3_TurnSlope.EndInit();
      this.nud_SmartBeaconing3_TurnAngle.EndInit();
      this.nud_SmartBeaconing3_FastRate.EndInit();
      this.nud_SmartBeaconing3_SlowRate.EndInit();
      this.nud_SmartBeaconing3_HighSpeed.EndInit();
      this.nud_SmartBeaconing3_LowSpeed.EndInit();
      this.grb_BeaconStatusText.ResumeLayout(false);
      this.grb_BeaconStatusText.PerformLayout();
      this.grp_AprsRingerCall.ResumeLayout(false);
      this.grp_AprsRingerCall.PerformLayout();
      this.grb_AprsRinger.ResumeLayout(false);
      this.grb_AprsUnit.ResumeLayout(false);
      this.grb_AprsFilter.ResumeLayout(false);
      this.tab_AprsGps.ResumeLayout(false);
      this.grb_MyPosition.ResumeLayout(false);
      this.grb_MyPosition.PerformLayout();
      this.nud_MyPosition_ManualLonMM2.EndInit();
      this.nud_MyPosition_ManualLatMM2.EndInit();
      this.nud_MyPosition_ManualLonMM1.EndInit();
      this.nud_MyPosition_ManualLatMM1.EndInit();
      this.nud_MyPosition_ManualLonDD.EndInit();
      this.nud_MyPosition_ManualLatDD.EndInit();
      this.grp_VoiceAleat.ResumeLayout(false);
      this.grp_SortFilter.ResumeLayout(false);
      this.grp_AprsPopupColor.ResumeLayout(false);
      this.grb_AprsPopup.ResumeLayout(false);
      this.grb_DigiPath.ResumeLayout(false);
      this.grb_DigiPath.PerformLayout();
      this.grb_AprsMsgText.ResumeLayout(false);
      this.grb_AprsMsgText.PerformLayout();
      this.grb_MySymbol.ResumeLayout(false);
      this.grb_MySymbol.PerformLayout();
      this.grb_AprsMsgGroup.ResumeLayout(false);
      this.grb_AprsMsgGroup.PerformLayout();
      this.grb_MsgReply.ResumeLayout(false);
      this.grb_MsgReply.PerformLayout();
      this.grb_AprsCommon.ResumeLayout(false);
      this.grb_AprsCommon.PerformLayout();
      this.tab_GmWiresX.ResumeLayout(false);
      this.grp_MsgText.ResumeLayout(false);
      ((ISupportInitialize) this.dgv_MsgText).EndInit();
      this.grb_Category.ResumeLayout(false);
      ((ISupportInitialize) this.dgv_Category).EndInit();
      this.grb_WiresX.ResumeLayout(false);
      this.grb_WiresX.PerformLayout();
      this.nud_WiresX_PresetFreq.EndInit();
      this.grb_Gm.ResumeLayout(false);
      this.grb_Gm.PerformLayout();
      this.grb_Digital.ResumeLayout(false);
      this.grb_Digital.PerformLayout();
      this.tab_NormalSetting.ResumeLayout(false);
      this.grb_FuncSet.ResumeLayout(false);
      this.grb_FuncSet.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.grb_Option.ResumeLayout(false);
      this.grb_Option.PerformLayout();
      this.grb_Config.ResumeLayout(false);
      this.grb_Config.PerformLayout();
      this.grb_DtmfSelect.ResumeLayout(false);
      ((ISupportInitialize) this.dgv_DtmfMemory).EndInit();
      this.grb_Scan.ResumeLayout(false);
      this.grb_Scan.PerformLayout();
      this.grb_Signaling.ResumeLayout(false);
      this.grb_Signaling.PerformLayout();
      this.grb_Display.ResumeLayout(false);
      this.grb_Display.PerformLayout();
      this.tbc_Setting.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
