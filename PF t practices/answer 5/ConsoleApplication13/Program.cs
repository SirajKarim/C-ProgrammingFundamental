using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("salary calculation");
            // gender //
            Console.WriteLine("gender");
            string gender = Console.ReadLine();
            Console.WriteLine("years of survice");
            int yearsSurvice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("qualification");
            string qualification = Console.ReadLine();
            
             //for male//
           
            if (gender == "male" && yearsSurvice >= 5 && qualification == "ms")
            { Console.WriteLine("90000"); }
            else  if (gender == "male" && yearsSurvice >= 5 && qualification == "mba" )
                { Console.WriteLine("90000"); }
            
            else if (gender == "male" && yearsSurvice >= 5 && qualification == "bs")
            { Console.WriteLine("60000"); }
            else  if (gender == "male" && yearsSurvice >= 5 &&qualification == "mcs")
                { Console.WriteLine("60000"); }
            
            else if (gender == "male" && yearsSurvice <= 5 && qualification == "bs")
            { Console.WriteLine("50000"); }
            else  if (gender == "male" && yearsSurvice <= 5&&qualification == "mcs")
                { Console.WriteLine("50000"); }
            
            else if (gender == "male" && yearsSurvice <= 5 && qualification == "bba")
            { Console.WriteLine("25000"); }
            // for female //

            else if (gender == "female" && yearsSurvice >= 5 && qualification == "ms")
            { Console.WriteLine("80000"); }
              else  if (gender == "female" && yearsSurvice >= 5 &&qualification == "mba")
                { Console.WriteLine("80000"); }
            
            else if (gender == "female" && yearsSurvice >= 5 && qualification == "bs")
            { Console.WriteLine("55000"); }
              else  if (gender == "female" && yearsSurvice >= 5 &&qualification == "mcs")
                { Console.WriteLine("55000"); }
            
            else if (gender == "female" && yearsSurvice <= 5 && qualification == "bs")
            { Console.WriteLine("40000"); }
            else   if (gender == "female" && yearsSurvice <= 5&&qualification == "mcs")
                { Console.WriteLine("40000"); }
            
            else if (gender == "female" && yearsSurvice <= 5 && qualification == "bba")
            { Console.WriteLine("20000"); }
            
        }
    }
}
