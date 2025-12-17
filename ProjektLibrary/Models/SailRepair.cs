using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Models
{
    public class SailRepair:Repair
    {
		private string _sailMaterial;
        public string SailMaterial //det stof-materale sejlet er lavet af.
		{
			get { return _sailMaterial; }
			set { _sailMaterial = value; }
		}
        public string TypeOfSail { get; set; } //Her er den det slags sejl, som sejlet er. f.eks.: MailSail, som er det primære sejl.
        public double AreaOfSail { get; set; } //I kvadratmeter (m^2)
        public SailRepair(string descriptionOfDamage, bool statusOfRepair, Boat theBoat, User theUser, string sailMaterial, string typeOfSail, double areaOfSail) : base(descriptionOfDamage, statusOfRepair, theBoat, theUser)
        {
            SailMaterial = sailMaterial;
            TypeOfSail = typeOfSail;
            AreaOfSail = areaOfSail;
        }

        public string ToString()
        {
            return base.ToString() + $"\nSejl Materiale: {SailMaterial}, SejlType: {TypeOfSail}, sejlets areal: {AreaOfSail} kvadratmeter";
        }

    }
}
