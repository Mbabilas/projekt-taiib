using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BronRepository:IBronRepository
    {
        private readonly Database _database;
        public BronRepository(Database database)
        {
            this._database = database;
        }

        public void AddBron(Bron bron)
        {
            _database.Bronie.Add(bron);
        }

        public bool DeleteBron(long bronId)
        {
            var removed = false;
            Bron bron = GetBron(bronId);

            if (bron != null)
            {
                removed = true;
                _database.Bronie.Remove(bron);
            }

            return removed;
        }

        public Bron GetBron(long Id)
        {
            return _database.Bronie.Where(u => u.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Bron> GetBronie()
        {
            return _database.Bronie;
        }
    }
}
