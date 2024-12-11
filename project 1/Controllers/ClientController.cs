using Microsoft.AspNetCore.Mvc;
using Clinic.Core.Entities;
using Clinic.Core.Services;
using Clinic.Service;
using System.Linq;
using System.Collections.Generic;

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
        public ActionResult<ClientcsClass> Get()
        {
            return Ok(_ClientcsService.GetPatient());
        }
        //GET api/<Client>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
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
            var index = _ClientcsService.GetPatient().ToList().FindIndex(x => x.Id == id);
            _ClientcsService.GetPatient().ToList()[index] = value;
        }

        // DELETE api/<patientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _ClientcsService.GetPatient().ToList().FindIndex(x => x.Id == id);
            _ClientcsService.GetPatient().ToList().RemoveAt(index);
        }
    }
}
