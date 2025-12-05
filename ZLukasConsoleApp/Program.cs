// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Models;

Console.WriteLine("Hello, World!");

//mock data

DateTime d1 = new DateTime(2025, 12,5);

Blogpost b1 = new Blogpost(1, "Fælles te!", "Alle får gratis te!", d1);

Console.WriteLine(b1);