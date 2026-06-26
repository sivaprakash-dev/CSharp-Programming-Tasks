using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ATM_Task
    {
        int balance = 10000;


        public int withdraw()
        {
            Console.WriteLine();
            Console.Write("Enter Your WithDraw Amount :");
            int with =int.Parse(Console.ReadLine());


            if ( with >= 500)
            {

                if (balance >= with)
                {
                    balance -= with;
                    Console.WriteLine("Withdraw Successfull, Please Collect Your Cash");
                    Console.WriteLine("Your Remaining Balance is :" + balance);
                    
                }
                else
                {
                    Console.WriteLine("Not That much Amount Check Your Balance");
                }
            }

            else
            {
                Console.WriteLine("Please Enter Your Amount Above 500");

            }
            return balance;
        }

        public int deposit()
        {
            Console.WriteLine();
            Console.Write("Enter Your Deposit Amount :");
            int depamount = int.Parse(Console.ReadLine());
            if (20000 >= depamount)
            {
                Console.WriteLine("Deposit Successfull");
                balance = depamount + balance;
                Console.WriteLine("Your New Balance is :" + balance);       
            }
            else
            {
                Console.WriteLine("Deposit Amount below 20000");
            }
            return balance;
        }

        public void bal()
        {

            Console.WriteLine();
            Console.WriteLine("Your Current Balance :" + balance);
        }

        public void accinfo()
        {
            Console.WriteLine();
            Console.WriteLine("---------------YOUR ACCOUNT INFORMATION-------------");
            Console.WriteLine();
            Console.WriteLine("Account Holder Name : D.SivaPrakash");
            Console.WriteLine("Account Number      : 1234567890");
            Console.WriteLine("Account Type        : Savings Account");
            Console.WriteLine("IFSC Code           : SBIN0001234");
            Console.WriteLine("Mobile Number       : 9786216760");
            Console.WriteLine("Branch              : Chennai");
            Console.WriteLine("Account Opening Date: 18/04/2020");
        }
        public static void Main(string[] args)
        {
            int limit = 0;

            do
            {
                Console.WriteLine();
                Console.Write("Enter Your Username :");
                string username = Console.ReadLine();
                Console.Write("Enter Your Pin :");
                int password = int.Parse(Console.ReadLine());

                if ("siva" == username && 2005 == password)
                {
                    Console.WriteLine();
                    Console.WriteLine("Login Successfull!");
                    Console.WriteLine();
                    Console.WriteLine("--------ATM MENU-------");
                    Console.WriteLine("1.WITHDRAW");
                    Console.WriteLine("2.DEPOSIT");
                    Console.WriteLine("3.BALANCE ENQUERY");
                    Console.WriteLine("4.ACCOUNT INFORMATION");
                    Console.WriteLine("5.EXIT");
                    ATM_Task atm = new ATM_Task();

                    while (true)
                    {
                        Console.WriteLine();
                        Console.Write("Enter Your Choice :");
                        int Choice = int.Parse(Console.ReadLine());

                       

                        switch (Choice)
                        {
                            case 1:
                                int res =atm.withdraw();
                                Console.WriteLine(res);
                                break;                               
                            case 2:
                                int r=atm.deposit();
                                Console.WriteLine(r);
                                break;
                            case 3:
                                atm.bal();
                                break;
                            case 4:
                                atm.accinfo();
                                break;
                            case 5:
                                Console.WriteLine("Thank You! Visit Again ");
                                return;
                            default:
                                Console.WriteLine("Invalid Option");
                                break;
                        }
                        
                    }
                }
                else 
                {
                    Console.WriteLine();
                    Console.WriteLine("Incorrect Username And Password, Try Again");
                }
                limit++;
            }
            while (limit < 3);
           
                Console.WriteLine("Login Limit Exceeded");
            
        }
    }
}
