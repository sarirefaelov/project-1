
using Microsoft.AspNetCore.Mvc;
using Clinic.Core.Services;
using Clinic.Service;
using Clinic.Core.Entities;
using System.Collections.Generic;
using System.Linq; 
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
        public ActionResult<DoctorClass> Get()
        {
            return Ok(_DoctorService.GetDoctor());
        }

        [HttpPost]
        public DoctorClass Post([FromBody] DoctorClass value)
        {
            _DoctorService.AddDoctor(value);
            return value;
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DoctorClass value)
        {
            var doctorsList = _DoctorService.GetDoctor().ToList(); 
            var index = doctorsList.FindIndex(x => x.Id == id);
            if (index != -1) 
            {
                doctorsList[index] = value;
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var doctorsList = _DoctorService.GetDoctor().ToList(); // המרת IEnumerable לרשימה
            var index = doctorsList.FindIndex(x => x.Id == id);
            if (index != -1) // בדיקה אם נמצא אינדקס
            {
                doctorsList.RemoveAt(index);
                // אם את רוצה להתעדכן בשירות, תצטרכי להוסיף שיטה למחיקת רופא מהשירות
            }
        }
    }
}