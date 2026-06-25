using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Different_and_multiple_Class_Method
{
    internal class Non_Static_To_Static
    {
        //Non static method
        public void Details(string Detail)
        {
            Console.WriteLine("My Detail is :" + Detail);

            Second.District("Kallakurichi");
        }

        class Second
        {
            //static method
            public static void District(string District)
            {
                Console.WriteLine("My District is :" + District);
            }

            //Main method
            public static void Main()
            {
                Non_Static_To_Static obj = new Non_Static_To_Static();
                obj.Details("102,North Street,Chinnasalem");
            }
        }
    }
}
