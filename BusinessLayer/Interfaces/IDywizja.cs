using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IDywizja
    {
        Dywizja UpsertDywizja(Dywizja dywizja);
        IEnumerable<Dywizja> GetDywizje();
        bool DeleteDywizja(long dywizjaId);
        Dywizja getDywizja(long dywizjaId);
    }
}
