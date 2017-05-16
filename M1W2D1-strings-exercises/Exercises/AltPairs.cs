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
         Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
         altPairs("kitten") → "kien"
         altPairs("Chocolate") → "Chole"
         altPairs("CodingHorror") → "Congrr"
         */
        public string AltPairs(string str)
        {
            string result = "";
<<<<<<< HEAD
            for(int i = 0; i < str.Length; i++)
            {
                if(i % 4 == 0 || i % 4 == 1)
                {
                    result = result + str.Substring(i, 1);
                }
                

            }

            return result;
            
=======

            //for (int i = 0; i < str.Length-1; i += 4)
            //{
            //    result = result + str.Substring(i, 2);
            //}

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 4 == 0 || i % 4 == 1)
                {
                    result = result + str.Substring(i, 1);
                }
            }


            return result;
>>>>>>> ae5cba06a9256c80e68ec5a5837440ec16f2f69e
        }
    }
}
