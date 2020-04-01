using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {//(c) findout acceleration//
            Console.WriteLine("Initial velocity");
                double initialVelocity=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final velocity");
            double finalVelocity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("time");
            int time = Convert.ToInt32(Console.ReadLine());
            double a = finalVelocity - initialVelocity;
            double b = a / time;
           

            Console.WriteLine("acceleration " + b);

        }
    }
}
