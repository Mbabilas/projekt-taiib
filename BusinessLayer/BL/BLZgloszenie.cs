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
    public class BLZgloszenie : IZgloszenie
    {
        private readonly IUnitOfWork uow;
        public BLZgloszenie(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public bool DeleteZgloszenie(long zgloszenieId)
        {
            if (zgloszenieId <= default(int))
                throw new ArgumentException("Invalid zgloszenie id");

            var isremoved = uow.Zgloszenie.DeleteZgloszenie(zgloszenieId);
            if (isremoved)
                uow.Complete();

            return isremoved;
        }
        public Zgloszenie GetZgloszenie(long zgloszenieId)
        {
            return uow.Zgloszenie.GetZgloszenie(zgloszenieId);
        }
        public IEnumerable<Zgloszenie> GetZgloszenia()
        {
            return uow.Zgloszenie.GetZgloszenia();
        }

        public Zgloszenie UpsertZgloszenie(Zgloszenie zgloszenie)
        {
            if (zgloszenie == null)
                throw new ArgumentException("Invalid zgloszenie details");

            if (string.IsNullOrWhiteSpace(zgloszenie.Imie)&& string.IsNullOrWhiteSpace(zgloszenie.Nazwisko))
                throw new ArgumentException("Invalid zgloszenie imie nazwisko");

            var _zgloszenie = uow.Zgloszenie.GetZgloszenie(zgloszenie.Id);
            if (_zgloszenie == null)
            {
                _zgloszenie = new Zgloszenie
                {
                    Imie=zgloszenie.Imie,
                    Nazwisko=zgloszenie.Nazwisko,
                    Kategoria=zgloszenie.Kategoria,
                    Plec=zgloszenie.Plec,
                    TypZgloszenia=zgloszenie.TypZgloszenia,
                    TrescZgloszenia=zgloszenie.TrescZgloszenia,
                    OrzeczenieLekarskie=zgloszenie.OrzeczenieLekarskie,
                    Zatwierdzony=zgloszenie.Zatwierdzony,
                    Armia=zgloszenie.Armia
                };
                uow.Zgloszenie.AddZgloszenie(_zgloszenie);
            }
            else
            {
                _zgloszenie.Imie = zgloszenie.Imie;
                _zgloszenie.Nazwisko = zgloszenie.Nazwisko;
            }

            uow.Complete();

            return _zgloszenie;
        }
    }
}
