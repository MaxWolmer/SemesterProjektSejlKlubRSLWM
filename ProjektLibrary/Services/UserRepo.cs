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

        public User GetMember()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(string mobile)
        {
            throw new NotImplementedException();
        }

        
    }
}
