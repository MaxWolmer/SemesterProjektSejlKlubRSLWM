using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Exceptions.BoatExceptions
{
    public class BoatIDAlreadyExistsException : Exception
    {
        public BoatIDAlreadyExistsException(string message)
            :base(message)
        {
        }
    }
}
