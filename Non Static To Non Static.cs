using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Different_and_multiple_Class_Method
{
    class Non_Static_To_Non_Static
    {
        //Non static method
        public void Country(string Country)
        {
            Console.WriteLine("My Country is :" + Country);
        }

        class Second
        {
            //Non static method
            public void State(string State)
            {
                Console.WriteLine("My State is :" + State);

                Non_Static_To_Non_Static Count = new Non_Static_To_Non_Static();
                Count.Country("India");
            }

            ///Main method 
            public static void Main()
            {
                Second obj = new Second();
                obj.State("Tamil Nadu");
            }
        }
    }
}
