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

        private User _theUser;
        private Boat _aBoat;
        private static int _bookingID;
        private static int _counter = 0;
        private bool _bookingDone = false;
        private DateTime _starTime;
        private DateTime _endTime;


        public Booking(User TheUser, Boat ABoat, DateTime StartTime, DateTime EndTime)
        {

            _starTime = StartTime;
            _endTime = EndTime;
            _counter++;
            _aBoat = ABoat;
            _theUser = TheUser;
            _bookingID = _counter;

        }       

        public DateTime DateStart
        {
            get { return _starTime; }
            set { _starTime = value; }
        }

        public DateTime DateEnd
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public int BookingId
        { get { return _bookingID; } }

        public bool BookingDone
        {
            get { return _bookingDone; }
            set { _bookingDone = value; }
        }
        public User TheUser
        {
            get { return _theUser; }
            set { _theUser = value; }
        }
        public Boat TheBoat
        {
            get { return _aBoat; }
            set { _aBoat = value; }
        }
        public int Bookings
        {
            get { return _bookingID; }
            set { _bookingID = value; }
        }

        public override string ToString()
        {
            return $"User that booked is {_theUser.Name} The boat that is booked is {_aBoat.BoatName} " +
                $"the booking id is {_bookingID}";
        }
    }
}
