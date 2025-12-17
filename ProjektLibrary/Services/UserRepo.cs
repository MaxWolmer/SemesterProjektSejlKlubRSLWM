using ProjektLibrary.Data;
using ProjektLibrary.Exceptions.UserExceptions;
using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Services
{
    public class UserRepo : IUserRepo
    {
        private Dictionary<string, User> _users;
        public int Count
        {
            get { return _users.Count; }
        }

        public UserRepo()
        {
            _users = MockData.UserData; //new Dictionary<string, User>();
        }

        #region methods
        public void AddUser(User user)
        {

            if (user != null && !_users.ContainsKey(user.PhoneNumber))
            {
                _users.Add(user.PhoneNumber, user);
                
            }
            else
                Console.WriteLine("User already excist");
        }

        public void DeleteUser(string mobile)
        {
            _users.Remove(mobile);
            
        }

        public List<User> GetAllUsers(User user)
        {
            if (user.Admin == true)
            {
                Console.WriteLine($"There are {_users.Count} Members. ");
                return _users.Values.ToList();
            }
            else
                throw new UserDoNotHaveAccessAdminOnlyException("User is not an Admin, Cannot access this");
        }


        public User? GetUserByMobile(string mobile)
        {
            if (_users.ContainsKey(mobile))
            {
                return _users[mobile];
            }

            return null;
        }

        public void UpdateUser(string oldMobile, User newUser)
        {
            if (_users.ContainsKey(oldMobile))
            {
                DeleteUser(oldMobile);
                AddUser(newUser);
            }
        }
        public void PrintAllUsers()
        {
            foreach (User u in _users.Values)
            {
                Console.WriteLine(u.ToString());
            }
        }

        public string AddPasswordToMobile(string mobile, string password)
        {
            bool toShort = password.Length < 8;
            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasNumber = password.Any(char.IsDigit);

            if (toShort || !hasUpperCase || !hasNumber)
            {
                throw new InvalidPasswordException("Password does not meet the criteria of \n" +
                    " - more then 8 characters \n" +
                    " - minimum one Numbers\n" +
                    " - minimum one uppercase letter");
            }
            _users[mobile].Password = password;
            return "Password was succesfully added";
        }

        public bool? Login(string mobile, string password)
        {
            bool userlogin = false;
            User? gettingUser = GetUserByMobile(mobile);
            if (gettingUser.Password == password)
            {
                userlogin = true;
                return userlogin;
            }
            return null;
        }
        public List<User> MakingAList()
        {

            return _users.Values.ToList();

        }

        public List<string> OnlyNamesInOrder()
        {
            List<User> Sort = MakingAList();
            List<string> Names = new List<string>();
            foreach (User u in Sort)
            {
                Names.Add(u.Name);
            }
            Names.Sort();
            return Names;
        }

        public void AdminChanges(User user, string mobile)
        {
            if (user.Admin == true)
            {
                if (_users[mobile].Admin == false)
                {
                    GetUserByMobile(mobile);
                    _users[mobile].Admin = true;
                    Console.WriteLine($"{_users[mobile].Name} is is now an {(_users[mobile].Admin ? "Admin" : "Member")}");
                }
                else
                if (_users[mobile].Admin == true)
                {
                    GetUserByMobile(mobile);
                    _users[mobile].Admin = false;
                    Console.WriteLine($"{_users[mobile].Name} is is now an {(_users[mobile].Admin ? "Admin" : "Member")}");
                }
            }else
                throw new UserDoNotHaveAccessAdminOnlyException("User is Not Admin and cannot change the status of others.");

        }



        #endregion
    }
}
