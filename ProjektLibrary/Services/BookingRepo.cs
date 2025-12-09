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

        private List<Booking> _bookings = new List<Booking>();


        public void BookingFree(Boat aboat, DateTime StarTime, DateTime Endtime)
        {
            foreach (Booking Somebooking in _bookings)
            {
                if (Somebooking.TheBoat.BoatName == aboat.BoatName)
                {
                    if (Endtime.Date < Somebooking.DateStart.Date  || StarTime.Date > Somebooking.DateEnd.Date)
                    {
                        Console.WriteLine("booking  available");
                    }
                    else Console.WriteLine("boat not available");
                }
            }

        }

        public void AddBooking(Booking Abooking)
        {
            _bookings.Add(Abooking);
        }
        public void DeleteBooking(Booking AbooKing)
        {
            _bookings.Remove(AbooKing);
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
        }
        public List<Booking>? PrintAllBookings()
        {
            return _bookings;
        }

        public void BookingsOnBoat(Boat aboat) //lav om til returnere liste
        {
            foreach (Booking abooking in _bookings)
            {
                if (abooking.TheBoat == aboat)
                {
                    Console.WriteLine(abooking);
                }
            }

        }

    }


}
