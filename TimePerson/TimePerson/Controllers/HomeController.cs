using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimePerson.Models;
using Microsoft.AspNetCore.Mvc;

namespace TimePerson.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Default Home route for our home page
        /// </summary>
        /// <returns>Generated View</returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int begYear, int endYear)
        {
            // To redirect to our results action with the "results" of our query

            List<TimePersonModel> persons = TimePersonModel.GetPersons(begYear, endYear);

            return null;
        }

        public IActionResult Results(List<TimePersonModel> persons)
        {
            return View(persons);
        }
    }
}