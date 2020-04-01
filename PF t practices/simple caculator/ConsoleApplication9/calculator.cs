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
        {
            x:
            Console.WriteLine("enter no:1");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter no:2");
            double b= Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("enter any operator");
            char d = Convert.ToChar(Console.ReadLine());
            if (d == '-')
            {
                Console.WriteLine(a - b);
            }
            else if (d == '+')
            { Console.WriteLine(a + b); }
            else if (d == '*')
            { Console.WriteLine(a * b); }

            else if (d == '/')
            { Console.WriteLine(a / b); }
            else
            {
                Console.WriteLine("abe ye kya karaha hy pagal wagal to nhi hogaya");
            }
            goto x;
        }
    }
}
