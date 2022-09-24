using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Randomize.Models;

namespace Randomize.Controllers
{
    public class MainController : Controller
    {
        //get
        public ActionResult Main(Digits digit)
        {
            digit.numberOne = -100;
            digit.numberTwo = 100;

            Random rand = new Random();

            digit.result = rand.Next(digit.numberOne, digit.numberTwo);

            return View(digit);
        }
        /*
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Main(Digits digit)
        {
            digit.numberOne = -100;
            digit.numberTwo = 100;

            Random rand = new Random();

            digit.result = rand.Next(digit.numberOne, digit.numberTwo);

            return View(digit);
        }*/
    }
}
