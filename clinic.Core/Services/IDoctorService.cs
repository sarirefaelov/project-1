﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;

namespace Clinic.Core.Services
{
    public interface IDoctorService
    {
        public IEnumerable<DoctorClass> GetDoctor();
        public DoctorClass AddDoctor(DoctorClass doctor);

    }
}