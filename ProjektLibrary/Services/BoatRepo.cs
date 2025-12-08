using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using ProjektLibrary.Exceptions.BoatExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

namespace ProjektLibrary.Services
{
    public class BoatRepo : IBoatRepo
    {
        //Hvad er key'en i det her?
        private Dictionary<int, Boat> _boats = new Dictionary<int, Boat>();

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
        }
        public Boat? FindBoatByID(int boatid)
        {
            if (_boats.ContainsKey(boatid))
            {
                return _boats[boatid];
            }
            return null;
        }

        public void UpdateBoat(int oldBoatID, Boat newBoat)
        {

            if (!_boats.ContainsKey(oldBoatID))
            {
                newBoat.boatid = oldBoatID;
                _boats[oldBoatID] = newBoat;
            }
        }

        public void DeleteBoat(int boatid)
        {
            _boats.Remove(boatid);
        }


        public void PrintAllBoats()
        {
            foreach (Boat boat in _boats.Values)
            {
                Console.WriteLine(boat.ToString());
            }
        }
    }
}
