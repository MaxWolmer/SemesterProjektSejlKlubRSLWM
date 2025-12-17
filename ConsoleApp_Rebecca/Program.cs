// See https://aka.ms/new-console-template for more information
using ProjektLibrary.Exceptions.UserExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");
Console.WriteLine();

Console.WriteLine("------------------------------------------------------------");

Console.WriteLine();
Console.WriteLine("just added a new list");
UserRepo userList = new UserRepo();

User user10 = new User("Dave", "da@gmail.com", "20202020", true, UserTypeEnum.Passive);
userList.AddUser(user10);

try
{ userList.GetAllUsers(user10); }
catch (UserDoNotHaveAccessAdminOnlyException use)
{
    Console.WriteLine(use.Message);
}
Console.WriteLine("done adding list");
Console.WriteLine();


Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine("testing add user");
try
{
    User user5 = new User("Bobby", "BobMaster@gmail.com", "15151515", true, UserTypeEnum.Senior);
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
    User user8 = new User("Danniella", "danmail.com", "19191919", false, UserTypeEnum.Junior);
    userList.AddUser(user8);
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
    User user9 = new User("Daniel", "daniel@gmail.com", "20202020", false, UserTypeEnum.Passive);
    userList.AddUser(user9);
}
catch (GmailDoesNotContain_Exception gex)
{
    Console.WriteLine(gex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("Done test with adding user");
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();

User user11 = new User("Sam", "sam@gmail.com", "21212121", false, UserTypeEnum.Junior);

Console.WriteLine();
Console.WriteLine("getting all Users");
try
{ userList.GetAllUsers(user11); }
catch (UserDoNotHaveAccessAdminOnlyException use)
{
    Console.WriteLine(use.Message);
}
Console.WriteLine();

try
{ userList.GetAllUsers(user10); }
catch (UserDoNotHaveAccessAdminOnlyException use)
{
    Console.WriteLine(use.Message);
}
Console.WriteLine("Done trying to get all users");
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("trying to delete a User");
userList.DeleteUser("14141414");
try
{ userList.GetAllUsers(user10); }
catch (UserDoNotHaveAccessAdminOnlyException use)
{
    Console.WriteLine(use.Message);
}
Console.WriteLine();
Console.WriteLine("done deleting");
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("trying to get member by number");
User? auser = userList.GetUserByMobile("12345678");
Console.WriteLine(auser);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("Updating the Member with new mobile number");
User newUser = new User("Bobby Mazing", "BobMaster@gmail.com", "16161616", true, UserTypeEnum.Senior);
userList.UpdateUser("15151515", newUser);
Console.WriteLine();
Console.WriteLine(newUser);
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("updating name but keeping the old number");
User newUser1 = new User("Steve BoneMan", "SteveBoneMan@Gmail.com", "12345678", true, UserTypeEnum.Junior);
userList.UpdateUser("12345678", newUser1);
Console.WriteLine(newUser1);
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Printing all members");
userList.PrintAllUsers();
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("trying to add a password to a user");
try
{
    string pass = userList.AddPasswordToMobile("18181818", "DanFan1234");
    Console.WriteLine(pass);
}
catch (InvalidPasswordException ipex)
{
    Console.WriteLine(ipex.Message);
}

try
{ 
    string pass = userList.AddPasswordToMobile("18181818", "DanFanstan");
    Console.WriteLine(pass);
}
catch (InvalidPasswordException ipex)
{
    Console.WriteLine(ipex.Message);
}

try
{
    string pass = userList.AddPasswordToMobile("18181818", "DanFan1");
    Console.WriteLine(pass);
}
catch (InvalidPasswordException ipex)
{
    Console.WriteLine(ipex.Message);
}

try
{
    string pass = userList.AddPasswordToMobile("18181818", "danfan1234");
    Console.WriteLine(pass);
}
catch (InvalidPasswordException ipex)
{
    Console.WriteLine(ipex.Message);
}
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();


Console.WriteLine();
Console.WriteLine("trying to login");
Console.WriteLine();
bool? login = userList.Login("18181818", "danfan123");

if (login == true)
{
    Console.WriteLine("you are now login");
}
else
{
    Console.WriteLine("login invalid Mobile or Password does not excist");
}

bool? login1 = userList.Login("18181818", "DanFan1234");
if (login1 == true)
{
    Console.WriteLine("you are now login");
}
else
{
    Console.WriteLine("login invalid Mobile or Password does not excist");
}
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();



Console.WriteLine();
Console.WriteLine("Trying to sort name in alphabetic order");

Console.WriteLine();
foreach (string s in userList.OnlyNamesInOrder())
{
    Console.WriteLine(s);
}
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();



Console.WriteLine();
Console.WriteLine("trying to change the status of admin");
User u1 = new User("Stan", "star@mail.com", "22222222", true, UserTypeEnum.Passive);
User u2 = new User("Bella", "Bell@mail.com", "23232323", false, UserTypeEnum.Senior);
userList.AddUser(u1);
userList.AddUser(u2);
try
{
    userList.AdminChanges(user10, "22222222");
}
catch (UserDoNotHaveAccessAdminOnlyException use)
{
    Console.WriteLine(use.Message);
}
try
{
    userList.AdminChanges(user10, "23232323");
}
catch (UserDoNotHaveAccessAdminOnlyException use)
{
    Console.WriteLine(use.Message);
}
try
{
    userList.AdminChanges(u1, "23232323");
}
catch (UserDoNotHaveAccessAdminOnlyException use)
{
    Console.WriteLine(use.Message);
}
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();


Console.WriteLine("enter name");
