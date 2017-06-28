using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
    public class FizzBuzzModel
    {
        public int FirstDiv { get; set; }
        public int SecondDiv { get; set; }
        public string Fizz { get; set; }
        public string Buzz { get; set; }
        public List<int> Num { get; set; } = new List<int>();
       


    }
}