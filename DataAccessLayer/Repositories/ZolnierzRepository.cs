using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ZolnierzRepository:IZolnierzRepository
    {
        private readonly Database _database;
        public ZolnierzRepository(Database database)
        {
            this._database = database;
        }

        public void AddZolnierz(Zolnierz zolnierz)
        {
            _database.Zolnierze.Add(zolnierz);
        }

        public bool DeleteZolnierz(long zolnierzId)
        {
            var removed = false;
            Zolnierz zolnierz = GetZolnierz(zolnierzId);

            if (zolnierz != null)
            {
                removed = true;
                _database.Zolnierze.Remove(zolnierz);
            }

            return removed;
        }

        public Zolnierz GetZolnierz(long Id)
        {
            return _database.Zolnierze.Where(u => u.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Zolnierz> GetZolnierze()
        {
            return _database.Zolnierze;
        }
    }
}
