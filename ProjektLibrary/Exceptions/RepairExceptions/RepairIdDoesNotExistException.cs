using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Exceptions.RepairExceptions
{
    public class RepairIdDoesNotExistException:Exception
    {
        public RepairIdDoesNotExistException(string message):base(message) //Forkortet til Idex
        {
             
        }
    }
}
