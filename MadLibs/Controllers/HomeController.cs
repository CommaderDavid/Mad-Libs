using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public string Hello() { return "Hello friend! Welcome to Mad Libs!"; }

        [Route("/form")]
        public ActionResult Form() { return View(); }

        [Route("/lib")]
        public ActionResult Lib(string name, string verb1, string verb2, string verb3, string noun1, string noun2, string noun3, string adj1, string adj2, string adj3)
        {
            LibVariable myLibVariable = new LibVariable(name, verb1, verb2, verb3, noun1, noun2, noun3, adj1, adj2, adj3);
            return View(myLibVariable);
        }
    }
}