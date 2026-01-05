using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.SubClasses.MartinsSubClasses
{
    public class Uboat : Boat
    {
        public int DiveSpeed { get; set; }
        public int DiveDepth { get; set; }


        public Uboat(int DiveSpeed, int DiveDepth, string Type, string Brand, string Name, string Dimensions, bool Available, bool admin, User aUser) : base(Type, Brand, Name, Dimensions, Available, admin, aUser)
        {

        }


        public override string ToString()
        {
            return $"";
        }
    }
}
