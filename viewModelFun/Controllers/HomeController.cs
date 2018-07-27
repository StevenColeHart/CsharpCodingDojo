using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewModelFun.Models;

namespace viewModelFun.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            User user = new User(){
                firstname = "Steven",
                lastname = "Hart"
            };
            return View(user);
        }
        [HttpGet]
        [Route("message")]
        public IActionResult Message(){

            Message MLK = new Message(){
                words= "I have a dream!"
            };

            return View(MLK);
        }
        [HttpGet]
        [Route("numbers")]
        public IActionResult Numbers(){
            int [] numbers = new Numbers{
                1,3,6,9,3,5,7,8,7666,4454
            };
            return View(numbers);
        }

    }
}
