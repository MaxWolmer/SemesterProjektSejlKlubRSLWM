using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Exceptions.RepairExceptions
{
    public class TheRepairHasAlreadyBeenFixedException:Exception
    {
        public TheRepairHasAlreadyBeenFixedException(string message):base(message)//Forkortet til afex
        {
            
        }
    }
}
