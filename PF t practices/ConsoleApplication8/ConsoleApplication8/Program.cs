using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static string value(int [] paf2)
        {

            int n, max;
            Console.WriteLine("enter the lenght of an array: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            max = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("input number " + i);
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (max < num[i])
                {
                    max = num[i];
                }

            }
            return max;
        }
        static void Main()
        {

            int [] myarray = [1,3,4,2,5,7]
            int min = max(myarray);
            Console.WriteLine(min);
            
        }
    }
}
