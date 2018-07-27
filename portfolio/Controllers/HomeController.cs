
using Microsoft.AspNetCore.Mvc;
using System;

namespace portfolio.Controllers
{
    public class HomeController : Controller   //remember inheritance??
    {
        [HttpGet]
        [Route("")]
        public IActionResult Home()
        {
            return View();
        }
        [HttpGet] 
        [Route("projects")]    
        public IActionResult Projects()
        {
            return View();
        }
        [HttpGet] 
        [Route("contact")]    
        public IActionResult Contacts()
        {
            return View();
        }

    }
}