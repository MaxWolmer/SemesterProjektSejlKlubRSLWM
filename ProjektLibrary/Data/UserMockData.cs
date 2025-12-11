using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Data
{
    public static class UserMockData
    {
        private static Dictionary<string, User> _users = new Dictionary<string, User>()
        {
            { "12345678", new User("Steve", "SteveBoneMan@Gmail.com", "12345678", true) },
            { "12121212", new User("Poul", "Pohe@Gmail.com", "12121212", true)},
            { "13131313", new User("Mikkel", "Mikkel@gmail.com", "13131313", false)},
            { "14141414", new User("Charlotte", "Char@gmail.com", "14141414", false)},
            { "15151515", new User("Bobby", "BobMaster@gmail.com", "15151515", true)},
            { "17171717", new User("Dan", "dan@mail.com", "17171717", false)},
            { "18181818", new User("Danny", "dan@gmail.com", "18181818", false)}

        };

        public static Dictionary<string, User> UserData
        {
            get { return _users; }
        }
    }
}
