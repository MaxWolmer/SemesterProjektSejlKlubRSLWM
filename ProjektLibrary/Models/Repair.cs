using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Models
{
    public class Repair
    {
        #region Instance fields
        private int _id=0;
		private static int _counter = 1;

		private DateTime _dateOfDamage;
		private string _descriptionOfDamage;
		private bool _statusOfRepair;
		
		private Boat _theBoat;
		private User _theUser;

        #endregion

        #region Properties
        public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public DateTime DateOfDamage
		{
			get { return _dateOfDamage; }
			set { _dateOfDamage = value; }
		}


		public string DescriptionOfDamage
		{
			get { return _descriptionOfDamage; }
			set { _descriptionOfDamage = value; }
		}


		public bool StatusOfRepair
		{
			get { return _statusOfRepair; }
			set { _statusOfRepair = value; }
		}


		//Her tilknyttes båden til repairlog:
		public Boat TheBoat
		{
			get { return _theBoat; }
			set { _theBoat = value; }
		}
        

        //Der tilknyttes der en user:
		public User TheUser
		{
			get { return _theUser; }
			set { _theUser = value; }
		}
		#endregion

		public Repair(string descriptionOfDamage, bool statusOfRepair, Boat theBoat, User theUser) 
		{
			DateOfDamage = DateTime.Now;
			DescriptionOfDamage = descriptionOfDamage;
			StatusOfRepair = statusOfRepair;
			Id = _counter++;
			TheBoat = theBoat;
			TheUser = theUser;
		}


		#region Metoder

		public override string ToString()
		{
			return $"Reperations id: {Id}, Båd: {TheBoat.Boatname}, Indrapporteret af: {TheUser.Name} \nTidspunkt for skaden: {DateOfDamage}, \nStatus på reperationen: {(StatusOfRepair ? "Reperareret. " : "Ikke reperareret.")}\nBeskrivelse af skade: {DescriptionOfDamage}\n.";
		}

        #endregion
    }
}
