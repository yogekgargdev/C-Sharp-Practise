using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFDemoDoctor
{
    [Table("DoctorTableEF")]
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get; set;}   
        public string name { get; set; }
        public string specialisation { get; set; }
        public string education { get; set; }
        public int yearsofexp { get; set; }

        [NotMapped]
        DoctorDBContext cdbc = null;

        public void InitialiseDBComp()
        {
            DbContextOptionsBuilder<DoctorDBContext> dbo = new DbContextOptionsBuilder<DoctorDBContext>();
            DbContextOptionsBuilder<DoctorDBContext> dbo1 = dbo.UseSqlServer("server=.;database=EFDBDemo;user id=sa;pwd=sa");
            DoctorDBContext cdbc = new DoctorDBContext(dbo1.Options);
            cdbc.Database.EnsureCreated(); //in case database does not exist it will create
            Console.WriteLine("Database Created Succesfully");
        }



    }
}
