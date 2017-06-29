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
            return View("Home", allReviews);
        }    

        public ActionResult Home()
        {
            List<ReviewModel> allReviews = reviewsDAL.GetAllReviews();
            return View("Home");
        }

        public ActionResult Review()
        {
            return View("Review");
        }
        public ActionResult Review(ReviewModel obj)
        {
            reviewsDAL.SaveReview(obj);

            return RedirectToAction("Review", "Home");
        }
    }
}