using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Initialize ViewBag properties with initial values.
            ViewBag.Fifteen = 0;
            ViewBag.Twenty = 0;

            // Fix: Corrected the typo in the ViewBag property name.
            ViewBag.TwentyFive = 0;

            // Fix: Added a return statement to return a view.
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator calc)
        {
            if (ModelState.IsValid)
            {
                // Calculate and set ViewBag properties for different tip percentages.
                ViewBag.Fifteen = calc.CalculateTip(0.15);
                ViewBag.Twenty = calc.CalculateTip(0.20);
                ViewBag.TwentyFive = calc.CalculateTip(0.25);
            }
            else
            {
                // Handle the case where ModelState is not valid (e.g., form validation failed).
                // Set ViewBag properties to 0 to ensure they are not null.
                ViewBag.Fifteen = 0;
                ViewBag.Twenty = 0;

                // Fix: Corrected the typo in the ViewBag property name.
                ViewBag.TwentyFive = 0;
            }
            // Return the view with the 'calc' model.
            return View(calc);
        }
    }
}
