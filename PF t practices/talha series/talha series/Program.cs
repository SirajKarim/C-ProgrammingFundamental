using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talha_series
{
    class Program
    {
        static void Main(string[] args)
        {  int a=1;
            int sum=0;
            int t;
            Console.WriteLine("enter your series lenght");
            int n=int.Parse(Console.ReadLine());
            for (int i=1; i<=n ; i++)
			{
                t = sum + a;


                Console.Write(" "+t+" ");
                sum = a;
                a = t;


			}
           
        }
    }
}
