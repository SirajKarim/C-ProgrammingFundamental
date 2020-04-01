using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_for_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = a; a >= 1; a--)
            {
                for (int s = i; s >= a; s--)
                { Console.Write(" "); }
                for (int k = 1; k <= 2 * a - 1; k++)
                { Console.Write("*"); }
                Console.WriteLine();

                //    Console.WriteLine();
                //    int a = Convert.ToInt32(Console.ReadLine());
                //for (r = a; a >= 1; a--)
                //{
                //    for (s = r;s >=a ; s--)
                //    {
                //        Console.Write(" ");

                //    }
                //    for (c = 1  ;c <=2*a-1 ; c++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();

                //}
            }
        }
    }
}