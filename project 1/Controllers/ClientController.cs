using Microsoft.AspNetCore.Mvc;
using project_1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projecctclilnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientcsClass : ControllerBase
    {
        public readonly DataContext _Patient;
        public ClientcsClass(DataContext patient)
        {
            _Patient = patient;
        }
        // GET: api/<patientController>
        [HttpGet]
        public IEnumerable<ClientcsClass> Get()
        {
            return _Patient.patient;
        }
        // POST api/<patientController>
        [HttpPost]
        public ClientcsClass Post([FromBody] ClientcsClass value)
        {
            _Patient.patient.Add(value);
            return value;
        }

        // PUT api/<patientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClientcsClass value)
        {
            var index = _Patient.patient.FindIndex(x => x.Id == id);
            _Patient.patient[index].Id = value.Id;
            _Patient.patient[index].Email = value.Email;
            _Patient.patient[index].Name = value.Name;
            _Patient.patient[index].Pone = value.Pone;
            _Patient.patient[index].City = value.City;
            _Patient.patient[index].Address = value.Address;

        }

        // DELETE api/<patientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _Patient.patient.FindIndex(x => x.Id == id);
            _Patient.patient.Remove(_Patient.patient[index]);
        }
    }
}
