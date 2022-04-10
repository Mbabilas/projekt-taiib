using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IStopien
    {
        Stopien UpsertStopien(Stopien stopien);
        IEnumerable<Stopien> GetStopnie();
        bool DeleteStopien(long stopienId);
        Stopien GetStopien(long stopienId);
    }
}
