using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * csc200
 * This program finds the convergence of an alternating sequence accurate to .000001
 */

namespace AlternatingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            double numerator = 1;
            double denominator = 3;
            //two sums used for comparison to determine accuracy
            double sum1 = 1;
            double sum2 = 1;
            //boolean sign acts as a switch to determine whether to subtract or add
            bool sign = false;
            //counter acts as a counter to see how many times the loop was executed
            int counter =0;

            while (true)
            {
                //addition case
                if (sign == true)
                {
                    //assign value of sum 2 to sum1 and do operation
                    sum1 = sum2 + (numerator / denominator);
                    denominator += 2;
                    sign = false;
                }
                //loops starts here because we must subract first
                //subtraction case
                else
                {
                    //assign value to sum 2 that is previous sum1 and do operation
                    sum2 = sum1 - (numerator / denominator);
                    denominator += 2;
                    sign = true;
                }
               
                //keeps track of amount of iterations
                counter += 1;
                //Console.WriteLine(sum1);
               // Console.WriteLine(sum2);
                //when accuracy is correct escape loop
                if ((sum1 - sum2) < 0.000001) break; 
            }
            

            Console.WriteLine("Counter: " + counter + " iterations");
            Console.WriteLine("Number: " + sum1);
        }
    }
}

