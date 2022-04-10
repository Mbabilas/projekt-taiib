using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IArmia
    {
        Armia UpsertArmia(Armia armia);
        IEnumerable<Armia> GetArmie();
        bool DeleteArmia(long armiaId);
        Armia getArmia(long armiaId);
    }
}
