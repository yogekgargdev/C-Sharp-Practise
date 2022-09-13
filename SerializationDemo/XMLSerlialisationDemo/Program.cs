using SoapSerialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerlialisationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student()
            {

                Roll = 456,
                Name = "Sachin",
                Gender = "Male",
                Mobile = "8097685213"
            };

            /*
            
            
            FileStream fs = new FileStream("C:\\Users\\Yogek.Garg\\Documents\\XMLDATA.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs= new XmlSerializer(typeof(Student));
            xs.Serialize(fs, s);
            Console.WriteLine("XML SERIALISATION COMPLETED");

            */
            
            
            

            FileStream fs = new FileStream("C:\\Users\\Yogek.Garg\\Documents\\XMLDATA.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            Student st1 = (Student)xs.Deserialize(fs);
            Console.WriteLine(st1);
            Console.WriteLine("XML de-SERIALISATION COMPLETED");
            
            

            Console.ReadLine();
        }
    }
}
