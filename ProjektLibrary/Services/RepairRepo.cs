using ProjektLibrary.Exceptions.RepairExceptions;
using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Services
{

    public class RepairRepo : IRepairRepo
    {
        //Dictionary:
        private Dictionary<int, Repair> _allRepairs;

        //Constructor:
        public RepairRepo()
        {
            _allRepairs = new Dictionary<int, Repair>();
        }

        public int Count { get { return _allRepairs.Count; } }

        //Methods:
        public void AddRepair(Repair damage)
        {
            if (_allRepairs.ContainsKey(damage.Id) == false)
            {
                _allRepairs.Add(damage.Id, damage);
            }
        }

        public List<Repair> GetAllRepairs()
        {
            return _allRepairs.Values.ToList();
        }

        public Repair GetRepairById(int id)
        {
            if (_allRepairs.ContainsKey(id))
            {
                return _allRepairs[id];
            }
            throw new RepairIdDoesNotExistException($"Id'et {id} eksisterer ikke - Prøv et andet id");
        }

        public void RemoveRepairById(int id)
        {
            foreach (Repair r in _allRepairs.Values)
            {
                if (r.Id == id)
                {
                    _allRepairs.Remove(id);
                }                
            }
        }

        public void UpdateRepairationStatus(int id)
        {
            if (GetRepairById(id).StatusOfRepair == false)
            {
                _allRepairs[id].StatusOfRepair = true;
            }
        }

        public Repair PrintAllRepairs()
        {
            foreach (Repair repair in _allRepairs.Values)
            {
                Console.WriteLine(repair);
            }
            return null;
        }

        public List<Repair> PrintNonFixedRepairs()
        {
            List<Repair> nonFixedRepairs = new List<Repair>();
            foreach (Repair reperation in _allRepairs.Values)
            {
                if (reperation.StatusOfRepair == false)
                {
                    nonFixedRepairs.Add(reperation);
                }
            }
            return nonFixedRepairs;
        }
    }
}
