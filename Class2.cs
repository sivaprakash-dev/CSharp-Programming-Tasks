using ConsoleApp2;
using System;

namespace ConsoleApp1
{
    class Program
    {
        public bool CheckLogin(string username, string password)
        {
            if (username == "admin" && password == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            Program obj= new Program();

            bool isValid =obj.CheckLogin("admin", "1234");

            if (isValid)
                Console.WriteLine("Login Success");
            else
                Console.WriteLine("Login Failed");
        }
    }
}
