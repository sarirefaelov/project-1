using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projecctclilnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {
        private static List<Turn> turn = new List<Turn> {
    new Turn
    {
        Id = 1,
        NameDoctor = "SARA",
        IdDoctor = 88,
        NameClient = "DDD",
        IdClient = 99,
        Description = "88",
        Date = DateTime.Parse("2024-11-05T20:19:30.157Z"), 
        Starttime = DateTime.Parse("2024-11-05T20:19:30.157Z"),
        Endtime = DateTime.Parse("2024-11-05T20:19:30.157Z") 
    }
};
        //GET: api/<turnController>
        [HttpGet]
        public IEnumerable<Turn> Get()
        {
            return turn;
        }
        // POST api/<turnController>
        [HttpPost]
        public Turn Post([FromBody] Turn value)
        {
            turn.Add(value);
            return value;
        }

        // PUT api/<turnController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Turn value)
        {
            var index = turn.FindIndex(x => x.Id == id);
            turn[index].Id = value.Id;
            turn[index].NameDoctor = value.NameDoctor;
            turn[index].Description = value.Description;
            turn[index].IdClient = value.IdClient;
            turn[index].IdDoctor = value.IdDoctor;
        }

        // DELETE api/<turnController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = turn.FindIndex(x => x.Id == id);
            turn.Remove(turn[index]);
        }
    }
}
