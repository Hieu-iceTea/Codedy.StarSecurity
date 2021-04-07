using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Codedy.StarSecurity.WebApp.Models.Catalog.Careers;
using Codedy.StarSecurity.WebApp.Areas.Account.Controllers;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CareersController : BaseController
    {
        private readonly ICareersService _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public CareersController(ICareersService context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;

        }

        // GET: Admin/Careers
        public IActionResult Index()
        {
            var info = _context.Careers();
            var session = HttpContext.Session.GetString("LevelSession");
            ViewBag.SessionLevl = session;
            return View(info);
        }

        // GET: Admin/Careers/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var career = _context.Career(id);
            if (career == null)
            {
                return NotFound();
            }

            return View(career);
        }

        // GET: Admin/Careers/Create
        public IActionResult Create()
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session =="Admin")
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Admin/Careers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Salary,WorkAddress,Description,ImageFile,ExpirationDate,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] Career career)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session =="Admin")
            {
                if (ModelState.IsValid)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(career.ImageFile.FileName);
                    string extension = Path.GetExtension(career.ImageFile.FileName);
                    career.Image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/assets/img/career/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await career.ImageFile.CopyToAsync(fileStream);
                    }

                    career.Id = Guid.NewGuid();
                    _context.Create(career);
                    return RedirectToAction(nameof(Index));
                }
                return View(career);
            }
            return RedirectToAction(nameof(Index));

        }

        // GET: Admin/Careers/Edit/5
        public IActionResult Edit(Guid? id)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session =="Admin")
            {
                if (id == null)
                {
                    return NotFound();
                }

                var career = _context.Career(id);
                if (career == null)
                {
                    return NotFound();
                }
                return View(career);
            }
            return RedirectToAction(nameof(Index));

        }

        // POST: Admin/Careers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Salary,WorkAddress,Description,Image,ImageFile,ExpirationDate,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] Career career)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session =="Admin")
            {
                if (id ==career.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        if (career.ImageFile ==null)
                        {
                            string wwwRootPath = _hostEnvironment.WebRootPath;
                            string fileName = Path.GetFileNameWithoutExtension(career.ImageFile.FileName);
                            string extension = Path.GetExtension(career.ImageFile.FileName);
                            career.Image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                            string path = Path.Combine(wwwRootPath + "/assets/img/career/", fileName);
                            using (var fileStream = new FileStream(path, FileMode.Create))
                            {
                                await career.ImageFile.CopyToAsync(fileStream);
                            }
                        }

                        _context.Edit(career);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!_context.CareerExists(career.Id))
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
                return View(career);
            }
            return RedirectToAction(nameof(Index));


        }

        // GET: Admin/Careers/Delete/5
        public IActionResult Delete(Guid? id)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session =="Admin")
            {
                if (id == null)
                {
                    return NotFound();
                }

                var career = _context.Career(id);
                if (career == null)
                {
                    return NotFound();
                }

                return View(career);
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Admin/Careers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _context.Detele(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
