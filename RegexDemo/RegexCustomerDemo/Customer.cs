using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexCustomerDemo
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }  
        public string LastName { get; set; }
        public string email { get; set; }   
        public string mobile { get; set; }

        private string input = "";

        public void CustomerDetails()
        {
            bool flag = false;
            //-> FirstName
            while(!flag)
            {
                Console.WriteLine("Enter First Name");
                input = Console.ReadLine();
                flag = NameValidate(input);
                if(flag== true)
                {
                    FirstName = input;
                    flag= false;
                    break;
                }

            }

            //-> MiddleName
            while (!flag)
            {
                Console.WriteLine("Enter Middle Name");
                input = Console.ReadLine();
                flag = NameValidate(input);
                if (flag == true)
                {
                    MiddleName = input;
                    flag = false;
                    break;
                }

            }

            //-> LastName
            while (!flag)
            {
                Console.WriteLine("Enter Last Name");
                input = Console.ReadLine();
                flag = NameValidate(input);
                if (flag == true)
                {
                    LastName = input;
                    flag = false;
                    break;
                }

            }
            /*
            //-> Email
            while (!flag)
            {
                Console.WriteLine("Enter Email");
                input = Console.ReadLine();
                flag = EmailValidate(input);
                if (flag == true)
                {
                    email = input;
                    flag = false;
                    break;
                }

            }
            */

            //-> Phone
            while (!flag)
            {
                Console.WriteLine("Enter Phone");
                input = Console.ReadLine();
                flag = PhoneValidate(input);
                if (flag == true)
                {
                    mobile = input;
                    flag = false;
                    break;
                }

            }

        }

        public bool NameValidate(string inputgiven)
        {
           
            if (Regex.IsMatch(inputgiven, "^[A-Z]{1}[a-z]+$"))
            {
                return true;
            }

            return false;


        }

        public bool EmailValidate(string inputgiven)
        {

            if (Regex.IsMatch(inputgiven, "^[a-zA-Z0-9]+[@]{1}[a-z]+${.com}$"))
            {
                return true;
            }
            return false;
        }

        public bool PhoneValidate(string inputgiven)
        {

            if (Regex.IsMatch(inputgiven, "^[+]{1}[0-9]{2}\t[0-9]{10}$"))
            {
                return true;
            }
            return false;
        }




    }
}
