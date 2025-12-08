// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Exceptions.BlogExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;

Console.WriteLine("Hello, World!");

//mock data
DateTime d1 = new DateTime(2025, 12, 5);
DateTime d2 = new DateTime(2026, 3, 7);
DateTime d3 = new DateTime(2026, 2, 1);
DateTime d4 = new DateTime(2026, 7, 19);
DateTime d5 = new DateTime(2026, 6, 4);

Blog b1 = new Blog("Nyeste sejlads", "Se hvor godt de klarede det!", d1);
Blog b2 = new Blog("fælles måltid", "Vi hygger os!", d2);
Blog b3 = new Blog("Fælles te!", "Alle fik gratis te!", d3);
Blog b4 = new Blog("Grilaften", "Grilå-pøser og brød", d4);
Blog b5 = new Blog("Haloween!", "Lidt tidligere end forventet", d5);

BlogRepo postlist = new BlogRepo();

postlist.AddBlogpost(b1);
postlist.AddBlogpost(b2);
postlist.AddBlogpost(b3);
postlist.AddBlogpost(b4);
postlist.AddBlogpost(b5);

postlist.PrintListOfBlogposts();

Console.WriteLine("Trying to delete post 2");
postlist.DeletePostById(2);
Console.WriteLine("Post 2 deleted\n");

Console.WriteLine("Trying to change post 3 title..");
postlist.UpdateTitle(3, "Fuclk uoy");
Console.WriteLine("Title changed\n");

Console.WriteLine("Trying to change post 3 description..");
postlist.UpdateDesc(3, "New description");
Console.WriteLine("Description changed\n");

postlist.PrintListOfBlogposts();