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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end 
        should not be removed.
        stringX("xxHxix") → "xHix"
        stringX("abxxxcd") → "abcd"
        stringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            string newStr = "";

            for(int i = 0; i < str.Length; i++ )
            {
                if(str[i] != 'x')
                {
                    newStr += str[i];
                }
            }

            if (str.Length < 2) 
            {
                return str;
            } 
            else if (str[0] == 'x' && str[str.Length - 1] == 'x')
            {
                return "x" + newStr + "x";
            }
            else
            {
                return newStr;
            }
        }
    }
}
