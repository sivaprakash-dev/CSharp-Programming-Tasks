using System;
using System.Text;

namespace string___StringBuilder
{
    internal class Class1_StringBuilder
    {
        public static void Main(string[] args)
        {
            StringBuilder name = new StringBuilder("Wellcome To All");

            //Append
            name.Append("Hello");
            Console.WriteLine(name);

            //AppendLine
            name.AppendLine("Siva");
            Console.WriteLine(name);


            //Insert
            name.Insert(12, "I am");
            Console.WriteLine(name);


            //Remove
            StringBuilder empname = new StringBuilder("Hi Iam Siva");

            empname.Remove(1,4);
            Console.WriteLine(empname);


            //Replace
            empname.Replace("Siva","Prakash");
            Console.WriteLine(empname);


            //Clear
            empname.Clear();
            Console.WriteLine(empname);



            //ToString
            StringBuilder Detail = new StringBuilder("CHENNAI");

            string d = Detail.ToString();
            Console.WriteLine(d);
        }
    }
}
