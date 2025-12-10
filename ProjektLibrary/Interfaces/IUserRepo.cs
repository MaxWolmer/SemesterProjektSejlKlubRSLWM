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
        User? GetMemberByMobile(string mobile);
        void DeleteUser(string mobile);
        void UpdateUser(string mobile, User updateUser);
        List<User> GetAllUsers();
        void PrintAllMembers();
        string AddPasswordToMobile(string mobile, string password);


    }
}
