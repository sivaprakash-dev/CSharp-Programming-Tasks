using System;


namespace Collections
{
    class Practice1
    {
        delegate void del(int id, int age);

        delegate T vall <T>(T a, T b);

        public int gen(int a, int b)
        {
            int result;
            Console.WriteLine("My Id:" + a);
            Console.WriteLine("My Age is:" + b);
            return result=a+b;
        }

        public void ass(int Id, int Age)
        {
            Console.WriteLine("Id:"+ Id);
            Console.WriteLine("Age:" + Age);
        }

        public static void Main()
        {
            Practice1 ob = new Practice1();

            //del ss = ob.ass;
            //ss(1, 101);

            vall<int> aa = ob.gen;
            aa(101, 21);




        }
    }
}
