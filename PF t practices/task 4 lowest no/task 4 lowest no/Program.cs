using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_lowest_no
{
    class Program
    {
        static void Main(string[] args)
        {
            // task highest no in an array
            //int n, min;
            //Console.WriteLine("enter the lenght of an array: ");
            //n = Convert.ToInt32(Console.ReadLine());
            //int[] num = new int[n];
            //min = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("input number " + i);
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //    if (num[i] < 0)
            //    {
            //        min = num[i];
            //    }

            //}
            //Console.WriteLine("minimum no is :  " + min);
            int sum, b, h, l, pos, neg;
            neg = 0;
            pos = 0;
            sum = 0;
            Console.WriteLine("Input array Length");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[length];
            Console.WriteLine("Input value");
            a[0] = Convert.ToInt32(Console.ReadLine());
            if (a[0] > 0)
                pos++;
            if (a[0] < 0)
                neg--;

            h = a[0];
            l = a[0];


            for (b = 1; b < a.Length; b++)
            {
                Console.WriteLine("Input value");
                a[b] = Convert.ToInt32(Console.ReadLine());
                sum = sum + a[b];
                if (a[b] > h)

                    h = a[b];

                if (a[b] < l)

                    l = a[b];
                if (a[b] > 0)
                    pos++;
                if (a[b] < 0)
                    neg++;



            }
            sum = sum + a[0];
            double avg = sum / length;
            Console.Write("Reverse Order ");
            for (b = length - 1; b >= 0; b--)
            {
                Console.Write(a[b] + ",");

            }
            Console.WriteLine();
            Console.WriteLine("Sum of All value is " + sum);
            Console.WriteLine("Average of all Value is " + avg);
            Console.WriteLine("highest value is " + h);
            Console.WriteLine("Lowest Value is " + l);
            Console.WriteLine("Number of Positive Value is " + pos);
            Console.WriteLine("Number of Nagetive Value is " + neg);
        }
    }
}
