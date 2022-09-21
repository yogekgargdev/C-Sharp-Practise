using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;
using static System.IO.Directory;
using static System.IO.File;
namespace StringBuilderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Welcome to Solera for DotNet Developement");

            sb.AppendLine(" Sovik loves Anu");

          
            WriteLine(sb);

            //->USING STATIC FOR FILE DIRECTORY

            Write("Enter folder name: \t\t");
            String fname = ReadLine();
            if(Exists("C:\\Users\\Yogek.Garg\\Documents"+fname))
            {
                WriteLine("Folder already exists");

            }
            else
            {
                CreateDirectory("C:\\Users\\Yogek.Garg\\Documents" + fname);
                WriteLine("Folder Created");
            }




            ReadLine();

        }
    }
}
