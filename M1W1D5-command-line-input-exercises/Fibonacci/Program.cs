using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /*
         The Fibonacci numbers are the integers in the following sequence:  
	        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
         By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
 
         Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number.
  
         C:\Users> Fiboncci
         Please enter the Fibonacci number: 25
         
         0, 1, 1, 2, 3, 5, 8, 13, 21
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Fibonacci number:");
            string input = Console.ReadLine();
            int inputValue = int.Parse(input);
            int firstValue = 0;
            int secondValue = 1;
            int sum = 0;

            for(int i = 1; sum < inputValue; i++)
            {
                sum = firstValue + secondValue;
                firstValue = secondValue;
                secondValue = sum;
                if (i == 1)
                {
                    Console.WriteLine(0);
                    Console.WriteLine(1);
                }

                if (sum < inputValue)
                {
                    Console.WriteLine(sum);
                }
            }

        }
    }
}
