// Decompiled with JetBrains decompiler
// Type: Ftm400dAdms7.Database
// Assembly: Ftm400dAdms7, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7A2DB9E8-7176-454B-A00F-EA8E232A8E3F
// Assembly location: C:\Users\Oliver\Downloads\FTM-400D_ADMS-7(DG-ID)_EXP\ADMS-7(DG-ID)\Ftm400dAdms7.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Ftm400dAdms7
{
  public class Database
  {
    private byte[] buffer = new byte[76800];
    public BindingList<BandMemory> aBandMemory = new BindingList<BandMemory>();
    public BindingList<BandMemory> bBandMemory = new BindingList<BandMemory>();
    public BindingList<BandMemory> aBandPmsMemory = new BindingList<BandMemory>();
    public BindingList<BandMemory> bBandPmsMemory = new BindingList<BandMemory>();
    public BindingList<BandMemory> aBandHome = new BindingList<BandMemory>();
    public BindingList<BandMemory> bBandHome = new BindingList<BandMemory>();
    public BindingList<BandMemory> aBandVfo = new BindingList<BandMemory>();
    public BindingList<BandMemory> bBandVfo = new BindingList<BandMemory>();
    public List<DtmfMemory> dtmfMemory = new List<DtmfMemory>();
    public List<Category> category = new List<Category>();
    public List<Group> group = new List<Group>();
    public List<MessageText> messageText = new List<MessageText>();
    public const int BUFFSIZE = 76800;
    public const int ABANDMEMCHNUM = 500;
    public const int BBANDMEMCHNUM = 500;
    public const int ABANDPMSMEMCHNUM = 18;
    public const int BBANDPMSMEMCHNUM = 18;
    public const int ABANDHOMECHNUM = 5;
    public const int BBANDHOMECHNUM = 5;
    public const int ABANDVFOCHNUM = 5;
    public const int BBANDVFOCHNUM = 5;
    public const int DTMFCHNUM = 9;
    public const int CATEGORYCHNUM = 5;
    public const int GROUPCHNUM = 16;
    public const int MESSAGETEXTCHNUM = 10;

    public byte[] Buffer
    {
      get
      {
        return this.buffer;
      }
      set
      {
        this.buffer = value;
      }
    }

    public int Config_DtTmFrmtDt { get; set; }

    public int Config_DtTmFrmtHr { get; set; }

    public int Config_TimeZone { get; set; }

    public int Config_AtRptShftA { get; set; }

    public int Config_AtRptShftB { get; set; }

    public int Config_Beep { get; set; }

    public int Config_MicProgKeyP1 { get; set; }

    public int Config_MicProgKeyP2 { get; set; }

    public int Config_MicProgKeyP3 { get; set; }

    public int Config_MicProgKeyP4 { get; set; }

    public int Config_RxCovA { get; set; }

    public int Config_RxCovB { get; set; }

    public int Config_Unit { get; set; }

    public int Config_Apo { get; set; }

    public int Config_Tot { get; set; }

    public int Config_GpsDtm { get; set; }

    public int Config_GpsDev { get; set; }

    public int Config_GpsLog { get; set; }

    public int Config_AtModeA { get; set; }

    public int Config_AtModeB { get; set; }

    public int Config_AtStepA { get; set; }

    public int Config_AtStepB { get; set; }

    public int Scan_DWStopA { get; set; }

    public int Scan_DWStopB { get; set; }

    public int Scan_ScanDrctnA { get; set; }

    public int Scan_ScanDrctnB { get; set; }

    public int Scan_ScanRsmA { get; set; }

    public int Scan_ScanRsmB { get; set; }

    public int Display_Altitude { get; set; }

    public int Display_TimerClk { get; set; }

    public int Display_GpsInfo { get; set; }

    public int Display_TgtLctn { get; set; }

    public int Display_BgClr { get; set; }

    public int Display_BandScpA { get; set; }

    public int Display_BandScpB { get; set; }

    public int Display_LcdBrigtness { get; set; }

    public int Display_LcdContrast { get; set; }

    public int Display_TimeVdd { get; set; }

    public int Data_ComSpeed { get; set; }

    public int Data_ComOutput { get; set; }

    public int Data_ComWpFormat { get; set; }

    public int Data_ComWpFilter { get; set; }

    public int Data_DBandAprs { get; set; }

    public int Data_DBandData { get; set; }

    public int Data_DSpeedAprs { get; set; }

    public int Data_DSpeedData { get; set; }

    public int Data_DSqlcAprs { get; set; }

    public int Data_DSqlcData { get; set; }

    public int Data_DSqlcTx { get; set; }

    public int Signaling_AutDialer { get; set; }

    public int Signaling_PageRx1 { get; set; }

    public int Signaling_PageRx2 { get; set; }

    public int Signaling_PageTx1 { get; set; }

    public int Signaling_PageTx2 { get; set; }

    public int Signaling_BellRingerA { get; set; }

    public int Signaling_BellRingerB { get; set; }

    public int Signaling_SqlExA { get; set; }

    public int Signaling_SqlExB { get; set; }

    public int Signaling_WxAlrtA { get; set; }

    public int Signaling_WxAlrtB { get; set; }

    public int Audio_SubBandMute { get; set; }

    public int Audio_MicGain { get; set; }

    public int Option_UsbCmrSize { get; set; }

    public int Option_UsbCmrQlty { get; set; }

    public int Option_BltthAudio { get; set; }

    public int Option_BltthBttery { get; set; }

    public int Option_BltthVox { get; set; }

    public int Option_VcMemPR { get; set; }

    public int Option_VcMemAnnc { get; set; }

    public int Option_VcMemLng { get; set; }

    public int Option_VcMemVlm { get; set; }

    public int Option_RxMute { get; set; }

    public int FuncSet_Array1 { get; set; }

    public int FuncSet_Array2 { get; set; }

    public int FuncSet_Array3 { get; set; }

    public int FuncSet_Array4 { get; set; }

    public int Digital_AmsTxMode { get; set; }

    public int Digital_SqlType { get; set; }

    public int Digital_SqlCode { get; set; }

    public int Digital_Popup { get; set; }

    public int Digital_LocationService { get; set; }

    public int Digital_StandbyBeep { get; set; }

    public int Digital_RxDgID { get; set; }

    public int Digital_TxDgID { get; set; }

    public int Gm_RangeRinger { get; set; }

    public string Gm_CallSign { get; set; }

    public int WiresX_RptWiresFreq { get; set; }

    public Decimal WiresX_PresetFreq { get; set; }

    public int WiresX_SearchSetup { get; set; }

    public int WiresX_DgID { get; set; }

    public int AprsCommon_Cmps { get; set; }

    public int AprsCommon_Dst { get; set; }

    public int AprsCommon_Modem { get; set; }

    public int AprsCommon_Mute { get; set; }

    public int AprsCommon_TxDelay { get; set; }

    public int AprsCommon_Ambgty { get; set; }

    public int AprsCommon_SpdCrc { get; set; }

    public int AprsCommon_Alttd { get; set; }

    public int AprsCommon_Auto { get; set; }

    public int AprsCommon_Intrvl { get; set; }

    public int AprsCommon_Prprtnl { get; set; }

    public int AprsCommon_Dcy { get; set; }

    public int AprsCommon_LwSpd { get; set; }

    public int AprsCommon_RtLmt { get; set; }

    public string AprsCommon_CallsignCode { get; set; }

    public int AprsCommon_CallsignSsId { get; set; }

    public int AprsCommon_PstnCmnt { get; set; }

    public int MySymbol_Sel { get; set; }

    public string MySymbol_1_Icn { get; set; }

    public string MySymbol_2_Icn { get; set; }

    public string MySymbol_3_Icn { get; set; }

    public string MySymbol_41_Icn { get; set; }

    public string MySymbol_42_Icn { get; set; }

    public string AprsMsgGroup_G1 { get; set; }

    public string AprsMsgGroup_G2 { get; set; }

    public string AprsMsgGroup_G3 { get; set; }

    public string AprsMsgGroup_G4 { get; set; }

    public string AprsMsgGroup_G5 { get; set; }

    public string AprsMsgGroup_G6 { get; set; }

    public string AprsMsgGroup_B1 { get; set; }

    public string AprsMsgGroup_B2 { get; set; }

    public string AprsMsgGroup_B3 { get; set; }

    public int MsgReply_Reply { get; set; }

    public string MsgReply_CallSignCode { get; set; }

    public int MsgReply_CallSignSsId { get; set; }

    public string MsgReply_ReplyText { get; set; }

    public int AprsMsgText_Sel { get; set; }

    public string AprsMsgText_1 { get; set; }

    public string AprsMsgText_2 { get; set; }

    public string AprsMsgText_3 { get; set; }

    public string AprsMsgText_4 { get; set; }

    public string AprsMsgText_5 { get; set; }

    public string AprsMsgText_6 { get; set; }

    public string AprsMsgText_7 { get; set; }

    public string AprsMsgText_8 { get; set; }

    public int VoiceAleat_VoiceAleat { get; set; }

    public int VoiceAleat_ToneSql { get; set; }

    public int VoiceAleat_Dcs { get; set; }

    public int SortFilter_Sort { get; set; }

    public int SortFilter_Filter { get; set; }

    public int MyPosition_Sel { get; set; }

    public int MyPosition_ManualLat { get; set; }

    public Decimal MyPosition_ManualLatDD { get; set; }

    public Decimal MyPosition_ManualLatMM1 { get; set; }

    public Decimal MyPosition_ManualLatMM2 { get; set; }

    public int MyPosition_ManualLon { get; set; }

    public Decimal MyPosition_ManualLonDD { get; set; }

    public Decimal MyPosition_ManualLonMM1 { get; set; }

    public Decimal MyPosition_ManualLonMM2 { get; set; }

    public int AprsFilter_MicE { get; set; }

    public int AprsFilter_Position { get; set; }

    public int AprsFilter_Weather { get; set; }

    public int AprsFilter_Object { get; set; }

    public int AprsFilter_Item { get; set; }

    public int AprsFilter_Status { get; set; }

    public int AprsFilter_Other { get; set; }

    public int AprsFilter_RangeLimit { get; set; }

    public int AprsFilter_Altnet { get; set; }

    public int AprsUnit_Position { get; set; }

    public int AprsUnit_Distance { get; set; }

    public int AprsUnit_Speed { get; set; }

    public int AprsUnit_Altitude { get; set; }

    public int AprsUnit_Baro { get; set; }

    public int AprsUnit_Temp { get; set; }

    public int AprsUnit_Rain { get; set; }

    public int AprsUnit_Wind { get; set; }

    public int AprsPopup_Bcn { get; set; }

    public int AprsPopup_Msg { get; set; }

    public int AprsPopup_MyPacket { get; set; }

    public int AprsPopupColor_Bcn { get; set; }

    public int AprsPopupColor_Mbl { get; set; }

    public int AprsPopupColor_ObjItm { get; set; }

    public int AprsPopupColor_CllRngr { get; set; }

    public int AprsPopupColor_RngRngr { get; set; }

    public int AprsPopupColor_Msg { get; set; }

    public int AprsPopupColor_GrpBult { get; set; }

    public int AprsPopupColor_MyPckt { get; set; }

    public int AprsRinger_TxBcn { get; set; }

    public int AprsRinger_TxMsg { get; set; }

    public int AprsRinger_RxBcn { get; set; }

    public int AprsRinger_RxMsg { get; set; }

    public int AprsRinger_MyPacket { get; set; }

    public int AprsRinger_CllRngr { get; set; }

    public int AprsRinger_RngRbgr { get; set; }

    public int AprsRinger_MsgVc { get; set; }

    public string AprsRingerCallCode_1 { get; set; }

    public string AprsRingerCallCode_2 { get; set; }

    public string AprsRingerCallCode_3 { get; set; }

    public string AprsRingerCallCode_4 { get; set; }

    public string AprsRingerCallCode_5 { get; set; }

    public string AprsRingerCallCode_6 { get; set; }

    public string AprsRingerCallCode_7 { get; set; }

    public string AprsRingerCallCode_8 { get; set; }

    public int AprsRingerCallSsID_1 { get; set; }

    public int AprsRingerCallSsID_2 { get; set; }

    public int AprsRingerCallSsID_3 { get; set; }

    public int AprsRingerCallSsID_4 { get; set; }

    public int AprsRingerCallSsID_5 { get; set; }

    public int AprsRingerCallSsID_6 { get; set; }

    public int AprsRingerCallSsID_7 { get; set; }

    public int AprsRingerCallSsID_8 { get; set; }

    public int BeaconStatusText_Sel { get; set; }

    public int BeaconStatusText_TxRate { get; set; }

    public string BeaconStatusText_1 { get; set; }

    public string BeaconStatusText_2 { get; set; }

    public string BeaconStatusText_3 { get; set; }

    public string BeaconStatusText_4 { get; set; }

    public string BeaconStatusText_5 { get; set; }

    public int BeaconStatusText_1_Mode { get; set; }

    public int BeaconStatusText_2_Mode { get; set; }

    public int BeaconStatusText_3_Mode { get; set; }

    public int BeaconStatusText_4_Mode { get; set; }

    public int BeaconStatusText_5_Mode { get; set; }

    public int DigiPath_Sel { get; set; }

    public string DigiPathCode_P11 { get; set; }

    public string DigiPathCode_P12 { get; set; }

    public string DigiPathCode_P21 { get; set; }

    public string DigiPathCode_P22 { get; set; }

    public string DigiPathCode_P31 { get; set; }

    public string DigiPathCode_P32 { get; set; }

    public string DigiPathCode_P41 { get; set; }

    public string DigiPathCode_P42 { get; set; }

    public string DigiPathCode_F11 { get; set; }

    public string DigiPathCode_F12 { get; set; }

    public string DigiPathCode_F13 { get; set; }

    public string DigiPathCode_F14 { get; set; }

    public string DigiPathCode_F15 { get; set; }

    public string DigiPathCode_F16 { get; set; }

    public string DigiPathCode_F17 { get; set; }

    public string DigiPathCode_F18 { get; set; }

    public string DigiPathCode_F21 { get; set; }

    public string DigiPathCode_F22 { get; set; }

    public string DigiPathCode_F23 { get; set; }

    public string DigiPathCode_F24 { get; set; }

    public string DigiPathCode_F25 { get; set; }

    public string DigiPathCode_F26 { get; set; }

    public string DigiPathCode_F27 { get; set; }

    public string DigiPathCode_F28 { get; set; }

    public int DigiPathSsId_P11 { get; set; }

    public int DigiPathSsId_P12 { get; set; }

    public int DigiPathSsId_P21 { get; set; }

    public int DigiPathSsId_P22 { get; set; }

    public int DigiPathSsId_P31 { get; set; }

    public int DigiPathSsId_P32 { get; set; }

    public int DigiPathSsId_P41 { get; set; }

    public int DigiPathSsId_P42 { get; set; }

    public int DigiPathSsId_F11 { get; set; }

    public int DigiPathSsId_F12 { get; set; }

    public int DigiPathSsId_F13 { get; set; }

    public int DigiPathSsId_F14 { get; set; }

    public int DigiPathSsId_F15 { get; set; }

    public int DigiPathSsId_F16 { get; set; }

    public int DigiPathSsId_F17 { get; set; }

    public int DigiPathSsId_F18 { get; set; }

    public int DigiPathSsId_F21 { get; set; }

    public int DigiPathSsId_F22 { get; set; }

    public int DigiPathSsId_F23 { get; set; }

    public int DigiPathSsId_F24 { get; set; }

    public int DigiPathSsId_F25 { get; set; }

    public int DigiPathSsId_F26 { get; set; }

    public int DigiPathSsId_F27 { get; set; }

    public int DigiPathSsId_F28 { get; set; }

    public int SmartBeaconing_Select { get; set; }

    public Decimal SmartBeaconing1_LowSpeed { get; set; }

    public Decimal SmartBeaconing1_HighSpeed { get; set; }

    public Decimal SmartBeaconing1_SlowRate { get; set; }

    public Decimal SmartBeaconing1_FastRate { get; set; }

    public Decimal SmartBeaconing1_TurnAngle { get; set; }

    public Decimal SmartBeaconing1_TurnSlope { get; set; }

    public Decimal SmartBeaconing1_TurnTime { get; set; }

    public Decimal SmartBeaconing2_LowSpeed { get; set; }

    public Decimal SmartBeaconing2_HighSpeed { get; set; }

    public Decimal SmartBeaconing2_SlowRate { get; set; }

    public Decimal SmartBeaconing2_FastRate { get; set; }

    public Decimal SmartBeaconing2_TurnAngle { get; set; }

    public Decimal SmartBeaconing2_TurnSlope { get; set; }

    public Decimal SmartBeaconing2_TurnTime { get; set; }

    public Decimal SmartBeaconing3_LowSpeed { get; set; }

    public Decimal SmartBeaconing3_HighSpeed { get; set; }

    public Decimal SmartBeaconing3_SlowRate { get; set; }

    public Decimal SmartBeaconing3_FastRate { get; set; }

    public Decimal SmartBeaconing3_TurnAngle { get; set; }

    public Decimal SmartBeaconing3_TurnSlope { get; set; }

    public Decimal SmartBeaconing3_TurnTime { get; set; }

    public Database()
    {
      for (int Number = 0; Number < 500; ++Number)
        this.aBandMemory.Add(new BandMemory(Number, 0));
      for (int Number = 0; Number < 500; ++Number)
        this.bBandMemory.Add(new BandMemory(Number, 0));
      for (int Number = 0; Number < 18; ++Number)
        this.aBandPmsMemory.Add(new BandMemory(Number, 1));
      for (int Number = 0; Number < 18; ++Number)
        this.bBandPmsMemory.Add(new BandMemory(Number, 1));
      for (int Number = 0; Number < 5; ++Number)
        this.aBandHome.Add(new BandMemory(Number, 2));
      for (int Number = 0; Number < 5; ++Number)
        this.bBandHome.Add(new BandMemory(Number, 2));
      for (int Number = 0; Number < 5; ++Number)
        this.aBandVfo.Add(new BandMemory(Number, 2));
      for (int Number = 0; Number < 5; ++Number)
        this.bBandVfo.Add(new BandMemory(Number, 2));
      for (int number = 0; number < 9; ++number)
        this.dtmfMemory.Add(new DtmfMemory(number));
      for (int number = 0; number < 5; ++number)
        this.category.Add(new Category(number));
      for (int number = 0; number < 16; ++number)
        this.group.Add(new Group(number));
      for (int number = 0; number < 10; ++number)
        this.messageText.Add(new MessageText(number));
    }
  }
}
