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
            _eventpostlist.Add(eventpost);
        }

        //public void AddEvent(Eventpost eventpost)
        //{
        //    Console.WriteLine("Skriv titel:");
        //    string Title = Console.ReadLine();
        //    Console.WriteLine("Skriv beskrivelse:");
        //    string Description = Console.ReadLine();
        //}

        public void DeleteEvent(int id)
        {
            Eventpost toRemove = FindEventById(id);
            if (toRemove != null)
            {
                _eventpostlist.Remove(toRemove);
                return;
            }
            throw new EventIdNotExistException("Et Event med dette ID findes ikke");
        }

        //public void DeleteEvent(int id)
        //{
        //    Eventpost toRemove = FindEventById(id);
        //    if (toRemove == null)
        //    {
        //        throw new EventIdNotExistException("Et Event med dette ID findes ikke");
        //    }
        //    _eventpostlist.Remove(toRemove);
        //    return;
        //}


        //public void UpdateEvent(int id)
        //{
        //    Eventpost post = FindEventById(id);
        //    if (post == null)
        //    {
        //        throw new EventIdNotExistException("En post med dette ID findes ikke");
        //    }
        //    Console.WriteLine("Skriv ny titel:");
        //    string newTitle = Console.ReadLine();
        //    post.EventTitle = newTitle;

        //    Console.WriteLine("Skriv ny beskrivelse:");
        //    string newDescription = Console.ReadLine();
        //    post.EventDescription = newDescription;
        //}

        public void UpdateEvent(int id, string newTitle, string newDescription)
        {
            Eventpost post = FindEventById(id);
            if (post == null)
            {
                throw new EventIdNotExistException("En post med dette ID findes ikke");
            }
            post.EventTitle = newTitle;
            post.EventDescription = newDescription;
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