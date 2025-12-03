using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Models
{
    public class Booking
    {
        private DateTime _thetime;
        private User _theuser;
        private Boat _aBoat;
        private static int _bookingID = 0;
        private bool _bookingdone = false;

        public Booking(User theuser, Boat Aboat, int bookingdate, int bookinghourstart, int bookinghourend)
        {

            _aBoat = Aboat;
            _theuser = theuser;
            _thetime = new DateTime();
            _bookingID++;


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

        public void Bookingavaible()
    }
}
