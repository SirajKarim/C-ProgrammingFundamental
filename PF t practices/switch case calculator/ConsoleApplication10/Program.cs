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
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case '+':
                    Console.WriteLine(a + b);
                    break;
            
             case'-':
                Console.WriteLine(a-b);
                break;
                case'/':
                Console.WriteLine(a/b);
                break;
                case'*':
                Console.WriteLine(a*b);
                break;
                default:
                Console.WriteLine("error");
                break;
            }




        }
    }
}
