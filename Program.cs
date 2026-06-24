using System;

namespace Array
{
    class Program
    {
        // Main method is the entry point of the program
        // It is where the program starts execution
        // In this program, we will create an array of integers and print its elements
        // An array is a collection of items stored at contiguous memory locations
        // We will create an array of 5 integers and initialize it with some values
        // Then we will use a for loop to iterate through the array and print each element
        // We will also create a multi-dimensional array (2D array) and print its elements using nested for loops

        static void Main(string[] args)
        {
            
            ////single dimensional array
            //int[] array = { 11, 22, 33, 44, 55 };

            //for (int i = 0; i < 5; i++)
            //Console.WriteLine(array[i]);

            //--------------------------------------------------------------------------------------------

            //multi dimensional array

            //int[,] arr =
            //{
            //    {22,44,55},
            //    {66,77,88},
            //    {19,12,21},
                
            //};

            //for(int i =0; i < 3; i++)
            //{
            //    for(int j = 0; j <3; j++)
            //    {                  
            //            Console.WriteLine(arr[i,j]);
            //    }
            
            //}


            //----------------------------------------------------------------------------------------------
            

            string[] name = new string[5];
            name[0] = "Siva";
            name[1] = "Prakash";
            name[2] = "Jhone";
            name[3] = "Ragul";
            name[4] = "Sri";

            for(int i = 0; i< 5; i++)
            {
                Console.WriteLine(name[i]);
            }

        }
    }

}











