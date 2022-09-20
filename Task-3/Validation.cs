using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Validation
    {
        public void  val(string emailid,string pass)
        {
            if(emailid == "jaisubramani23@gmail.com")
            {
                Console.WriteLine("The emailid enterd is valid");
            }


        }

        public void val(int memid,int pin)
        {
            if(memid == 234 && pin == 1234)
            {
                Console.WriteLine("Entred Correct Pin and MembershipID");
            }
        }

        public void val(long mobno,int pin)
        {
            if(mobno == 63636662677 && pin== 56787)
            {
                Console.WriteLine("The pin and MobilNo is  correct");
            }

        }
        public static void Main()
        {
            //val(883883888838,56787);
        }
    }
}
