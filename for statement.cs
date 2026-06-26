using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class for_statement
    {
        static void Main(string[] args)
        {
            // 1.
            for (int i = 1; i <= 10; i++)
            {
                if (i == 8)
                {
                    break;
                }
                {
                    Console.WriteLine(i);
                }
            }


            //2.
            //for (int i=1; i<=15; i++)
            //{
            //   if(i %2 == 0)
            //    {
            //        continue;
            //    }
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //3.
            //for(int i=1; i<=20; i++)
            //    {
            //    if(i % 3 == 0)
            //    {
            //        continue;
            //    }
            //    {
            //        Console.WriteLine(i);
            //    }
            //    }


            //4.
            //for (int i=1; i<=25; i++)
            //{
            //    if (i == 25)
            //    {
            //        break;
            //    }
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //5.
            //retry:
            //Console.Write("Enter a Number:");
            //int number = int.Parse(Console.ReadLine());

            //if(number < 0)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Negative Number");
            //    Console.WriteLine();
            //    goto retry;
            //}
            //else
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Your value is:" + number);
            //}


            //6.
            //for (int i=1; i<=30; i++)
            //{
            //    if(i %4 == 0)
            //    {
            //        continue;
            //    }
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //7.
            //for(int i=1; i<=40; i++)
            //{
            //    if(i == 33)
            //    {
            //        break;
            //    }
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //8.
            //retry:
            //    Console.Write("Enter a Number:");
            //    int number = int.Parse(Console.ReadLine());

            //    if (number == 0)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Zero is not allowed Please Enter The Number Again");
            //        Console.WriteLine();
            //        goto retry;
            //    }
            //    else
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Your value is:" + number);
            //    }
        }
    }
}
