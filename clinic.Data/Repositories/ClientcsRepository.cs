using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;

namespace Clinic.Data.Repositories
{
    public class ClientcsRepository : IClientcsRepository
    {
        private DataContext _context;

        public ClientcsRepository(DataContext context)
        {
            _context = context;
        }
        public List<ClientcsClass> GetPatient()
        {
            return _context.List_patient.ToList();
        }
        public ClientcsClass Add(ClientcsClass patient)
        {
            _context.List_patient.ToList().Add(patient);
            return patient;
        }
    }
}
