using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IStopienRepository
    {
        void AddStopien(Stopien stopien);
        Stopien GetStopien(long id);
        IEnumerable<Stopien> GetStopnie();
        bool DeleteStopien(long stopienId);
    }
}
