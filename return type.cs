using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_type
{
    internal class return_type
    {
        //Without parameters without return type
        public void find()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);
        }

        //Without parameters with return type
        public int add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            return c;

        }

        //with parameters with return type
        public string name(string name1, string name2)
        {
            return name1 + name2;

        }

        //with parameters without return type
        public void display(int a, int b)
        {
          

            int c = a + b;

            Console.WriteLine(c);

        }

        public static void Main()
        {
            return_type f = new return_type();
            f.find();

            int result = f.add();
            Console.WriteLine("The sum is: " + result);


            string fname = f.name("siva","prakash");
            Console.WriteLine(fname);

            f.display(100, 300);
        }
    }
}
