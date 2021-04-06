using Codedy.StarSecurity.WebApp.Models;
using Codedy.StarSecurity.WebApp.Models.Catalog.Careers;
using Codedy.StarSecurity.WebApp.Views._ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Controllers
{
    public class CareerController : Controller
    {
        private readonly ICareersService _careersService;

        private readonly ILogger<HomeController> _logger;

        public CareerController(ILogger<HomeController> logger, ICareersService careersService)
        {
            _logger = logger;
            _careersService = careersService;
        }

        //GET: Career
        public IActionResult Index()
        {
            var services = _careersService.Careers();

            return View(services);
        }

        public IActionResult Details(Guid? id)
        {
            var carrers = _careersService.Careers();
            var carrer = _careersService.Career(id);
            var info = new CarrerModel()
            {
                Careers = carrers,
                Career = carrer,
            };
            return View(info);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
