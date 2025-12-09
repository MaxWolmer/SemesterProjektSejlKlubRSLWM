// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Models;
using ProjektLibrary.Services;

Console.WriteLine("Hello, World!");

//Har udkommenteret grundet båd id ændringer
//Boat boat1 = new Boat("best", "good", 343);
User user1 = new User("hans", "gmail@", "303", true);
Boat Boat1 = new Boat("bsetboat", "newmodel");


DateTime BookingStart = new DateTime(2002, 2, 2);
DateTime BookingEnd = new DateTime(2002, 2, 3);

DateTime date3 = new DateTime(2002, 2, 1);
DateTime date4 = new DateTime(2002, 2, 6);


Booking booking1 = new Booking(user1, Boat1, BookingStart, BookingEnd);
BookingRepository repo1 = new BookingRepository();

repo1.AddBooking(booking1);



repo1.BookingFree(Boat1, date3, date4);




