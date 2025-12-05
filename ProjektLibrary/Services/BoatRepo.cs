using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using ProjektLibrary.Exceptions.BoatExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Services
{
    public class BoatRepo : IBoatRepo
    {
        private Dictionary<int, Boat> _boats;

        public int Count
        {
            get { return _boats.Count; }
        }

        public void AddBoat(Boat boat)
        {
            if (!_boats.ContainsKey(boat.boatid))
            {
                _boats.Add(boat.boatid, boat);
            }
            else
            {
                throw new BoatIDAlreadyExistsException($"The boat ID {boat.boatid} already exists\n");
            }
            //foreach (Boat b in _boats.Values)
            //{
            //    if (b.boatid == boat.boatid)
            //    {
            //        throw new BoatIDAlreadyExists($"The boat ID {boat.boatid} already exists\n");
            //    }
            //}
            //_boats.Add(boat.boatid, boat);
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
