using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_quetion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5;i++ )
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2*i-1; k++)
                {
                    if (k == 1 || k == 3 || k == 5 || k == 7 || k == 9)
                    { Console.Write("0"); }
                    else
                    { Console.Write("1"); }
                }
                Console.WriteLine();
            }
            
        }
    }
}
