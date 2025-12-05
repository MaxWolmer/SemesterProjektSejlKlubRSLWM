using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Models
{
    public class Blogpost
    {
        private int _id=0;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _blogtitle;
        public string Blogtitle
        {
            get { return _blogtitle; }
            set { _blogtitle = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private DateTime _createdat;
        public DateTime CreatedAt
        {
            get { return _createdat; }
            set { _createdat = value; }
        }

        public Blogpost(int id, string title, string description, DateTime timestamp)
        {
            Id = id;
            Blogtitle = title;
            Description = description;
            CreatedAt = timestamp; 
        }

        public override string ToString()
        {
            return $"{Blogtitle}\n{Description}\nDette sker den {CreatedAt.ToShortDateString()}";
        }
    }
}
