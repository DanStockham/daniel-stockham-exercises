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

            return View("FizzBuzzResult");
        }
    }
}