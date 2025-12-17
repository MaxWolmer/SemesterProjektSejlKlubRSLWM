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
using System.Security.Cryptography.X509Certificates;
using ProjektLibrary.Data;

namespace ProjektLibrary.Services
{
    public class BookingRepository : IBookingRepo
    {
        
        private List<Booking> _bookings = new List<Booking>();


        public BookingRepository()
        {
            _bookings = MockData.
        }
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
        public void userwithmostbookings()
        {

            int currenthighest = 0;
            string currenthighestname = "";
            foreach (Booking abooking in _bookings)
            {
                abooking.TheUser.BookingCounter++;
             
                
            }
            
            foreach(Booking Auser in _bookings)
            {
                if(Auser.TheUser.BookingCounter > currenthighest)
                {
                    currenthighest = Auser.TheUser.BookingCounter;
                    currenthighestname = Auser.TheUser.Name;
                }
            }

            Console.WriteLine($"{currenthighest} is {currenthighestname}");
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
                Abooking.TheBoat.BoatCounter++;
            }
            

           
                     
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

        public int BookingsOnBoat(int boatid) //lav om til returnere liste
        {
          

            foreach (Booking abooking in _bookings)
            {
                if (abooking.TheBoat.BoatId == boatid)
                {
                    return abooking.TheBoat.BoatCounter;                                  
                }

            }


            

            return 0;

            
        }
        public void printall()
        {
            foreach (Booking Abooking in _bookings)
            {
                Console.WriteLine(Abooking);
            }
        }
        #endregion
    }


}
