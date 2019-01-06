using System.IO;
using System.Collections.Generic;

public class CSV {
	private string[] lines;
	private int lineIndex;
	private bool endOfData;
	private string[] SplitColumns(string row) {
		var columns = new List<string>();
		columns.Add("");
		bool openQuotes = false;
		for (int i = 0; i < row.Length; i++) {
			if (row[i] == '"' && !openQuotes) {
				openQuotes = true;
			}
			else if (row[i] == '"' && openQuotes) {
				openQuotes = false;
			}
			else if (row[i] == ',' && !openQuotes) {
				columns.Add("");
			}
			else if (row[i] == ',' && openQuotes) {
				columns[columns.Count - 1] += ',';
			}
			else {
				columns[columns.Count - 1] += row[i];
			}
		}
		return columns.ToArray();
	}
	public CSV(string filename) {
		lines = File.ReadAllLines(filename);
		lineIndex = 1;
		endOfData = false;
	}
	public string[] GetColumnNames() {
		return this.SplitColumns(lines[0]);
	}
	public string[] GetNextRow() {
		if (lineIndex + 1 == lines.Length) {
			endOfData = true;
		}
		return this.SplitColumns(lines[lineIndex++]);
	}
	public bool EndOfData() {
		return endOfData;
	}
	public void Rewind() {
		lineIndex = 0;
		endOfData = false;
	}
}
