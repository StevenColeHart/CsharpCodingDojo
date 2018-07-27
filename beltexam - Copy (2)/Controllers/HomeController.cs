using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using beltexam.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace beltexam.Controllers
{
    public class HomeController : Controller
    {
        private BeltExamContext _context;
 
        public HomeController(BeltExamContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            
            return View("Index");
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(User user){
        //the name of the instance must be different than the asp-for on the form
            if(ModelState.IsValid)
            {
                User exists = _context.User.SingleOrDefault(thisuser => thisuser.email == user.email);
                if(exists != null){
                    ModelState.AddModelError("Email", "An account with this email already exists!");
                    return View("Index");
                }

                else{
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.password = Hasher.HashPassword(user, user.password);
                    HttpContext.Session.SetInt32("UserID", user.id);                
                    _context.Add(user);
                    Console.WriteLine(user.password);
                    _context.SaveChanges();
                    return View("Welcome");
                }
            }
            else
            {
                Console.WriteLine("form did not submit");
                return View("Index");
    
            }
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(string email_login, string password_login)
        {
            User checkUser = _context.User.SingleOrDefault(user => user.email == email_login);
            if (checkUser != null && password_login != null){
                var Hasher = new PasswordHasher<User>();
                if(0 != Hasher.VerifyHashedPassword(checkUser, checkUser.password, password_login))
                {
                    Console.WriteLine("logging in");
                    HttpContext.Session.SetInt32("UserID", checkUser.id);
                    return RedirectToAction("Welcome");
                }
                else{
                    ModelState.AddModelError("password", "password invalid");
                    Console.WriteLine("can't log in");
                    return View("Index");
                }
            }
            else{
                return View("Index");
            }
            
        }
        [HttpGet]
        [Route("welcome")]
        public IActionResult Welcome()
        {
            int? UserID =  HttpContext.Session.GetInt32("UserID");
            if (UserID != null)
            {
                User currentUser = _context.User.SingleOrDefault(u => u.id == UserID);
                // var allposts = _context.Post.ToList();



                ViewBag.current_user = currentUser;
                ViewBag.allposts = _context.Post.Include(x => x.creator).ToList().OrderByDescending(x => x.created_at);
                return View("Welcome");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpPost]
        [Route("post")]
        public IActionResult Post(Post newpost){
            int? UserID =  HttpContext.Session.GetInt32("UserID");
            if (UserID != null)
            {

            User currentUser = _context.User.SingleOrDefault(u => u.id == UserID);
            newpost.creator = currentUser;
            newpost.created_at= DateTime.Now;
            _context.Add(newpost);
            _context.SaveChanges();

           
            return RedirectToAction("Welcome");
            }
            else
            {
                return View("Index");
            }

        }
        [HttpPost]
        [Route("delete/{id}")]
        public IActionResult DeletePost(int id){
            Post post = _context.Post.SingleOrDefault(x => x.id == id );
            _context.Remove(post);
            _context.SaveChanges();
            return RedirectToAction("Welcome");
        }


        [HttpGet]
        [Route("logout")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

    }
}
        