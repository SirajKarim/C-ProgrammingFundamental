using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {    //v1//
            Console.WriteLine("enter initial vel");
            double v1 = Convert.ToInt32(Console.ReadLine());
            // v2 //
            Console.WriteLine("enter final vel");
            double v2 = Convert.ToInt32(Console.ReadLine());
            double v = v1 + v2;
            double avg =( v / 2);
            Console.WriteLine("average velocity "+ avg);

            
        }
    }
}
