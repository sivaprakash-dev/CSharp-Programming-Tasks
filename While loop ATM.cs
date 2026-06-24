using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class @while
    {
        static void Main(string[] args)
        {
            int password = 2005;

            Console.WriteLine("Enter the Password:");
            int userpassword = int.Parse(Console.ReadLine());

            while (password != userpassword)
            {
                Console.WriteLine("Wrong Password, Please enter again:");
                userpassword = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Login Successful");
        }
    }
}
