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
    [Route("api/Bron")]
    [ApiController]
    public class BronController : ControllerBase
    {
        private readonly IBron blBron;

        public BronController(IBron bron)
        {
            this.blBron = bron;
        }
        // GET: api/Bron
        [HttpGet]
        public IEnumerable<Bron> Get()
        {
            var bronie = blBron.GetBronie();
            return bronie;
        }

        [HttpGet]
        public Bron Get(long bronId)
        {
            var bron = blBron.getBron(bronId);
            return bron;
        }

        // POST: api/Bron
        [HttpPost]
        public void Post([FromBody] Bron bron)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
