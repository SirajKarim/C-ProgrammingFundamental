using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int sort = 0;
            int[] array = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        sort = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = sort;
                    }

                }
                for (int k = 0; k < array.Length; k++)
                { Console.Write(array[i] + " "); }



            }
        }
    }
}

