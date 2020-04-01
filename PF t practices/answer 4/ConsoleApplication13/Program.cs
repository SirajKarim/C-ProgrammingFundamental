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
        {
            Console.WriteLine("enter number");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = 2;
            
            if (a % b == 0 && a >= 1)
            { Console.WriteLine("positive even"); }
            else if (a % b == 1 && a >= 1)
            { Console.WriteLine("positive odd"); }
            else if (a % b == 0 && a <= -1)
            { Console.WriteLine("negitive even"); }
            else if (a % b == -1 && a <= -1)
            { Console.WriteLine("negitive odd"); }
            else if (a==0)
            { Console.WriteLine("zero"); }

        }
    }
}
