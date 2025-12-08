// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Exceptions.RepairExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;

//Forløbig test af repair - 14/12 kl. 12.45:
DateTime d1 = new DateTime(2025, 12, 04, 13, 00, 00);

Repair r1 = new Repair(d1,"Masten er knekket", false, new Boat("Kiwi","Fishermans", 738746), new User("Jytte","jytte@mail.com", "12121212", false));
Repair r2 = new Repair(DateTime.Now, "Roret er i stykker", false, new Boat("Annika", "Fishermans", 764399), new User("Poul", "poul@mail.com","13131313", false));
Repair r3 = new Repair(DateTime.Now,"Der er skarbet maling af bunden", false, new Boat("Surfer", "sejlbåd", 123123), new User("Anderas", "andreas","14141414", false));
Repair r4 = new Repair(DateTime.Now, "Der er kommet en flænge i sejlet", false, new Boat("Søstjernen", "Tera", 1424), new User("Susanne", "Susanne@mail.com", "15151515", false));

//Console.WriteLine(r1);
//Console.WriteLine();
//Console.WriteLine(r2);
//Console.WriteLine();
//Console.WriteLine(r3);
//Console.WriteLine();
//Console.WriteLine(r4);
Console.WriteLine("Testing af RepairRepo:");

RepairRepo rRepo = new RepairRepo();
rRepo.AddRepair(r1);
rRepo.AddRepair(r2);
rRepo.AddRepair(r3);
rRepo.AddRepair(r4);
Console.WriteLine($"Der er antal {rRepo.Count} reperationer");
rRepo.GetAllRepairs();

Console.WriteLine("Test af PrintAll");
rRepo.PrintAllRepairs();
Console.WriteLine("Testing af GetRepairById:");
rRepo.GetRepairById(2);
try
{
    Console.WriteLine(rRepo.GetRepairById(3));
}
catch (RepairIdDoesNotExistException IdEx)
{
    Console.WriteLine($"Fejlbesked: {IdEx.Message}");
}

Console.WriteLine($"Der er {rRepo.Count} antal reperationer før remove.");
rRepo.RemoveRepairById(4);
Console.WriteLine($"Der er {rRepo.Count} antal reperationer efter remove.");

Console.WriteLine("Testing af UpdateRepair:");
Console.WriteLine("Bådens status før:" + r1.StatusOfRepair);
try
{
rRepo.UpdateRepairationStatus(1);
}
catch(RepairIdDoesNotExistException idex)
{
    Console.WriteLine(idex.Message);
}
Console.WriteLine($"bådens status efter: {r1.StatusOfRepair}");

Console.WriteLine();
Console.WriteLine("Test af PrintNonFixedRepairs:");
foreach(Repair r in rRepo.PrintNonFixedRepairs())
{
    Console.WriteLine(r.ToString());
}
