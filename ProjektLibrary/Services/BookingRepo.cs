using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using ProjektLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektLibrary.Exceptions.BookingExceptions;

namespace ProjektLibrary.Services
{
    public class BookingRepository : IBookingRepo
    {
        
        private List<Booking> _bookings = new List<Booking>();

        #region metoder
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
        public List<string> userbookingnames()
        {
            List<string> Userlist = new List<string>();

            foreach (Booking abooking in _bookings)
            {
                Userlist.Add(abooking.TheUser.Name);
            }
            return Userlist;
        }

        public string userwithmostbookings()
        {
            List<string> userswithnames = userbookingnames();


            for (int i = 0; i < userswithnames.Count; i++)
            {
                userswithnames[i] = userswithnames[i] + "1";
            }


          



            return $"user with most bookings is {mostbookings} he has {currentbiggest} bookings";


        }


        public void BookingDone(DateTime timeback, Boat boat)
        {
            foreach(Booking abooking in _bookings)
            {
                if(boat.BoatId == abooking.TheBoat.BoatId)
                {
                    abooking.DateEnd = timeback;
                }
            }
        }

        public void AddBooking(Booking Abooking)
        {
            bool bookingthere = false;

            foreach(Booking Somebooking in _bookings)
            {
                if(Somebooking.BookingId == Abooking.BookingId)
                {   
                    bookingthere = true;    
                }
            }
            if (bookingthere == false)
            {
                _bookings.Add(Abooking);
            }
            

            else throw new BookingException("no");
                     
        }
        public void DeleteBooking(Booking AbooKing)
        {
            bool bookingthere = false;            
 
            foreach (Booking Somebooking in _bookings)
            {
                if(Somebooking.BookingId == AbooKing.BookingId)
                {
                    bookingthere = true;

                }

            }
            if (bookingthere == false)
            {
                _bookings.Remove(AbooKing);
            }
            else Console.WriteLine("booking was not there");
        }

        public void FindBooking(Booking Abooking)
        {
            bool found = false;
            foreach (Booking onebooking in _bookings)
            {
                if (Abooking.BookingId == onebooking.BookingId)
                {
                    Console.WriteLine(onebooking);
                    found = true;
                }

            }
            if(found == false)
            {
                Console.WriteLine("booking not found");
            }
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
                { 
                  Console.WriteLine("zerobookings"); 
                }

            return bookinglist;

        }
        #endregion
    }


}
