using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mark_Grad
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Mark:");
            int mark = int.Parse(Console.ReadLine());
            if (90 <= mark && mark <= 100)
            {
                Console.WriteLine("A+ Grade");
            }
            else if(80 <= mark && mark <= 90)
            {
                Console.WriteLine("B Grade");
            }
            else if (70 <= mark &&  mark <= 80)
            {
                Console.WriteLine("C Grade");
            }
            else if(60 <= mark && mark <= 70)
            {
                Console.WriteLine("D Grade");
            }
            else if(50 <= mark && mark <= 60)
            {
                Console.WriteLine("E Grade");
            }
            else
            {
                Console.WriteLine("You Are Failed");
            }
        }
    }
}
