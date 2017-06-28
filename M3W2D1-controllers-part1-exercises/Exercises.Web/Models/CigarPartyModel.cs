using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercises.Web.Models;

namespace Exercises.Web.Models
{
    public class CigarPartyModel
    {
        public int NumOfSquirrels { get; set; }
        public bool IsWeekend { get; set; }

        public bool IsSuccess()
        {
            if(NumOfSquirrels >= 40 && NumOfSquirrels <= 60)
            {
                return true;
            }
            else if (NumOfSquirrels >= 40 && IsWeekend)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}