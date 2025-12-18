using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Interfaces
{
    public interface IBoatRepo
    {
        public int Count { get; }
        Boat AddBoat(Boat boat);
        Boat? FindBoatByID(int boatid);
        void UpdateBoat(int oldBoatID, Boat newBoat);
        void DeleteBoat(int boatid);
        void PrintAllBoats();
        public List<Boat> GetAllBoats();
        public void BrandsInOrder();
        public void NamesInOrder();
        public void TypesInOrder();
        public List<Boat> GetBoatsBySearchWord(string type = null, string brand = null, bool? available = null);
    }
}
