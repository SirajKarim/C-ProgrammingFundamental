using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pst");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a*100/100+"%");
            if (a >= 90)
            {
                Console.WriteLine("A-one grade");
            }
            else if (a >= 80)
            {
                Console.WriteLine("A-grade");
            }
            else if (a >= 70)
            {
                Console.WriteLine("B-grade");
            }
            else if (a >= 60)
            {
                Console.WriteLine("C-grade");
            }
            else if (a >= 50)
            {
                Console.WriteLine("d-grade");
            }
            else
            {
                Console.WriteLine("fail");
            }
            Console.WriteLine("vlm");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(b * 100 / 100+"%");
            if (b >= 90)
            {
                Console.WriteLine("A-one grade");
            }
            else if (b >= 80)
            {
                Console.WriteLine("A-grade");
            }
            else if (b >= 70)
            {
                Console.WriteLine("B-grade");
            }
            else if (b >= 60)
            {
                Console.WriteLine("C-grade");
            }
            else if (b >= 50)
            {
                Console.WriteLine("d-grade");
            }
            else
            {
                Console.WriteLine("fail");
            }
            Console.WriteLine("isl");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(c * 100 / 100+"%");
            if (c >= 90)
            {
                Console.WriteLine("A-one grade");
            }
            else if (c >= 80)
            {
                Console.WriteLine("A-grade");
            }
            else if (c >= 70)
            {
                Console.WriteLine("B-grade");
            }
            else if (c >= 60)
            {
                Console.WriteLine("C-grade");
            }
            else if (c >= 50)
            {
                Console.WriteLine("d-grade");
            }
            else
            {
                Console.WriteLine("fail");
            }
            Console.WriteLine("iict");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(d * 100 / 100+"%");
            if (d >= 90)
            {
                Console.WriteLine("A-one grade");
            }
            else if (d >= 80)
            {
                Console.WriteLine("A-grade");
            }
            else if (d >= 70)
            {
                Console.WriteLine("B-grade");
            }
            else if (d >= 60)
            {
                Console.WriteLine("C-grade");
            }
            else if (d >= 50)
            {
                Console.WriteLine("d-grade");
            }
            else
            {
                Console.WriteLine("fail");
            }
            double t = (a + b + c + d) * 100 / 400;
            Console.WriteLine(t+"%");
            if (t>=90)
            {
                Console.WriteLine("A-one grade");
            }
            else if (t >= 80)
            {
                Console.WriteLine("A-grade");
            }
            else if (t >= 70)
            {
                Console.WriteLine("B-grade");
            }
            else if (t >= 60)
            {
                Console.WriteLine("C-grade");
            }
            else if (t >= 50)
            {
                Console.WriteLine("d-grade");
            }
            else
            {
                Console.WriteLine("fail");
            }
           
        }
    }
}
