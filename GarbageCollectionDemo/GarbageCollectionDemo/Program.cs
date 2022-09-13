using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p= new Player(123,"Saurav");
            Console.WriteLine(p);
            p = null;
         
            GC.Collect(); //-> desctructor wont work unless u put p=null;, bcoz it is having ref, garbage collection works on unreferced data
            Console.Read();
            //-> use ctrl+f5 

            // pls read about dispose method // GC.SupressFinalize()

        }
    }
}
