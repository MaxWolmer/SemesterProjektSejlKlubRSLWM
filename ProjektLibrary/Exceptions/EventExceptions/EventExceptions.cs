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
    public class EventDateNotValidException : Exception //ednvex
    {
        public EventDateNotValidException(string message) : base(message)
        {

        }
    }
}
