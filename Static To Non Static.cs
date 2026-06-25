using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Different and Multiple Class using 1 main method Different Class run for only public Method
    class Different_Class
    {
        //static method
        public static void name(string name)
        {
            Console.WriteLine("My Name is :" + name);
        }


        class Second
        {
            //Non static method
            public void age(int age)
            {
                Console.WriteLine("My age is :" + age);

                Different_Class.name("Siva Prakash");

            }

            //Maiin method
            public static void Main()
            {
                Second ag = new Second();
                ag.age(20);
            }
        }
    }
}
