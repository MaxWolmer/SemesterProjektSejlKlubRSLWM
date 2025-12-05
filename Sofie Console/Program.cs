// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Exceptions.RepairExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;

//Forløbig test af repair - 14/12 kl. 12.45:
DateTime d1 = new DateTime(2025, 12, 04, 13, 00, 00);

Repair r1 = new Repair(d1, "Masten er knekket", false, new Boat("Kiwi","Fishermans", 738746), new User("Jytte","jytte@mail.com", "12121212", false));
Repair r2 = new Repair(new DateTime(2025,12,02,15,00,00), "Roret er i stykker", true, new Boat("Annika", "Fishermans", 764399), new User("Poul", "poul@mail.com","13131313", false));
Repair r3 = new Repair(new DateTime(2025, 12, 05, 10, 30, 00), "Der er skarbet maling af bunden", false, new Boat("Surfer", "sejlbåd", 123123), new User("Anderas", "andreas","14141414", true));

Console.WriteLine(r1);
Console.WriteLine();
Console.WriteLine(r2);
Console.WriteLine();
Console.WriteLine(r3);

Console.WriteLine("Testing af RepairRepo:");

RepairRepo rRepo = new RepairRepo();
rRepo.AddRepair(r1);
rRepo.AddRepair(r2);

rRepo.GetAllRepairs();

rRepo.GetRepairById(2);
Console.WriteLine(rRepo.GetRepairById(2));

Console.WriteLine();

try
{
Console.WriteLine(rRepo.GetRepairById(3));
}
catch (RepairIdDoesNotExistException IdEx)
{
    Console.WriteLine($"Fejlbesked: {IdEx.Message}");
}


