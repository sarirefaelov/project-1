
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace Clinic.Data
{
    public class DataContext : DbContext
    {

        public DbSet<ClientcsClass> List_patient { get; set; }
        public DbSet<DoctorClass> List_doctor { get; set; }
        public DbSet<TurnClass> List_turn { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Clinic");
        }
        
    }
}

