using Microsoft.AspNetCore.Mvc;
using Clinic.Core.Entities;
using Clinic.Core.Services;
using Clinic.Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clientcs : ControllerBase
    {
        private IClientcsService _ClientcsService;
        public Clientcs(IClientcsService clientcsService)
        {
            _ClientcsService = clientcsService;
        }
        [HttpGet]
        public IEnumerable<ClientcsClass> Get()
        {
            return _ClientcsService.GetPatient();
        }
        // GET api/<Client>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        // POST api/<patientController>
        [HttpPost]
        public ClientcsClass Post([FromBody] ClientcsClass value)
        {
            _ClientcsService.AddPatient(value);
            return value;
            //var client= _ClientcsService.AddPatient(value);
            //if(client.Id)
            //_ClientcsService.List_patient.Add(value);
            //return value;

        }

        // PUT api/<patientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClientcsClass value)
        {
            var index = _ClientcsService.GetPatient().FindIndex(x => x.Id == id);
            _ClientcsService.GetPatient()[index] = value;

            //var index = _ClientcsService.GetPatient().FindIndex(x => x.Id == id);
            //_ClientcsService.GetPatient()[index].Id = value.Id;
            //_ClientcsService.GetPatient()[index].Email = value.Email;
            //_ClientcsService.GetPatient()[index].Name = value.Name;
            //_ClientcsService.GetPatient()[index].Phone = value.Phone;
            //_ClientcsService.GetPatient()[index].City = value.City;
            //_ClientcsService.GetPatient()[index].Address = value.Address;

        }

        // DELETE api/<patientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _ClientcsService.GetPatient().FindIndex(x => x.Id == id);
            _ClientcsService.GetPatient().RemoveAt(index);
        }
    }
}
