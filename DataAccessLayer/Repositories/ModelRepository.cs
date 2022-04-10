using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ModelRepository:IModelRepository
    {
        private readonly Database _database;
        public ModelRepository(Database database)
        {
            this._database = database;
        }

        public void AddModel(Model model)
        {
            _database.Modele.Add(model);
        }

        public bool DeleteModel(long modelId)
        {
            var removed = false;
            Model model = GetModel(modelId);

            if (model != null)
            {
                removed = true;
                _database.Modele.Remove(model);
            }

            return removed;
        }

        public Model GetModel(long Id)
        {
            return _database.Modele.Where(u => u.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Model> GetModele()
        {
            return _database.Modele;
        }
    }
}
