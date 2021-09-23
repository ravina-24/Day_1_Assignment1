using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1_Assignment1
{
    class PrintThreeNames
    {

        public void printNames()
        {


            int n = 3;

            string[] arr = new string[n];
            Console.Write("Enter strings below  = ");
            for (int i = 0; i<n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            

            for (int i = 0; i<arr.Length; i++)
            {
               

                for (int j = 0; j<arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                       string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                   
                }
            }
            Console.Write("After sorting the array appears like : Hi ");
           for ( int i = 0; i < arr.Length; i++)
           {
                Console.Write(arr[i] + "," + " ");

           }
         Console.WriteLine();
        }
    }
}
