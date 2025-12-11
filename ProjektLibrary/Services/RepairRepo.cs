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
        #region constructor
        public RepairRepo()
        {
            _allRepairs = new Dictionary<int, Repair>();
        }
        #endregion

        #region Property
        public int Count 
        { 
            get { return _allRepairs.Count; } 
        }
        #endregion

        #region Methods
        public void AddRepair(Repair damage)
        {
            if (_allRepairs.ContainsKey(damage.Id) == false)
            {
                _allRepairs.Add(damage.Id, damage);
            }
            damage.TheBoat.updaterepair(GetAllRepairs());
        }
        public void AddRepairWilliam(Repair damage)
        {
            if (_allRepairs.ContainsKey(damage.Id) == false)
            {
                _allRepairs.Add(damage.Id, damage);
            }
            damage.TheBoat.updaterepair(GetAllRepairs());
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
            if(_allRepairs.ContainsKey(id))
            {
                _allRepairs.Remove(id);
                return;
            }
            else
            {
                throw new RepairIdDoesNotExistException($"Id'et {id} eksisterer ikke - Prøv et andet id");
            }
        }

        public void UpdateReperationStatus(int id)
        {
            if (GetRepairById(id).StatusOfRepair == false)
            {
                _allRepairs[id].StatusOfRepair = true;
            }
            throw new TheRepairHasAlreadyBeenFixedException($"Skaden med Id'et {id}, er allerede repareret");

        }

        public Repair PrintAllRepairs()
        {
            Console.WriteLine("Printer alle reperationer:");
            foreach (Repair repair in _allRepairs.Values)
            {
                Console.WriteLine(repair);
            }
            return null;
        }

        public List<Repair> GetNonFixedRepairs()
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
        #endregion
    }
}