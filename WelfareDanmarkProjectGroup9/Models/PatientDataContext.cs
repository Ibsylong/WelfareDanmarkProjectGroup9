using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WelfareDanmarkProjectGroup9.Models
{
    public class PatientDataContext:DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public PatientDataContext(DbContextOptions<PatientDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
