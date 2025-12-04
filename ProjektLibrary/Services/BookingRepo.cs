using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Services
{
    public class BookingRepository
    {
        private List<Booking> _bookings;

        public BookingRepository()
        {
            _bookings = new List<Booking>();
        }
        
        public void Bookingfree(Boat aboatmodel, DateTime StarTime, DateTime Endtime)
        {
            foreach (Booking Somebooking in _bookings)
            {
               

            }
           
        }

        public void addbooking(Booking Abooking)
        {
            _bookings.Add(Abooking);
        }
        public void deletebooking(Booking Abooking)
        {
            _bookings.Remove(Abooking);
        }
        public void findbooking(Booking Abooking)
        {
            foreach (Booking onebooking in _bookings)
            {
                if (Abooking.bookingid == onebooking.bookingid)
                {
                    Console.WriteLine(onebooking);
                }
            }
        }
        public List<Booking> printallbookings()
        {
            List<Booking> bookinglist = new List<Booking>();

            foreach (Booking onebooking in _bookings)
            
            { bookinglist.Add(onebooking); }

            return bookinglist;
        }

        public void BookingsonBoat(Boat aboat)
        {
            foreach (Booking abooking in _bookings)
            {
                if(abooking.Theboat == aboat)
                {
                    Console.WriteLine(abooking);
                }
            }

        }

    }

}
