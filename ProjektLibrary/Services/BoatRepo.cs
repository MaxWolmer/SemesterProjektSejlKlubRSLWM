using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using ProjektLibrary.Exceptions.BoatExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using ProjektLibrary.Data;

namespace ProjektLibrary.Services
{
    public class BoatRepo : IBoatRepo
    {
        //boatid som er af typen int er key og Boat er value.
        private Dictionary<int, Boat> _boats = new Dictionary<int, Boat>();


        public BoatRepo()
        {
            _boats = MockData.BoatData;
        }
        public int Count
        {
            get { return _boats.Count; }
        }

        public Boat AddBoat(Boat boat)
        {
            if (!_boats.ContainsKey(boat.BoatId))
            {
                _boats.Add(boat.BoatId, boat);
            }
            else
            {
                throw new BoatIDAlreadyExistsException($"The boat ID {boat.BoatId} already exists\n");
            }
            return boat;
        }
        public Boat? FindBoatByID(int boatid)
        {
            if (_boats.ContainsKey(boatid))
            {
                return _boats[boatid];
            }
            return null;
        }

        //public void UpdateBoat2(int boatid, Boat newBoat)
        //{
        //    if (_boats.TryGetValue(boatid, out var existingBoat))
        //    {
        //        existingBoat.BoatName = newBoat.BoatName;
        //        existingBoat.BoatModel = newBoat.BoatModel;
        //    }
        //    else
        //    {
        //        throw new KeyNotFoundException($"Boat ID {boatid} not found.");
        //    }
        //}

        public void UpdateBoat(int boatid, Boat newboat)
        {
            if (_boats.ContainsKey(boatid))
            {
                Boat existingBoat = _boats[boatid];

                existingBoat.BoatName = newboat.BoatName;
                existingBoat.BoatModel = newboat.BoatModel;
            }
            else
            {
                throw new KeyNotFoundException($"Boat ID {boatid} not found.");
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

        public List<Boat> MakingAList()
        {
            return _boats.Values.ToList();
        }

        public List<string> OnlyNamesInOrder()
        {
            List<Boat> Sort = MakingAList();
            List<string> Names = new List<string>();
            foreach (Boat b in Sort)
            {
                Names.Add(b.BoatName);
            }
            Names.Sort();
            return Names;
        }

        public List<string> TypeInOrder()
        {
            List<Boat> Sort = MakingAList();
            List<string> Names = new List<string>();
            foreach (Boat b in Sort)
            {
                Names.Add(b.BoatName);
            }
            Names.Sort();
            return Names;

        }
    }
}