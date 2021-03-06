﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints length 3, figure out which is larger between the first and last elements 
         in the array, and set all the other elements to be that value. Return the changed array.
         maxEnd3([1, 2, 3]) → [3, 3, 3]
         maxEnd3([11, 5, 9]) → [11, 11, 11]
         maxEnd3([2, 11, 3]) → [3, 3, 3]
         */
        public int[] MaxEnd3(int[] nums)
        {
            int max;

            if(nums[0] > nums[nums.Length - 1])
            {
                max = nums[0];
            }
            else if(nums[0] < nums[nums.Length - 1])
            {
                max = nums[nums.Length - 1];
            }
            else
            {
                max = nums[0];
            }

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = max;
            }

            return nums;
        }

    }
}
