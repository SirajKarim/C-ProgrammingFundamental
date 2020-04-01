using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {   // (e) distance //
            Console.WriteLine("v1 velocity");
            int initialVelocity = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("time");
            int time = Convert.ToInt16(Console.ReadLine());
            int a = initialVelocity * time;
            Console.WriteLine("acc");
            int acc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("time1");
            int time1 = Convert.ToInt32(Console.ReadLine());
            int squreT = (int)Math.Pow(time1, 2);
            int b = acc * squreT;
            double distance = a + (0.5 * b);
            Console.WriteLine("Distance "+distance);





        }
    }
}
