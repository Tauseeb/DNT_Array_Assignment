using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Array_Assignment
{
    internal class ConcatenateTwoArrays
    {
        public static void Main()
        {
            int i = 0;
            int j = 0;

            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[10];

            //Read numbers into array
            Console.WriteLine("Enter elements of ARR1 : ");
            for (i = 0; i < 5; i++)
            {                 
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Enter elements of ARR2 : ");
            for (i = 0; i < 5; i++)
            {                
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            // Concatenate arr1 and arr2 to arr3

            for (i = 0, j = 0; i < 5; i++)
            {
                arr3[j++] = arr1[i];
            }
            for (i = 0; i < 5; i++)
            {
                arr3[j++] = arr2[i];
            }
                      
            Console.WriteLine("Array Elements are Concatenated : ");
            for (i = 0; i < 10; i++)
            {
                Console.Write(arr3[i]);

            }

            Console.ReadLine();
        }
    }
}

        
