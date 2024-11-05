using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projecctclilnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private static List<Patient> patient = new List<Patient> {
            new Patient { Id = 1, Name = "david",Pone=0556761152,Email = "hi@email.com",Address="rabi akiva",City="bny brk"} ,
            new Patient { Id = 2, Name = "david",Pone=0556761152,Email = "hi@email.com",Address="rabi akiva",City="bny brk"} ,
            new Patient { Id = 3, Name = "david",Pone=0556761152,Email = "hi@email.com",Address="rabi akiva",City="bny brk" } };
        // GET: api/<patientController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return patient;
        }
        // POST api/<patientController>
        [HttpPost]
        public Patient Post([FromBody] Patient value)
        {
            patient.Add(value);
            return value;
        }

        // PUT api/<patientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Patient value)
        {
            var index = patient.FindIndex(x => x.Id == id);
            patient[index].Id = value.Id;
            patient[index].Email = value.Email;
            patient[index].Name = value.Name;
            patient[index].Pone = value.Pone;
            patient[index].City = value.City;
            patient[index].Address = value.Address;

        }

        // DELETE api/<patientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = patient.FindIndex(x => x.Id == id);
            patient.Remove(patient[index]);
        }
    }
}
