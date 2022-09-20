using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class calc
    {
        public abstract void add(int num1,int num2);
        public abstract void sub(int num1,int num2);
        public abstract void mul(int num1,int num2);
        public abstract void div(int num1,int num2);
    }
    class Cal : calc
    {
        public override void add(int n1,int num2)
        {
            int add = n1 + num2;
            Console.WriteLine("Addition "+add);
        }

        public override void sub(int num1,int num2)
        {
            int sub = num1 - num2;
            Console.WriteLine("Subtraction "+sub);
        }

        public override void mul(int num1,int num2)
        {
            Console.WriteLine("Multiplication ",num1 * num2);
        }

        public override void div(int num1,int num2)
        {
            double val = num1 / num2;
            Console.WriteLine("Divition{0:E} ",+val);
        }
    }
    internal class Calculator
    {
        public static void Main()
        {
            Cal calc = new Cal();
            calc.add(23, 45);
            calc.sub(277, 36);
            calc.mul(6, 7);
            calc.div(60, 5);
        }
    }
}
