using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IArmiaRepository
    {
        void AddArmia(Armia armia);
        Armia GetArmia(long id);
        IEnumerable<Armia> GetArmie();
        bool DeleteArmia(long armiaId);
    }
}
