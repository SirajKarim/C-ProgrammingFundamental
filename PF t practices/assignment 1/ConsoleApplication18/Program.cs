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
            int s, r, c;
            int a = Convert.ToInt32(Console.ReadLine());
            for (r = a; a >= 1; a--)
            {
                for (s = r;s >=a ; s--)
                {
                    Console.Write(" ");
                    
                }
                for (c = 1  ;c <=2*a-1 ; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
        

            }
        }
               
    }

