using ProjektLibrary.Exceptions.BoatExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;
using System.Runtime.Intrinsics.X86;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!\n\n");

BoatRepo bRepo = new BoatRepo();


try
{
    Console.WriteLine($"Number of boats {bRepo.Count}");
    Console.WriteLine("------------------------------------------------------\n");

    Console.WriteLine("Getting first boat");
    Console.WriteLine(1.ToString());
    Console.WriteLine(2.ToString());

    Console.WriteLine("\nAdding and printing boat");

    Boat b7 = new Boat("Feisty Fiona", "Ferry");
    bRepo.AddBoat(b7);
    Console.WriteLine($"\n{ b7}");
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