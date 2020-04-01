using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i; j++)
                { Console.Write(" "); }
                for (int k = 7; k >= 2 * i - 1; k--)
                { Console.Write("*"); }
                Console.WriteLine();

            }
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");}
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {

                        Console.Write("*");
                    }
                     Console.WriteLine(); 



                }


            }
        }
    }


