using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Odd_or_Even
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Value:");
            int value = int.Parse(Console.ReadLine());
            if(value % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
