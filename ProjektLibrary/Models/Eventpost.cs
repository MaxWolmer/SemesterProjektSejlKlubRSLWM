using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Models
{
    public class Eventpost
    {
        #region Instance Fields
        private static int _id = 1;

        private string _eventtitle;
        private string _eventdescription;
        private DateTime _eventstartdate;
        private DateTime _eventenddate;
        #endregion

        #region Properties
        public int Id { get; private set; }
        public string EventTitle
        {
            get { return _eventtitle; }
            set { _eventtitle = value; }
        }
        public string EventDescription
        {
            get { return _eventdescription; }
            set { _eventdescription = value; }
        }
        public DateTime EventStartDate
        {
            get { return _eventstartdate; }
            set { _eventstartdate = value; }
        }
        public DateTime EventEndDate
        {
            get { return _eventenddate; }
            set { _eventenddate = value; }
        }

        #endregion

        #region Constructors
        public Eventpost(string title, string description, DateTime eventstartdate, DateTime eventenddate)
        {
            Id = _id++;
            EventTitle = title;
            EventDescription = description;
            EventStartDate = eventstartdate;
            EventEndDate = eventenddate;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Id}. {EventTitle}\n" +
                $"{EventDescription}\n" +
                $"Denne event varer fra d. {EventStartDate}\n" +
                $"til d. {EventEndDate}.\n";
        }
        #endregion
    }
}
