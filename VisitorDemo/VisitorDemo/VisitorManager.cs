using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDemo
{
    public class VisitorManager
    {
        List<Visitor> visitors = new List<Visitor>()
        {
            new Visitor(1,"Yogek Garg","Male","Punjab","Panchanan","Job","7888698233"),
            new Visitor(2,"Panchanan","Male","Kolkata","Yogek Garg","Job","7242982334"),
            new Visitor(3,"Raju","Male","Gujrat","Prem","Job","7888698256"),
            new Visitor(4,"Abhishek","Male","Bihar","Tata","Job","7328258233"),
            new Visitor(5,"Koyel","Female","Punjab","Panchanan","Job","7238698233"),
            new Visitor(6,"Piyali","Female","Kolkata","Panchanan","Job","78886369233"),
            new Visitor(7,"Shaishvi","Female","Punjab","Yogek","Job","7888898233"),
            new Visitor(8,"Madhav","Male","Delhi","Panchanan","Job","7888827833"),
            new Visitor(9,"Shreya","Female","Punjab","Panchanan","Job","7888623233"),
            new Visitor(10,"Nidhi","Female","Himachal","Yogek","Job","7881098233"),

        };

        public void ExportToCSV(String path)
        {
            FileStream fs = new FileStream(path + "\\Visitor.csv", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Id,Name,Gender,Comfrom,WhomToMeet,Purpose,Mobile");
            foreach (Visitor v in visitors)
            {
                sw.WriteLine(v.id + "," + v.name + "," + v.gender + "," + v.comefrom + "," + v.whometomeet + "," + v.purpose + "," + v.mobile);

            }
            sw.Close();

        }

        public void ImportFromCSV(String path)
        {
            FileStream fs = new FileStream(path + "\\Visitor.csv", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            //Console.WriteLine("Id\tName\tGender\tComfrom\tWhomToMeet\tPurpose\t\tMobile");
            Console.WriteLine(reader.ReadToEnd());

        }

    }
}
