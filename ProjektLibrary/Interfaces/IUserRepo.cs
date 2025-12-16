using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Interfaces
{
    public interface IUserRepo
    {
        public int Count { get; }

        void AddUser(User user);
        User? GetUserByMobile(string mobile);
        void DeleteUser(string mobile);
        void UpdateUser(string mobile, User updateUser);
        List<User> GetAllUsers(User user);
        void PrintAllUsers();
        string AddPasswordToMobile(string mobile, string password);
        bool? Login(string mobile, string password);
        void AdminChanges(User user, string mobile);

    }
}
