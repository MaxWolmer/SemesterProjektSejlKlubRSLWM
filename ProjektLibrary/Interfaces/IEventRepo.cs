using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Interfaces
{
    public interface IEventRepo
    {
        void AddEvent(Eventpost eventpost);
        void DeleteEvent(int id);
        void UpdateEvent(int id, string newTitle, string newDescription, DateTime newStartDate, DateTime newEndDate);
        Eventpost FindEventById(int id);
    }
}
