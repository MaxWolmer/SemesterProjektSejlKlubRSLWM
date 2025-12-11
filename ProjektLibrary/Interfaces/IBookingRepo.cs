using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Interfaces
{
    public interface IBookingRepo
    {
        

        public void BookingFree(Boat aboat, DateTime StarTime, DateTime Endtime);

        public void AddBooking(Booking Abooking);

        public void DeleteBooking(Booking AbooKing);

        public void FindBooking(Booking Abooking);

        public List<Booking>? GetAllBookings();

        public List<Booking> BookingsOnBoat(Boat aboat);

    }
}
