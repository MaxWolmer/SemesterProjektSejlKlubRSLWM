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
        private Dictionary<int, Repair> _allRepairs; //Her er key-value værdien det Id, der er tilknyttet til den enkelte repair.

        //Constructor:
        #region constructor
        public RepairRepo() //Der er lavet MockData til Repair, som bliver hentet i konstruktøren. 
        {
            _allRepairs = MockData.RepairData;
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
        }

        public List<Repair> GetAllRepairs()
        {
            return _allRepairs.Values.ToList();
        }

        public Repair GetRepairById(int id) //Der bliver kastet en exception, hvis Id'et ikke eksisterer.
        {
            if (_allRepairs.ContainsKey(id))
            {
                return _allRepairs[id];
            }
            throw new RepairIdDoesNotExistException($"Id'et {id} eksisterer ikke - Prøv et andet id");
        }

        public void RemoveRepairById(int id)
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
            if (GetRepairById(id).StatusOfRepair == false)//Der bliver kastet en exception fra GetRepairById()-metoden, hvis Id'et ikke eksisterer.
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
            foreach (Repair repair in _allRepairs.Values)
            {
                Console.WriteLine(repair.ToString());
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
            
        public List<Repair> GetRepairsForBoat(int boatId)
        {
            List<Repair> repairsInTheBoat = new List<Repair>();
            foreach (Repair r in _allRepairs.Values)
            {
                if (boatId == r.TheBoat.BoatId)
                {
                    repairsInTheBoat.Add(r);
                }
            }
            return repairsInTheBoat;
        }
        
        #endregion
    }
}