using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;

public class Programmer {
	static public void Main(string[] args) {
		// Sort by distance or not.
		bool sort = false;
		// Parse arguments.
		if (!(args.Length == 3 || args.Length == 4)) {
			Console.WriteLine("Usage: ./Programmer.exe inputfile.dat vhfmemories.csv uhfmemories.csv outputfile.dat");
			Console.WriteLine("inputfile.dat should be the .dat file from your Yaesu FTM-400XDR's SD card backup.");
			Console.WriteLine("vhfmemories.csv should be a CSV in Chirp CSV format containing all the VHF repeaters you want programmed (can be downloaded from RepeaterBook).");
			Console.WriteLine("uhfmemories.csv should be a CSV in Chirp CSV format containing all the UHF repeaters you want programmed (can be downloaded from RepeaterBook).");
			Console.WriteLine("outputfile.dat should the name you want the programmed .dat file written to.");
			return;
		}
		// Load settings from XML file.
		Settings.LoadFromXmlFile();
		// Initialize a database object that holds all of the radio parameters and memories.
		Database db = new Database();
		// Initialize a dataconverter object that translates the radio's binary format into the database.
		DataConverter dc = new DataConverter();
		// Read the binary data from the file and into the database.
        db.Buffer = File.ReadAllBytes(args[0]);
		dc.Decode(db);
		// Dump data to HTML.
		Dumper.Dump(db, "source.html");
		// Parse VHF CSV.
		CSV vhfCsv = new CSV(args[1]);
		var vhfCsvData = new List<string[]>();
		while (!vhfCsv.EndOfData()) {
			vhfCsvData.Add(vhfCsv.GetNextRow());
		}
		// Sort the CSV of VHF repeaters by how close the repeater is to Pleasanton.
		var geocoder = new Geocoder();
		var memories = new List<Tuple<int, double>>();
		if (sort) {
			for (int i = 0; i < vhfCsvData.Count; i++) {
				Console.WriteLine($"{i}/{vhfCsvData.Count - 1}");
				memories.Add(new Tuple<int, double>(i, geocoder.DistanceBetween(vhfCsvData[i][12], "Pleasanton, CA 94566")));
			}
			memories.Sort((a, b) => a.Item2.CompareTo(b.Item2));
			var newVhfCsvData = new List<string[]>();
			foreach (var memory in memories) {
				newVhfCsvData.Add(vhfCsvData[memory.Item1]);
			}
			vhfCsvData = newVhfCsvData;
		}
		// Parse UHF CSV.
		CSV uhfCsv = new CSV(args[2]);
		var uhfCsvData = new List<string[]>();
		while (!uhfCsv.EndOfData()) {
			uhfCsvData.Add(uhfCsv.GetNextRow());
		}
		// Sort the CSV of UHF repeaters by how close the repeater is to Pleasanton.
		if (sort) {
			memories = new List<Tuple<int, double>>();
			for (int i = 0; i < uhfCsvData.Count; i++) {
				Console.WriteLine($"{i}/{uhfCsvData.Count - 1}");
				memories.Add(new Tuple<int, double>(i, geocoder.DistanceBetween(uhfCsvData[i][12], "Pleasanton, CA 94566")));
			}
			memories.Sort((a, b) => a.Item2.CompareTo(b.Item2));
			var newUhfCsvData = new List<string[]>();
			foreach (var memory in memories) {
				newUhfCsvData.Add(uhfCsvData[memory.Item1]);
			}
			uhfCsvData = newUhfCsvData;
		}
		// Place the CSV repeater data into the database (take only the first 500 items because of how large the radio's memory is).
        vhfCsvData = vhfCsvData.GetRange(0, 499);
        uhfCsvData = uhfCsvData.GetRange(0, 499);
		Encoder.Encode(vhfCsvData, db.aBandMemory);
		Encoder.Encode(uhfCsvData, db.bBandMemory);
		// Save database to file (if in SD card mode).
        Dumper.Dump(db, "destination.html");
        dc.Encode(db);
        byte[] buffer = db.Buffer;
        File.WriteAllBytes(args[3], buffer);
	}
}
