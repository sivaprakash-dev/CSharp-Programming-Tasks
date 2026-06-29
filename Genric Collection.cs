
using System;
using System.Collections.Generic;




namespace Collections
{

    // Genric Collection

    // List 
    // Dictionary
    // Stack
    // Queue

    class Program
    {
        // List

        public void lis()
        {
            List<int> val = new List<int>();

            val.Add(100);
            val.Add(200);
            val.Add(300);


            // Insert

            val.Insert(1, 500);


            // Remove()

            val.Remove(100);



            // RemoveAt()

            val.RemoveAt(2);

            foreach (int o in val)
            {
                Console.WriteLine(o);
            }

            //Count 

            List<int> number = new List<int>();
            number.Add(10);
            number.Add(20); 
            number.Add(30);
            number.Add(40);

            Console.WriteLine(number.Count);


            // Clear

            number.Clear();


            // Sort

            List<int> num = new List<int>();

            num.Add(53);
            num.Add(23);
            num.Add(12);
            num.Add(44);
            num.Add(10);
            num.Add(4);

            num.Sort();

            foreach(int ob in num)
            {
                Console.WriteLine(ob);
            }




            // Reverse

            List<int> kd = new List<int>();

            kd.Add(100);
            kd.Add(200);
            kd.Add(300);
            kd.Add(400);

            kd.Reverse(0,3);   
            
            foreach(int va in kd)
            {
                Console.WriteLine(va);
            }

        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.lis();

        }
    }

    // -------------------------------------------------------------------

    // Dictionary


    class Dictionary
    {
        public void dic()
        {
            
            Dictionary<int, string> dict = new Dictionary<int, string>();

            

            dict.Add(1, "Siva");
            dict.Add(2, "Prakash");

            // Call by Keyvalue

            Console.WriteLine(dict[1]);


            // Call full value
            foreach (var key in dict)
            {
                Console.WriteLine(key);
            }
        }

        public static void Main(string[] args)
        {
            //Dictionary obj = new Dictionary();
            //obj.dic();

            dict ne = new dict();
            ne.coll();
        }
    }

    class dict
    {
        public void coll()
        {
            Dictionary<String, string> key = new Dictionary<string, string>();

            key.Add("Siva", "Prakash");

            Console.WriteLine(key["Siva"]);
        }
    }


    //---------------------------------------------------------------------------------------------------------

    class Stack_____Queue
    {
        // Stack
        // First in Last Value

        public void stack()
        {
            Stack<int> st = new Stack<int>();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push(40);

            Console.WriteLine(st.Pop());
        }


        public static void Main()
        {
            Stack_____Queue obj = new Stack_____Queue();
            obj.stack();

        }
    }

    // -----------------------------------------------------------------------------------------------


    // Queue
    // First in Last Value

    class Queue
    {
        public void Que()
        {
            Queue<int> Qu = new Queue<int>();
            Qu.Enqueue(10);
            Qu.Enqueue(20);
            Qu.Enqueue(30);
            Qu.Enqueue(40);

            Console.WriteLine(Qu.Dequeue());

        }

        public static void Main()
        {
            Queue qu = new Queue();
            qu.Que();
        }

        internal void Enqueue(int v)
        {
            throw new NotImplementedException();
        }

        internal bool Dequeue()
        {
            throw new NotImplementedException();
        }
    }
}
