using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In collection initialiser we dont use Add() method
            //List<string> list = new List<string>();
            //list.Add("One");
            //list.Add("Two");

            List<string> list = new List<string>() { "One","Two","Three"};

            foreach(var i in list)
            {
                Console.WriteLine(i);
            }

            //Dictionary<int,string> dct = new Dictionary<int, string>();
            //dct.Add(1, "One");
            //dct.Add(2, "Two");
            //dct.Add(3, "Three");

            Dictionary<int, string> dct = new Dictionary<int, string>() { { 1, "One" }, {2, "Two" }, {3, "Three" } };


            foreach (var v in dct)
            {
                Console.WriteLine(v.Key +": "+v.Value);
            }


            Doctor d = new Doctor();
            Console.WriteLine(d);

            Console.ReadLine();

        }
    }
}
