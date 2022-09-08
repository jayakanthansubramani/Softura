using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public static void Main()
        {
            int[] marks = new int[5];
            int total = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enter the mark:");
                int j = Convert.ToInt32(Console.ReadLine());
                marks[i] = j;
            }
            foreach (int i in marks)
            {
                total += i;
            }
            decimal per = total / marks.Length;
            Console.WriteLine("The total mark obtained by a student:" + total);
            Console.WriteLine("The percentage obtained by a student: " + per);
        }
    }
}
