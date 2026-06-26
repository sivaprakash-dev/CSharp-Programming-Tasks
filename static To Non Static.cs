using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class static_To_Non_Static
    {
        //static method
        public static void detail(int detail)
        {
            Console.WriteLine("Your Age is :" + detail);
        }

        //Non static method
        public void detail1(string detail1)
        {
            Console.WriteLine("Your City name :" + detail1);
        }

        public static void Main()
        {
            static_To_Non_Static.detail(20);

            static_To_Non_Static obj = new static_To_Non_Static();
            obj.detail1("Chennai");
        }
    }
}
