// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Models;
using ProjektLibrary.Services;

Console.WriteLine("Hello, World!");


Boat boat1 = new Boat("best", "good", 343);
User user1 = new User("hans", "gmail@", "303", true);


DateTime date = new DateTime(2002, 2, 2);
DateTime date1 = new DateTime(2002, 3, 3);
Event newevent = new Event(date, 2, "the best event");

Registration aregi = new Registration(user1, newevent);
Repair repair1 = new Repair(DateTime.Now, "damagealot", false, boat1, user1);
boat1.addrepair(repair1);

List<Repair> repiairlis = boat1.getrepairs;

foreach(Repair arepair in repiairlis)
{
    Console.WriteLine(arepair);
}

Booking abooking = new Booking(user1, boat1, date, date1);





