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
        
        public void Bookingfree(string month,int bookinghourstart, int bookingminutes, int bookingendhour, int bookingendminutes)
        {
            foreach (Booking Somebooking in _bookings)
            {
                if(Abooking. == Somebooking.)
            }
            else throw Exception 
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
        public void printallbookings()
        {
            foreach (Booking onebooking in _bookings)
            { Console.WriteLine(onebooking); }
        }

    }

}
