using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Binary_and_Unary
    {
        static void Main(string[] args)
        {
            int password = 2005;
            int userpassword = 0;
            int limit = 0;
            int balance = 10000;
            int withdrawlimit = 0;
            int deposilimit = 0;
            do
            {
                Console.WriteLine("---------- Welcom to SBI ATM ----------");
                Console.WriteLine();
                Console.Write("Enter The Password:");
                userpassword = int.Parse(Console.ReadLine());
                if (password == userpassword)
                {
                    Console.WriteLine();
                    Console.WriteLine("Login Successfully");
                    Console.WriteLine();
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
                return;
            }
                 
                //Console.WriteLine("Welcome to ATM");
                Console.WriteLine("1.Withdraw");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Balance Enquiry");
                Console.WriteLine("4.Account Information");
                Console.WriteLine();
                Console.Write("Choose Your Option:");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Enter Withdraw Amount:");
                            int withdrawAmount = int.Parse(Console.ReadLine());
                            if (withdrawAmount <= balance)
                            {
                                balance = balance - withdrawAmount;
                                Console.WriteLine("Withdraw Successful. Please Collect Your Cash");
                            Console.WriteLine("Current Balance:" + balance);
                            }
                            else
                            {
                                Console.WriteLine("Insufficient Balance");
                            }
                            withdrawlimit++;
                        }
                        while (withdrawlimit < 3);
                        if (withdrawlimit == 3)
                        {
                            Console.WriteLine("Your Withdraw Limit Exceeded");
                        }
                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Enter Deposit Amount:");
                            int depositamount = int.Parse(Console.ReadLine());
                            if (depositamount <= 20000)
                            {

                                balance = balance + depositamount;
                                Console.WriteLine("Deposit Successful.");
                                Console.WriteLine();
                                Console.WriteLine("Current Balance:" + balance);
                            }
                            else
                            {
                                Console.WriteLine("Deposit Amount must be Above 20000");
                            }
                            deposilimit++;
                        }
                        while (deposilimit < 3);
                        if (deposilimit == 3)
                        {
                            Console.WriteLine("Your Deposit Limit Exceeded");
                        }
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Current Balance:" + balance);
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("---------Your Account Information------");
                        Console.WriteLine();
                        Console.WriteLine("Name         : Sivaprakash D");
                        Console.WriteLine("Account No   : 973948968");
                        Console.WriteLine("Branch       : Chinnasalem");
                        Console.WriteLine("IFSC No      : IDIB000C045");
                        Console.WriteLine("Mobile Number: 9786216760");
                        Console.WriteLine("Account Type : Savings");
                        Console.WriteLine("Date of Account Opening: 08/10/2024");
                        break;
                    default:
                    Console.WriteLine("Invalid Option");
                            break;
            }
        }
    }
}
