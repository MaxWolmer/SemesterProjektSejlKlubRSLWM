// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Exceptions.UserExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");
Console.WriteLine();

Console.WriteLine();
UserRepo userList = new UserRepo();

try
{
    User user1 = new User("Steve", "SteveBoneMan@Gmail.com", "12345678", true);
    userList.AddUser(user1);
}
catch (GmailDoesNotContain_Exception gex)
{
    Console.WriteLine(gex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    User user2 = new User("Poul", "Pohe@Gmail.com", "12121212", true);
    userList.AddUser(user2);
}
catch (GmailDoesNotContain_Exception gex)
{
    Console.WriteLine(gex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    User user3 = new User("Mikkel", "Mikkel@gmail.com", "13131313", false);
    userList.AddUser(user3);
}
catch (GmailDoesNotContain_Exception gex)
{
    Console.WriteLine(gex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    User user4 = new User("Charlotte", "Char@gmail.com", "14141414", false);
    userList.AddUser(user4);
}
catch (GmailDoesNotContain_Exception gex)
{
    Console.WriteLine(gex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    User user5 = new User("Bobby", "BobMaster@gmail.com", "15151515", true);
    userList.AddUser(user5);
}
catch (GmailDoesNotContain_Exception gex)
{
    Console.WriteLine(gex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    User user6 = new User("Dan", "danmail.com", "17171717", false);
    userList.AddUser(user6);
}
catch (GmailDoesNotContain_Exception gex)
{
    Console.WriteLine(gex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    User user7 = new User("Danny", "dan@gmail.com", "18181818", false);
    userList.AddUser(user7);
}
catch (GmailDoesNotContain_Exception gex)
{
    Console.WriteLine(gex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine();
Console.WriteLine("getting all Users");
userList.GetAllUsers();
Console.WriteLine();

Console.WriteLine("trying to delete a User");
userList.DeleteUser("14141414");
userList.GetAllUsers();
Console.WriteLine();

Console.WriteLine("trying to get member by number");
User? auser = userList.GetUserByMobile("12345678");
Console.WriteLine(auser);
Console.WriteLine();

Console.WriteLine("Updating the Member with new mobile number");
User newUser = new User("Bobby Mazing", "BobMaster@gmail.com", "16161616", true);
userList.UpdateUser("15151515", newUser);
Console.WriteLine();
Console.WriteLine(newUser);

Console.WriteLine();
Console.WriteLine("Printing all members");
userList.PrintAllUsers();

try
{
    Console.WriteLine();
    Console.WriteLine("trying to add a password to a user");
    string pass = userList.AddPasswordToMobile("18181818", "DanFan1234");
    Console.WriteLine(pass);
}
catch (InvalidPasswordException ipex)
{
    Console.WriteLine(ipex.Message);
}

try
{
    Console.WriteLine();
    Console.WriteLine("trying to add a password to a user");
    string pass = userList.AddPasswordToMobile("18181818", "DanFanstan");
    Console.WriteLine(pass);
}
catch (InvalidPasswordException ipex)
{
    Console.WriteLine(ipex.Message);
}

try
{
    Console.WriteLine();
    Console.WriteLine("trying to add a password to a user");
    string pass = userList.AddPasswordToMobile("18181818", "DanFan1");
    Console.WriteLine(pass);
}
catch (InvalidPasswordException ipex)
{
    Console.WriteLine(ipex.Message);
}

try
{
    Console.WriteLine();
    Console.WriteLine("trying to add a password to a user");
    string pass = userList.AddPasswordToMobile("18181818", "danfan1234");
    Console.WriteLine(pass);
}
catch (InvalidPasswordException ipex)
{
    Console.WriteLine(ipex.Message);
}


Console.WriteLine();
Console.WriteLine("trying to login");
userList.Login("18181818", "DanFan1234");
Console.WriteLine();
userList.Login("18181818", "danfan123");