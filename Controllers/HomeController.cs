using System;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

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
        public IActionResult Result (Survey postData)
        {
            Survey Info = new Survey
            {
                Name = postData.Name,
                City = postData.City,
                Language = postData.Language,
                Comments = postData.Comments
            };
            return View (Info);
        }

        [HttpGet ("contact")]

        public ViewResult Contact ()
        {
            return View();
        }

    }

}