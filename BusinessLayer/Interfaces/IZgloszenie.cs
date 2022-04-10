using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IZgloszenie
    {
        Zgloszenie UpsertZgloszenie(Zgloszenie zgloszenie);
        IEnumerable<Zgloszenie> GetZgloszenia();
        bool DeleteZgloszenie(long zgloszenieId);
        Zgloszenie GetZgloszenie(long zgloszenieId);
    }
}
