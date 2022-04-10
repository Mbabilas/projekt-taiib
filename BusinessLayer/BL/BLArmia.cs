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
    public class BLArmia:IArmia
    {
        private readonly IUnitOfWork uow;
        public BLArmia(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public bool DeleteArmia(long armiaId)
        {
            if (armiaId <= default(int))
                throw new ArgumentException("Invalid armia id");

            var isremoved = uow.Armia.DeleteArmia(armiaId);
            if (isremoved)
                uow.Complete();

            return isremoved;
        }

        public Armia getArmia(long armiaId)
        {
                return uow.Armia.GetArmia(armiaId);
        }

        public IEnumerable<Armia> GetArmie()
        {
            return uow.Armia.GetArmie();
        }

        public Armia UpsertArmia(Armia armia)
        {
            if (armia == null)
                throw new ArgumentException("Invalid armia details");

            if (string.IsNullOrWhiteSpace(armia.Nazwa))
                throw new ArgumentException("Invalid armia name");

            var _armia = uow.Armia.GetArmia(armia.Id);
            if (_armia == null)
            {
                _armia = new Armia
                {
                    Nazwa = armia.Nazwa,
                    MozliwosciBojowe = armia.MozliwosciBojowe,
                    SilyLadowe = armia.SilyLadowe,
                    SilyMorskie = armia.SilyMorskie,
                    SilyPowietrzne = armia.SilyPowietrzne,
                    Bronie = armia.Bronie,
                    Zgloszenia=armia.Zgloszenia,
                    Dywizje=armia.Dywizje
                };
                uow.Armia.AddArmia(_armia);
            }
            else
            {
                _armia.Nazwa = armia.Nazwa;
            }

            uow.Complete();

            return _armia;
        }
    }
}
