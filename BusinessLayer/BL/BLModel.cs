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
    public class BLModel : IModel
    {
        private readonly IUnitOfWork uow;
        public BLModel(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public bool DeleteModel(long modelId)
        {
            if (modelId <= default(int))
                throw new ArgumentException("Invalid model id");

            var isremoved = uow.Model.DeleteModel(modelId);
            if (isremoved)
                uow.Complete();

            return isremoved;
        }

        public IEnumerable<Model> GetModele()
        {
            return uow.Model.GetModele();
        }
        public Model GetModel(long modelId)
        {
            return uow.Model.GetModel(modelId);
        }

        public Model UpsertModel(Model model)
        {
            if (model == null)
                throw new ArgumentException("Invalid armia details");

            if (string.IsNullOrWhiteSpace(model.Przeznaczenie))
                throw new ArgumentException("Invalid model przeznaczenie");

            var _model = uow.Model.GetModel(model.Id);
            if (_model == null)
            {
                _model = new Model
                {
                    Przeznaczenie = model.Przeznaczenie,
                    Typ = model.Typ,
                    Mnoznik = model.Mnoznik,
                    Bronie=model.Bronie
                };
                uow.Model.AddModel(_model);
            }
            else
            {
                _model.Przeznaczenie = model.Przeznaczenie;
            }

            uow.Complete();

            return _model;
        }
    }
    }

