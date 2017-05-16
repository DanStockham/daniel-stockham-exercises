using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return the count of the number of times that a substring length 2 appears in the string and 
         also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
         last2("hixxhi") → 1
         last2("xaxxaxaxx") → 1
         last2("axxxaaxx") → 2
         */
        public int Last2(string str)
        {
            int count = 0;
            string firstChars = str.Substring(0, 2);
            string lastChars = str.Substring(str.Length - 2, 2);

            for(int i = 2; i < str.Length - 1; i++)
            {
                if(str[i] == firstChars[0] && str[i + 1] == firstChars[1])
                {
                    count++;

                }
                
                
            }
            return count;
        }
    }
}
