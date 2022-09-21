using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace JsonSerialization
{
     public class Program
    {
        static void Main(string[] args)
        {
            //note u need to add reference in assemblies -> system.runtime.Serialization, System.Runtime.Serialization.Formatter.SOAP

            //Emplyee em = new Emplyee
            //{
            //    EID = 123,
            //    EName = "Somanth Verma",
            //    ESalary = 45000.0f
            //};

            //FileStream fs = new FileStream("C:\\Users\\Yogek.Garg\\Documents\\JSONSerializationfile.json",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            //DataContractJsonSerializer empjson = new DataContractJsonSerializer(typeof(Emplyee));
            //empjson.WriteObject(fs, em);

            //Console.WriteLine("Employee Data Serialized to JSON file...");
            //Console.ReadKey

            //-> reading json data
            //FileStream fs = new FileStream("C:\\Users\\Yogek.Garg\\Documents\\JSONSerializationfile.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //DataContractJsonSerializer empjson = new DataContractJsonSerializer(typeof(Emplyee));
            //var e1=(Emplyee)empjson.ReadObject(fs);
            //Console.WriteLine("Name: "+e1.EName+"\tEID: "+e1.EID+"\tSalary: "+e1.ESalary);
            //Console.ReadKey();


            //Emplyee em = new Emplyee
            //{
            //    EID = 123,
            //    EName = "Somanth Verma",
            //    ESalary = 45000.0f
            //};

            //MemoryStream msObj = new MemoryStream();
            //DataContractJsonSerializer empjson = new DataContractJsonSerializer(typeof(Emplyee));
            //empjson.WriteObject(msObj, em);
            //msObj.Position = 0;
            //StreamReader sr = new StreamReader(msObj);

            //string json = sr.ReadToEnd();
            //Console.WriteLine(json);

            //sr.Close();
            //msObj.Close();
            //Console.ReadKey();

            Emplyee em = new Emplyee
            {
                EID = 123,
                EName = "Somanth Verma",
                ESalary = 45000.0f
            };


            using (var ms= new MemoryStream())
            {
                DataContractJsonSerializer empjson = new DataContractJsonSerializer(typeof(Emplyee));
                empjson.WriteObject(ms, em);
                Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));

            }
            Console.ReadKey();



        }
    }
}
