using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IZgloszenieRepository
    {
        void AddZgloszenie(Zgloszenie zgloszenie);
        Zgloszenie GetZgloszenie(long id);
        IEnumerable<Zgloszenie> GetZgloszenia();
        bool DeleteZgloszenie(long zgloszenieId);
    }
}
