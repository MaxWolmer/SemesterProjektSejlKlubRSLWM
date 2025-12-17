using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Exceptions.EventExceptions
{
    public class EventIdNotExistException : Exception // eineex
    {
        public EventIdNotExistException(string message) : base(message)
        {

        }
    }
    public class SpaceCannotBeEmptyException : Exception // scbeex
    {
        public SpaceCannotBeEmptyException(string message) : base(message)
        {

        }
    }
}
