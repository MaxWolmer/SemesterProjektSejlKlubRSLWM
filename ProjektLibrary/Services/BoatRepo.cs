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
            else
            {
                throw new BoatNotExistException($"The boat ID {boatid} does not exist\n");
            }
        }

        public void UpdateBoat(int boatid, Boat newboat)
        {
            if (_boats.ContainsKey(boatid))
            {
                Boat existingBoat = _boats[boatid];

                existingBoat.BoatType = newboat.BoatType;
                existingBoat.BoatBrand = newboat.BoatBrand;
                existingBoat.BoatName = newboat.BoatName;
                existingBoat.BoatDimensions = newboat.BoatDimensions;
                existingBoat.BoatAvailable = newboat.BoatAvailable;
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

        public List<Boat> GetAllBoats()
        {
            List<Boat> results = new List<Boat>();

            foreach (Boat b in _boats.Values)
            {
                results.Add(b);
            }

            return results;
        }



        //Sorting methods

        public List<Boat> MakingAList()
        {
            return _boats.Values.ToList();
        }

        public void TypesInOrder()
        {
            List<Boat> Sort = MakingAList();
            List<string> combined = new List<string>();

            // Kombinér brand og model til én streng
            foreach (Boat b in Sort)
            {
                combined.Add(b.BoatType + " - " + b.BoatBrand + " - " + b.BoatName);
            }

            // Sortér alfabetisk efter hele strengen
            combined.Sort();

            // Print resultatet
            foreach (string line in combined)
            {
                Console.WriteLine(line);
            }
        }

        public void BrandsInOrder()
        {
            List<Boat> Sort = MakingAList();
            List<string> combined = new List<string>();

            foreach (Boat b in Sort)
            {
                combined.Add(b.BoatBrand + " - " + b.BoatType + " - " + b.BoatName);
            }

            combined.Sort();

            foreach (string line in combined)
            {
                Console.WriteLine(line);
            }
        }

        public void NamesInOrder()
        {
            List<Boat> Sort = MakingAList();
            List<string> combined = new List<string>();

            foreach (Boat b in Sort)
            {
                combined.Add(b.BoatName + " - " + b.BoatType + " - " + b.BoatBrand);
            }

            combined.Sort();

            foreach (string line in combined)
            {
                Console.WriteLine(line);
            }
        }

        public List<Boat> GetBoatsBySearchWord(string type = null, string brand = null, bool? available = null)
        {
            List<Boat> results = new List<Boat>();

            foreach (Boat b in _boats.Values)
            {
                bool typeMatch = (type == null || b.BoatType == type);
                bool brandMatch = (brand == null || b.BoatBrand == brand);
                bool availabilityMatch = (available == null || b.BoatAvailable == available);

                if (typeMatch && brandMatch && availabilityMatch)
                {
                    results.Add(b);
                }
            }
            return results;
        }

        //public void MarkBoatAvailability()
        //{
        //    foreach (Boat b in _boats.Values)
        //    {
        //        bool(b.BoatType == type);

        //        if ()
        //    }
        //}
    }
}