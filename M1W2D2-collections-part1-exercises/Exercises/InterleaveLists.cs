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
         Given two lists of Integers, interleave them beginning with the first element in the first list followed
         by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
         Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
         list to the new list before returning it.
		 DIFFICULTY: HARD
         interleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
         */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            List<int> interleaving = new List<int>();
            int extraInt = 0;
            
            if( listOne.Count() > listTwo.Count())
            {
                extraInt = listOne[listOne.Count() - 1];
                listOne.Remove(extraInt);
            }
            else if(listTwo.Count() > listOne.Count())
            {
                extraInt = listTwo[listTwo.Count() - 1];
                listTwo.Remove(extraInt);
            }

            for(int i = 0; i < listOne.Count(); i++)
            {
                interleaving.Add(listOne[i]);
                interleaving.Add(listTwo[i]);
            }

            if (extraInt > 0)
            {
                interleaving.Add(extraInt);
            }
            
            
            
            return interleaving;
        }
    }
}
