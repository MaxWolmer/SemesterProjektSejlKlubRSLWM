using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Services
{
    public class UserRepo:IUserRepo
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

        public void AddUser()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetMember()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }

        
    }
}
