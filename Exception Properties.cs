using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol__exxception_
{
    internal class Exception_Properties
    {
        public static void Main(string[] args)
        {
            //Message

            //try
            //{
            //    Console.WriteLine("Enter Your Age:");
            //    int age = int.Parse(Console.ReadLine());
            //}
            //catch (System.Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //StackTrace


            //try
            //{
            //    Console.WriteLine("Enter Your Age:");
            //    int age = int.Parse(Console.ReadLine());
            //}
            //catch (System.Exception ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}






            //Source


            //try
            //{
            //    Console.WriteLine("Enter Your Age:");
            //    int age = int.Parse(Console.ReadLine());
            //}
            //catch (System.Exception ex)
            //{
            //    Console.WriteLine(ex.Source);
            //}












            try
            {
                Console.WriteLine("Enter Your Age:");
                int age = int.Parse(Console.ReadLine());
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }
        }
    }
}
