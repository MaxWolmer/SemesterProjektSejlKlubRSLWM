using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Data
{
    public static class EventMockData
    {
        public static List<Event> _Events = new List<Event>()

        { 
         new Event (new DateTime(2002,3,12), "someevent") ,
         new Event (new DateTime(2001,2,23), "goodevent") ,
         new Event (new DateTime(2000,3,22), "newevent")  ,
         new Event (new DateTime(2010,1,2), "newevent")

        };
    }
}
