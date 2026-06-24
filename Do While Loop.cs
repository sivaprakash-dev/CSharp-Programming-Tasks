using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Do_While_Loop
    {
        static void Main(string[] args)
        {
            int password = 2005;
            int userpassword = 0;
            int limit = 0;
            int withdrawlimit = 0;
            int balance = 10000;
            int userwithdraw = 0;


            do
            {
                Console.Write("Enter the Password:");
                userpassword = int.Parse(Console.ReadLine());
                if (password == userpassword)
                {
                    Console.WriteLine("Login Successfull");
                    break;

                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
                limit++;
            }
            while (limit < 3);
            if(limit == 3)
            {
                Console.WriteLine("Your Limit Exceeded");
            }

            do
            {
                Console.WriteLine("Enter Your Withdraw Amount:");
                userwithdraw = int.Parse(Console.ReadLine());
                if (balance >= userwithdraw)
                {
                    Console.WriteLine("Withdraw Successfull");
                    Console.WriteLine("Current Balance");
                    Console.WriteLine(balance - userwithdraw);
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the your balance below amount");
                }
                withdrawlimit++;
            }
            while (withdrawlimit < 3);
            if (withdrawlimit == 3)
            {
                Console.WriteLine("Your Limit Exceeded");
            }
            }
            
            }
        }
    
