using Microsoft.AspNetCore.Mvc;
using project_1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projecctclilnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clientcs : ControllerBase
    {
        public readonly DataContext _Patient;
        public Clientcs(DataContext patient)
        {
            _Patient = patient;
        }
        // GET: api/<patientController>
        [HttpGet]
        public IEnumerable<ClientcsClass> Get()
        {
            return _Patient.List_patient;
        }
        // POST api/<patientController>
        [HttpPost]
        public ClientcsClass Post([FromBody] ClientcsClass value)
        {
            _Patient.List_patient.Add(value);
            return value;
        }

        // PUT api/<patientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClientcsClass value)
        {
            var index = _Patient.List_patient.FindIndex(x => x.Id == id);
            _Patient.List_patient[index].Id = value.Id;
            _Patient.List_patient[index].Email = value.Email;
            _Patient.List_patient[index].Name = value.Name;
            _Patient.List_patient[index].Phone = value.Phone;
            _Patient.List_patient[index].City = value.City;
            _Patient.List_patient[index].Address = value.Address;

        }

        // DELETE api/<patientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _Patient.List_patient.FindIndex(x => x.Id == id);
            _Patient.List_patient.Remove(_Patient.List_patient[index]);
        }
    }
}
