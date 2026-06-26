using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Non_Static_To_Non_Static
    {
        //Non method
        public void age(int age)
        {
            Console.WriteLine("My Age is :" + age);
        }

        //Non method
        public void Details(string Details)
        {
            Console.WriteLine("My Details is :" + Details);

            age(20);
        }

        //Main method
        public static void Main()
        {
            Non_Static_To_Non_Static obj1 = new Non_Static_To_Non_Static();
            obj1.Details("Hello");




            //string v = "100";

            //int a = int.Parse(v);
            //Console.WriteLine(a);


            //double a = 12.23;

            //int s =(int) a;
            //Console.WriteLine(s);
        }
    }
}
