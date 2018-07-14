using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCoreMVC.Models;

namespace ASPNETCoreMVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "This is for testing purposes only.";
            return View();
        }
    }
}