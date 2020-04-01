using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {  // (b) find out speed//
            Console.WriteLine("Distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Time");
            double time = Convert.ToDouble(Console.ReadLine());
            double b = distance / time;
            double c = distance % time;
            Console.WriteLine("speed "+ b + "remainder "+c); 

          
        }
    }
}
