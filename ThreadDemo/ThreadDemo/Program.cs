using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread; //-> Thread executing on main method

            //-> thread name needs to be initialised
            t.Name = "Main Thread";

            //->priority of thread can be changed
            t.Priority = ThreadPriority.Highest; //-> its basically an enum
            // managedthreadid cannot be altered

            Console.WriteLine($"Thread ID: {t.ManagedThreadId}");
            Console.WriteLine($"Thread Name: {t.Name}");
            Console.WriteLine($"Thread Priority: {t.Priority}");


            //-> controlling the execution of the thread
            for(int i=1;i<10;i++)
            {
                Thread.Sleep(1000); //-> MILLISECONDS PARAMETER, 1000 MILLISECOND EQUAL TO 1 SECOND
                Console.WriteLine(i);
            }

            //-> Thread abort cannot be resumed again, but suspened thread can be resumed again


            Console.ReadKey();

        }
    }
}
