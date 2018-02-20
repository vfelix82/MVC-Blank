using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Name.Models;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index(){
        return View();
    }

}
