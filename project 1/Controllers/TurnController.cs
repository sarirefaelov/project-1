using Microsoft.AspNetCore.Mvc;
using Clinic.Core.Services;
using Clinic.Service;
using Clinic.Core.Entities;

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
        public IEnumerable<TurnClass> Get()
        {
            return _TurnService.GetTurn();
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
            var index = _TurnService.GetTurn().FindIndex(x => x.Id == id);
            _TurnService.GetTurn()[index] = value;
            //var index = _TurnService.GetTurn().FindIndex(x => x.Id == id);
            //_TurnService.GetTurn()[index].Id = value.Id;
            //_TurnService.GetTurn()[index].NameDoctor = value.NameDoctor;
            //_TurnService.GetTurn()[index].Description = value.Description;
            //_TurnService.GetTurn()[index].IdClient = value.IdClient;
            //_TurnService.GetTurn()[index].IdDoctor = value.IdDoctor;
        }

        // DELETE api/<turnController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _TurnService.GetTurn().FindIndex(x => x.Id == id);
            _TurnService.GetTurn().Remove(_TurnService.GetTurn()[index]);
        }
    }
}
