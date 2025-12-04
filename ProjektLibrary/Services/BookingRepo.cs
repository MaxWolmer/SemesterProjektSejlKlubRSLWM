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
        
        public void Bookingfree(Boat aboatmodel, string month,int bookinghourstart, int bookingstartminutes, int bookingendhour, int bookingendminutes)
        {
            foreach (Booking Somebooking in _bookings)
            {
                //if (Somebooking.Theboat.Boatmodel == aboatmodel.Boatmodel) ;
                
                   //{ 
                   // switch 
                   //    (Somebooking.starthour == bookingendhour  && Somebooking.endminutes > bookingstartminutes)
                   // {
                   //     Console.WriteLine("Booking taken");

                   // }
                
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
        public void printallbookings()
        {
            foreach (Booking onebooking in _bookings)
            { Console.WriteLine(onebooking); }
        }

    }

}
