using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // float//
            Console.WriteLine("enter integar type value");
            int intValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intValue);
            Console.WriteLine("enter float type value");
            float floatValue = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(floatValue);

            // converting into long //
            Console.WriteLine("enter long type value");
            long longValue = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine(longValue);
            //converting into double//
            Console.WriteLine("enter double type value");
            double doubleValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(doubleValue);
            // connverting into decimal//
            Console.WriteLine("enter decimal type value");
            decimal decimalValue = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(decimalValue);
            //converting into char //
            Console.WriteLine("enter character type value");
            char charValue = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(charValue);
            // converting  value into string//
            Console.WriteLine("enter string type value");
            string stringValue = Convert.ToString(Console.ReadLine());
            Console.WriteLine(stringValue);
            //converting value into boolean //
            Console.WriteLine("enter boolean type value");
            bool boolValue = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(boolValue);
        }
    }
}
