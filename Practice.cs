using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Practice
    {
        public static void mb()
        {

            // ---------------  Genric Collection  ----------------------

            // List

            //List <int> val = new List <int> ();
            //val.Add (20);
            //val.Add(100);
            //val.Insert(2, 300);

            //foreach(int s in val)
            //{
            //    Console.WriteLine(s);
            //}



            // Dictionary

            //Dictionary <int,string> ass = new Dictionary<int, string>();

            //ass.Add(101, "Sivaprakash");
            //ass.Add(102, "Surya");
            //ass.Add(103, "Sri");

            //ass.Remove(101); // Remove the value in key value call

            //foreach(var d  in ass)
            //{
            //    Console.WriteLine(d);
            //}




            // Stack ------------> First in Last Out

            //Stack<int> ds = new Stack<int>();
            //ds.Push(100);
            //ds.Push(200);
            //ds.Contains(100);

            //Console.WriteLine(ds.Pop());




            // Queue -------------> First in First Out

            //Queue<int> q = new Queue<int>();
            //q.Enqueue(5);
            //q.Enqueue(10);
            //q.Enqueue(15);
            //q.Enqueue(20);

            //Console.WriteLine(q.Dequeue());






            // --------------  Non Genric Collection  --------------------


            //  ArrayList 

            //ArrayList va = new ArrayList();
            //va.Add(100);
            //va.Add(200);
            //va.Add(300);
            //va.Add(400);

            //va.Insert(1,150);

            //foreach(int i in va)
            //{
            //    Console.WriteLine(i);
            //}


            // Hashtable

            //Hashtable ht = new Hashtable();
            //ht.Add(5,"Siva");
            //ht.Add(10, "Prakash");

            //foreach(DictionaryEntry h in ht)
            //{
            //    Console.WriteLine(h.Key + "" + h.Value);
            //}



            //  Stack --------------> First in Last Out

            //Stack st = new Stack();
            //st.Push(1);
            //st.Push(2);
            //st.Push(3);
            //st.Push(4);
            //st.Push(5);

            //Console.WriteLine(st.Pop());





            // Queue

            Queue ss = new Queue();
            ss.Enqueue(23);
            ss.Enqueue(45);

            Console.WriteLine(ss.Dequeue());

        }

        public static void Main()
        {
            mb();
        }
    }
}
