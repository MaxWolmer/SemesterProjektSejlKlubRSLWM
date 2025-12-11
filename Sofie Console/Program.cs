// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Exceptions.RepairExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;

RepairRepo rRepo = new RepairRepo();
#region data
Boat b1 = new Boat("Kiwi", "Fishermans");
Boat b2 = new Boat("Annika", "Fishermans");
Boat b3 = new Boat("Surfer", "sejlbåd");
Boat b4 = new Boat("Søstjernen", "Tera");

User u1 = new User("Jytte", "jytte@mail.com", "12121212", false);
User u2 = new User("Poul", "poul@mail.com", "13131313", false);
User u3 = new User("Anderas", "andreas@mail.com", "14141414", false);
User u4 = new User("Susanne", "Susanne@mail.com", "15151515", false);

Repair r1 = new Repair("Masten er knekket", false, b1, u1);
Repair r2 = new Repair("Roret er i stykker", false, b2, u3);
Repair r3 = new Repair("Der er skarbet maling af bunden", false, b3, u3);
Repair r4 = new Repair("Der er kommet en flænge i sejlet", false, b4, u4);
Repair r5 = new Repair("Malingen er skallet af bagbordside", false, b1, u2);

Console.WriteLine(r1);
Console.WriteLine();
Console.WriteLine(r2);
Console.WriteLine();
Console.WriteLine(r3);
Console.WriteLine();
Console.WriteLine(r4);
#endregion
//b1.AddRepair(r1);
//b1.AddRepair(r5);
Console.WriteLine("Tester GetRepairs fra specifik båd:");
var repairList = b1.GetRepairs;
Console.WriteLine("Print af liste af reperationer fra specifik båd (før):");
rRepo.AddRepair(r5);
foreach (var repair in b1.GetRepairs)
{
    Console.WriteLine(repair);
}
Console.WriteLine("Print af liste af reperationer fra dictionary (før):");
rRepo.PrintAllRepairs();

Console.WriteLine("Test af Remove fra en specifik båd:");
rRepo.RemoveRepairById(r5.Id);

Console.WriteLine("Print af liste af reperationer fra specifik båd (efter):");
foreach (var repair in b1.GetRepairs)
{
    Console.WriteLine(repair);
}
Console.WriteLine("Print af liste af reperationer fra Dictionary (efter):");
rRepo.PrintAllRepairs();

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


