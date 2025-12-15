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
        private User _auser;
        public Event(DateTime TheDate, string description, User auser)
        {
            _description = description;
            _id = _counter;
            _counter++;
            _theDate = TheDate;
            _auser = auser;
        }

        public int Id
        {
            get { return _id; }

            set
            {
                if (_auser.Admin) { _id = value; }
            }
        }
        public string Description
        {
            get { return _description; }

            set
            {
                if (_auser.Admin)
                {
                    _description = value;
                }
            }
        }




        public override string ToString()
        {
            return $"EventNumber:{_counter}, Beskrivelse:{_description}, Dato:{_theDate}";
        }
    }

}
