using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Static_To_Static
    {
        //static method
        public static void name(string name)
        {
            Console.WriteLine("Your First name is:" + name);
            name1("Prakash");
        }

        //static method
        public static void name1(string name1)
        {
            Console.WriteLine("Your Last name is:" + name1);
        }

        public static void Main()
        {
            Static_To_Static.name("Siva");
        }
    }
}
