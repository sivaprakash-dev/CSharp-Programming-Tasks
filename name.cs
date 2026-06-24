using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class name
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name :");
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.WriteLine("Enter Your Mark:");
            int mark = int.Parse(Console.ReadLine());
            if (mark >= 35)
            {
                Console.WriteLine("You are Passed");
            }
            else
            {
                Console.WriteLine("You are Failed");
            }
        }
    }
}

