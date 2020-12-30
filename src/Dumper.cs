using System;
using System.IO;

public class Dumper {
	static public void Dump(Database db, string filename) {
		// Dump data.
		using (StreamWriter dump_file = new StreamWriter(filename)) {
			dump_file.WriteLine("<!DOCTYPE html>");
			dump_file.WriteLine("<html>");
			dump_file.WriteLine($"<head><title>Radio Data Dump</title><h1>Radio Data Dump for {db.Gm_CallSign}</h1></head>");
			dump_file.WriteLine("<body>");
			dump_file.WriteLine("<h2>A-Band (VHF) Memories</h2>");
			dump_file.WriteLine("<table>");
			dump_file.WriteLine("<tr><th>No</th><th>RecvFreq</th><th>SendFreq</th><th>ShiftFreq</th><th>ShiftDir</th><th>Mode</th><th>MemoryName</th><th>SqlType</th><th>ToneFreq</th><th>DcsCode</th><th>PrTone</th><th>SendOut</th><th>Skip</th><th>Step</th><th>ClockShift</th><th>MemoryDir</th><th>Comment</th></tr>");
			foreach (BandMemory bm in db.aBandMemory) {
				dump_file.WriteLine($@"<tr><td>{Int32.Parse(bm.No) + 1}</td>
							<td>{bm.RecvFreq}</td>
							<td>{bm.SendFreq}</td>
							<td>{bm.ShiftFreq}</td>
							<td>{DataForm.tbl_ShiftDir_All[bm.ShiftDir]}</td>
							<td>{DataForm.tbl_Mode[bm.Mode]}</td>
							<td>{bm.MemoryName}</td>
							<td>{DataForm.tbl_SqlType_All[bm.SqlType]}</td>
							<td>{DataForm.tbl_ToneFreq[bm.ToneFreq]}</td>
							<td>{DataForm.tbl_DcsCode[bm.DcsCode]}</td>
							<td>{DataForm.tbl_PrTone[bm.PrTone]}</td>
							<td>{DataForm.tbl_SendOut[bm.SendOut]}</td>
							<td>{DataForm.tbl_Skip[bm.Skip]}</td>
							<td>{DataForm.tbl_Step_all[bm.Step]}</td>
							<td>{bm.ClockShift}</td>
							<td>{bm.MemoryDir}</td>
							<td>{bm.Comment}</td></tr>");
			}
			dump_file.WriteLine("</table>");
			dump_file.WriteLine("<h2>B-Band (UHF) Memories</h2>");
			dump_file.WriteLine("<table>");
			dump_file.WriteLine("<tr><th>No</th><th>RecvFreq</th><th>SendFreq</th><th>ShiftFreq</th><th>ShiftDir</th><th>Mode</th><th>MemoryName</th><th>SqlType</th><th>ToneFreq</th><th>DcsCode</th><th>PrTone</th><th>SendOut</th><th>Skip</th><th>Step</th><th>ClockShift</th><th>MemoryDir</th><th>Comment</th></tr>");
			foreach (BandMemory bm in db.bBandMemory) {
				dump_file.WriteLine($@"<tr><td>{Int32.Parse(bm.No) + 1}</td>
							<td>{bm.RecvFreq}</td>
							<td>{bm.SendFreq}</td>
							<td>{bm.ShiftFreq}</td>
							<td>{DataForm.tbl_ShiftDir_All[bm.ShiftDir]}</td>
							<td>{DataForm.tbl_Mode[bm.Mode]}</td>
							<td>{bm.MemoryName}</td>
							<td>{DataForm.tbl_SqlType_All[bm.SqlType]}</td>
							<td>{DataForm.tbl_ToneFreq[bm.ToneFreq]}</td>
							<td>{DataForm.tbl_DcsCode[bm.DcsCode]}</td>
							<td>{DataForm.tbl_PrTone[bm.PrTone]}</td>
							<td>{DataForm.tbl_SendOut[bm.SendOut]}</td>
							<td>{DataForm.tbl_Skip[bm.Skip]}</td>
							<td>{DataForm.tbl_Step_all[bm.Step]}</td>
							<td>{bm.ClockShift}</td>
							<td>{bm.MemoryDir}</td>
							<td>{bm.Comment}</td></tr>");
			}
			dump_file.WriteLine("</table>");
			dump_file.WriteLine("</body>");
			dump_file.WriteLine("</html>");
		}
	}
}
