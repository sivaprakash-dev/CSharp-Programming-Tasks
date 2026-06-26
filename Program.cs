using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int password = 2005;

            retry:
            Console.WriteLine("Enter The Password: ");
            int pin = int.Parse(Console.ReadLine());

            if(password == pin)
            {
                Console.WriteLine("Login Successfull");
            }
            else
            {
                Console.WriteLine("Wrong Password");
                goto retry;

            }
        }
    }
}
