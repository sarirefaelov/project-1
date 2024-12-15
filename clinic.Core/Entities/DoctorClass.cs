using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Entities
{
    public class DoctorClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
        public int Businesshours { get; set; }
        public List <ClientcsClass> Clientcs { get; set; }
        public List<TurnClass> Turns { get; set; }

    }
}
