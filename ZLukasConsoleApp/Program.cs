// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Exceptions.BlogExceptions;
using ProjektLibrary.Exceptions.EventExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;
using System;
using System.Linq.Expressions;
using System.Transactions;

Console.WriteLine("Hello, World!");

#region Blog Testing
BlogRepo postlist = new BlogRepo();
postlist.PrintListOfPosts();
#endregion

EventRepo eventlist = new EventRepo();

#region Event Update Testing

//Tror dette kan skrives direkte ind i Console
Console.WriteLine("Skriv ID på den ppst du gerne vil ændre:");
int id = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv ny titel:");
string newTitle = Console.ReadLine();
Console.WriteLine("Skriv ny beskrivelse:");
string newDescription = Console.ReadLine();

try
{
    eventlist.UpdateEvent(id, newTitle, newDescription);
    Console.WriteLine("Event er opdateret\n");
}
catch (EventIdNotExistException eineex)
{
    Console.WriteLine(eineex.Message);
}
eventlist.PrintListOfEvents();

#endregion

