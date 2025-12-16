// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Data;
using ProjektLibrary.Exceptions.RepairExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;

RepairRepo rRepo = new RepairRepo();

#region Ekstra Data
User u1 = new User("Marlene", "Marlene@mail.com", "10101010", false);
User u2 = new User("Jytte","Jytte@mail.com", "20202020", true);
Boat b1 = new Boat("FEVA", "Volksbotten", "Svane", "Length: 12 m\nWidth: 3 m\nHeight: 2 m", true, true, u1);
Boat b2 = new Boat("FEVA", "Sea Viking", "Havfruen", "Length: 12 m\nWidth: 3 m\nHeight: 2 m", true, true, u2);


Repair r5 = new Repair("Malingen er skallet af bagbordside", false, b1, u1);
Repair r6 = new Repair("Flænge i sejlet", false, b1, u1);

#endregion

#region Test af Test af AddRepair(Repair repair)
//Console.WriteLine("Test af AddRepair");

//Console.WriteLine($"Der er antal {rRepo.Count} reperationer før AddRepair er brugt.");
//rRepo.AddRepair(r5);
//rRepo.AddRepair(r6);

//Console.WriteLine();
//Console.WriteLine($"Der er antal {rRepo.Count} reperationer efter AddRepair er brugt x2.");
//Console.WriteLine();
#endregion

#region Test af PrintAllRepairs()
//Console.WriteLine("Test af PrintAll");
//rRepo.PrintAllRepairs();
#endregion

#region Test af GetRepairById(int id)
//Console.WriteLine("Testing af GetRepairById:");
//rRepo.GetRepairById(1);
//rRepo.GetRepairById(2);
//try
//{
//    Console.WriteLine(rRepo.GetRepairById(3));
//}
//catch (RepairIdDoesNotExistException IdEx)
//{
//    Console.WriteLine($"Fejlbesked: {IdEx.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Fejlbesked: {ex.Message}");
//}

//Console.WriteLine("Test af exceptionen: RepairIdDoesNotExistException:");

//try
//{
//    Console.WriteLine(rRepo.GetRepairById(60));
//}
//catch (RepairIdDoesNotExistException IdEx)
//{
//    Console.WriteLine($"Fejlbesked: {IdEx.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Fejlbesked: {ex.Message}");
//}
#endregion

#region Test af RemoveRepairById(int id)
//Console.WriteLine("Testing RemoveRepairById:");
//Console.WriteLine($"Der er {rRepo.Count} antal reperationer før remove.");
//try
//{
//    rRepo.RemoveRepairById(1);
//}
//catch (RepairIdDoesNotExistException idex)
//{
//    Console.WriteLine($"Fejlbesked: {idex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Fejlbesked: {ex.Message}");
//}

//Console.WriteLine($"Der er {rRepo.Count} antal reperationer efter remove.");
#endregion

#region Test af UpdateRepair(int id)
//Console.WriteLine("Test af UpdateRepair fra ikke-repareret til repareret:");
//Console.WriteLine("Bådens status før:" + r5.StatusOfRepair);
//try
//{
//    rRepo.UpdateReperationStatus(r5.Id);
//}
//catch (RepairIdDoesNotExistException idex)
//{
//    Console.WriteLine(idex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//Console.WriteLine($"Bådens status efter: {r5.StatusOfRepair}");
//Console.WriteLine();

#region test af skaden er repararet
//Console.WriteLine("Test af UpdateRepair fra repareret til ikke-repareret:");
//Console.WriteLine("Bådens status før:" + r5.StatusOfRepair);
//try
//{
//    rRepo.UpdateReperationStatus(r5.Id);
//}
//catch (RepairIdDoesNotExistException idex)
//{
//    Console.WriteLine(idex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//Console.WriteLine($"Bådens status efter: {r5.StatusOfRepair}");
//Console.WriteLine();
#endregion
#endregion

#region Test af GetNonFixedRepairs
//Console.WriteLine();

//Console.WriteLine("Test af GetNonFixedRepairs:");

//rRepo.GetNonFixedRepairs();
//foreach(Repair r in rRepo.GetNonFixedRepairs())
//{
//    Console.WriteLine(r.ToString());
//}
#endregion

#region Test af GetRepairsInBoat(int boatId)
//Console.WriteLine("Test af GetRepairsInBoat:");
//rRepo.GetRepairsForBoat(b1.BoatId);

//foreach (Repair r in rRepo.GetRepairsForBoat(b1.BoatId))
//{
//    Console.WriteLine(r.ToString());
//}

//Console.WriteLine("Test med båd uden reparationer:");
//foreach (Repair r in rRepo.GetRepairsForBoat(b2.BoatId))
//{
//    Console.WriteLine(r);
//}

#endregion

#region Test af SailRepair
SailRepair sr1 = new SailRepair("Der er kommet et hul i sejlet", false, b1, u2, "polyester", "MainSail", 3.7);

Console.WriteLine(sr1.ToString());

Console.WriteLine("Test om SailRepair kan add'et til samlingen af reparationer:");
Console.WriteLine($"Der er antal {rRepo.Count} reperationer før AddRepair er brugt.");
rRepo.AddRepair(sr1);
Console.WriteLine($"Der er antal {rRepo.Count} reperationer efter AddRepair er brugt.");
rRepo.PrintAllRepairs(); //Der bliver kun printet den del af ToString til sr1, som den får af Repair, men ikke det ekstra.

#endregion