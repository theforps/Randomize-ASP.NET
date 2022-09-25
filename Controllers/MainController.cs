﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Randomize.Models;

namespace Randomize.Controllers
{
    public class MainController : Controller
    {
        //get
        public ActionResult Main()
        {
            return View();
        }

        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Main(Digits digit)
        {
            if (ModelState.IsValid)
            {
                Random rand = new Random();
                digit.result = rand.Next(digit.numberOne, digit.numberTwo+1);
            }

            return View(digit);
        }
    }
}
