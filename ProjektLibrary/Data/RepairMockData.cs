using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Data
{
    public class RepairMockData
    {
        #region  Båd og user Data
        public static Boat b1 = new Boat("Kiwi", "Fishermans");
        public static Boat b2 = new Boat("Annika", "Fishermans");
        public static Boat b3 = new Boat("Surfer", "sejlbåd");
        public static Boat b4 = new Boat("Søstjernen", "Tera");

        public static User u1 = new User("Jytte", "jytte@mail.com", "12121212", false);
        public static User u2 = new User("Poul", "poul@mail.com", "13131313", false);
        public static User u3 = new User("Anderas", "andreas@mail.com", "14141414", false);
        public static User u4 = new User("Susanne", "Susanne@mail.com", "15151515", false);

        #endregion

        private static Dictionary<int, Repair> _repairData = new Dictionary<int, Repair>()
          {
              {1, new Repair("Masten er knekket", false, b1, u1) },
              {2, new Repair("Roret er i stykker", false, b2, u2) },
              {3, new Repair("Der er skarbet maling af bunden", false, b3, u3) },
              {4, new Repair("Der er kommet en flænge i sejlet", false, b4, u4) }
          };

        public static Dictionary<int, Repair> RepairData
        {
            get { return _repairData; }
        }
            
    }

}
