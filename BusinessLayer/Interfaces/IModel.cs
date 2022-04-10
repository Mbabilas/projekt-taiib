using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IModel
    {
        Model UpsertModel(Model model);
        IEnumerable<Model> GetModele();
        bool DeleteModel(long modelId);
        Model GetModel(long modelId);
    }
}
