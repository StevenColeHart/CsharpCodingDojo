using Microsoft.AspNetCore.Mvc;
using System;

namespace TimeDate.Controllers{
    public class TimeController : Controller{
        [HttpGet]
        [Route("")]
        public IActionResult Home(){
            return View();
        }
    }
}