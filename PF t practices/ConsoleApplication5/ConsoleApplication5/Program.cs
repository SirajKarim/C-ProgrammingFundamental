using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("ENTER LENGHT OF ARRAY ");
            int len1 = Convert.ToInt32(Console.ReadLine());
            double[] array1 = new double [len1];
            double[] array2 = new double [len1];
            for (int i = 0; i < len1; i++)
            {
                Console.WriteLine("ENTER VALUE OF ARRAY 1");
                array1[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int j = 0; j < len1; j++)
            {
                Console.WriteLine("ENTER VALUE OF ARRAY 2");
                array2[j] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("YOUR SUM IS ");
            for (int k = 0; k < len1; k++)
            {
                double sum = array1[k] + array2[k];
                Console.WriteLine(array1[k] + "+" + array2[k] + "=" + sum);
            }
            Console.WriteLine();
            Console.WriteLine("YOUR subraction IS ");
            for (int k = 0; k < len1; k++)
            {
                double minus = array1[k] - array2[k];
                Console.WriteLine(array1[k] + "-" + array2[k] + "=" + minus);
            }
            Console.WriteLine();
            Console.WriteLine("YOUR multiplication  IS ");
            for (int k = 0; k < len1; k++)
            {
                double mul = array1[k] * array2[k];
                Console.WriteLine(array1[k] + "*" + array2[k] + "=" + mul);
            }
            Console.WriteLine();
            Console.WriteLine("YOUR division  IS ");
            for (int k = 0; k < len1; k++)
            {
                double div = array1[k] / array2[k];
                Console.WriteLine(array1[k] + "/" + array2[k] + "=" + div);

            }
            Console.WriteLine();
            Console.WriteLine("HERE EVEN AND ODD");
            Console.WriteLine();
            Console.WriteLine("FOR ARRAY 1");
            for (int k = 0; k < len1; k++)
            {
                if (array1[k] % 2 == 0)
                {
                    Console.WriteLine(array1[k] + " even");
                }
                else
                { Console.WriteLine(array1[k] + " odd"); }
            }
            Console.WriteLine();
            Console.WriteLine("FOR ARRAY 2 ");
            for (int k = 0; k < len1; k++)
            {
                if (array2[k] % 2 == 0)
                {
                    Console.WriteLine(array2[k] + " even");
                }
                else
                { Console.WriteLine(array2[k] + " odd"); }

            }




            }
        }
        }
    

