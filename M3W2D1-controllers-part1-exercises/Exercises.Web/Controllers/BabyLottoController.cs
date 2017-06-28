using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class BabyLottoController : Controller
    {
        // GET: BabyLotto
        public ActionResult BabyLotto()
        {
            return View("BabyLotto");
        }

        public ActionResult BabyLottoResult(BabyLottoModel obj)
        {
            BabyLottoModel model = new BabyLottoModel();

            model.LottoNum = obj.LottoNum;

            return View("BabyLottoResults", model);
        }
    }
}