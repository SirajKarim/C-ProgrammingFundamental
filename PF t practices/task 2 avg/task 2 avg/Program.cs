using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_avg
{
    class Program
    {
        static void Main(string[] args)
        {
            //2nd task averages//
            int sum1=0;
            Console.WriteLine("input the length");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] x1 = new  int  [b];
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("input any no");
                x1[i] = Convert.ToInt32(Console.ReadLine());
                 sum1 = sum1+ x1[i];
               
            }
            int avg = sum1 / b;
            Console.WriteLine("avg is "+avg);

           
            }
        }
    }

