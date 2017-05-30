using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> linesFound = new List<String>();

            //1. Ask the user for the search string
            Console.WriteLine("Which word are you searching for in the document?");
            string searchWord = Console.ReadLine();
            Console.WriteLine("Is the word case sensitive? (Y)es or (N)o?");
            bool caseCheck = "y" == Console.ReadLine().ToLower();

            if(!caseCheck)
            {
                searchWord = searchWord.ToLower();
            }

            //2. Ask the user for the file path
           

            //3. Open the file
            {
                try {
                    Console.WriteLine("What is the filepath of the document you want to search?");
                    string dir = Environment.CurrentDirectory;
                    string file = Console.ReadLine();
                    string filepath = Path.Combine(dir, file);

                    int lineNum = 1;
                    using (StreamReader sr = new StreamReader(filepath))
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();

                            if (!caseCheck)
                            {
                                line = line.ToLower();
                            }


                            if (line.Contains(searchWord))
                            {
                                linesFound.Add(lineNum + ") " + line);
                        }

                        lineNum++;
                    }
                }
                catch(IOException e)
                {
                    Console.WriteLine("The file you entered either doesn't exist or is not within this directory");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                
            }

            foreach(string line in linesFound)
            {
                Console.WriteLine(line);
            }
				//4. Loop through each line in the file
					//5. If the line contains the search string, print it out along with its line number
				
			
        }
    }
}
