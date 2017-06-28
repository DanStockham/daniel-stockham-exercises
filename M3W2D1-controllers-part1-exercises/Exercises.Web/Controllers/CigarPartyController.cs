using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class CigarPartyController : Controller
    {
        // GET: CigarParty
        public ActionResult CigarParty()
        {
            return View("CigarParty");
        }
        public ActionResult CigarPartyResult(CigarPartyModel obj)
        {
            CigarPartyModel model = new CigarPartyModel();
            model.NumOfSquirrels = obj.NumOfSquirrels;
            model.IsWeekend = obj.IsWeekend;

            return View("CigarPartyResult", model);
        }
    }
}