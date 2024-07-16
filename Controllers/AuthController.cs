using practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practice.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Account model) 
        {
            if (model.Name == "Himel" && model.Password == "1234")
            {
                ModelState.Clear(); 
                Session["User"] = model.Name;
                ViewBag.Message = "True";
                return RedirectToAction("Index", "Home");
            }
            else ViewBag.Message = "False";
            return View();
        }
        public ActionResult Logout() 
        {
            Session.Remove("User");
            return RedirectToAction("Login", "Auth");
        }
    }
}