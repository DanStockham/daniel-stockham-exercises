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
         Given an array of Strings, return a List containing the same Strings in the same order 
         except for any words that contain exactly 4 characters.
         no4LetterWords( {"Train", "Boat", "Car"} )  ->  ["Train", "Car"]
         no4LetterWords( {"Red", "White", "Blue"} )  ->  ["Red", "White"]
         no4LetterWords( {"Jack", "Jill", "Jane", "John", "Jim"} )  ->  ["Jim"]
         */
        public List<string> No4LetterWords(string[] stringArray)
        {
            List<string> stringList = new List<string>();
            stringList.AddRange(stringArray);

            foreach(string word in stringArray)
            {
                if(word.Length == 4)
                {
                    stringList.Remove(word);
                }
            }

            return stringList;
        }

    }
}
