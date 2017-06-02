using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is the name of the input file?");
                string inputFile = Console.ReadLine();
                string dir = Environment.CurrentDirectory;
                string filePath = Path.Combine(dir, inputFile);
                Console.WriteLine("How many lines of text (max) should there be in the split files?");
                int lines = int.Parse(Console.ReadLine());
                List<string> docLines = new List<string>();

                using (StreamReader sr = new StreamReader(filePath))
                {

                    while (!sr.EndOfStream)
                    {
                        docLines.Add(sr.ReadLine());
                    }
                    

                }
                Console.WriteLine();
                Console.WriteLine($"The input file had {docLines.Count()} lines of text");
                Console.WriteLine($"For a {docLines.Count()} line input file \"{inputFile}\" this will produce {docLines.Count() / lines} output files");
                Console.WriteLine();
                Console.WriteLine("***GENERATING OUTPUT***");

                int startLine = 0;
                int endLine = lines;

                for(int i = 0; i < docLines.Count() / lines; i++)
                {
                    if(docLines.Count() - endLine < 30)
                    {
                        startLine = docLines.Count() - lines;
                        endLine = docLines.Count();
                    }
                    else
                    {
                        startLine = endLine;
                        endLine += lines;
                    }

                    string newFileOutput = inputFile.Substring(0, inputFile.Length - 4) + "-" + (i + 1) + ".txt";

                    Console.WriteLine();
                    Console.WriteLine($"Generating {newFileOutput}");

                    StreamWriter sw = new StreamWriter(Path.Combine(dir, newFileOutput), false);
                    
                    for(int j = startLine; j < endLine; j++)
                    {
                        sw.WriteLine(docLines[j]);
                    }

                    
                       
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("The file entered could not be found. Please try again");
            }
        }
    }
}
