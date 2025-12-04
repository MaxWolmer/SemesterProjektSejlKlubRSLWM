// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Models;


//Forløbig test af repair - 14/12 kl. 12.45:
DateTime d1 = new DateTime(2025, 12, 04, 13, 00, 00);

Repair r1 = new Repair(d1, "Masten er knekket", false);

Console.WriteLine(r1);