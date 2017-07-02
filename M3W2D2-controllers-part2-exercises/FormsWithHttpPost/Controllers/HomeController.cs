using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;

namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["squirrelReviews"].ToString();

        ReviewSqlDAL reviewsDAL;

        public HomeController()
        {
            reviewsDAL = new ReviewSqlDAL(connectionString);
        }

        // GET: Home
        public ActionResult Index()
        {
            List<ReviewModel> allReviews = reviewsDAL.GetAllReviews();
            return View("Index", allReviews);
        }    

        public ActionResult Review()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult Review(ReviewModel obj)
        {
            reviewsDAL.SaveReview(obj);

            return RedirectToAction("Index", "Home", null);
        }
    }
}