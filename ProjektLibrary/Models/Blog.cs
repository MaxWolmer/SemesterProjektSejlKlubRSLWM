using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Models
{
    public class Blog
    {
        //Instance Fields
        private static int _id = 1;

        private string _blogtitle;
        private string _description;
        private DateTime _createdat;

        //Properties
        public int Id { get; private set; }
        public string Blogtitle
        {
            get { return _blogtitle; }
            set { _blogtitle = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public DateTime CreatedAt
        {
            get { return _createdat; }
            set { _createdat = value; }
        }

        //Constructors
        public Blog(string title, string description, DateTime timestamp)
        {
            Id = _id++;
            Blogtitle = title;
            Description = description;
            CreatedAt = timestamp;
        }

        //Methods
        public override string ToString()
        {
            return $"{Id}. {Blogtitle}\n{Description}\nDette sker den {CreatedAt.ToShortDateString()}\n";
        }
    }
}
