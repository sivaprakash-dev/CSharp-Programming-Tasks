using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Non_Static_To_Static
    {
        //Non static method
        public void a(int a)
        {
            Console.WriteLine("Your Age is :" + a);
        }

        //static method
        public static void b(string b)
        {
            Console.WriteLine("You are Aligible :" + b);
        }

        //Main method
        public static void Main()
        {
            Non_Static_To_Static obj = new Non_Static_To_Static();
            obj.a(20);

            Non_Static_To_Static.b("You Are Eligible for Voting");
        }
    }
}
