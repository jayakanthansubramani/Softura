using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bill
    {
        public static void Main()
        {
            Console.WriteLine("Enter the name of a person:");
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            int count = age;
            while(count > 0)
            {
                Console.WriteLine(name);
                count--;
            }
        }
    }
}
