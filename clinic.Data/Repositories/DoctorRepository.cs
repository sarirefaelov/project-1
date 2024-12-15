using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Clinic.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Data.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private DataContext _context;

        public DoctorRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<DoctorClass> GetDoctor()
        {
            return _context.List_doctor.Include(p => p.Clientcs); ;
        }
        public DoctorClass Add(DoctorClass doctor)
        {
            _context.List_doctor.Add(doctor);
            _context.SaveChanges();
            return doctor;
        }
    }
}
