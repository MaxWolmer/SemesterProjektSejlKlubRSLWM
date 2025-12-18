using ProjektLibrary.Exceptions.BoatExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;
using ProjektLibrary.Data;
using System.Runtime.Intrinsics.X86;
using System.ComponentModel.Design;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!\n\n");

BoatRepo bRepo = new BoatRepo();

User u1 = new User("Marlene", "Marlene@mail.com", "10101010", false, UserTypeEnum.Passive);
User u2 = new User("Kasper", "Kasper@gmail.com", "12345678", true, UserTypeEnum.Senior);

//Calling the ToString of boats
Console.WriteLine($"Number of boats {bRepo.Count}");
Console.WriteLine("------------------------------------------------------\n");


Console.WriteLine("Getting second boat\n");

List<Boat> allBoats = bRepo.GetAllBoats();
foreach (Boat b in allBoats)
{
    if (b.BoatId == 2)
    {
        Console.WriteLine(b.ToString());
    }
}
Console.WriteLine("------------------------------------");


//Adding a new boat to the Dictionary with exception if boat ID already exists
Console.WriteLine("\nAdding and printing boat");
//try
//{
    Boat b7 = new Boat("Ferry", "Brunswick", "Feisty Fiona", "Length: 12 m\nWidth: 3 m\nHeight: 2 m", true, true, u1);
    bRepo.AddBoat(b7);
    Console.WriteLine($"\n{b7}");
//}
//catch (BoatIDAlreadyExistsException bae)
//{
//    Console.WriteLine(bae.Message);
//}
Console.WriteLine("------------------------------------------------------\n");



//Getting a boat by it's ID
Console.WriteLine("Finding and printing a boat\n");
Boat aFoundBoat = bRepo.FindBoatByID(2);
if (aFoundBoat != null)
{
    Console.WriteLine($"{aFoundBoat}\n");
}



//Updating existing boat objekt info
try
{
    Console.WriteLine("Updating boat info\n");
    Boat newBoat = new Boat("Hydroplane", "Lund", "Speedy Sussie", "Length: 4 m\nWidth: 1 m\nHeight: 2 m", false, true, u1);
    bRepo.UpdateBoat(4, newBoat);

    Boat newBoat1 = new Boat("Kajak", "Kaloon", "Kopying Karla", "Length: 10 m\nWidth: 4 m\nHeight: 3 m", true, true, u1);
    bRepo.UpdateBoat(9, newBoat);
}
catch (KeyNotFoundException knf)
{
    Console.WriteLine($"{knf.Message}\n");
}


//Deleting an existing boat objekt
bRepo.DeleteBoat(3);

Console.WriteLine("\nPrinting all boats\n");
bRepo.PrintAllBoats();

Console.WriteLine("------------------------------------------------------\n");



//Printing alphabetically sorted boat lists
Console.WriteLine("------------------------------------------------------\n");
Console.WriteLine($"Printing alphabetically sorted boat lists\n");
Console.WriteLine("------------------------------------\n");

Console.WriteLine($"Printing Model sorted boat list\n------------------------------------");
bRepo.TypesInOrder();

Console.WriteLine("------------------------------------");
Console.WriteLine($"Printing Brands sorted boat list\n------------------------------------");
bRepo.BrandsInOrder();

Console.WriteLine("------------------------------------");
Console.WriteLine($"Printing Names sorted boat list\n------------------------------------");
bRepo.NamesInOrder();
Console.WriteLine();



//Searching boat by either type, brand or availability
Console.WriteLine("------------------------------------------------------\n");
Console.WriteLine("Searching boat by either type, brand or availability\n");

Console.WriteLine("Getting all available boats");
var onlyAvailable = bRepo.GetBoatsBySearchWord(available: true);
if (onlyAvailable.Count > 0)
{
    Console.WriteLine($"Found {onlyAvailable.Count} available boats:\n");
    foreach (Boat b in onlyAvailable)
    {
        Console.WriteLine($"Boat id: {b.BoatId}\nType: {b.BoatType}\nBrand: {b.BoatBrand}\nAvailability: {b.BoatAvailable}\n");
    }
}
else
{
    Console.WriteLine("No boats found matching the search");
}

Console.WriteLine("------------------------------------");


Console.WriteLine("Getting all Frigates, as Tracker brand, boats\n");
var specificSearch = bRepo.GetBoatsBySearchWord(type: "Frigate", brand: "Tracker");
if (specificSearch.Count > 0)
{
    Console.WriteLine($"Found {specificSearch.Count} Frigates as Tracker brand:\n");
    foreach (Boat b in specificSearch)
    {
        Console.WriteLine($"Boat id: {b.BoatId}\nType: {b.BoatType}\nBrand: {b.BoatBrand}\nAvailability: {b.BoatAvailable}\n");
    }
}
else
{
    Console.WriteLine("No boats found matching the search");
}
Console.WriteLine("------------------------------------");
