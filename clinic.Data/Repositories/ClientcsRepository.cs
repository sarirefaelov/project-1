using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Data.Repositories
{
    public class ClientcsRepository : IClientcsRepository
    {
        private DataContext _context;

        public ClientcsRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<ClientcsClass> GetPatient()
        {
            return _context.List_patient.Include(p => p.Doctors);
        }
        public ClientcsClass Add(ClientcsClass patient)
        {
            _context.List_patient.Add(patient);
            _context.SaveChanges();
            return patient;
        }
    }
}
