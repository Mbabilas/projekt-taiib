using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IZolnierz
    {
        Zolnierz UpsertZolnierz(Zolnierz zolnierz);
        IEnumerable<Zolnierz> GetZolnierze();
        bool DeleteZolnierze(long zolnierzeId);
        Zolnierz GetZolnierz(long zolnierzId);
    }
}
