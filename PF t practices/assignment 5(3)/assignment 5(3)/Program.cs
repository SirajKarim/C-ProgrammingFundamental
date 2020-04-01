using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_5_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int space = 5; space >= i; space--)
                { Console.Write(" "); }
               

                for (int n = 1; n <= 2 * i - 1; n++)
                { Console.Write(n); }
                Console.WriteLine();
            }
           
            for (int i = 1; i <= 2; i++)
            {
                for (int space = -2; space <= i; space++)
                { Console.Write(" "); }
                int l = 1;
                for (int n = 3; n >= 2 * i - 1; n--)
                { Console.Write(l); l++; }
                { Console.WriteLine(); }
            }
            for (int i = 1; i <= 11; i++)
            {
                for (int k = 1; k < i; k++)
                { Console.Write(" "); }

                for (int m = 11; m >= 2 * i - 1; m--)
                { Console.Write("*"); }
                { Console.Write("\n"); }

            }
        }
    }
}
