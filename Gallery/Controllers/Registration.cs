using Gallery.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gallery.Controllers
{
    public class Registration : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            using (var db = new UserContext())
            {
                db.Add(user);
                db.SaveChanges();
            }
            return View();
        }
    }
}
