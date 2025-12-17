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

        private string _blogtitle;
        private string _blogdescription;
        private DateTime _blogcreatedat;

        private User _blogpostedby;
        #endregion

        #region Properties
        public int Id { get; private set; }
        public string BlogTitle
        {
            get { return _blogtitle; }
            set { _blogtitle = value; }
        }
        public string BlogDescription
        {
            get { return _blogdescription; }
            set { _blogdescription = value; }
        }
        public DateTime BlogCreatedAt
        {
            get { return _blogcreatedat; }
            set { _blogcreatedat = value; }
        }

        public User BlogPostedBy
        {
            get { return _blogpostedby; }
            set { _blogpostedby = value; }
        }
        #endregion

        #region Constructors
        public Blogpost(string title, string description, DateTime timestamp, User postedBy)
        {
            Id = _id++;
            BlogTitle = title;
            BlogDescription = description;
            BlogCreatedAt = timestamp;
            BlogPostedBy = postedBy;

        }

        //Automatisk timestamp constructor
        public Blogpost(string title, string description, User postedBy)
        {
            Id = _id++;
            BlogTitle = title;
            BlogDescription = description;
            BlogCreatedAt = DateTime.Now;
            BlogPostedBy = postedBy;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Id}. {BlogTitle}\n" +
                $"{BlogDescription}\n" +
                $"Dette indslag er oprettet d. {BlogCreatedAt}.\n" +
                $"Dette indslag var delt af {BlogPostedBy.Name}.\n";
        }
        #endregion
    }
}
