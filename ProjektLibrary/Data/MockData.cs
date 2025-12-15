using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Data
{
    public static class MockData
    {
        #region User Data
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
        #endregion

        #region Boat Data
        #region Instance fields
        private static Dictionary<int, Boat> _boatData =
            new Dictionary<int, Boat>()
        {
        { 1, new Boat("Big Bertha", "Catamaran") },
        { 2, new Boat("Small Bessie", "Ironclad") },
        { 3, new Boat("Furious Freja", "Uboat") },
        { 4, new Boat("Mad Maddie", "Tireme") },
        { 5, new Boat("Talkative Tuna", "Frigate") },
        { 6, new Boat("Jealous Jane", "Submarine") }
        };
        #endregion
        
        #region Properties
        public static Dictionary<int, Boat> BoatData
        {
            get { return _boatData; }
        }
        #endregion
        #endregion

        #region Repair
        #region Instance fields
        private static Dictionary<int, Repair> _repairData = new Dictionary<int, Repair>()
        {
            {1, new Repair("Masten er knekket", false, _boatData[1], _users["12345678"]) },
            {2, new Repair("Roret er i stykker", false, _boatData[2], _users["12121212"]) },
            {3, new Repair("Der er skarbet maling af bunden", false, _boatData[3], _users["13131313"]) },
            {4, new Repair("Der er kommet en flænge i sejlet", false, _boatData[4], _users["14141414"]) },
            {5,new Repair("Der er revner i malingen", true, _boatData[5], _users["15151515"]) },
            {6, new Repair("Masten er blevet skæv", false, _boatData[5], _users["17171717"]) },
            {7, new Repair("Der er et hul i bunden af båden" , false, _boatData[6], _users["18181818"]) }
          };
        #endregion

        #region Property
        public static Dictionary<int, Repair> RepairData
        {
            get { return _repairData; }
        }
        #endregion
        #endregion

        #region Booking data

        #endregion

        #region Registration

        #endregion

        #region BlogPost Data
        private static List<Blogpost> _postlist = new List<Blogpost>()
        {
            new Blogpost("Nyeste sejlads", "Se hvor godt de klarede det!",new DateTime(2026, 6, 4), _users["12345678"]),
            new Blogpost("Fælles måltid", "Vi hygger os!", new DateTime(2026, 3, 7), _users["12121212"]),
            new Blogpost("Fælles te!", "Alle fik gratis te!", new DateTime(2026, 2, 1), _users["13131313"]),
            new Blogpost("Grillaften", "Grilpøser og brød", new DateTime(2026, 7, 19), _users["14141414"]),
            new Blogpost("Halloween!", "Lidt tidligere end forventet", new DateTime(2026, 6, 4), _users["15151515"]),
            new Blogpost("ny event", "eventbeskrivelser", _users["17171717"]),
        };

        public static List<Blogpost> PostList
        {
            get { return _postlist; }
        }
        #endregion

        #region Event Data
        public static List<Event> _Events = new List<Event>()

        {
         new Event (new DateTime(2002,3,12), "someevent") ,
         new Event (new DateTime(2001,2,23), "goodevent") ,
         new Event (new DateTime(2000,3,22), "newevent")  ,
         new Event (new DateTime(2010,1,2), "newevent")

        };
        #endregion
    }
}
