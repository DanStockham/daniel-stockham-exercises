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
         Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or 
         whatever is there if the string is less than length 3. Return n copies of the front;
         frontTimes("Chocolate", 2) → "ChoCho"
         frontTimes("Chocolate", 3) → "ChoChoCho"
         frontTimes("Abc", 3) → "AbcAbcAbc"
         */
        public string FrontTimes(string str, int n)
        {
            int count = 0;
            string newStr = "";

            if (str.Length < 3)
            {
                while (count < n) //changed from <= to <
                {
                    newStr += str;
                    count++;
                }
            }
            
            else  //changed from "if (str.Length >= 3)" to "else"
            {
                string front = str.Substring(0, 3); //moved inside of "else"

                while (count < n) //changed from <= to <
                {
                    newStr += front;
                    count++;
                }
            }
            return newStr;

        }

    }
}
