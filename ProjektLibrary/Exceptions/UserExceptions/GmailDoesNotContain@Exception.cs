using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Exceptions.UserExceptions
{
    public class GmailDoesNotContain_Exception : Exception
    {
        public GmailDoesNotContain_Exception(string message) : base(message)
        {

        }
    }
}
