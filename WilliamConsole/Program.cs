// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Models;

Console.WriteLine("Hello, World!");


Boat boat1 = new Boat("best", "good", 343);


Repair arepair = new Repair(new DateTime(2002, 3, 4), "alot", false, boat1);


boat1.addrepair(arepair);

 List<Repair> repaies = new List<Repair>(boat1.getrepairs);

   
foreach(Repair arapier in repaies)
    {
    Console.WriteLine(arepair);
}

