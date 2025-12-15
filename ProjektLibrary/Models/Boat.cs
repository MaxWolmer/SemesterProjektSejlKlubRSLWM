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
        private bool _admin;
        

        public Boat(string Name, string Model, bool admin)
        {
            _name = Name;
            _model = Model;
            _id = _counter++;
            _admin = admin;
        }
        
        public string BoatName { get { return _name; } set { if (_admin) { { _name = value; } } } } 
        public string BoatName { get { return _name; }
            set { _name = value; } }

        public string BoatModel { get { return _model; } set { if (_admin) { { _model = value; } } } }


        public int BoatId { get { return _id; }  set { if (_admin) { { _id = value; } } } }


      

        public override string ToString()
        {
            return $"Boat id: {_id}\nBoat name: {_name}\nBoat model: {_model}\n\n";
        }
        
    }
}