using Microsoft.AspNetCore.Http;
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
            return View();
        }
    }
}
