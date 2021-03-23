using Codedy.StarSecurity.WebApp.Models;
using Codedy.StarSecurity.WebApp.Models.Catalog.Careers;
using Codedy.StarSecurity.WebApp.Models.Catalog.Services;
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
    public class HomeController : Controller
    {
        private readonly IServicesService _contextService;
        private readonly ICareersService _careersService;

        public HomeController(IServicesService context,ICareersService careersService)
        {
            _contextService = context;
            _careersService = careersService;
        }

        public IActionResult Index()
        {
            var services = _contextService.Services();
            var careers = _careersService.Careers();
            var info = new HomeModel()
            {
                Careers = careers,
                Services = services
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
