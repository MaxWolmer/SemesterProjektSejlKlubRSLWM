using ProjektLibrary.Data;
using ProjektLibrary.Exceptions.BlogExceptions;
using ProjektLibrary.Exceptions.EventExceptions;
using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
        public void AddEvent(Eventpost eventpost)
        {
            if (DateTime.Now > eventpost.EventStartDate && DateTime.Now > eventpost.EventEndDate)
            {
                throw new EventDateNotValidException("Et Event kan ikke starte før dagens dato");
            }
            _eventpostlist.Add(eventpost);
        }

        public void DeleteEvent(int id)
        {
            Eventpost toRemove = FindEventById(id);
            if (toRemove == null)
            {
                throw new EventIdNotExistException("Et Event med dette ID findes ikke");
            }
            _eventpostlist.Remove(toRemove);
            return;
        }

        public void UpdateEvent(int id, string newTitle, string newDescription, DateTime newStartDate, DateTime newEndDate)
        {
            Eventpost post = FindEventById(id);
            if (post == null)
            {
                throw new EventIdNotExistException("Et Event med dette ID findes ikke");
            }
            if (DateTime.Now > newStartDate && DateTime.Now > newEndDate)
            {
                throw new EventDateNotValidException("Et Event kan ikke starte før dagens dato");
            }
            post.EventTitle = newTitle;
            post.EventDescription = newDescription;
            post.EventStartDate = newStartDate; //Formuleres xx-xx-xxxx
            post.EventEndDate = newEndDate; //Formuleres xx-xx-xxxx
        }

        public Eventpost FindEventById(int id)
        {
            foreach (Eventpost post in _eventpostlist)
            {
                if (post.Id == id)
                {
                    return post;
                }
            }
            return null;
        }

        public void PrintListOfEvents()
        {
            foreach (Eventpost b in _eventpostlist)
            {
                Console.WriteLine(b.ToString());
            }
            Console.WriteLine("- Has printed all Eventposts -\n");
        }
        #endregion
    }
}