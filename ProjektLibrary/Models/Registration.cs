using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Models
{
    public class Registration
    {
        private User _theUser;
        private Event _TheEvent;
        private static int _registrationID = 0; //
        private int _id;
        private string _comment;
       
        public Registration(User AUser, Event TheEvent, string Comment)
        {
            _theUser = AUser;
            _TheEvent = TheEvent;
            _registrationID++; 
            _id = _registrationID;
            _comment = Comment;
        }



       
        

        public override string ToString()
        {
            return $"Opretter: {_theUser}, Comment:{_comment} ";
        }
    }
}
