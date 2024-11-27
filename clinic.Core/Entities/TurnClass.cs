using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Entities
{
    public class TurnClass
    {
        public int Id { get; set; }
        public string NameDoctor { get; set; }
        public int IdDoctor { get; set; }
        public string NameClient { get; set; }
        public int IdClient { get; set; }
        public string Description { get; set; }

        public DateTime Date;
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }
    }
}
