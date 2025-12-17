using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektLibrary.Models
{
    public class Boat
    {
        private int _id;
        private static int _counter = 1;
        private string _type;
        private string _brand;
        private string _name;
        private string _dimensions;
        private bool _available;             
        private bool _admin;
        private User _aUser;
        private int _bookingCounter;
        

        public Boat(string Type, string Brand, string Name, string Dimensions, bool Available, bool admin, User aUser)
        {
            _id = _counter++;
            _name = Name;
            _type = Type;
            _brand = Brand;
            _dimensions = Dimensions;
            _available = Available;
            _admin = admin;
            _aUser = aUser;
        }

        

        public int BoatCounter
        {
            get { return _bookingCounter; }
            set { _bookingCounter = value; }
        }
        public int BoatId { get { return _id; }  set { if (_admin) { { _id = value; } } } }
        
        public string BoatType { get { return _type; } set { if (_admin) { { _type = value; } } } }
        
        public string BoatBrand { get { return _brand; } set { if (_admin) { { _brand = value; } } } }

        public string BoatName { get { return _name; } set { if (_admin) { { _name = value; } } } } 

        public string BoatDimensions { get { return _dimensions; } set { if (_admin) { { _dimensions = value; } } } }

        public bool BoatAvailable { get { return _available; } set { if (_admin) { { _available = value; } } } }


        public override string ToString()
        {
            return $"Boat id: {_id}\nBoat type: {_type}\nBoat brand: {_brand}\nBoat name: {_name}\nBoat dimensions:\n{_dimensions}\nBoat available: {_available}\n\n";
        }
        
    }
}