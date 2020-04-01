using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_quetion
{
    class Program
    {
        static void Main(string[] args)
        {
            int j =1;
            int input=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <input ; i++)
            {
                int x = (2 * i) + j;
                for (int l = input; l > i; l--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= x; k++)
                {
                    if (k==1 || k==3 || k==5 || k==7 || k==9)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                   
                }
                Console.WriteLine();
            }
          

        }
    }
}
