using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class OrderedController : Controller
    {
        // GET: Ordered
        public ActionResult Index()
        {
            return View("xOrdered");
        }

        public ActionResult XOrdered()
        {
            return View("xOrdered");
        }

        public ActionResult XOrderedResult(FullNameOrderModel obj)
        {
            FullNameOrderModel model = new FullNameOrderModel();

            model.FirstName = obj.FirstName;
            model.MiddleInitial = obj.MiddleInitial;
            model.LastName = obj.LastName;
            model.Order = obj.Order;


            return View("xOrderedResult", model);
        }
    }
}