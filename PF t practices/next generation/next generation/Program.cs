using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace next_generation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 3 ; i++)
            {
                int b = a%10;
                int c = a / 10;
                int d = a + b + c;
                Console.WriteLine(a + "+" + b + "+" + c + "=" + d);
                a = d;
            }

        }
    }
}
