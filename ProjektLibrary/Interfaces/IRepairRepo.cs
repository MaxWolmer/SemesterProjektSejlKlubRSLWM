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

        Repair GetRepairById(int id);

        void UpdateReperationStatus(int id);

        Repair PrintAllRepairs();

        List<Repair> GetNonFixedRepairs();

        ///TIlføjelser:
        ///Get the lastestDamage()
        ///GetAllOfTypeDamage()
        ///GetDamagesfromTheLastweek()



       

    }
}
