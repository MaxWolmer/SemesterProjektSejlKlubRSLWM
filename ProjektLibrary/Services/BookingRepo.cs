using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Services
{
    public class BookingRepository : IBookingRepo
    {

        private List<Booking> _bookings = new List<Booking>();


        public void BookingFree(Boat aboat, DateTime StarTime, DateTime Endtime)
        {
            foreach (Booking Somebooking in _bookings)
            {
                if (Somebooking.TheBoat.BoatName == aboat.BoatName && Endtime.Date < Somebooking.DateStart.Date || StarTime.Date > Somebooking.DateEnd.Date)
                {
                    Console.WriteLine("booking  available");
                }
                else Console.WriteLine("boat not available");

            }

        }

        public void AddBooking(Booking Abooking)
        {
            foreach(Booking Somebooking in _bookings)
            {
                if(Somebooking.BookingId != Abooking.BookingId)
                {
                    _bookings.Add(Abooking);
                }
            }
            Console.WriteLine("booking already there");
        }
        public void DeleteBooking(Booking AbooKing)
        {
            foreach (Booking Somebooking in _bookings)
            {
                if(Somebooking.BookingId == AbooKing.BookingId)
                {
                    _bookings.Remove(AbooKing);

                }
            }
            Console.WriteLine("booking not there to delete");
        }

        public void FindBooking(Booking Abooking)
        {
            foreach (Booking onebooking in _bookings)
            {
                if (Abooking.BookingId == onebooking.BookingId)
                {
                    Console.WriteLine(onebooking);
                }
            }
            Console.WriteLine("booking not found");
        }
        public List<Booking>? GetAllBookings()
        {
            return _bookings;
        }

        public List<Booking> BookingsOnBoat(Boat aboat) //lav om til returnere liste
        {
            List<Booking> bookinglist = new List<Booking>();
            foreach (Booking abooking in _bookings)
            {
                if (abooking.TheBoat == aboat)
                {
                    bookinglist.Add(abooking);
                }

            }
            if(bookinglist == null)

            { Console.WriteLine("zerobookings"); }

            return bookinglist;

        }

    }


}
