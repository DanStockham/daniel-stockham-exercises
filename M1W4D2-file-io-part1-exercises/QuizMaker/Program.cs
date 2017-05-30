using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = Environment.CurrentDirectory;
            string file = "sample-quiz-file.txt";
            string filePath = Path.Combine(dir, file);

            using (StreamReader sr = new StreamReader(filePath))
            {
                int marks = 0;
                int totalQuestions = 0;
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('?');
                    totalQuestions++;
                    string question = line[0];
                    int answer = 0;
                    List<string> choices = new List<string>();
                    choices.AddRange(line[1].Split('|'));

                    Console.WriteLine(question);
                    foreach (string item in choices)
                    {
                        if (item.Contains('*'))
                        {
                            item.Replace("*", string.Empty);
                            answer = choices.IndexOf(item);
                        }
                        Console.WriteLine(item);
                    }
                    string userInput = Console.ReadLine();

                    if(int.Parse(userInput) == answer)
                    {
                        Console.WriteLine("RIGHT!!");
                        marks++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that was not the right answer");
                    }
                }
                Console.WriteLine($"You got {marks} answer(s) correct out of the total {totalQuestions} questions asked ");
            }

            
        }
    }
}
