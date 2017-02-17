using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Collections;
using Newtonsoft.Json;

namespace delapp.Controllers
{
    public class HomeController : Controller
    {
      
        public HomeController()
        {
        }
        public IActionResult Index()
        {
            return View("Index");
        }
        ///////Метод для суши

        public IActionResult Restaurants(string id)
        {
            ViewBag.Rest = id;
            return View();
        }

        public IActionResult Dishes(int id)
        {
            ViewBag.Dish = id;
            return View();
        }

    }
}
