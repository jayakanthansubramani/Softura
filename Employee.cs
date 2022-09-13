using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        

        public static void Main()
        {
            Employee emp = new Employee
            {
                ID = 101,
                Name = "Jayakanthan",
                Gender = "Male",
                Age = 22
            };

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("C:\\practice\\Day-2 c sharp\\Emp.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(fs,emp);
            fs.Flush();
            fs.Close();

            BinaryFormatter bf1 = new BinaryFormatter();
            FileStream fs1 = new FileStream("C:\\practice\\Day-2 c sharp\\Emp.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            string str = (string) bf1.Deserialize(fs1);
            Console.WriteLine(str);

            fs1.Flush();
            fs1.Close();

        }
    }
}
