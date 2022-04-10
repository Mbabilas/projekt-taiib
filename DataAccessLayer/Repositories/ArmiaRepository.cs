using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ArmiaRepository:IArmiaRepository
    {
        private readonly Database _database;
        public ArmiaRepository(Database database)
        {
            this._database = database;
        }

        public void AddArmia(Armia armia)
        {
            _database.Armie.Add(armia);
        }

        public bool DeleteArmia(long armiaId)
        {
            var removed = false;
            Armia armia = GetArmia(armiaId);

            if (armia != null)
            {
                removed = true;
                _database.Armie.Remove(armia);
            }

            return removed;
        }

        public Armia GetArmia(long Id)
        {
            return _database.Armie.Where(u => u.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Armia> GetArmie()
        {
            return _database.Armie;
        }
    }
}
