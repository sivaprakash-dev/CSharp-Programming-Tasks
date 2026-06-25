using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string___StringBuilder
{
    internal class Program
    {
        // String is Immutable


        static void Main(string[] args)
        {
            //Length

            string name = "Sivaprakash";
            int length = name.Length;
            Console.WriteLine(length);

            //ToUpper

            name = name.ToUpper();
            Console.WriteLine(name);

            //ToLower

            name = name.ToLower();
            Console.WriteLine(name);


            //Substring

            name = name.Substring(4);
            Console.WriteLine(name);


            //Contains

            string empname = "Pravinkumar";
            bool res = empname.Contains("Pravin");
            Console.WriteLine(res);


            //Replace

            string na = empname.Replace("Pravin", "Siva");
            Console.WriteLine(na);


            //Trim

            string va = empname.Trim();
            Console.WriteLine(va);



            //IndexOf

            int po = empname.IndexOf("i");
            Console.WriteLine(po);
        }
    }
}
