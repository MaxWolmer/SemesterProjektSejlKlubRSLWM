using ProjektLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Models
{
    public class Booking
    {

        private User _theuser;
        private Boat _aBoat;
        private static int _bookingID = 0;
        private bool _bookingdone = false;
        private DateTime _startime;
        private DateTime _endtime;



        public Booking(User theuser, Boat Aboat, DateTime StartTime, DateTime Endtime)
        {

            _startime = StartTime;
            _endtime = Endtime;

            _aBoat = Aboat;
            _theuser = theuser;
            _bookingID++;




        }
       

        public DateTime Datestart
        {
            get { return _startime; }
            set { _startime = value; }
        }

        public DateTime DateEnd
        {
            get { return _endtime; }
            set { _endtime = value; }
        }



        public int bookingid
        { get { return _bookingID; } }

        public bool bookingdone
        {
            get { return _bookingdone; }
            set { _bookingdone = value; }
        }
        public User Theuser
        {
            get { return _theuser; }
            set { _theuser = value; }
        }
        public Boat Theboat
        {
            get { return _aBoat; }
            set { _aBoat = value; }
        }
        public int bookings
        {
            get { return _bookingID; }
            set { _bookingID = value; }
        }

        public override string ToString()
        {
            return $"User that booked is {_theuser.Name} The boat that is booked is {_aBoat.Boatname} " +
                $"the booking id is {_bookingID}";
        }
    }
}
