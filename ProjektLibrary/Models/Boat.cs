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

        public Boat(string name, string model, List<Repair> therepairs, int id)
        {
            _name = name;
            _model = model;
            _repairs = therepairs;
            _id = id;

        }

    }
