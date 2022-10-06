using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoDoctor
{
    public class DoctorDBContext: DbContext
    {
        public DoctorDBContext(DbContextOptions<DoctorDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Doctor> Doctors { get; set; }

    }
}
