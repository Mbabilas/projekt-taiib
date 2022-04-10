using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DywizjaRepository:IDywizjaRepository
    {
        private readonly Database _database;
        public DywizjaRepository(Database database)
        {
            this._database = database;
        }

        public void AddDywizja(Dywizja dywizja)
        {
            _database.Dywizje.Add(dywizja);
        }

        public bool DeleteDywizja(long dywizjaId)
        {
            var removed = false;
            Dywizja dywizja = GetDywizja(dywizjaId);

            if (dywizja != null)
            {
                removed = true;
                _database.Dywizje.Remove(dywizja);
            }

            return removed;
        }

        public Dywizja GetDywizja(long Id)
        {
            return _database.Dywizje.Where(u => u.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Dywizja> GetDywizje()
        {
            return _database.Dywizje;
        }
    }
}
