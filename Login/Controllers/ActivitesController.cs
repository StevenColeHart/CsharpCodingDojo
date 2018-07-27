using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Login.Models;
using System.Linq;

namespace Login.Controllers
{
    public class ActivitesController : Controller
    {
        private UserContext _context;
 
        public ActivitesController(UserContext context)
        {
            _context = context;
        }
        // [HttpGet]
        // [Route("welcome")]
        // public IActionResult Welcome()
        // {
            
        //     return View();
        // }

    }
}