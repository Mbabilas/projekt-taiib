using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDywizjaRepository
    {
        void AddDywizja(Dywizja dywizja);
        Dywizja GetDywizja(long id);
        IEnumerable<Dywizja> GetDywizje();
        bool DeleteDywizja(long dywizjaId);
    }
}
