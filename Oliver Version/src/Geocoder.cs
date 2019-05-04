using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;

public class Geocoder {
	private Dictionary<string, double[]> cache;

	public Geocoder() {
		cache = new Dictionary<string, double[]>();	
	}

	public double[] Locate(string address) {
		try {
			return cache[address];
		}
		catch {
			// Pass.
		}

		HttpWebRequest request = (HttpWebRequest) WebRequest.Create($"http://nominatim.openstreetmap.org/search?q={address}&format=json");
		request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36";
		HttpWebResponse response = (HttpWebResponse) request.GetResponse();
		Stream stream = response.GetResponseStream();
		StreamReader reader = new StreamReader(stream);
		string rawJson = reader.ReadToEnd();

		double[] coordinates = new double[2];
		Regex regex = new Regex("\"lat\":\"(-?\\d+\\.\\d+)");
		Match match = regex.Match(rawJson);
		if (match.Groups[1].Value.Equals("")) {
			coordinates[0] = 0.0;
			coordinates[1] = 0.0;
			return coordinates;
		}
		coordinates[0] = Double.Parse(match.Groups[1].Value);
		regex = new Regex("\"lon\":\"(-?\\d+\\.\\d+)");
		match = regex.Match(rawJson);
		coordinates[1] = Double.Parse(match.Groups[1].Value);

		cache[address] = coordinates;

		Thread.Sleep(100);

		return coordinates;
	}

	public double DistanceBetween(string address1, string address2) {
		double[] coords1, coords2;
		coords1 = this.Locate(address1);
		coords2 = this.Locate(address2);
		return Math.Sqrt((coords2[0] - coords1[0]) * (coords2[0] - coords1[0]) + (coords2[1] - coords1[1]) * (coords2[1] - coords1[1]));
	}
}
