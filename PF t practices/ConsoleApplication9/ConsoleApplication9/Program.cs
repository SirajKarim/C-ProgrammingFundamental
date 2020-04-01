using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int max=0;
            Console.WriteLine("lenght of array");
            int a = int.Parse(Console.ReadLine());
            int[] array = new int [a];
            Console.WriteLine("ENTER VALUE ");
            for (int i = 0; i <a ; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                max = Math.Max(array[i], max);
            }
            Console.WriteLine("MAX VALUE IS ");
            Console.WriteLine(array.Max());
            Console.WriteLine("YOUR MIN VALUE IS ");
            Console.WriteLine(array.Min());
            Console.WriteLine("YOUR sum IS ");
            Console.WriteLine(array.Sum());
            Console.WriteLine("your average is ");
            Console.WriteLine(array.Average());
            Console.WriteLine("your first value is ");
            Console.WriteLine(array.First());
            Console.WriteLine("your count value is  ");
            Console.WriteLine(array.Count());
            Console.WriteLine(max);
           

           
         
            

        }
    }
}