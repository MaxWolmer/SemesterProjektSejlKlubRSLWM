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
        public string Name { get; set; }

        public string Email { get; set; }

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
        }

        public override string ToString()
        {
            return $"The Member Name: {Name}\nThe Email: {Email}\nThe PhoneNumber {_phoneNumber}\nIs Admin or Member: {(_admin ? "Admin" : "Member")}";
        }



    }
}
