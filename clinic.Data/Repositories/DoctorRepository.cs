using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Clinic.Core.Repositories;

namespace Clinic.Data.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private DataContext _context;

        public DoctorRepository(DataContext context)
        {
            _context = context;
        }
        public List<DoctorClass> GetDoctor()
        {
            return _context.List_doctor.ToList();
        }
        public DoctorClass Add(DoctorClass doctor)
        {
            _context.List_doctor.ToList().Add(doctor);
            return doctor;
        }
    }
}
