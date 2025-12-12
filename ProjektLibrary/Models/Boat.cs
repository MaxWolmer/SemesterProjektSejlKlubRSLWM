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
        private List<Repair> _repairs;
        private int _id;
        private static int _counter = 1;
        

        public Boat(string Name, string Model)
        {
            _name = Name;
            _model = Model;
            _id = _counter++;
        }
        
        public string BoatName { get { return _name; } set { _name = value; } }

        public string BoatModel { get { return _model; } set { _model = value; } }


        public int BoatId { get { return _id; }  set { _id = value; }}


      

        public override string ToString()
        {
            return $"Boat id: {_id}\nBoat name: {_name}\nBoat model: {_model}\n\n";
        }
        
    }
}