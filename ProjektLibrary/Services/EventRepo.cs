using ProjektLibrary.Data;
using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Services
{
    public class EventRepo : IEventRepo
    {
        #region List Creation
        private List<Eventpost> _eventpostlist;

        public EventRepo()
        {
            _eventpostlist = MockData.EventList;
        }
        #endregion

        #region Methods

        #endregion
    }
}