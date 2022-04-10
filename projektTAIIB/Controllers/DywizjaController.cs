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
    [Route("api/Dywizja")]
    [ApiController]
    public class DywizjaController : ControllerBase
    {
        private readonly IDywizja blDywizja;

        public DywizjaController(IDywizja dywizja)
        {
            this.blDywizja = dywizja;
        }
        // GET: api/Dywizja
        [HttpGet]
        public IEnumerable<Dywizja> Get()
        {
            var dywizje = blDywizja.GetDywizje();
            return dywizje;
        }

        [HttpGet]
        public Dywizja Get(long dywizjaId)
        {
            var dywizja = blDywizja.getDywizja(dywizjaId);
            return dywizja;
        }

        // POST: api/Armia
        [HttpPost]
        public void Post([FromBody] Dywizja dywizja)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
