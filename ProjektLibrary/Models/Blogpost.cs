using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjektLibrary.Models
{
    public class Blogpost
    {
        #region Instance Fields
        private static int _id = 1;

        private string _title;
        private string _description;
        private DateTime _createdat;

        private User _postedby;
        #endregion

        #region Properties
        public int Id { get; private set; }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
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

        public User PostedBy
        {
            get { return _postedby; }
            set { _postedby = value; }
        }
        #endregion

        #region Constructors
        public Blogpost(string title, string description, DateTime timestamp, User postedBy)
        {
            Id = _id++;
            Title = title;
            Description = description;
            CreatedAt = timestamp;
            PostedBy = postedBy;

        }

        //Automatisk timestamp constructor
        public Blogpost(string title, string description, User postedBy)
        {
            Id = _id++;
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
            PostedBy = postedBy;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Id}. {Title}\n" +
                $"{Description}\n" +
                $"Denne post er oprettet d. {CreatedAt}.\n";
                //$"Denne blog va delt af{PostedBy.Name}"
        }
        #endregion
    }
}
