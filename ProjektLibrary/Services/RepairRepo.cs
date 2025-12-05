using ProjektLibrary.Exceptions.RepairExceptions;
using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Services
{
    
    public class RepairRepo : IRepairRepo
    {
        //Liste
        private List<Repair> _allRepairs;

        //Constructor:
        public RepairRepo()
        {
            _allRepairs = new List<Repair>();
        }

        //Methods:
        public void AddRepair(Repair damage)
        {
            _allRepairs.Add(damage);
        }

        public List<Repair> GetAllRepairs()
        {
            return _allRepairs;
        }

        public Repair GetRepairById(int id)
        {
            foreach(Repair repairation in _allRepairs)
            {
                if(repairation.Id == id)
                {
                    return repairation;
                }
            }
            throw new RepairIdDoesNotExistException($"Id'et {id} eksisterer ikke i listen.");
        }

        public void RemoveRepair(Repair id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRepairation()
        {
            throw new NotImplementedException();
        }

        void IRepairRepo.GetRepairById(Repair id)
        {
            throw new NotImplementedException();
        }
    }
}
