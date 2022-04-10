using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkUOW
{
    public interface IUnitOfWork
    {
        IArmiaRepository Armia { get; }
        IBronRepository Bron { get; }
        IDywizjaRepository Dywizja { get; }
        IModelRepository Model { get; }
        IStopienRepository Stopien { get; }
        IZgloszenieRepository Zgloszenie { get; }
        IZolnierzRepository Zolnierz { get; }
        Task<int> CompleteAsync();
        int Complete();
    }
}
