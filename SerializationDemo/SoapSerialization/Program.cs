using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;


namespace SoapSerialization
{
    public class Program
    {
        static void Main(string[] args)
        {

            Student st = new Student
            {
                Roll = 123,
                Name = "Mohit",
                Gender = "Male",
                Mobile = "7888698233"

            };

            /*

            FileStream fs = new FileStream("C:\\Users\\Yogek.Garg\\Documents\\StudDataSOAP.txt", FileMode.Create, FileAccess.ReadWrite);
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, st);
            Console.WriteLine("Soap Serialization Completed");
            
            */

            FileStream fs = new FileStream("C:\\Users\\Yogek.Garg\\Documents\\StudDataSOAP.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter sf = new SoapFormatter();
            Student st1=(Student)sf.Deserialize(fs);
            Console.WriteLine(st1);
            
            Console.WriteLine("Soap deSerialization Completed");
            Console.ReadKey();


        }
    }
}
