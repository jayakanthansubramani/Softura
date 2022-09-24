using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp2
{
    class EmployeeDetails
    {
        public void EmployeeId()
        {
            Console.WriteLine("Enter the EmpId");
            int ID = Convert.ToInt32(Console.ReadLine());
        }

        public void Name()
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
        }

        public void Gender()
        {
            Console.WriteLine("Enter the Gender");
            string gender = Console.ReadLine();
        }

        public void YearOfEx()
        {
            Console.WriteLine("Enter the EmpId");
            int YOE = Convert.ToInt32(Console.ReadLine());
        }

        public int Salary()
        {
            Console.WriteLine("Enter the Salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            return salary;
        }

        public string Depart()
        {
            Console.WriteLine("Enter the Department");
            string dept = Console.ReadLine();
            return dept;
        }
    }

    class SalaryCalc : EmployeeDetails
    {
        public void SalesAndMarketing()
        {
            double salary = 0;
            salary = (double)salary * (.20);
            Console.WriteLine(salary);
        }

        public void Production()
        {
            double salary = 0;
            salary = (double)salary * (.10);

        }
    }
    internal class EmpDetails
    {
        public static void Main()
        {
            SalaryCalc sobj = new SalaryCalc();
            sobj.SalesAndMarketing();
        }
    }
}
