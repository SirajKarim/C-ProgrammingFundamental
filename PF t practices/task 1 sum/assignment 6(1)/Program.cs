using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_6_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1 sum of all values //
            int sum = 0;
            Console.WriteLine("input the length");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[a];
            for (int i = 1; i < a; i++)
            {
                Console.WriteLine("input any no");
                x[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + x[i];

            }


            Console.WriteLine("sum is " + sum);
            


        }
        }
    }

