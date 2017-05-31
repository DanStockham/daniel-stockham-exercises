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
                    for(int i = 1; i < choices.Count(); i++)
                    {
                        if (choices[i].Contains('*'))
                        {
                            choices[i] = choices[i].Replace("*", string.Empty);
                            answer = i;
                        }
                        Console.WriteLine($"{i}. {choices[i]}");
                    }
                    string userInput = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine($"Your answer: {userInput}");

                    if(int.Parse(userInput) == answer)
                    {
                        Console.WriteLine();
                        Console.WriteLine("RIGHT!!");
                        Console.WriteLine();
                        marks++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry, that was not the right answer");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine($"You got {marks} answer(s) correct out of the total {totalQuestions} questions asked ");
            }

            
        }
    }
}
