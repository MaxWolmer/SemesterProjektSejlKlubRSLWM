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
        void DeleteBoat(string name);
        void FindBoatByName(string name);
        void PrintAllBoats();
    }
}
