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
    [Route("api/Zgloszenie")]
    [ApiController]
    public class ZgloszenieController : ControllerBase
    {
        private readonly IZgloszenie blZgloszenie;

        public ZgloszenieController(IZgloszenie zgloszenie)
        {
            this.blZgloszenie = zgloszenie;
        }
        // GET: api/Zgloszenie
        [HttpGet]
        public IEnumerable<Zgloszenie> Get()
        {
            var zgloszenia = blZgloszenie.GetZgloszenia();
            return zgloszenia;
        }

        [HttpGet]
        public Zgloszenie Get(long zgloszenieId)
        {
            var zgloszenie = blZgloszenie.GetZgloszenie(zgloszenieId);
            return zgloszenie;
        }

        // POST: api/Zgloszenie
        [HttpPost]
        public void Post([FromBody] Zgloszenie zgloszenie)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
