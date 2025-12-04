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

        void AddUser();
        User GetMember();
        void DeleteUser();
        void UpdateUser();
        List<User> GetAllUsers();


    }
}
