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
    public class BLZolnierz : IZolnierz
    {
        private readonly IUnitOfWork uow;
        public BLZolnierz(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public bool DeleteZolnierze(long zolnierzeId)
        {
            if (zolnierzeId <= default(int))
                throw new ArgumentException("Invalid zolnierz id");

            var isremoved = uow.Zolnierz.DeleteZolnierz(zolnierzeId);
            if (isremoved)
                uow.Complete();

            return isremoved;
        }
        public Zolnierz GetZolnierz(long zolnierzId)
        {
            return uow.Zolnierz.GetZolnierz(zolnierzId);
        }
        public IEnumerable<Zolnierz> GetZolnierze()
        {
            return uow.Zolnierz.GetZolnierze();
        }

        public Zolnierz UpsertZolnierz(Zolnierz zolnierz)
        {
            if (zolnierz == null)
                throw new ArgumentException("Invalid zolnierz details");

            if (string.IsNullOrWhiteSpace(zolnierz.Imie)&& string.IsNullOrWhiteSpace(zolnierz.Nazwisko))
                throw new ArgumentException("Invalid zolnierz imie nazwisko");

            var _zolnierz = uow.Zolnierz.GetZolnierz(zolnierz.Id);
            if (_zolnierz == null)
            {
                _zolnierz = new Zolnierz
                {
                    Imie=zolnierz.Imie,
                    Nazwisko=zolnierz.Nazwisko,
                    DataUrodzenia=zolnierz.DataUrodzenia,
                    MiejsceUrodzenia=zolnierz.MiejsceUrodzenia,
                    Pesel=zolnierz.Pesel,
                    Dywizja=zolnierz.Dywizja,
                    Stopien=zolnierz.Stopien
                };
                uow.Zolnierz.AddZolnierz(_zolnierz);
            }
            else
            {
                _zolnierz.Imie = zolnierz.Imie;
                _zolnierz.Nazwisko = zolnierz.Nazwisko;
            }

            uow.Complete();

            return _zolnierz;
        }
    }
}
