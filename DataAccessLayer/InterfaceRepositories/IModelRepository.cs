using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IModelRepository
    {
        void AddModel(Model model);
        IEnumerable<Model> GetModele();
        bool DeleteModel(long modelId);
        Model GetModel(long Id);
    }
}
