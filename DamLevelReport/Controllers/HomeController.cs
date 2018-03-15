using DamLevelReport.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace DamLevelReport.Controllers
{
   
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
         

            var name = User.Identity.GetUserName();
            var identity = new ClaimsIdentity();



            ViewBag.rock = name;
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Roles = "User")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }     
}