using Codedy.StarSecurity.WebApp.Models;
using Codedy.StarSecurity.WebApp.Models.Catalog.Recruitments;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Controllers
{
    public class RecruitmentController : Controller
    {
        private readonly IRecruitmentService _context;
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostEnvironment;

        public RecruitmentController(ILogger<HomeController> logger, IRecruitmentService context, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }


        public IActionResult Index(Guid? ID)
        {
            var career = _context.Career(ID);
            ViewBag.CareerContact = career;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("ID,ID_Career,Email,FileRecruitment,Phone,Address,Gender,FirstName,LastName,DOB,Education,Experience,CreatedAt,CreatedBy,UpdateAt,UpdateBy,Version,Delete")] Recruitment recruitment)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(recruitment.FileRecruitment.FileName);
                string extension = Path.GetExtension(recruitment.FileRecruitment.FileName);
                recruitment.FileNameRecruitment = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/assets/File/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await recruitment.FileRecruitment.CopyToAsync(fileStream);
                }

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
