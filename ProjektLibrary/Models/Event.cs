using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Models
{
    public class Event
    {
        private int _id;
        private static int _counter = 0;
        private string _description;
        private DateTime _theDate;
        public Event(DateTime TheDate, string description)
        {
            _description = description;
            _id = _counter;
            _counter++;
            _theDate = TheDate;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Beskrivlese {get { return _description; } set { _description = value; } }


        public override string ToString()
        {
            return $"EventNumber:{_counter}, Beskrivelse:{_description}, Dato:{_theDate}";
        }
    }
   
}
