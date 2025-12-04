using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Models
{
    public class Registration
    {
        private User _theuser;
        private List<User> _Participants;
        private Event _TheEvent;
       
        public Registration(User auser, Event theevent)
        {
            _theuser = auser;
            _TheEvent = theevent;
        }



        public void addparticipants(List<User> Users)
        {
            _Participants = Users;
        }
        public void addparticipant(User User)
        {
            _Participants.Add(User);
        }

        public override string ToString()
        {
            return $"the users {_Participants} the list {_theuser} ";
        }
    }
}
