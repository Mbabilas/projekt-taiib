using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IBron
    {
        Bron UpsertBron(Bron bron);
        IEnumerable<Bron> GetBronie();
        bool DeleteBron(long bronId);
        Bron getBron(long bronId);
    }
}
