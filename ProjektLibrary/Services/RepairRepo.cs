using ProjektLibrary.Data;
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
            _allRepairs = RepairMockData.RepairData;
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
                damage.TheBoat.AddRepair(damage);
            }
        }

        public void AddRepairWilliam(Repair damage)
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

        public void RemoveRepairById(int id) //Denne skal kobles sammen med repair liste i Boat. 
        {
            if (_allRepairs.ContainsKey(id))
            {
                _allRepairs.Remove(id);
            }
            else
            {
                throw new RepairIdDoesNotExistException($"Id'et {id} eksisterer ikke - Prøv et andet id");
            }
        }

        public void UpdateReperationStatus(int id)
        {
            if (GetRepairById(id).StatusOfRepair == false) //Der bliver kastet en exception fra GetRepairById()-metoden.
            {
                _allRepairs[id].StatusOfRepair = true;
            }
            else
            {
                _allRepairs[id].StatusOfRepair = false;
            }
        }

        public Repair PrintAllRepairs()
        {
            Console.WriteLine("Printer alle reperationer:");
            foreach (Repair repair in _allRepairs.Values)
            {
                Console.WriteLine(repair);
            }
            return null; //evt. ny exception?
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