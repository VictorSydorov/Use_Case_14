using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;
using System.Globalization;
using Use_Case_14.Helpers;
using Use_Case_14.Models;

namespace Use_Case_14.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> stringLocalizer;

        public HomeController(IStringLocalizer<HomeController> stringLocalizer)
        {
            this.stringLocalizer = stringLocalizer;
        }

        public IActionResult Index()
        {
            var culture = CultureInfo.CurrentCulture;
            ViewBag.Datetimes = new string[] {
                DateTime.Now.FormatShortDate(culture),
                DateTime.Now.FormatLongDate(culture),
                DateTime.Now.FormatShortTime(culture),
                DateTime.Now.FormatLongTime(culture)
            };

            ViewBag.Numbers = new int[] { 100, 1000, 1000000, 1000000000 }.Select(i => i.FormatNumber(culture));

            ViewBag.UoM = new string[] { 10.0.FormatLength(culture), 10.0.FormatVolume(culture) , 10.0.FormatWeight(culture) };
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}