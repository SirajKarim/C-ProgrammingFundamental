using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sherry
{
    class Program
    {
        static void Main(string[] args)
        {
            //top//
            for (int i = 1; i <=5; i++)
            {
                for (int j = 6; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }













            // down//
            for (int i = 1; i <=7; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 7; k>i; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
