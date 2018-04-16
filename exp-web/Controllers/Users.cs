using System;
using exp_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace exp_web.Controllers
{
    public class Users : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [Route("/dede")]
        public IActionResult ViewDetails()
        {
            var user = new User
            {
                Username = "soleng",
                Password = "toto",
                Birthday = new DateTime()
            };

            ViewBag.Username = user.Username;
            ViewBag.Birthday = user.Birthday.ToString();

            return View("Index");
        }
    }
}