using Microsoft.AspNetCore.Mvc;
using project_1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projecctclilnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Doctor : ControllerBase
    {
        private readonly DataContext _doctor;

        public Doctor(DataContext dataDoctor)
        {
            _doctor = dataDoctor;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<DoctorClass> Get()
        {
            return _doctor.List_doctor;
        }

        [HttpPost]
        public DoctorClass Post([FromBody] DoctorClass value)
        {
            _doctor.List_doctor.Add(value);
            return value;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DoctorClass value)
        {
            var index = _doctor.List_doctor.FindIndex(x => x.Id == id);
            _doctor.List_doctor[index].Id = value.Id;
            _doctor.List_doctor[index].Email = value.Email;
            _doctor.List_doctor[index].Name = value.Name;
            _doctor.List_doctor[index].Phone = value.Phone;
            _doctor.List_doctor[index].Businesshours = value.Businesshours;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _doctor.List_doctor.FindIndex(x => x.Id == id);
            _doctor.List_doctor.Remove(_doctor.List_doctor[index]);
        }
    }
}
