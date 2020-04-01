using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3___multiply_
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
                int sum = array1[k] * array2[k];
                Console.WriteLine(array1[k] + "*" + array2[k] + "=" + sum);
            }
        
        }
    }
}
