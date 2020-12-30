# FTM-400XDR Programming Software
### By Oliver Trevor, KM6WOX

Yaesu's provided programming software for the FTM-400(XDR) radio series is buggy and unusable. The third-party RT Systems programming software is expensive. CHIRP does not support the FTM-400(XDR) series. The Yaesu and RT Systems software packages don't run on Linux. This project aims to fix all of these problems.

We provide a single .NET executable (written in C#) that takes a .dat radio data backup file (obtained by telling the FTM-400(XDR) to back itself up to a microSD card), a csv file of A-band repeaters, a csv file of B-band repeaters, and an output filename. The output file will be a .dat file that can be copied back to the radio's microSD card and used to program the radio by restoring from backup.

Example usage:

```
./Programmer.exe CLNFTM400D.dat vhfmemories.csv uhfmemories.csv CLNFTM400D.dat.new
```

The program will read in the original .dat file, add the repeaters to it, then output a new .dat file which can be copied back to the SD card with the same name and location as the original file.

The .csv files should be in the CHIRP format. You can download them from RepeaterBook using the EXPORT > CHIRP menu option.

## Dependencies

You will need to be able to run .NET executables. On Windows, .NET is usually already installed. On Linux, install Mono to be able to run the executable.

No warranty is provided, nor any guarantee that the program will not damage your radio. Use at your own risk.
