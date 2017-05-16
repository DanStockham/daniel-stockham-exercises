﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed, but 
         the "a" can be any char. The "yak" strings will not overlap.
         stringYak("yakpak") → "pak"
         stringYak("pakyak") → "pak"
         stringYak("yak123ya") → "123ya"
         */
        public string StringYak(string str)
        {
            string replaceYak = str.Replace("yak", "d");
            string newStr = "";

            for(int i = 0; i < replaceYak.Length; i++)
            {
                if(replaceYak[i] != 'd')
                {
                    newStr += replaceYak[i];
                }
            }
            return newStr;
        }
    }
}