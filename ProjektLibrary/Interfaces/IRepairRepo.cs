using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Interfaces
{
    public interface IRepairRepo
    {
        int Count { get; }

        void AddRepair(Repair damage);

        Repair GetRepairById(int id); //Ændrer til int i parameter.

        void UpdateRepairationStatus(int id); //Tilføj parameter.

        Repair PrintAllRepairs();

        List<Repair> PrintNonFixedRepairs();

        ///TIlføjelser:
        ///Get the lastestDamage()
        ///GetAllOfTypeDamage()
        ///GetDamagesfromTheLastweek()



       

    }
}
