using ProjektLibrary.Exceptions.UserExceptions;
using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
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
            _users = new Dictionary<string, User>();
        }

        public void AddUser(User user)
        {
            if (user != null && !_users.ContainsKey(user.PhoneNumber))
            {
                _users.Add(user.PhoneNumber, user);
                Console.WriteLine($"{user.Name} is added");
            }
        }

        public void DeleteUser(string mobile)
        {
            _users.Remove(mobile);
            Console.WriteLine($"this user has been deleted by this number {mobile}");
        }

        public List<User> GetAllUsers()
        {
            Console.WriteLine($"There are {_users.Count} Members. ");
            return _users.Values.ToList();
        }


        public User? GetMemberByMobile(string mobile)
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
                AddUser(newUser);
                DeleteUser(oldMobile);
            }
        }
        public void PrintAllMembers()
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
                    " - less then 8 characters \n" +
                    " - no Numbers\n" +
                    " - no uppercase letters");
            }
            _users[mobile].Password = password;
            return "Password was succesfully added";
        }




    }
}
