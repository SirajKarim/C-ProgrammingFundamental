using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {    Console.WriteLine("age of alpha");
            int alpha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("age of bravo");
            int bravo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("age of charlie");
            int charlie = Convert.ToInt32(Console.ReadLine());
            if (alpha<bravo && alpha<charlie)
            {Console.WriteLine("alpha is youngest in them his age is "+alpha); }
            else if (bravo < alpha && bravo < charlie)
            { Console.WriteLine("bravo is youngest in them his age is "+bravo); }
            else if (charlie < bravo && charlie < alpha)
            { Console.WriteLine("charlie is youngest in them his age is "+charlie); }
            else if (alpha == bravo)
            { Console.WriteLine("alpha and bravo have same ages " + alpha); }
            else if (charlie == bravo)
            { Console.WriteLine("charlie and bravo have same ages  " + bravo); }

            else if (charlie == alpha)
            { Console.WriteLine("charlie and alpha have same ages  " + charlie); }



        }
    }
}
