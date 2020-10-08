using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CanadapostAPI.Models;
using CanadapostAPI.Service;

namespace CanadapostAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            CanadapostAPIService service = new CanadapostAPIService();
            var mailedBy = "4008838";
            var response = service.GetRate(mailedBy);
            return View(response);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
