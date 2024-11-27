using Microsoft.AspNetCore.Mvc;
using Clinic.Core.Services;
using Clinic.Service;
using Clinic.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Doctor : ControllerBase
    {
        private IDoctorService _DoctorService;
        public Doctor(IDoctorService doctorService)
        {
            _DoctorService = doctorService;
        }
        [HttpGet]
        public IEnumerable<DoctorClass> Get()
        {
            return _DoctorService.GetDoctor();
        }
        // GET api/<Doctor>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        [HttpPost]
        public DoctorClass Post([FromBody] DoctorClass value)
        {
            _DoctorService.AddDoctor(value);
            return value;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DoctorClass value)
        {
            var index = _DoctorService.GetDoctor().FindIndex(x => x.Id == id);
            _DoctorService.GetDoctor()[index] = value;

            //_DoctorService.GetDoctor()[index].Id = value.Id;
            //_DoctorService.GetDoctor()[index].Email = value.Email;
            //_DoctorService.GetDoctor()[index].Name = value.Name;
            //_DoctorService.GetDoctor()[index].Phone = value.Phone;
            //_DoctorService.GetDoctor()[index].Businesshours = value.Businesshours;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _DoctorService.GetDoctor().FindIndex(x => x.Id == id);
            _DoctorService.GetDoctor().RemoveAt(index);
        }
    }
}
