using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Clinic.Core.Repositories;
using Clinic.Core.Services;
namespace Clinic.Service
{
    public class ClientcsService : IClientcsService
    {
        private IClientcsRepository _clientcsRepository;
        public ClientcsService(IClientcsRepository clientcsRepository)
        {
            _clientcsRepository = clientcsRepository;
        }
        public IEnumerable<ClientcsClass> GetPatient()
        {
            return _clientcsRepository.GetPatient();
        }
        public ClientcsClass AddPatient(ClientcsClass patient)
        {
            //var patients = _clientcsRepository.GetPatient();
            //var exist = patients.Contains(patient);
            //if (exist)
            //{
            //    return new ClientcsClass();
            //}
            return _clientcsRepository.Add(patient);
        }
        //public bool IsExist(ClientcsClass patient)
        //{
        //    var patients = _clientcsRepository.GetPatient();
        //    var exist = patients.Contains(patient);
        //    if (exist)
        //        return false;
        //    return true;
        //}
    }
}
