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
    public class BLDywizja : IDywizja
    {
        private readonly IUnitOfWork uow;
        public BLDywizja(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public bool DeleteDywizja(long dywizjaId)
        {
            if (dywizjaId <= default(int))
                throw new ArgumentException("Invalid dywizja id");

            var isremoved = uow.Dywizja.DeleteDywizja(dywizjaId);
            if (isremoved)
                uow.Complete();

            return isremoved;
        }
        public Dywizja getDywizja(long dywizjaId)
        {
            return uow.Dywizja.GetDywizja(dywizjaId);
        }
        public IEnumerable<Dywizja> GetDywizje()
        {
            return uow.Dywizja.GetDywizje();
        }

        public Dywizja UpsertDywizja(Dywizja dywizja)
        {
            if (dywizja == null)
                throw new ArgumentException("Invalid dywizja details");

            if (string.IsNullOrWhiteSpace(dywizja.Nazwa))
                throw new ArgumentException("Invalid dywizja name");

            var _dywizja = uow.Dywizja.GetDywizja(dywizja.Id);
            if (_dywizja == null)
            {
                _dywizja = new Dywizja
                {
                    Nazwa = dywizja.Nazwa,
                    MiejsceStacjonowania = dywizja.MiejsceStacjonowania,
                    Personel = dywizja.Personel,
                    Zolnierze=dywizja.Zolnierze,
                    Armia=dywizja.Armia
                };
                uow.Dywizja.AddDywizja(_dywizja);
            }
            else
            {
                _dywizja.Nazwa = dywizja.Nazwa;
            }

            uow.Complete();

            return _dywizja;
        }
    }
}
