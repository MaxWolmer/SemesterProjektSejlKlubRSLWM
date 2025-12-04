// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Models;


//Forløbig test af repair - 14/12 kl. 12.45:
DateTime d1 = new DateTime(2025, 12, 04, 13, 00, 00);

Boat b1 = new Boat("Kiwi", "Fishermans", 738746);

Repair r1 = new Repair(d1, "Masten er knekket", false, b1);

Console.WriteLine(r1);

Console.WriteLine();
Boat b2 = new Boat("Annika", "Fishermans", 764399);
Repair r2 = new Repair(new DateTime(2025,12,02,15,00,00), "Roret er i stykker", true, b2);

Console.WriteLine(r2);