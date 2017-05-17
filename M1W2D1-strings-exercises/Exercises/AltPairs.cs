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
         Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
         altPairs("kitten") → "kien"
         altPairs("Chocolate") → "Chole"
         altPairs("CodingHorror") → "Congrr"
         */
        public string AltPairs(string str)
        {
            string result = "";

            for(int i = 0; i < str.Length; i++)
            {
                if(i % 4 == 0 || i % 4 == 1)
                {
                    result = result + str.Substring(i, 1);
                }
                

            }

            return result;
            

            
        }
    }
}
