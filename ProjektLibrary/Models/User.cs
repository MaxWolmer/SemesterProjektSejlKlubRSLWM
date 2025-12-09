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
        private bool _admin;
        private string _phoneNumber;
        private string _email;
        private int _id;
        private static int _counter = 1;
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

        public User(string name, string email, string phoneNumber, bool admin)
        {
            Name = name;
            Email = email; 
            _phoneNumber = phoneNumber;
            _admin = admin;
            _id = _counter++;
        }

        public override string ToString()
        {
            return $"The Id: {_id}\nThe Member Name: {Name}\nThe Email: {Email}\nThe PhoneNumber {_phoneNumber}\nIs Admin or Member: {(_admin ? "Admin" : "Member")}\n";
        }



    }
}
