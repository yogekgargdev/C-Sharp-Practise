using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student
            {
                Roll = 123,
                Name = "Ram Verma",
                Gender = "Male",
                Mobile = "7888698233"

            };
            /*
            FileStream fs = new FileStream("C:\\Users\\Yogek.Garg\\Documents\\StudData.txt",FileMode.Create,FileAccess.ReadWrite);
            //-> in case you want to read the data use FileMode.OpenOrCreate insted of FileMode.Create
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, s);
            Console.WriteLine("Data Serialized");
            fs.Flush();
            fs.Close();
            */

            FileStream fs = new FileStream("C:\\Users\\Yogek.Garg\\Documents\\StudData.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //-> in case you want to read the data use FileMode.OpenOrCreate insted of FileMode.Create
            BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, s);
            //Console.WriteLine("Data Serialized");
            Student st= (Student)bf.Deserialize(fs);
            Console.WriteLine("Data Deserialized");
            Console.WriteLine(st);

            fs.Flush();
            fs.Close();
            Console.Read();
        }
    }
}
