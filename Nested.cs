using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Nested
    {
        static void Main(string[] args)
        {
            string username = "siva";
            int password = 2005;
            int depcode = 101;

            Console.Write("Enter Your Username:");
            string name = Console.ReadLine();

            if (username == name)
            {
                Console.Write("Enter Your Password:");
                int pass = int.Parse(Console.ReadLine());
                if (password == pass)
                {
                    Console.Write("Enter The Depcode:");
                    int dep = int.Parse(Console.ReadLine());
                    if (depcode == dep)
                    {

                        Console.WriteLine("Login Successfull");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Depcode");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }
            else
            {
                Console.WriteLine("Incorrect username");
            }
        }
    }
}
        