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
            if (digit.numberTwo == digit.numberOne)
                ModelState.AddModelError("numberOne", "The numbers are equal");
            else if (digit.numberTwo < digit.numberOne)
                ModelState.AddModelError("numberOne", "Incorrectly entered numbers in the range");

            if (ModelState.IsValid)
            {
                Random rand = new Random();
                digit.result = rand.Next(digit.numberOne, digit.numberTwo+1);
            }

            return View(digit);
        }
    }
}
