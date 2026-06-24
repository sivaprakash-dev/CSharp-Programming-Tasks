using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ATM
    {
        static void Main(string [] args)
        {
            int pass = 1234;

            Console.WriteLine("Welcom to State Bank ATM");
            Console.Write("Enter The UserName:");
            string username=Console.ReadLine();
            Console.Write("Enter The Password:");
            int password=int.Parse(Console.ReadLine());
            
            if("admin" == username && pass == password)
            {
                Console.WriteLine("Login Successfully");
                Console.WriteLine("1.Withrawal");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Balance Enquiry");
                Console.WriteLine("4.Account Information");
                Console.Write("Enter Your Choice(1,2,3,4): ");

                int value = int.Parse(Console.ReadLine());
                int balance = 10000;
                switch (value)
                {
                    case 1:
                        Console.WriteLine("Enter The Withdraw Amount:");
                        int withdrawAmount = int.Parse(Console.ReadLine());
                        
                        if (withdrawAmount <= balance)
                        {
                            Console.WriteLine("Withdrawal Successful Collect your Cash");
                            Console.Write("Your Balance:");
                            Console.WriteLine(balance -= withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Not That much Amount Check Your Balance");
                        }
                        break;
                    case 2:
                        Console.Write("Enter The Deposit Amount:");
                        int depositAmount = int.Parse(Console.ReadLine());
                        int withraAmount = depositAmount + balance;
                        if (depositAmount <= 20000)
                        {

                            Console.WriteLine("Successfully Deposit Your Amount");
                            Console.WriteLine("Your Balance:" + withraAmount);
                        }
                        else
                        {
                            Console.WriteLine("Deposit Amount 20000 only Limit");
                        }
                        break;
                    case 3:
                        Console.Write("Your Current balance:");
                        Console.WriteLine(balance);
                        break;
                    case 4:
                        Console.WriteLine("---------Your Account Information------");
                        Console.WriteLine("Name: Sivaprakash D");
                        Console.WriteLine("Account No: 973948968");
                        Console.WriteLine("Branch: Chinnasalem");
                        Console.WriteLine("IFSC No: IDIB000C045");
                        Console.WriteLine("Mobile Number: 9786216760");
                        Console.WriteLine("Account Type: Savings");
                        Console.WriteLine("Date of Account Opening: 08/10/2024");
                        break;
                    default:
                        Console.WriteLine("Incorrect Choice");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Incorrect Username and Password");
            }
        }
    }
}
