using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using ProjektLibrary.Services;

namespace zControlMenu
{
    public class controller
    {
        private UserRepo _userRepo;
        private EventRepo _eventRepo;
        private RepairRepo _repairRepo;
        private BookingRepository _bookingRepo;
        private BlogRepo _blogRepo;
        private BoatRepo _boatRepo;
        public controller(UserRepo Arepo, EventRepo AEventrepo, RepairRepo RepairRepo, BookingRepository Bookingrepo,BlogRepo ABlogrepo, BoatRepo Boatrepo)
        {
            _userRepo = Arepo;
            _eventRepo = AEventrepo;
            _repairRepo = RepairRepo;
            _bookingRepo = Bookingrepo;
            _blogRepo = ABlogrepo;
            _boatRepo = Boatrepo;
        }
   
        public UserRepo UserRepo
        {
            get { return _userRepo; }
            set { _userRepo = value; }
        }
        public EventRepo EventRepo
        {
            get { return _eventRepo; }
            set { _eventRepo = value; }
        }
        public RepairRepo RepairRepo
        {
            get { return _repairRepo; }
            set { _repairRepo = value; }
        }
        public BookingRepository BookingRepo
        {
            get { return _bookingRepo; }
            set { _bookingRepo = value; }
        }
        public BlogRepo BlogRepo
        {
            get { return _blogRepo; }
            set { _blogRepo = value; }
        }
        public BoatRepo BoatRepo
        {
            get { return _boatRepo; }
            set { _boatRepo = value; }
        }
    }
}
