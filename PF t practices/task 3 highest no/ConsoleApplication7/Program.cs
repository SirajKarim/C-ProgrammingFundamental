using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {  // task highest no in an array
            int  n, max;
            Console.WriteLine("enter the lenght of an array: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            max = 0;
            for (int i = 0; i <n; i++)
            {
                Console.WriteLine("input number " + i);
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (max<num[i])
                {
                    max = num[i];
                }

            }
            Console.WriteLine("maximum no is :  "+max);
        }
    }
}
