using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyText()
        {
            return Content("**********Product Controller**********");
        }
        public IActionResult MyJSON()
        {
            return Json(new { name = "Surface Pro Laptop", message = "The Surface Pro 6 Is Your Perfectly Light, Incredibly Powerful Travel Laptop. ." });
        }
        public IActionResult MyHTML()
        {
            var h = "<!DOCTYPE html><html><body>This is the best laptop I have ever used" +
            "<br><br> <a href='/Product'>Return</a></body></html>";
            return Content(h, "text/html");
        }

        public IActionResult MyView()
        {
            return View();
        }
    }
}