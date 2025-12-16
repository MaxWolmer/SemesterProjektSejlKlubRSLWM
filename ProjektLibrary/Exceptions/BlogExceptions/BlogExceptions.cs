using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Exceptions.BlogExceptions
{
    public class BlogIdNotExistException : Exception //bineex
    {
        public BlogIdNotExistException(string message) : base(message)
        {

        }
    }
    public class SpaceCannotBeEmptyException : Exception //bscbeex
    {
        public SpaceCannotBeEmptyException(string message) : base(message)
        {

        }
    }
}
