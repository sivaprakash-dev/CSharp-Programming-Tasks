using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arithmetic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st value:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number:");
            float num2 = float.Parse(Console.ReadLine());

            float Additioin = num1 + num2;
            float Subtraction = num1 - num2;
            float Multiplication = num1 * num2;
            float Division = num1 / num2;
            float Modulus = num1 % num2;

            Console.WriteLine("Addition=" + Additioin);
            Console.WriteLine("Subtraction=" + Subtraction);
            Console.WriteLine("Multiplication=" + Multiplication);
            Console.WriteLine("Division=" + Division);
            Console.WriteLine("Modulus=" + Modulus);
            Console.WriteLine("1st value is GreaterThen=" + (num1 > num2));
            Console.WriteLine("2nd value is LessThen=" + (num1 < num2));
            Console.WriteLine("1st and 2nd value or Equal=" + (num1 == num2));
            Console.WriteLine("1st and 2nd value are Not Equal=" + (num1 != num2));
        }
    }
}
