using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Array_Assignment
{
    internal class CalculateStandardDeviation
    {       
            public void check(double[] varStr)
            {
                 
                double mean, sum = 0, sd = 0;
                int i;
                for(i=0;i<5;i++)
                {
                    sum=sum+varStr[i];
                }
                mean=sum/5;
                for(i=0;i<5;i++)
                {
                    sd = sd + Math.Pow(varStr[i]-mean,2);
                }
                Console.WriteLine("The standard deviation is : " + Math.Sqrt(sd / 5));              
                
            }
        
        static void Main(string[] args)          
        {
            int k;
            double[] varStr= new double[5];
            Console.WriteLine("Enter Array Element.. ");
            for (k = 0; k< 5; ++k)
            {
                varStr[k] = Convert.ToInt32(Console.ReadLine());
            }
            CalculateStandardDeviation obj = new CalculateStandardDeviation();
            obj.check(varStr);           
           
            Console.ReadLine();            
        }
    }
}
