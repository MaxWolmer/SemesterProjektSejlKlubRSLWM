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
		private int _id=0;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private static int _counter;

		private DateTime _dateOfDamage;

		public DateTime DateOfDamage
		{
			get { return _dateOfDamage; }
			set { _dateOfDamage = value; }
		}

		private string _descriptionOfDamage;

		public string DescriptionOfDamage
		{
			get { return _descriptionOfDamage; }
			set { _descriptionOfDamage = value; }
		}

		private bool _statusOfRepair;

		public bool StatusOfRepair
		{
			get { return _statusOfRepair; }
			set { _statusOfRepair = value; }
		}

		private Boat _theBoat;

		//Her tilknyttes båden til repairlog:
		public Boat TheBoat
		{
			get { return _theBoat; }
			set { _theBoat = value; }
		}

		//Der skal lige tilknyttes en user, når det er klar.


		public Repair(DateTime dateOfDamage, string descriptionOfDamage, bool statusOfRepair, Boat theBoat) //Båd skal måske også med i constructor.
		{
			DateOfDamage = dateOfDamage;
			DescriptionOfDamage = descriptionOfDamage;
			StatusOfRepair = statusOfRepair;
			Id = _counter++;
			TheBoat = theBoat;
		}


		//Ret ToString efter at båd og bruger tilknyttet
        public override string ToString()
        {
            return $"Reperations id: {Id}, Båd: {TheBoat}, \nTidspunkt for skaden: {DateOfDamage}, \nStatus på reperationen: {(StatusOfRepair ? "Reperareret. ": "Ikke reperareret.")}\nBeskrivelse af skade: {DescriptionOfDamage}.";
        }

	}
}
