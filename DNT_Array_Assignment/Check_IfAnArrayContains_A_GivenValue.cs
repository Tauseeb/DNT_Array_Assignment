using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Array_Assignment
{
    internal class Check_IfAnArrayContains_A_GivenValue
    {
        public static void Main(String[] args)
        {

            int[] num = { 10, 12, 33, 64, 25 };
            int toFind = 34;
            bool found = false;

            for (int n=0;n< num.Length;n++)
            {
                if (num[n]== toFind)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine(toFind + " is found.");
            }
            else
            {
                Console.WriteLine(toFind + " is not found.");
            }

            Console.ReadLine();
        }     
 
    }
}
