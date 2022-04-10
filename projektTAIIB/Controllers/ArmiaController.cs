using AutoMapper;
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
    [Route("api/Armia")]
    [ApiController]
    public class ArmiaController : ControllerBase
    {
        private readonly IArmia blArmia;

        public ArmiaController(IArmia armia)
        {
            this.blArmia = armia;
        }
        // GET: api/Armia
        [HttpGet]
        public IEnumerable<Armia> Get()
        {
            var armie = blArmia.GetArmie();
            return armie;
        }

        [HttpGet]
        public Armia Get(long armiaId)
        {
            var armia = blArmia.getArmia(armiaId);
            return armia;
        }

        // POST: api/Armia
        [HttpPost]
        public void Post([FromBody] Armia armia)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
