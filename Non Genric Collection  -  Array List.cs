using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    // Non Genric Collection 

    // ArrayList
    // HashTable
    // Stack
    // Queue

    class Non_Genric_Collection_____Array_List
    {

        // ArrayList

        // Stores elements of any type
        // Mixed data allowed

        public void arraylist()
        {
            ArrayList arr = new ArrayList();

            arr.Add(10);
            arr.Add("Siva");
            arr.Add(133.34);

            foreach(var it in arr)
            {
                Console.WriteLine(it);
            }
        }
        public static void Main(string[] args)
        {
            Non_Genric_Collection_____Array_List array = new Non_Genric_Collection_____Array_List();
            array.arraylist();
        }
    }



    // HashTable
    // Stores key-value pairs
    class Hash
    {
        public void tab()
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "Siva");
            ht.Add(2, "Prakash");

            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }
        public static void Main(string[] args)
        {
            Hash hash = new Hash();
            hash.tab();
        }
    }



    // Stack  
    // Last In First Value collection

    class stack
    {
        public void st()
        {
            Stack sta = new Stack();
            sta.Push(30);
            sta.Push(40);
            sta.Push(10);
            sta.Push(50);

            Console.WriteLine(sta.Pop());         

        }

        public static void Main(string[] args)
        {
            stack sk = new stack();
            sk.st();
        }
    }

    
    // Queue

    //class Que
    //{

    //    // First In First Value collection

    //    public void qu()
    //    {
    //         Queue y = new Queue();
    //        y.Enqueue(23);
    //        y.Enqueue(45);

    //        Console.WriteLine("Queue (Dequeue): " + y.Dequeue());

    //    }
    //}


}
