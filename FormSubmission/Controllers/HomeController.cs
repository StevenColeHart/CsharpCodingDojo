
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
   
            return View();
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(User user)
        {

            if(ModelState.IsValid == false){
                ViewBag.errors = ModelState.Values;
                return View("Errors");
            }

            return RedirectToAction("Result");
        }
        [HttpGet]
        [Route("Success")]
        public IActionResult Result()
        {
            return View("Result");
        }
    }

}