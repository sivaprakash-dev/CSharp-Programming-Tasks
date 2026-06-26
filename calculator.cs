using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class calculator
    {
        //static method
        public static void add(int a,int b)
        {
            Console.WriteLine();
            Console.WriteLine("Addition is :" + (a+b));
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine();
            Console.WriteLine("Subtraction is :" + (a-b));
        }

        //Non static method
        public void mul(int a, int b)
        {
            Console.WriteLine();
            Console.WriteLine("Multiplication is :" + (a*b));
        }

        public void div(int a, int b)
        {
            Console.WriteLine();
            Console.WriteLine("Division is :" + (a/b));
        }

        //Main method
        public static void Main()
        {
            Console.Write("Enter a numbers:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter b Numbers:");
            int b = int.Parse(Console.ReadLine());

            calculator.add(a, b);
            calculator.sub(a, b);

            calculator obj = new calculator();
            obj.mul(a, b);
            obj.div(a, b);
        }
    }
}
