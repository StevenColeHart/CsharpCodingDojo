using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;
using DbConnection;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //string command = "SELECT * FROM quotes";
            //var quotes = DbConnector.Query(command);
            //ViewBag.quotes = quotes;
            //return View("Quotes");
           return View(new Quote());
        }
        
        [HttpPost]
        [Route("Quotes")]
        public IActionResult Quotes(Quote quote)
        {
            if(ModelState.IsValid){
            string user = '"'+ quote.user +'"';
            string text = '"'+ quote.text +'"';
            string queryString = $"INSERT INTO name(user, text)VALUES({user}, {text});";
            DbConnector.Execute(queryString);
            return RedirectToAction("Quotes");
            }
            else{
                return View("Index");
            }
   
        }
        
        [HttpGet]
        [Route("Quotes")]
        public IActionResult Quotes()
        {
            string command = "SELECT * FROM name";
            var allQuotes = DbConnector.Query(command);
            ViewBag.quotes = allQuotes;
            return View("Quotes");
        }
        [HttpGet]
        [Route("UserQuote")]
        public IActionResult UserQuote(int id){

            return View("UserQuote");
        }
    }
}