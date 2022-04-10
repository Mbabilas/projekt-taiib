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
    [Route("api/Stopien")]
    [ApiController]
    public class StopienController : ControllerBase
    {
        private readonly IStopien blStopien;

        public StopienController(IStopien stopien)
        {
            this.blStopien = stopien;
        }
        // GET: api/Stopien
        [HttpGet]
        public IEnumerable<Stopien> Get()
        {
            var stopnie = blStopien.GetStopnie();
            return stopnie;
        }

        [HttpGet]
        public Stopien Get(long stopienId)
        {
            var stopien = blStopien.GetStopien(stopienId);
            return stopien;
        }

        // POST: api/Stopien
        [HttpPost]
        public void Post([FromBody] Stopien stopien)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
