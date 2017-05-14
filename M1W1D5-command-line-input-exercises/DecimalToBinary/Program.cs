using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        /*
        Write a command line program which prompts the user for a series of decimal integer values  
        and displays each decimal value as itself and its binary equivalent

        C:\Users> DecimalToBinary
        
        Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321
        
        460 in binary is 111001100
        8218 in binary is 10000000011010
        1 in binary is 1
        31313 in binary is 111101001010001
        987654321 in binary is 111010110111100110100010110001
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a series of decimal values (separated by spaces):");
            char splitChar = ' ';
            string decimalNumbers = Console.ReadLine();
            string binary = "";
            int powerOfTwo = 1;
            string[] stringArr = decimalNumbers.Split(splitChar);
            int[] decimalArr = new int[stringArr.Length];
            string[] binaries = new string[decimalArr.Length];
            




            for (int i = 0; i < stringArr.Length; i++)
            {
                decimalArr[i] = int.Parse(stringArr[i]);
                
            }

            for (int i = 0; i < decimalArr.Length; i++)
            {
                for (powerOfTwo = 1; powerOfTwo <= decimalArr[i];)
                {
                    powerOfTwo *= 2;


                }

                powerOfTwo /= 2;

                for (int j = powerOfTwo; j >= 1; j /= 2)
                {
                    if ((decimalArr[i] - j) >= 0)
                    {
                        binary += "1";
                        decimalArr[i] -= j;

                    }
                    else
                    {
                        binary += "0";
                    }

                }
                binaries[i] = binary;
                binary = "";

            }

            for(int i = 0; i < binaries.Length; i++)
            {
                Console.WriteLine($"{ stringArr[i] } in binary is { binaries[i] }");
            }
        }
    }
}