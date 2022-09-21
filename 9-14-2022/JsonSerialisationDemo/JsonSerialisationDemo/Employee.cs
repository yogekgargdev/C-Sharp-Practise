using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialisationDemo
{
    [DataContract]
    public class Employee
    {
        [DataMember(Name ="Employee Id")]
        public int EId { get; set; }
        [DataMember(Name = "Employee Name")]
        public string EName { get; set; }

        [DataMember(Name = "Employee Salary")]
        public string ESalary { get; set; } 

    }
}   
