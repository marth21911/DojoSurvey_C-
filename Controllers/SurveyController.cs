using Microsoft.AspNetCore.Mvc;
using System;
namespace DojoSurvey
{
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("index");
        }
        [HttpPost("Survey")]
        public IActionResult Survey(string Name, string Location, string Language, string Comments)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comments= Comments;
            return View("Result");
        }
        [HttpGet("result")]
        public IActionResult Result()
        {
            return View("result");
        }

    }
}