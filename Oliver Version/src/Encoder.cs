using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;

/**
Class for transferring parsed CSV data into a Database object.
*/
public class Encoder {
	public static void Encode(List<string[]> csvData, BindingList<BandMemory> bandMemories) {
		// Place band memories into database.
		int location = 0;
		foreach (string[] columns in csvData) {
			if (location >= Database.ABANDMEMCHNUM) {
				break;
			}
			string name = columns[1];
			decimal frequency = Decimal.Parse(columns[2]);
			string duplex = columns[3];
			decimal offset;
			if (columns[4].Length > 0) {
				offset = Decimal.Parse(columns[4]);
			}
			else {
				offset = 0.0m;
			}
			string tone = columns[5];
			decimal rtonefreq = Decimal.Parse(columns[6]);
			decimal ctonefreq = Decimal.Parse(columns[7]);
			int dtcscode = Int32.Parse(columns[8]);
			string dtcspolarity = columns[9];
			string mode = columns[10];
			string tstep = columns[11];
			string comment = columns[12];
			if (string.Equals(mode, "FM") || string.Equals(mode, "AM") || string.Equals(mode, "NFM") || string.Equals(mode, "Auto")) {
				Console.WriteLine("Location: " + location);
				Console.WriteLine("Name: " + name);
				Console.WriteLine("Frequency: " + frequency);
				Console.WriteLine("Duplex: " + duplex);
				Console.WriteLine("Offset: " + offset);
				Console.WriteLine("Tone: " + tone);
				Console.WriteLine("Rtonefreq: " + rtonefreq);
				Console.WriteLine("Ctonefreq: " + ctonefreq);
				Console.WriteLine("Dtcscode: " + dtcscode);
				Console.WriteLine("Dtcspolarity: " + dtcspolarity);
				Console.WriteLine("Mode: " + mode);
				Console.WriteLine("Tstep: " + tstep);
				Console.WriteLine("Comment: " + comment);
				Console.WriteLine("***********************************************");
				bandMemories[location].No = location.ToString();
				bandMemories[location].RecvFreq = frequency;
				bandMemories[location].SendFreq = 0.0m;
				bandMemories[location].ShiftFreq = Math.Abs(offset);
				if (offset > 0) {
					bandMemories[location].ShiftDir = Array.IndexOf(DataForm.tbl_ShiftDir_All, "+RPT");
				}
				else if (offset < 0) {
					bandMemories[location].ShiftDir = Array.IndexOf(DataForm.tbl_ShiftDir_All, "-RPT");
				}
				else {
					bandMemories[location].ShiftDir = Array.IndexOf(DataForm.tbl_ShiftDir_All, "OFF");
				}
				if (string.Equals(mode, "Auto")) {
					mode = "FM";
				}
				bandMemories[location].Mode = Array.IndexOf(DataForm.tbl_Mode, mode);
				bandMemories[location].MemoryName = name;
				if (string.Equals(tone, "Tone")) {
					bandMemories[location].SqlType = Array.IndexOf(DataForm.tbl_SqlType_All, "TONE SQL");
				}
				else if (string.Equals(tone, "DTCS")) {
					bandMemories[location].SqlType = Array.IndexOf(DataForm.tbl_SqlType_All, "TONE DCS");
				}
				else {
					bandMemories[location].SqlType = Array.IndexOf(DataForm.tbl_SqlType_All, "OFF");
				}
				bandMemories[location].ToneFreq = Array.IndexOf(DataForm.tbl_ToneFreq, rtonefreq + " Hz");
				bandMemories[location].DcsCode = Array.IndexOf(DataForm.tbl_DcsCode, dtcscode.ToString().PadLeft(3, '0'));
				bandMemories[location].SendOut = Array.IndexOf(DataForm.tbl_SendOut, "HIGH");
				bandMemories[location].Skip = Array.IndexOf(DataForm.tbl_Skip, "OFF");
				bandMemories[location].Step = Array.IndexOf(DataForm.tbl_Step_all, "5.0KHz");
				bandMemories[location].ClockShift = false;
				bandMemories[location].MemoryDir = true;
				bandMemories[location].Comment = comment;
				location++;
			}
		}
	}
}
