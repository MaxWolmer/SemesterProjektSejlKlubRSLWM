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

        public Boat(string name, string model,  int id)
        {
            _repairs = new List<Repair>();
            _name = name;
            _model = model;
            _id = id;
             

        }
        public string Boatname { get { return _name; } set { _name = value; } }

        public string Boatmodel { get { return _model; } set { _model = value; } }

        public List<Repair> getrepairs { get { return _repairs; } set { _repairs = value; } }

        public int boatid { get { return _id; }  set { _id = value; }}


        public void addrepair(Repair Arepair)
        {
            _repairs.Add(Arepair);
        }

        public override string ToString()
        {
            return $"Boat id{_id} Boat name: {_name} Boat model: {_model}";
        }
        
    }
}