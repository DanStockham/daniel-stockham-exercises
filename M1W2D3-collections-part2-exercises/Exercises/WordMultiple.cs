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
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         * 
         * wordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * wordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * wordMultiple(["c", "c", "c", "c"]) → {"c": true}
         * 
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, bool> wordDich = new Dictionary<string, bool>();

            foreach (string item in words)
            {
                wordDich[item] = false;
            }

            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < words.Length; j++)
                {


                    if (words[i] == words[j])
                    {
                        count += 1;
                    }
                }
                if (count >= 2)
                {
                    wordDich[words[i]] = true;
                }
            }
            return wordDich;
        }
    }
}
