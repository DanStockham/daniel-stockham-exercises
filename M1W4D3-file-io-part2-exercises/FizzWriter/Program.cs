using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = Environment.CurrentDirectory;
            string outputFile = "fizzbuzz.txt";
            string filePath = Path.Combine(dir, outputFile);

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    for(int i = 1; i <= 300; i++)
                    {
                        if(i % 3 == 0 && i % 5 == 0)
                        {
                            sw.WriteLine("FizzBuzz");
                        }
                        else if(i % 3 == 0)
                        {
                            sw.WriteLine("Fizz");
                        }
                        else if(i % 5 == 0)
                        {
                            sw.WriteLine("Buzz");
                        }
                        else
                        {
                            sw.WriteLine(i);
                        }
                    }

                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Make sure the file is being created in a directory that exist");
            }
        }
    }
}
