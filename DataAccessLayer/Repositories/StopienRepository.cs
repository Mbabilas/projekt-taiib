using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StopienRepository:IStopienRepository
    {
        private readonly Database _database;
        public StopienRepository(Database database)
        {
            this._database = database;
        }

        public void AddStopien(Stopien stopien)
        {
            _database.Stopnie.Add(stopien);
        }

        public bool DeleteStopien(long stopienId)
        {
            var removed = false;
            Stopien stopien = GetStopien(stopienId);

            if (stopien != null)
            {
                removed = true;
                _database.Stopnie.Remove(stopien);
            }

            return removed;
        }

        public Stopien GetStopien(long Id)
        {
            return _database.Stopnie.Where(u => u.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Stopien> GetStopnie()
        {
            return _database.Stopnie;
        }
    }
}
