using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class clac1
    {
        public void add(int num1,int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public void sub(int num1,int num2)
        {
            Console.WriteLine(num1 - num2);
        }
    }

    class calc2:clac1
    {
        public void multiply(int n1,int n2)
        {
            Console.WriteLine(n1*n2);
        }

        public void divide(int n1,int n2)
        {
            double div = n1/n2;
            Console.WriteLine("the divition is {0}"+div);
        }
    }
    internal class Task3_1
    {
        public static void Main()
        {
            calc2 obj = new calc2();
            obj.add(20,30);
            obj.divide(60,7);
        }
    }
}
