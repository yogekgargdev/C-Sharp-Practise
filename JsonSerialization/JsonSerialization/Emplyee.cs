using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialization
{
    [DataContract]
    public class Emplyee
    {
        [DataMember(Name ="Employee ID")]
        public int EID { get; set; }

        [DataMember(Name = "Employee Name")]
        public string EName { get; set; }

        [DataMember(Name = "Employee Salary")]
        public float ESalary { get; set; }  


    }
}
