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
        void AddBoat(Boat boat);
        Boat? FindBoatByID(int boatid);
        void UpdateBoat(int oldBoatID, Boat newBoat);
        void DeleteBoat(int boatid);
        void PrintAllBoats();
    }
}
