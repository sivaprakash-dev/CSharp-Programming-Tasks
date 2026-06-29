using System;


namespace Collections
{
    class Task
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            int dub = num;
            int l = num.ToString().Length;
            int tot = 0;

            while (true)
            {
                int rem = dub % 10;
                dub = dub / 10;

                tot += (int)Math.Pow(rem, l);

                if (dub == 0)
                    break;
            }

            if (tot == num)
                Console.WriteLine("Armstrong number");
            else
                Console.WriteLine("It is not an Armstrong number");
        }
    }
}
