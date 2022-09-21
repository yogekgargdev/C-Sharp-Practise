using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameofDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 90;
            Console.WriteLine($"Inside {nameof(Main)} method of {nameof(Program)} class");
            Console.WriteLine($"The value of a is: {a}");
            Console.WriteLine($"The value of {nameof(a)} is: {a}");
            //-> note in case the name is very complex we can print the name of the variable like above
            //_> same can be extended to clases, structure etc;
            //-> above thing reduces human errror

            //-> Await try catch finally
            AwaitCatchFinally();



            Console.Read();
        }

        //-> await operator can only be used with async operator

        public async static void AwaitCatchFinally()
        {
            int x = 90, y = 0, z = 0;
            try
            {
                z = x / y;
            }
            catch (Exception ex)
            {
                var result1 = await LogError();


            }
            finally
            {
                var result2 = await LogInformation();
            }
        }

        public async static Task<bool> LogError()
        {
            //_> its async bcoz its on server so can take some time
            Console.WriteLine("Error logged in log files");
            Task.Delay(1000).Wait();
            return await Task.FromResult<bool>(true);

        }

        public async static Task<bool> LogInformation()
        {
            //_> its async bcoz its on server so can take some time
            Console.WriteLine("Information logged in log files");
            Task.Delay(1000).Wait();
            return await Task.FromResult<bool>(true);

        }
    }
}
