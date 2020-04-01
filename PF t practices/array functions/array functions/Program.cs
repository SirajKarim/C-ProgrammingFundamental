using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_functions
{
    class Program
    {
        static void Main(string[] args);
        
            
           
          

    {
        inputArray = new int[] { 1, 2, 3, 4, 5, 6 };

            if (min > max)
            {
                Console.WriteLine("Nil");
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    Console.WriteLine(++mid);
                }
                else if (key < inputArray[mid])
                {
                    Console.WriteLine(inputArray, key, min, mid - 1);
                }
                else
                {
                    Console.WriteLine(inputArray, key, mid + 1, max);
                }
            }

        }
    }
}
