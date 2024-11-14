using Microsoft.AspNetCore.Mvc;
using project_1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projecctclilnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorClass : ControllerBase
    {
        private readonly DataContext _doctor;

        public DoctorClass(DataContext dataDoctor)
        {
            _doctor = dataDoctor;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<DoctorClass> Get()
        {
            return _doctor.doctor;
        }

        [HttpPost]
        public DoctorClass Post([FromBody] DoctorClass value)
        {
            _doctor.doctor.Add(value);
            return value;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DoctorClass value)
        {
            var index = _doctor.doctor.FindIndex(x => x.Id == id);
            _doctor.doctor[index].Id = value.Id;
            _doctor.doctor[index].Email = value.Email;
            _doctor.doctor[index].Name = value.Name;
            _doctor.doctor[index].Pone = value.Pone;
            _doctor.doctor[index].Businesshours = value.Businesshours;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _doctor.doctor.FindIndex(x => x.Id == id);
            _doctor.doctor.Remove(_doctor.doctor[index]);
        }
    }
}
