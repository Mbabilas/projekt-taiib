using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projektTAIIB.Controllers
{
    [Route("api/Model")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IModel blModel;

        public ModelController(IModel model)
        {
            this.blModel = model;
        }
        // GET: api/Model
        [HttpGet]
        public IEnumerable<Model> Get()
        {
            var modele = blModel.GetModele();
            return modele;
        }

        [HttpGet]
        public Model Get(long modelId)
        {
            var model = blModel.GetModel(modelId);
            return model;
        }

        // POST: api/Model
        [HttpPost]
        public void Post([FromBody] Model model)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
