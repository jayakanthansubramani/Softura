using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Packages
    {
        public abstract void Membership();
    }

    class Silver:Packages
    {
        public override void Membership()
        {
            Console.WriteLine("3 days accomodation at Resort");
        }
    }

    class Gold : Packages
    {
        public override void Membership()
        {
            Console.WriteLine("5 days accomodation at Resort & 2Dinners on the house");

        }
    }

    class Platinum : Packages
    {
        public override void Membership()
        {
            Console.WriteLine("7 days accomodation at Resort & 5 Dinners on the house");

        }
    }
    internal class MemberShip
    {
        public static void Main()
        {
            Silver silver = new Silver();
            silver.Membership();
            Gold gold = new Gold();
            gold.Membership();
            Platinum platinum = new Platinum();
            platinum.Membership();
        }

    }
}
