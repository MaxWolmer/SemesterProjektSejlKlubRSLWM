using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Services
{
    public class BoatRepo : IBoatRepo
    {

        public void AddBoat(Boat boat)
        {
            Boat.Add(boat)
        }

        public void DeleteBoat(string name)
        {
            throw new NotImplementedException();
        }

        public void FindBoatByName(string name)
        {
            throw new NotImplementedException();
        }

        public void PrintAllBoats()
        {
            throw new NotImplementedException();
        }
    }
}
