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
        private static Dictionary<int, Repair> _repairData = new Dictionary<int, Repair>()
          {
              {1, new Repair("Masten er knekket", false, new Boat("Kiwi", "Fishermans"), new User("Jytte", "jytte@mail.com", "12121212", false)) },
              {2, new Repair("Roret er i stykker", false, new Boat("Annika", "Fishermans"), new User("Poul", "poul@mail.com", "13131313", false)) },
              {3, new Repair("Der er skarbet maling af bunden", false, new Boat("Surfer", "sejlbåd"), new User("Anderas", "andreas@mail.com", "14141414", false)) },
              {4, new Repair("Der er kommet en flænge i sejlet", false, new Boat("Søstjernen", "Tera"), new User("Susanne", "Susanne@mail.com", "15151515", false))}
          };

        public static Dictionary<int, Repair> RepairData
        {
            get { return _repairData; }
        }
            
    }
}
