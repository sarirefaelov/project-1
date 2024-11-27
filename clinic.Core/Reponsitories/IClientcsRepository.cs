using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;

namespace Clinic.Core.Repositories
{
    public interface IClientcsRepository
    {
        public List<ClientcsClass> GetPatient();
        public ClientcsClass Add(ClientcsClass patient);
    }
}
