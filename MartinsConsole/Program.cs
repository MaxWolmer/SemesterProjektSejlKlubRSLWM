using ProjektLibrary.Exceptions.BoatExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;
using System.Runtime.Intrinsics.X86;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!\n\n");

BoatRepo bRepo = new BoatRepo();

#region MockData
try
{
    Boat b1 = new Boat("Big Bertha", "Catamaran");
    Boat b2 = new Boat("Small Bessie", "Ironclad");
    Boat b3 = new Boat("Furious Freja", "Uboat");
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

    Console.WriteLine($"Number of boats {bRepo.Count}");
    Console.WriteLine("------------------------------------------------------\n");

    Console.WriteLine("Getting first boat");
    Console.WriteLine(b1.ToString());
    Console.WriteLine(b2.ToString());
}
catch (BoatIDAlreadyExistsException bae)
{
    Console.WriteLine(bae.Message);
}
Console.WriteLine("------------------------------------------------------\n");





try
{
    Console.WriteLine("Updating boat name and model\n");
    Boat newBoat = new Boat("Speedy Sussie", "Hydroplane");
    bRepo.UpdateBoat(4, newBoat);

    Boat newBoat1 = new Boat("Speedy Sussie", "Hydroplane");
    bRepo.UpdateBoat(9, newBoat);
}
catch (KeyNotFoundException knf)
{
    Console.WriteLine($"{knf.Message}");
}

bRepo.DeleteBoat(3);


bRepo.PrintAllBoats();

Console.WriteLine("------------------------------------------------------\n");

Console.WriteLine("Finding and printing a boat\n");
Boat aFoundBoat = bRepo.FindBoatByID(2);
if (aFoundBoat != null)
{
    Console.WriteLine($"{aFoundBoat}\n");
}