using ProjektLibrary.Exceptions.UserExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Models
{
    public class User
    {
        #region instance fields
        private bool _admin;
        private string _phoneNumber;
        private string _email;
        private int _id;
        private static int _counter = 1;
        private DateTime _creationDate;


        #endregion

        #region properties
        public string Name { get; set; }

        public string Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains('@'))
                {
                    throw new GmailDoesNotContain_Exception($"Email is not valid need a @");
                }
                _email = value;
            }
        }

        public string Password { get; set; }
        public bool Admin
        {
            get { return _admin; }
            set { _admin = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public DateTime CreationDate
        {
            get { return _creationDate; }
        }
        public int BookingCounter { get; set; }
        #endregion


        #region construktor
        public User(string name, string email, string phoneNumber, bool admin)
        {
            Name = name;
            Email = email; 
            _phoneNumber = phoneNumber;
            _admin = admin;
            _id = _counter++;
            _creationDate = DateTime.Now;
            BookingCounter = 0;
        }
        #endregion

        public override string ToString()
        {
            return $"The Id: {_id}\nThe Member Name: {Name}\nThe Email: {Email}\nThe PhoneNumber {_phoneNumber}\n" +
                $"Is Admin or Member: {(_admin ? "Admin" : "Member")}\nThis Member was added {_creationDate}\n";
        }



    }
}
