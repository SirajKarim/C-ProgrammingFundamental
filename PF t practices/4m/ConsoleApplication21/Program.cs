using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {   // (m) finf out the percentage of chemical compound //
            Console.WriteLine("enter no of moles");
            double molesValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter molar mass of an element");
            double elementMassValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter molar mass of compound");
            double compoundMassValue = Convert.ToDouble(Console.ReadLine());
            double a = molesValue * elementMassValue;
            double b = a / compoundMassValue;
            double c=b*100;
            Console.WriteLine("the % of compound is "+c + "%");




        }
    }
}
