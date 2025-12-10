// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Exceptions.RepairExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;

//Forløbig test af repair - 14/12 kl. 12.45:
DateTime d1 = new DateTime(2025, 12, 04, 13, 00, 00);
#region data
Boat b1 = new Boat("Kiwi", "Fishermans");
Boat b2 = new Boat("Annika", "Fishermans");
Boat b3 = new Boat("Surfer", "sejlbåd");
Boat b4 = new Boat("Søstjernen", "Tera");

Repair r1 = new Repair("Masten er knekket", false, b1, new User("Jytte","jytte@mail.com", "12121212", false));
Repair r2 = new Repair("Roret er i stykker", false, b2, new User("Poul", "poul@mail.com","13131313", false));
Repair r3 = new Repair("Der er skarbet maling af bunden", false, b3, new User("Anderas", "andreas@mail.com", "14141414", false));
Repair r4 = new Repair("Der er kommet en flænge i sejlet", false, b4, new User("Susanne", "Susanne@mail.com", "15151515", false));

Console.WriteLine(r1);
Console.WriteLine();
Console.WriteLine(r2);
Console.WriteLine();
Console.WriteLine(r3);
Console.WriteLine();
Console.WriteLine(r4);

b1.AddRepair(r1);
b1.AddRepair(r2);


#endregion
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
rRepo.GetRepairById(1);
rRepo.GetRepairById(2);
try
{
    Console.WriteLine(rRepo.GetRepairById(3));
}
catch (RepairIdDoesNotExistException IdEx)
{
    Console.WriteLine($"Fejlbesked: {IdEx.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Fejlbesked: {ex.Message}");
}
Console.WriteLine("Testing RemoveRepairById:");
Console.WriteLine($"Der er {rRepo.Count} antal reperationer før remove.");
try
{
    rRepo.RemoveRepairById(4);
}
catch(RepairIdDoesNotExistException idex)
{
    Console.WriteLine($"fejlbesked: {idex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine("Fejl");
}
Console.WriteLine($"Der er {rRepo.Count} antal reperationer efter remove.");

Console.WriteLine("Testing af UpdateRepair:");
Console.WriteLine("Bådens status før:" + r1.StatusOfRepair);
try
{
    rRepo.UpdateReperationStatus(1);
}
catch(RepairIdDoesNotExistException idex)
{
    Console.WriteLine(idex.Message);
}
catch(TheRepairHasAlreadyBeenFixedException afex)
{
    Console.WriteLine($"Fejlbesked: {afex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine($"bådens status efter: {r1.StatusOfRepair}");
Console.WriteLine();


Console.WriteLine("Testing af TheRepairHasAlreadyBeenFixedException:");
try
{
    rRepo.UpdateReperationStatus(1);
}
catch (RepairIdDoesNotExistException idex)
{
    Console.WriteLine($"Fejlbesked: {idex.Message}");
}
catch (TheRepairHasAlreadyBeenFixedException afex)
{
    Console.WriteLine($"Fejlbesked: {afex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Fejlbesked: {ex.Message}");
}




Console.WriteLine();

Console.WriteLine("Test af GetNonFixedRepairs:");

rRepo.GetNonFixedRepairs();
foreach(Repair r in rRepo.GetNonFixedRepairs())
{
    Console.WriteLine(r.ToString());
}


