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
    public class BLBron : IBron
    {
        private readonly IUnitOfWork uow;
        public BLBron(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public Bron getBron(long bronId)
        {
            return uow.Bron.GetBron(bronId);
        }
        public bool DeleteBron(long bronId)
        {
            if (bronId <= default(int))
                throw new ArgumentException("Invalid bron id");

            var isremoved = uow.Bron.DeleteBron(bronId);
            if (isremoved)
                uow.Complete();

            return isremoved;
        }

        public IEnumerable<Bron> GetBronie()
        {
            return uow.Bron.GetBronie();
        }

        public Bron UpsertBron(Bron bron)
        {
            if (bron == null)
                throw new ArgumentException("Invalid bron details");

            var _bron = uow.Bron.GetBron(bron.Id);
            if (_bron == null)
            {
                _bron = new Bron
                {
                    Model=bron.Model,
                    Armia=bron.Armia,
                    WUzyciu=bron.WUzyciu
                };
                uow.Bron.AddBron(_bron);
            }

            uow.Complete();

            return _bron;
        }
    }
}
