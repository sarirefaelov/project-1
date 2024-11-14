using Microsoft.AspNetCore.Mvc;
using project_1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projecctclilnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnClass : ControllerBase
    {
        public readonly DataContext _turn;
        public TurnClass(DataContext turn)
        {
            _turn = turn;
        }
        //GET: api/<turnController>
        [HttpGet]
        public IEnumerable<TurnClass> Get()
        {
            return _turn.List_turn;
        }
        // POST api/<turnController>
        [HttpPost]
        public TurnClass Post([FromBody] TurnClass value)
        {
            _turn.List_turn.Add(value);
            return value;
        }

        // PUT api/<turnController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TurnClass value)
        {
            var index = _turn.turn.FindIndex(x => x.Id == id);
            _turn.List_turn[index].Id = value.Id;
            _turn.List_turn[index].NameDoctor = value.NameDoctor;
            _turn.List_turn[index].Description = value.Description;
            _turn.turn[index].IdClient = value.IdClient;
            _turn.turn[index].IdDoctor = value.IdDoctor;
        }

        // DELETE api/<turnController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _turn.turn.FindIndex(x => x.Id == id);
            _turn.turn.Remove(_turn.turn[index]);
        }
    }
}
