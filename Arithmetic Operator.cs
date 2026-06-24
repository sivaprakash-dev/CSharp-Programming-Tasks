using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arithmetic_Operator
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the 1st value: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the 2st value: ");
            int b = int.Parse(Console.ReadLine());

            if (a >= 1 && b <= 100 && a <=100 && b >= 1)
            {
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Modulus");
                Console.Write("Enter Your Operator Choose:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition:" + (a + b));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction:" + (a - b));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication:" + (a * b));
                        break;
                    case 4:
                        Console.WriteLine("Division:" + (a / b));
                        break;
                    case 5:
                        Console.WriteLine("Modulus:" + (a % b));
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid value Enter the 1 value Between 100.");
            }
            
        }
    }
}
