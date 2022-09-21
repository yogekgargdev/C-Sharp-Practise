using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mobile = "";
            try
            {
                Console.WriteLine("Mobile Number please: ");
                mobile=Console.ReadLine();
                Program p = new Program();
                if(p.Validate(mobile))
                {
                    Console.WriteLine("Valid Mobile Number");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadKey();

        }

        public bool Validate(String mobile)
        {
            /*
            //Regex objNotIntPattern = new Regex("^[0 - 9]{10}$");
            if (Regex.IsMatch(mobile, "^[0 - 9]{10}$"))
            {
                return true;
            }
            else
            {

                throw new Exception("Invalid Mobile Number");
            }
            */
            Regex r = new Regex("^[0-9]{10}$");
            Match m=r.Match(mobile);
            if(m.Success)
            {
                return true;
            }
            else
            {
                throw new Exception("Invalid Mobile Number");

            }
        }
    }
}
