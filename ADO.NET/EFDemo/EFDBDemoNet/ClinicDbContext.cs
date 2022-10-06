
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFDBDemoNet
{
    public class ClinicDbContext : DbContext
    {
        public ClinicDbContext() : base()
        {

        }
        public DbSet<Medicine> Medicines { get; set; }
    }
}
