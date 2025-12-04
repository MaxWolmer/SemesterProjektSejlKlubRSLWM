using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Models
{
    public class Blogpost
    {
        public string _blogtitle;
        public string _description;
        public DateTime _timestamp;

        public Blogpost(string title, string description, DateTime timestamp)
        {
            _blogtitle = title;
            _description = description;
            _timestamp = timestamp;
        }
    }
}
