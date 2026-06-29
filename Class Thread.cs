using System;
using System.Threading;



namespace Collections
{

    class Class_Thread
    {
        int count=0;
        object lockKey = new object();

        public void first()
        {
           
                for (int i = 10; i <= 20; i++)
                {
                    Console.WriteLine("Fst:" + i);

                    Thread.Sleep(1000);    // 1000 for Seconds            
                }
            
        }

        public void second()
        {
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("Sec:" + j);
                Thread.Sleep(1000);  // 1000 for seconds
            }
        }

        
        public static void Main(string[] args)
        {
            Class_Thread obj = new Class_Thread();


            //Thread t1 = new Thread(obj.first);
            //t1.Start();
            ////t1.Join();    // Join for Method By Method Call Aagum



            //Thread t2 = new Thread(obj.second);
            //t2.Start();

            Thread a1 = new Thread(obj.acc);
            a1.Start();
            a1.Join();


            Thread b1 = new Thread(obj.adc);
            b1.Start();
            b1.Join();

            

        }


        // Lock
        public void acc()
        {
            lock (lockKey)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(6000);
                }

                count++;
            }
        }
        public void adc()
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(3000);
            }
        }


    }
}
