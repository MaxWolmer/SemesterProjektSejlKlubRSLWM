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

User user7 = new User("lukas", "Lukas@grr.la", "42424242", true);

Blogpost b1 = new Blogpost("Nyeste sejlads", "Se hvor godt de klarede det!", d1, user7);
Blogpost b2 = new Blogpost("fælles måltid", "Vi hygger os!", d2, user7);
Blogpost b3 = new Blogpost("Fælles te!", "Alle fik gratis te!", d3, user7);
Blogpost b4 = new Blogpost("Grilaften", "Grilpøser og brød", d4, user7);
Blogpost b5 = new Blogpost("Haloween!", "Lidt tidligere end forventet", d5, user7);

Console.WriteLine("Afprøver timestamp");

//Automatisk timestamp afprøvning
Blogpost b6 = new Blogpost("ny event", "eventbeskrivelser", user7);
#endregion

BlogRepo postlist = new BlogRepo();

postlist.AddPost(b1);
postlist.AddPost(b2);
postlist.AddPost(b3);
postlist.AddPost(b4);
postlist.AddPost(b5);
postlist.AddPost(b6);

postlist.PrintListOfPosts();

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
    postlist.UpdatePostTitle(3, "Lol nyt navn");    
    Console.WriteLine("Title changed\n");
}
catch (IdNotExistException ineex)
{
    Console.WriteLine(ineex.Message);
}

try
{
    Console.WriteLine("Trying to change post 3 description..");
    postlist.UpdatePostDesc(3, "New description");
    Console.WriteLine("Description changed\n");
}
catch (IdNotExistException ineex)
{
    Console.WriteLine(ineex.Message);
}

postlist.PrintListOfPosts();

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
    postlist.UpdatePostTitle(8, "New Title");
}
catch (IdNotExistException ineex)
{
    Console.WriteLine(ineex.Message);
}
try
{
    Console.WriteLine("Trying to change post 8 description (this does not exist)..");
    postlist.UpdatePostDesc(8, "New description");
}
catch (IdNotExistException ineex)
{
    Console.WriteLine(ineex.Message);
}