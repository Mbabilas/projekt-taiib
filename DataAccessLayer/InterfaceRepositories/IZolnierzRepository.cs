using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IZolnierzRepository
    {
        void AddZolnierz(Zolnierz zolnierz);
        Zolnierz GetZolnierz(long id);
        IEnumerable<Zolnierz> GetZolnierze();
        bool DeleteZolnierz(long zolnierzId);
    }
}
