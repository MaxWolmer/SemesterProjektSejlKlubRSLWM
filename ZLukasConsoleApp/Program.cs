// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Exceptions.BlogExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;
using System;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

#region Mock Data
DateTime d1 = new DateTime(2025, 12, 5);
DateTime d2 = new DateTime(2026, 3, 7);
DateTime d3 = new DateTime(2026, 2, 1);
DateTime d4 = new DateTime(2026, 7, 19);
DateTime d5 = new DateTime(2026, 6, 4);

Blog b1 = new Blog("Nyeste sejlads", "Se hvor godt de klarede det!", d1);
Blog b2 = new Blog("fælles måltid", "Vi hygger os!", d2);
Blog b3 = new Blog("Fælles te!", "Alle fik gratis te!", d3);
Blog b4 = new Blog("Grilaften", "Grilpøser og brød", d4);
Blog b5 = new Blog("Haloween!", "Lidt tidligere end forventet", d5);

//Automatisk timestamp afprøvning
Blog b6 = new Blog("ny event", "eventbeskrivelse");
#endregion

BlogRepo postlist = new BlogRepo();

postlist.AddPost(b1);
postlist.AddPost(b2);
postlist.AddPost(b3);
postlist.AddPost(b4);
postlist.AddPost(b5);
postlist.AddPost(b6);

//postlist.PrintListOfPosts();

try
{
    Console.WriteLine("Trying to delete post 2..");
    postlist.DeletePost(2);
    Console.WriteLine("Post 2 deleted\n");
}
catch (IdNotExistException ineex)
{
    Console.WriteLine(ineex.Message);
}

try
{
    Console.WriteLine("Trying to change post 3 title..");
    postlist.UpdateTitle(3, "Fuclk uoy");
    Console.WriteLine("Title changed\n");
}
catch (IdNotExistException ineex)
{
    Console.WriteLine(ineex.Message);
}

try
{
    Console.WriteLine("Trying to change post 3 description..");
    postlist.UpdateDesc(3, "New description");
    Console.WriteLine("Description changed\n");
}
catch (IdNotExistException ineex)
{
    Console.WriteLine(ineex.Message);
}

//postlist.PrintListOfPosts();

//Try catch fejltest

Console.WriteLine("- try-catch fejltest herfra -\n");
try
{
    Console.WriteLine("Trying to delete post 8 (this does not exist)..");
    postlist.DeletePost(8);
}
catch (IdNotExistException ineex)
{
    Console.WriteLine(ineex.Message);
}
try
{
    Console.WriteLine("Trying to change post 8 title (this does not exist)..");
    postlist.UpdateTitle(8, "Fuclk uoy");
}
catch (IdNotExistException ineex)
{
    Console.WriteLine(ineex.Message);
}
try
{
    Console.WriteLine("Trying to change post 8 description (this does not exist)..");
    postlist.UpdateDesc(8, "New description");
}
catch (IdNotExistException ineex)
{
    Console.WriteLine(ineex.Message);
}