using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3_even_or_odd
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("ENTER LENGHT OF ARRAY ");
            int len1 = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int [len1];
            int [] array2 = new int [len1];
            for (int i = 0; i < len1; i++)
            {
                Console.WriteLine("ENTER VALUE OF ARRAY 1");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < len1; j++)
            {
                Console.WriteLine("ENTER VALUE OF ARRAY 2");
                array2[j] = Convert.ToInt32(Console.ReadLine());
            }
            for (int k = 0; k < len1; k++)
            {
                if (array1[k] % 2 == 0)
                {
                    Console.WriteLine(array1[k] + " even");
                }
                else
                { Console.WriteLine(array1[k] + " odd"); }
            }
                for (int k = 0; k < len1; k++)
                { if (array2[k] % 2 == 0)
                {
                    Console.WriteLine(array2[k] + " even");
                }
                else
                { Console.WriteLine(array2[k] + " odd"); }
               
            }
        }
        }
    }

