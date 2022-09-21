using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JsonSerialisationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-> note we need to add System.Runtime.Serialization and System.Runtime.Serialization.Formatter.SOAP
            Employee employee = new Employee()
            {
                EId=345,
                EName="Yogek",
                ESalary="450000"
            };

            //FileStream
            FileStream fs = new FileStream("C:\\Users\\Yogek.Garg\\Documents\\fileoutput.json",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            DataContractJsonSerializer empjson= new DataContractJsonSerializer(typeof(Employee));
            empjson.WriteObject(fs, employee);

            Console.WriteLine("JSON Serialization Complete");
            Console.ReadLine();

        }
    }
}
