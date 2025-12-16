// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Exceptions.BlogExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;
using System;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

BlogRepo postlist = new BlogRepo();

postlist.PrintListOfPosts();

try
{
    Console.WriteLine("Trying to delete post 2..");
    postlist.DeletePost(2);
    Console.WriteLine("Post 2 deleted\n");
}
catch (BlogIdNotExistException bineex)
{
    Console.WriteLine(bineex.Message);
}

try
{
    Console.WriteLine("Trying to change post 3 title..");
    postlist.UpdatePostTitle(3, "Lol nyt navn");
    Console.WriteLine("Title changed\n");
}
catch (BlogIdNotExistException bineex)
{
    Console.WriteLine(bineex.Message);
}

try
{
    Console.WriteLine("Trying to change post 3 description..");
    postlist.UpdatePostDesc(3, "New description");
    Console.WriteLine("Description changed\n");
}
catch (BlogIdNotExistException bineex)
{
    Console.WriteLine(bineex.Message);
}

postlist.PrintListOfPosts();

//Try catch fejltest

Console.WriteLine("- try-catch fejltest herfra -\n");
try
{
    Console.WriteLine("Trying to delete post 8 (this does not exist)..");
    postlist.DeletePost(8);
}
catch (BlogIdNotExistException bineex)
{
    Console.WriteLine(bineex.Message);
}
try
{
    Console.WriteLine("Trying to change post 8 title (this does not exist)..");
    postlist.UpdatePostTitle(8, "New Title");
}
catch (BlogIdNotExistException bineex)
{
    Console.WriteLine(bineex.Message);
}
try
{
    Console.WriteLine("Trying to change post 8 description (this does not exist)..");
    postlist.UpdatePostDesc(8, "New description");
}
catch (BlogIdNotExistException bineex)
{
    Console.WriteLine(bineex.Message);
}