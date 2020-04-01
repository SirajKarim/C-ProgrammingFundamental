using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {  // (d) kinetic energy//
            Console.WriteLine("enter mass");
            int mass = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter velocity");
            int velocity = Convert.ToInt32(Console.ReadLine());
            velocity=(int) Math.Pow(velocity,2);
            double a =0.5* mass * velocity;
            
            Console.WriteLine("kinetic energy "+a);



        }
    }
}
