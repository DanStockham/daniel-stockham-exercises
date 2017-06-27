using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class ColorizedController : Controller
    {
        // GET: Colorized
        public ActionResult Colorized()
        {
            return View("Colorized");
        }

        public ActionResult ColorizedResult(ColorizedModel obj)
        {
            ColorizedModel model = new ColorizedModel();

            model.FirstName = obj.FirstName;
            model.LastName = obj.LastName;
            model.Red = obj.Red;
            model.Blue = obj.Blue;
            model.Green = obj.Green;

            return View("ColorizedResult", model);
        }
    }
}