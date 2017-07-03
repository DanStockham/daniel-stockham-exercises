using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validation.Web.Models;

namespace Validation.Web.Controllers
{
    public class UsersController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View("Login");
        }

        // Add the following Controller Actions

        // GET: User/Register
        // Return the empty registration view

        // POST: User/Register
        // Validate the model and redirect to confirmation (if successful) or return the 
        // registration view (if validation fails)        

        // GET: User/Login
        // Return the empty login view
        public ActionResult Login()
        {
            return View("Login");
        }

        // POST: User/Login  
        // Validate the model and redirect to login (if successful) or return the 
        // login view (if validation fails)
        [HttpPost]
        public ActionResult Login(LoginViewModel login)
        {
          if(!ModelState.IsValid)
            {
                return View("Login", login);
            }

            return RedirectToAction("Confirmation", "Users");
        }
        // GET: User/Confirmation
        // Return the confirmation view
        public ActionResult Confirmation()
        {
            return View("Confirmation");
        }
    }
}