using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace SurveyForm.Controllers
{
    public class Survey : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Errors = new List<string>();
            return View();
        }

        [HttpPost]
        [Route("method")]
        public IActionResult Method(string name, string location, string language, string comment)
        {
            ViewBag.Errors = new List<string>();
            if(name == null)
            {
                ViewBag.Errors.Add("Name cannot be empty");
            }
            if(location == null)
            {
                ViewBag.Errors.Add("Please select a valid location");
            }
            if(language == null)
            {
                 ViewBag.Errors.Add("Please select a valid language");
            }
            if(comment == null)
            {
                comment = "";
            }
            if(ViewBag.Errors.Count > 0 )
            {
                return View("Index");
            }

            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;

            return View("Results");
        }

    }
}