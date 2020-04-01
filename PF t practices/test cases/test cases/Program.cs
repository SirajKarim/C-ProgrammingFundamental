using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_cases
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp = 2;
            Console.WriteLine("length of test ");
            int test = int.Parse(Console.ReadLine());
            while (test-->0)

            {
                Console.WriteLine("input in series");
                string a = Console.ReadLine();
                string[] arr = a.Split(' ');
              
                


                   int  b = int.Parse(arr[0]);
                   int  c = int.Parse(arr[1]);
                   int sum = b + c;

                   if (sum % tmp == 0)
                   {
                       Console.WriteLine(sum + "even");
                   }
                   else
                   {
                       Console.WriteLine(sum + "odd");
                   }
                
            }
    
        }
    }
}
