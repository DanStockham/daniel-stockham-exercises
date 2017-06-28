using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class LastTwoController : Controller
    {
        // GET: LastTwo
        public ActionResult LastTwo()
        {
            return View("LastTwo");
        }

        public ActionResult LastTwoResult(LastTwoModel obj)
        {
            LastTwoModel model = new LastTwoModel();
            model.Words = obj.Words;
            return View("LastTwoResult", model);
        }
    }
}