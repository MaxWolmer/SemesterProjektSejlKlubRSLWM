using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Models
{
    public class Event
    {
        private static int _eventnumber;
        private int _id;
        private string _beskrivelse;
        private DateTime _thedate;
        public Event(DateTime Thedate, int id, string beskrivelse)
        {
            _beskrivelse = beskrivelse;
            _id = id;
            _eventnumber++;
            _thedate = Thedate;

        }

        public int id { get { return _id; } set { _id = value; } }
        public string beskrivlese {get { return _beskrivelse; } set { _beskrivelse = value; } }
    }
}
