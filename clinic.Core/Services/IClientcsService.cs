using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;

namespace Clinic.Core.Services
{
    public interface IClientcsService
    {
        public List<ClientcsClass> GetPatient();
        public ClientcsClass AddPatient(ClientcsClass patient);
    }
}
