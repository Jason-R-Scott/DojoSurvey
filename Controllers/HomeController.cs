using System;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey
{

    public class HomeController : Controller
    {

        [HttpGet ("")]

        public ViewResult Index ()
        {
            return View();
        }

        [HttpPost ("Result")]

        public IActionResult Result (string Name, string City, string Language, string Comments)
        {
            ViewBag.Name = Name;
            ViewBag.City = City;
            ViewBag.Language = Language;
            ViewBag.Comments = Comments;
            return View ();
        }

        [HttpGet ("contact")]

        public ViewResult Contact ()
        {
            return View();
        }

    }

}