﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace RazorPagesMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int numtimes=1)
        {
            ViewData["name"] = name;
            ViewData["numtimes"] = numtimes;
            return View();  
        }
    }
}
