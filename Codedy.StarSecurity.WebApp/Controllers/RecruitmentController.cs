using Codedy.StarSecurity.WebApp.Models;
using Codedy.StarSecurity.WebApp.Models.Catalog.Recruitments;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Controllers
{
    public class RecruitmentController : Controller
    {
        private readonly IRecruitmentService _context;
        private readonly ILogger<HomeController> _logger;

        public RecruitmentController(ILogger<HomeController> logger, IRecruitmentService context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index(Guid? ID)
        {
            var career = _context.Career(ID);
            ViewBag.CareerContact = career;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind("ID,ID_Career,Email,Phone,Address,Gender,FirstName,LastName,DOB,Education,Experience,CreatedAt,CreatedBy,UpdateAt,UpdateBy,Version,Delete")] Recruitment recruitment)
        {
            if (ModelState.IsValid)
            {
                recruitment.Id = Guid.NewGuid();
                _context.Create(recruitment);
                return RedirectToAction("Index", "Home");
            }
            return View(recruitment);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
