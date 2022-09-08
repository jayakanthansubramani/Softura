using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tables
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i*num);
            }
        }
    }
}
