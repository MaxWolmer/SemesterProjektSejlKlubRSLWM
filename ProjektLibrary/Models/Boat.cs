using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektLibrary.Models
{
    public class Boat
    {
        private string _name;
        private string _model;
        private int _id;
        private static int _counter = 1;
        private User _auser;
        private int _bookingcounter;
        

        public Boat(string Name, string Model, User Auser)
        {
            _name = Name;
            _model = Model;
            _id = _counter++;
            _auser = Auser;
        }

        

        public int Boatcounterr
        {
            get { return _bookingcounter; }
            set { _bookingcounter = value; }
        }

        public string BoatName { get { return _name; } set { if (_auser.Admin) { { _name = value; } } } } 


        public string BoatModel { get { return _model; } set { if (_auser.Admin) { { _model = value; } } } }


        public int BoatId { get { return _id; }  set { if (_auser.Admin) { { _id = value; } } } }


      

        public override string ToString()
        {
            return $"Boat id: {_id}\nBoat name: {_name}\nBoat model: {_model}\n\n";
        }
        
    }
}