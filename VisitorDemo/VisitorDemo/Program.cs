using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VisitorDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            VisitorManager vm = new VisitorManager();
            vm.ExportToCSV("C:\\Users\\Yogek.Garg\\Documents");
            vm.ImportFromCSV("C:\\Users\\Yogek.Garg\\Documents");

            Console.ReadKey();
        }
    }
}
