// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Models;
using ProjektLibrary.Services;
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");
Console.WriteLine();


User user1 = new User("Steve", "SteveBoneMan@Gmail.com", "12345678", true);
User user2 = new User("Poul", "Pohe@Gmail.com", "12121212", true);
User user3 = new User("Mikkel", "Mikkel@gmail.com", "13131313", false);
User user4 = new User("Charlotte", "Char@gmail.com", "14141414", false);
User user5 = new User("Bobby", "BobMaster@gmail.com", "15151515", true);

UserRepo userList = new UserRepo();

Console.WriteLine("Trying to add User");
userList.AddUser(user1);
userList.AddUser(user2);
userList.AddUser(user3);
userList.AddUser(user4);
userList.AddUser(user5);
Console.WriteLine();

Console.WriteLine("getting all Users");
userList.GetAllUsers();
Console.WriteLine();

Console.WriteLine("trying to delete a User");
userList.DeleteUser("14141414");
userList.GetAllUsers();
Console.WriteLine();





