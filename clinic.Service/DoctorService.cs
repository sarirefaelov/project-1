using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Clinic.Core.Repositories;
using Clinic.Core.Services;
namespace Clinic.Service
{
    public class DoctorService : IDoctorService
    {
        private IDoctorRepository _doctorRepository;
        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public IEnumerable<DoctorClass> GetDoctor()
        {
            return _doctorRepository.GetDoctor();
        }
        public DoctorClass AddDoctor(DoctorClass doctor)
        {
            //var doctors = _doctorRepository.GetDoctor();
            //var exist = doctors.Contains(doctor);
            //if (exist)
            //{
            //    return new DoctorClass();
            //}
            return _doctorRepository.Add(doctor);
        }
        //public bool IsExist(DoctorClass doctor)
        //{
        //    var doctors = _doctorRepository.GetDoctor();
        //    var exist = doctors.Contains(doctor);
        //    if (exist)
        //        return false;
        //    return true;
        //}
    }
}

