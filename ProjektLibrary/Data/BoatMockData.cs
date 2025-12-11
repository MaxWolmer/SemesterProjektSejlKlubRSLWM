using ProjektLibrary.Exceptions.BoatExceptions;
using ProjektLibrary.Models;
using ProjektLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Data
{
    public static class BoatMockData
    {
        #region Instance fields
        private static Dictionary<int, Boat> _boatData =
            new Dictionary<int, Boat>()
        {
        { 1, new Boat("Big Bertha", "Catamaran") },
        { 2, new Boat("Small Bessie", "Ironclad") },
        { 3, new Boat("Furious Freja", "Uboat") },
        { 4, new Boat("Mad Maddie", "Tireme") },
        { 5, new Boat("Talkative Tuna", "Frigate") },
        { 6, new Boat("Jealous Jane", "Submarine") }
        };


        //public static void LoadBoatMockData(BoatRepo bRepo)
        //{
        //    try
        //    {
        //        Boat b1 = new Boat("Big Bertha", "Catamaran");
        //        Boat b2 = new Boat("Small Bessie", "Ironclad");
        //        Boat b3 = new Boat("Furious Freja", "Uboat");
        //        Boat b4 = new Boat("Mad Maddie", "Tireme");
        //        Boat b5 = new Boat("Talkative Tuna", "Frigate");
        //        Boat b6 = new Boat("Jealous Jane", "Submarine");

        //        bRepo.AddBoat(b1);
        //        bRepo.AddBoat(b2);
        //        bRepo.AddBoat(b3);
        //        bRepo.AddBoat(b4);
        //        bRepo.AddBoat(b5);
        //        bRepo.AddBoat(b6);
        //    }
        //    catch (BoatIDAlreadyExistsException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        #endregion
        #region Properties
        public static Dictionary<int, Boat> BoatData
            {
            get { return _boatData; }
    }
        #endregion
    }

}
