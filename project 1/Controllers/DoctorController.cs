using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projecctclilnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private static List<Doctor> doctor = new List<Doctor> {
            new Doctor { Id = 1, Name = "david",Pone=0556761152,Email = "hi@email.com",Businesshours=7 } ,
            new Doctor { Id = 2, Name = "david",Pone=0556761152,Email = "hi@email.com",Businesshours=7 } ,
            new Doctor { Id = 3, Name = "david",Pone=0556761152,Email = "hi@email.com",Businesshours=7 } };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return doctor;
        }

        [HttpPost]
        public Doctor Post([FromBody] Doctor value)
        {
            doctor.Add(value);
            return value;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctor value)
        {
            var index = doctor.FindIndex(x => x.Id == id);
            doctor[index].Id = value.Id;
            doctor[index].Email = value.Email;
            doctor[index].Name = value.Name;
            doctor[index].Pone = value.Pone;
            doctor[index].Businesshours = value.Businesshours;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = doctor.FindIndex(x => x.Id == id);
            doctor.Remove(doctor[index]);
        }
    }
}
