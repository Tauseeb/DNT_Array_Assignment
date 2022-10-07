using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Array_Assignment
{
    internal class AverageOfArrayElements
    {
        public static void Main()
        {
            double sum = 0, avg = 0;
            double[] numbers = new double[5];
            Console.WriteLine("Enter Array Element for Calculate the Average of Array elements..");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                
                sum = sum+ numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine("The Sum is : " + sum);
            Console.WriteLine("The Average is : " + avg);
            
            Console.ReadLine();
        }
    }
}