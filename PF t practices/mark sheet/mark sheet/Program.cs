using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mark_sheet
{
    class Program
    {
        static void Main(string[] args)
        { // mark sheet//
            int sum = 0;
            int percentage = 0;
            Console.WriteLine("Marksheet");
            Console.Write("Name of student: ");
            string nameofstudent = Console.ReadLine();
            Console.Write("Father's Name: ");
            string fname = Console.ReadLine();
            Console.Write("Student Id: ");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.Write("total Subjects are: ");
            int len = Convert.ToInt32(Console.ReadLine());
            string[] subjectArray = new string[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write("Subject " + (i + 1) + ": ");
                subjectArray[i] = Console.ReadLine();
            }
            Console.WriteLine("enter Marks");
            int[] marksArray = new int[len];
            for (int j = 0; j < len; j++)
            {
                Console.Write(subjectArray[j] + ": ");
                marksArray[j] = Convert.ToInt32(Console.ReadLine());
                sum = sum + marksArray[j];
            }
            percentage = (sum * 100 / (len * 100));
            if (percentage > 90 && percentage < 100)
            {
                Console.WriteLine("Grade: A+");
            }
            if (percentage < 90 && percentage > 80)
            {
                Console.WriteLine("Grade: A");
            }
            if (percentage > 70 && percentage < 80)
            {
                Console.WriteLine("Grade: B");
            }
            if (percentage > 60 && percentage < 70)
            {
                Console.WriteLine("Grade: C");
            }
            if (percentage > 50 && percentage < 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: Fail");
            }
            Console.WriteLine("Total Marks: " + sum);
            Console.WriteLine("Percentage: " + percentage + "%");
            Console.ReadKey();
        }
    }
}
