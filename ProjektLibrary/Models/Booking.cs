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
        private BookingRepository _bookingRepository;

        private string _bookingmonth;
        private int _bookingstarthour;
        private int _bookingstartminutes;
        private int _bookingendhour;
        private int _bookingendminutes;

        public Booking(BookingRepository arepo,User theuser, Boat Aboat, string month, int starthour, int startmintues, int endhour, int endminutes)
        {
            _bookingRepository = arepo;
            _bookingRepository.Bookingfree(Aboat, month, starthour, startmintues, endhour, endminutes); 
            _aBoat = Aboat;
            _theuser = theuser;
            _bookingID++;
            _bookingmonth = month;
            _bookingstarthour = starthour;
            _bookingstartminutes = startmintues;
            _bookingendhour = endhour;
            _bookingendminutes = endminutes;
            


        }
        public string month { get { return _bookingmonth; } set { _bookingmonth = value; } }
        public int starthour {  get { return _bookingstarthour; }set { _bookingstarthour = value; } }
        public int startminute {  get { return _bookingstartminutes; } set { _bookingstartminutes = value; } }
        public int endhour {  get { return _bookingendhour; }  set { _bookingendhour = value; } }
        public int endminutes {  get { return _bookingendminutes;} set { _bookingendminutes = value; } }
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
                $"the booking id is {_bookingID }";
        }
    }
}
