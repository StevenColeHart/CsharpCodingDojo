using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Restauranter.Models;
using System.Linq;

namespace Restauranter.Controllers
{
    public class HomeController : Controller
    {
        private ReviewContext _context;
 
        public HomeController(ReviewContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            
            return View("Index");
        }
        [HttpGet]
        [Route("reviews")]
        public IActionResult Reviews()
        {
            List<Review> AllReviews = _context.Review.OrderByDescending(x =>x.created_at).ToList();
            
            ViewBag.elephant = AllReviews;
            return View();
        }
        [HttpPost]
        [Route("newReview")]
        public IActionResult newReview(Review review)
        //the name of the instance must be different than the asp-for on the form
        {
            if(ModelState.IsValid)
            {
                review.created_at=DateTime.Now;
                _context.Add(review);
                _context.SaveChanges();
                return RedirectToAction("Reviews");
            }
            else
            {
                Console.WriteLine("form did not submit");
                return View("Index");
            }
        }
    }
}