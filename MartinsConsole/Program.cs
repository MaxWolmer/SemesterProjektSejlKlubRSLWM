using ProjektLibrary.Models;
using ProjektLibrary.Services;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

BoatRepo bRepo = new BoatRepo();

#region MockData
try
    {
    Boat b1 = new Boat("Big Bertha", "Catamaran");
    Boat b2 = new Boat("Small Bessie", "Ironclad");
    Boat b3 = new Boat("Furious Tasha", "Uboat");
    Boat b4 = new Boat("Mad Maddie", "Tireme");
    Boat b5 = new Boat("Talkative Tuna", "Frigate");
    Boat b6 = new Boat("Jealous Jane", "Submarine");

    bRepo.AddBoat(b1);
    bRepo.AddBoat(b2);
    bRepo.AddBoat(b3);
    bRepo.AddBoat(b4);
    bRepo.AddBoat(b5);
    bRepo.AddBoat(b6);
    #endregion

    Console.WriteLine($"Number of boats {bRepo.Count}\n");

    Console.WriteLine(b1.ToString());

}
catch (Exception exp)
{
    Console.WriteLine(exp.Message);
}
    


bRepo.FindBoatByID(2);



Boat newBoat = new Boat("Updated crap", "updated model crap");
bRepo.UpdateBoat(2, newBoat);



bRepo.DeleteBoat(3);


bRepo.PrintAllBoats();