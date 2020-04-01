using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int min_value,sort;
            int[] select = new int[] { 30,29,28,27,26 };
            Console.WriteLine("array before selection sorting");
                for (int i = 0; i < select.Length; i++)
			{

                Console.WriteLine(select[i]);}
                Console.WriteLine("array after selection sorting");
			 for (int j = 0; j < select.Length-1; j++)
			{ min_value=j;
			 for (int k = j+1; k < select.Length; k++)
			{
                 if (select[k]<select[min_value])
	{
                     min_value=k;
		 
	}
			 
			}
             sort = select[min_value];
             select[min_value] = select[j];
             select[j] = sort;
			}

             for (int i = 0; i < select.Length; i++)
             {
                 Console.WriteLine(select[i]);
             }

        }
    }
}
