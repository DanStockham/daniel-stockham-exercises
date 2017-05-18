using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the 
         * number of times that string appears in the array.
         * 
         * ** A CLASSIC **
         * 
         * wordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * wordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * wordCount([]) → {}
         * wordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         * 
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            HashSet<string> wordCountParse = new HashSet<string>();
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach(string item in words)
            {
                wordCountParse.Add(item);
            }

            foreach(string word in wordCountParse)
            {
                wordCount.Add(word, 0);
            }

            foreach(string item in words)
            {
                wordCount[item] += 1;
            }

            return wordCount;
        }
    }
}
