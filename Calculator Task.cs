using System;


namespace Consol__exxception_
{
    class calculate : Exception
    {
        public calculate(string mess) : base(mess)
        {

        }
    }
    class Calculator_Task
    {
        public void add()
        {
            int val=0;
            int val2 =0;
        access:
            try
            {
                Console.WriteLine();
                Console.WriteLine("Enter First Number:");
                val = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Number:");
                val2 = int.Parse(Console.ReadLine());

                if (val <= 0 && val2 <= 0)
                {
                    throw new calculate("Negative numbers are not allowed");
                }
                Console.Clear();
               
            }
            catch (OverflowException)
            {
                Console.Clear() ;
                Console.WriteLine("Value Limited Access");
                Console.WriteLine();
                Console.WriteLine("Please Enter Correct Format");
                goto access;
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Error :" + ex.Message);
                Console.WriteLine();
                Console.WriteLine("StackTrace :" + ex.StackTrace);
                Console.WriteLine();
                Console.WriteLine("Source :" + ex.Source);
                Console.WriteLine();
                Console.WriteLine("TargetSite :" + ex.TargetSite);
                Console.WriteLine();
                Console.WriteLine("GetType :" + ex.GetType());
                Console.WriteLine();
                Console.WriteLine("Please Enter Correct Format");
                goto access;
            }

            Console.WriteLine("------------------- Menu ---------------------");
            Console.WriteLine();
            Console.WriteLine("1.ADDITION +");
            Console.WriteLine("2.SUBTACTION -");
            Console.WriteLine("3.MULTIPLICATION *");
            Console.WriteLine("4.DIVITION /");
            Console.WriteLine("5.Modulus %");
            Console.WriteLine("6.Exit");

        Cons:
            Console.WriteLine();
            Console.WriteLine("Enter Your Option:");
            int option = int.Parse(Console.ReadLine());


            try
            {
                switch (option)
                {
                    case 1:
                        Console.Clear ();

                        Console.WriteLine("First Number :" + val);
                        Console.WriteLine("Second Number:" + val2);

                        int r = val + val2;
                        Console.WriteLine();
                        Console.WriteLine("Addition is:" + r);
                        goto access;

                    case 2:
                        Console.Clear();

                        Console.WriteLine("First Number :" + val);
                        Console.WriteLine("Second Number:" + val2);

                        int r2 = val - val2;
                        Console.WriteLine();
                        Console.WriteLine("Subtraction is:" + r2);
                        goto access;
                    case 3:
                        Console.Clear();

                        Console.WriteLine("First Number :" + val);
                        Console.WriteLine("Second Number:" + val2);

                        int r3 = val * val2;
                        Console.WriteLine();
                        Console.WriteLine("Multiple is:" + r3);
                        goto access;

                    case 4:
                        Console.Clear();

                        Console.WriteLine("First Number :" + val);
                        Console.WriteLine("Second Number:" + val2);

                        int r4 = val / val2;
                        Console.WriteLine("Division is:" + r4);
                        goto access;

                    case 5:
                        Console.Clear();

                        Console.WriteLine("First Number :" + val);
                        Console.WriteLine("Second Number:" + val2);
                        int r5 = val % val2;
                        Console.WriteLine();
                        Console.WriteLine("Modulus is:" + r5);
                        goto access;

                    case 6:
                        Console.WriteLine("Thank You");
                        return;

                    default:
                        Console.WriteLine("Invalid Option");
                        goto Cons;
                        
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine();
                Console.WriteLine("Cannot divide by zero");
                Console.WriteLine();
                goto access;
            }

        }
        public static void Main(string[] args)
        {
            Calculator_Task o = new Calculator_Task();
            o.add();

        }
    }
}
