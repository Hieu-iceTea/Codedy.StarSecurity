using Codedy.StarSecurity.WebApp.Areas.Admin.Services;
using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
using Codedy.StarSecurity.WebApp.Models.Catalog.Recruitments;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Codedy.StarSecurity.WebApp.Models.Database.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RecruitmentAdminController : Controller
    {
        private readonly IRecruitmentService _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public RecruitmentAdminController(IRecruitmentService context, IWebHostEnvironment hostEnvironment) 
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            var info = _context.RecruitmentModels();
            return View(info);
        }

        public IActionResult Detail(Guid? ID, Guid? ID_Career)
        {
            if (ID == null && ID_Career == null)
            {
                return NotFound();
            }
            var recruitment = _context.RecruitmentModel(ID);
            var career = _context.Career(ID_Career);
            var info = new RecruitmentDetailModel()
            {
                RecruitmentModel = recruitment,
                Career = career,
            };
            return View(info);
        }

        public IActionResult Delete(Guid? ID)
        {
            if (ID == null)
            {
                return NotFound();
            }

            var recruitment = _context.Recruitment(ID);
            if (recruitment == null)
            {
                return NotFound();
            }

            return View(recruitment);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid ID)
        {
            _context.Delete(ID);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(Guid? ID)
        {
            

            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                if (ID == null)
                {
                    return NotFound();
                }

                var recruitment = _context.Recruitment(ID);
                var career = _context.Career(recruitment.ID_Career);
                ViewBag.CareerRecruitment = career;
                if (recruitment == null)
                {
                    return NotFound();
                }
                return View(recruitment);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,ID_Career,Email,Phone,Address,Gender,FirstName,LastName,DOB,StatusRecruitment,FileRecruitment,FileNameRecruitment,IsActive,IsFeatured,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] Recruitment recruitment)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                if (id != recruitment.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        if (recruitment.FileRecruitment != null)
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
                        }
                        _context.Edit(recruitment);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!_context.RecruitmentExists(recruitment.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(recruitment);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
