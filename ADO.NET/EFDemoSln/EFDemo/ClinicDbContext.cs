using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    public class ClinicDbContext : DbContext
    {
        public ClinicDbContext(DbContextOptions<ClinicDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Medicine> Medicines { get; set; }
    }
}
