using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class task_1
    {
        static void Main(string[] args)
        {
            int a = 10;

            //Post Increment
            Console.WriteLine("Before post incr:" + a);
            a++;
            Console.WriteLine("After post incr:" + a);

            //Pre Increment
            Console.WriteLine("Before pre incr:" + a);
            Console.WriteLine("After pre incr:" + (++a));

            //post Decrement
            Console.WriteLine("Before post decr:" + a);
            a--;
            Console.WriteLine("After post decr:" + a);

            //pre Decrement
            Console.WriteLine("Before pre decr:" + a);
            Console.WriteLine("Afetr pre decr:" + --a);

            Console.Write("Total incr and decr:");
            Console.WriteLine((a++) + (++a) + (a--) + (--a));
        }
    }
}
