using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ZgloszenieRepository:IZgloszenieRepository
    {
        private readonly Database _database;
        public ZgloszenieRepository(Database database)
        {
            this._database = database;
        }

        public void AddZgloszenie(Zgloszenie zgloszenie)
        {
            _database.Zgloszenia.Add(zgloszenie);
        }

        public bool DeleteZgloszenie(long zgloszenieId)
        {
            var removed = false;
            Zgloszenie zgloszenie = GetZgloszenie(zgloszenieId);

            if (zgloszenie != null)
            {
                removed = true;
                _database.Zgloszenia.Remove(zgloszenie);
            }

            return removed;
        }

        public Zgloszenie GetZgloszenie(long Id)
        {
            return _database.Zgloszenia.Where(u => u.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Zgloszenie> GetZgloszenia()
        {
            return _database.Zgloszenia;
        }
    }
}
