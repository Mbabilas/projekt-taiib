using BusinessLayer.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkUOW;

namespace BusinessLayer.BL
{
    public class BLStopien : IStopien
    {
        private readonly IUnitOfWork uow;
        public BLStopien(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public bool DeleteStopien(long stopienId)
        {
            if (stopienId <= default(int))
                throw new ArgumentException("Invalid stopien id");

            var isremoved = uow.Stopien.DeleteStopien(stopienId);
            if (isremoved)
                uow.Complete();

            return isremoved;
        }
        public Stopien GetStopien(long stopienId)
        {
            return uow.Stopien.GetStopien(stopienId);
        }
        public IEnumerable<Stopien> GetStopnie()
        {
            return uow.Stopien.GetStopnie();
        }

        public Stopien UpsertStopien(Stopien stopien)
        {
            if (stopien == null)
                throw new ArgumentException("Invalid stopien details");

            if (string.IsNullOrWhiteSpace(stopien.Nazwa))
                throw new ArgumentException("Invalid stopien name");

            var _stopien = uow.Stopien.GetStopien(stopien.Id);
            if (_stopien == null)
            {
                _stopien = new Stopien
                {
                    Nazwa = stopien.Nazwa,
                    Oficerski=stopien.Oficerski,
                    Podoficerski=stopien.Podoficerski,
                    Generalski=stopien.Generalski,
                    Zolnierze=stopien.Zolnierze
                };
                uow.Stopien.AddStopien(_stopien);
            }
            else
            {
                _stopien.Nazwa = stopien.Nazwa;
            }

            uow.Complete();

            return _stopien;
        }
    }
}
