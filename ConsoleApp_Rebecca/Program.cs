// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Exceptions.UserExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");
Console.WriteLine();
User user1;
User user2;
User user3;
User user4;
User user5;
User user6;
User user7;

user1 = new User("Steve", "SteveBoneMan@Gmail.com", "12345678", true);
user2 = new User("Poul", "Pohe@Gmail.com", "12121212", true);
user3 = new User("Mikkel", "Mikkel@gmail.com", "13131313", false);
user4 = new User("Charlotte", "Char@gmail.com", "14141414", false);
user5 = new User("Bobby", "BobMaster@gmail.com", "15151515", true);
user6 = new User("Dan", "danmail.com", "17171717", false);
user7 = new User("Danny", "dan@gmail.com", "18181818", false);



Console.WriteLine();
UserRepo userList = new UserRepo();

Console.WriteLine("Trying to add User");
userList.AddUser(user1);
userList.AddUser(user2);
userList.AddUser(user3);
userList.AddUser(user4);
userList.AddUser(user5);
userList.AddUser(user6);
userList.AddUser(user7);
Console.WriteLine();

Console.WriteLine("getting all Users");
userList.GetAllUsers();
Console.WriteLine();



//Console.WriteLine("trying to delete a User");
//userList.DeleteUser("14141414");
//userList.GetAllUsers();
//Console.WriteLine();

//Console.WriteLine("trying to get member by number");
//User? auser = userList.GetMemberByMobile("12345678");
//Console.WriteLine(auser);
//Console.WriteLine();

Console.WriteLine("Updating the Member with new mobile number");
User newUser = new User("Bobby Mazing", "BobMaster@gmail.com", "16161616", true);
userList.UpdateUser("15151515", newUser);
Console.WriteLine();
Console.WriteLine(newUser);

Console.WriteLine();
Console.WriteLine("Printing all members");
userList.PrintAllMembers();
