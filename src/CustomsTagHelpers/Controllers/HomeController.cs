﻿using Microsoft.AspNet.Mvc;
using CustomsTagHelpers.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomsTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = new Products(); 
            return View(products);
        }
    }
}
