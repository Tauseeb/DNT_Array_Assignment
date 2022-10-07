using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Array_Assignment
{
    internal class LargestElement
    {
        public static void Main()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter Array Element To Find Largest Element: ");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("After Element: ");
            Array.Sort(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Reverse Elements: ");
            Array.Reverse(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Second Lergest Element is {0}", arr[0]);

        }
    }
}
