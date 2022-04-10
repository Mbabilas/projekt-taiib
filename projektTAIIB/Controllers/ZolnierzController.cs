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
    [Route("api/Zolnierz")]
    [ApiController]
    public class ZolnierzController : ControllerBase
    {
        private readonly IZolnierz blZolnierz;

        public ZolnierzController(IZolnierz zolnierz)
        {
            this.blZolnierz = zolnierz;
        }
        // GET: api/Zolnierz
        [HttpGet]
        public IEnumerable<Zolnierz> Get()
        {
            var zolnierze = blZolnierz.GetZolnierze();
            return zolnierze;
        }

        [HttpGet]
        public Zolnierz Get(long zolnierzId)
        {
            var zolnierz = blZolnierz.GetZolnierz(zolnierzId);
            return zolnierz;
        }

        // POST: api/Zolnierz
        [HttpPost]
        public void Post([FromBody] Zolnierz zolnierz)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
