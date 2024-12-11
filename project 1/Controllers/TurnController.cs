using Microsoft.AspNetCore.Mvc;
using Clinic.Core.Services;
using Clinic.Service;
using Clinic.Core.Entities;
using System.Linq;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Turn : ControllerBase
    {
        private ITurnService _TurnService;
        public Turn(ITurnService turnService)
        {
            _TurnService = turnService;
        }
        [HttpGet]
        public ActionResult<TurnClass> Get()
        {
            return Ok(_TurnService.GetTurn());
        }
        // GET api/<Turn>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        // POST api/<turnController>
        [HttpPost]
        public TurnClass Post([FromBody] TurnClass value)
        {
            _TurnService.AddTurn(value);
            return value;
        }

        // PUT api/<turnController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TurnClass value)
        {
            var index = _TurnService.GetTurn().ToList().FindIndex(x => x.Id == id);
            _TurnService.GetTurn().ToList()[index] = value;
        }

        // DELETE api/<turnController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _TurnService.GetTurn().ToList().FindIndex(x => x.Id == id);
            _TurnService.GetTurn().ToList().Remove(_TurnService.GetTurn().ToList()[index]);
        }
    }
}
