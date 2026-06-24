using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main()
        {
            Console.WriteLine("Enter Your Age");
            int age=Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are Eligible for Voting");
            }
            else
            {
                Console.WriteLine("You are Not Eligible for Voting");
            }
        }

    }
}
