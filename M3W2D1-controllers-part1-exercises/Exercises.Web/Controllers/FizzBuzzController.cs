using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        public ActionResult FizzBuzz()
        {
            return View("FizzBuzz");
        }

        public ActionResult FizzBuzzResult(FizzBuzzModel obj)
        {
            FizzBuzzModel model = new FizzBuzzModel();

            model.FirstDiv = obj.FirstDiv;
            model.SecondDiv = obj.SecondDiv;
            model.Fizz = obj.Fizz;
            model.Buzz = obj.Buzz;
            model.Num = obj.Num;

            return View("FizzBuzzResult", model);
        }
    }
}