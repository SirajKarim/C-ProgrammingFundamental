using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {   // find out how many meters are there in a mile //
            Console.WriteLine("enter your miles value");
            double mV = Convert.ToDouble(Console.ReadLine());
            double a = mV * 1609.34;
            Console.WriteLine("converted value "+a + "m");
        }
    }
}
