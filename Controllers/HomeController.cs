using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestPowtorka.DAL;
using TestPowtorka.Models;

namespace TestPowtorka.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        PowtorkaContext powtorkaContext;

        public HomeController(ILogger<HomeController> logger, PowtorkaContext powtorkaContext)
        {
            this.powtorkaContext = powtorkaContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        public IActionResult Authors()
        {
            ViewBag.Autorzy = powtorkaContext.Autorzy.ToList();

            return View();
        }

        public IActionResult Books(int id)
        {
            ViewBag.Ksiazki = powtorkaContext.Ksiazki.Where(x => x.AutorId.Equals(id)).ToList();

            return View();
        }

    }
}
