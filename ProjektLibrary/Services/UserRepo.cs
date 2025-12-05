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
            if (_users.ContainsKey(user.PhoneNumber) != true)
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
            Console.WriteLine($"There are {_users.Count}");
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
    

        
    }
}
