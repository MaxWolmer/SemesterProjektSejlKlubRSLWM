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
        void AddRepair(Repair damage);

        List<Repair> GetAllRepairs();

        void GetRepairById(Repair id);

        void UpdateRepairation();

        ///TIlføjelser:
        ///Get the lastestDamage()
        ///GetAllOfTypeDamage()
        ///GetDamagesfromTheLastweek()
        ///PrintAllRepairs


       

    }
}
