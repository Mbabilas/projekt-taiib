using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IBronRepository
    {
        void AddBron(Bron bron);
        Bron GetBron(long id);
        IEnumerable<Bron> GetBronie();
        bool DeleteBron(long bronId);
    }
}
