﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.PrintData();
            Console.ReadKey();

        }

        public async Task PrintData()
        {
            int result = 5;
            result=await GetData();
            //result = t.Result;  
            Console.WriteLine($"Retured Data is: {result}");
        }

        public Task<int> GetData()
        {
            Task.Delay(5000).Wait();
            return Task.FromResult(45);
        }

    }
}
