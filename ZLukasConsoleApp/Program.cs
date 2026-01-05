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

#region Event Testing
EventRepo eventlist = new EventRepo();
eventlist.PrintListOfEvents();
#endregion

