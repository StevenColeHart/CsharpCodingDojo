using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Login.Models;
using System.Linq;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        private UserContext _context;
 
        public HomeController(UserContext context)
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
                    _context.Add(user);
                    Console.WriteLine(user.password);
                    _context.SaveChanges();
                    return RedirectToAction("Welcome", "Activites");
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
                    HttpContext.Session.SetInt32("UserID", checkUser.idUser);
                    return RedirectToAction("Welcome");
                }
                else{
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
                User currentUser = _context.User.SingleOrDefault(u => u.idUser == UserID);
                ViewBag.current_user = currentUser;
                return View("Welcome");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet]
        [Route("new")]
        public IActionResult New(){
            return View();

        }
    }
}
        