using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_s_function
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //Console.WriteLine("input values in series");
            //string input1 = Console.ReadLine();
            //string[] ARR = input1.Split(' ');
            //for (int i = 0; i < ARR.Length; i++)
            //{
            //    int c = int.Parse(ARR[i]);
            //    sum = sum + c;

            //}
            //Console.WriteLine("sum is : " + sum);

            Console.WriteLine("ENTER LENGHT");
            int len = int.Parse(Console.ReadLine());
            int[] arr1 = new int[len];

            
            Console.WriteLine("input values in series");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());


               

            }
            Console.WriteLine("AFTER SORTING");
            for (int i = arr1.Length-1; i >= 0; i--)
            {
                Array.Sort(arr1);
                Console.WriteLine(arr1[i]);    
            }
            
           
        }
    }
}
