using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Codedy.StarSecurity.WebApp.Models.Catalog.Services;
using Microsoft.AspNetCore.Http;
using System.IO;
using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
using Microsoft.AspNetCore.Hosting;
using Codedy.StarSecurity.WebApp.Areas.Account.Controllers;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : BaseController
    {
        private readonly IServicesService _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ServicesController(IServicesService context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Admin/Services
        public IActionResult Index()
        {
            var info = _context.Services();
            var session = HttpContext.Session.GetString("LevelSession");
            ViewBag.SessionLevel = session;
            return View(info);
        }

        // GET: Admin/Services/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var session = HttpContext.Session.GetString("LevelSession");
            ViewBag.SessionLevel = session;
            var service = _context.Service(id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Admin/Services/Create
        public IActionResult Create()
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Admin/Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync([Bind("Id,CategoryId,Title,Description,ImageFile,Price,PromotionPrice,IsActive,IsFeatured,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] Service service)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string fileName = Path.GetFileNameWithoutExtension(service.ImageFile.FileName);
                        string extension = Path.GetExtension(service.ImageFile.FileName);
                        service.Image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                        string path = Path.Combine(wwwRootPath + "/assets/img/services/", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await service.ImageFile.CopyToAsync(fileStream);
                        }

                        service.Id = Guid.NewGuid();
                        _context.Create(service);
                        return RedirectToAction(nameof(Index));
                    }
                    catch (Exception ex)
                    {
                        return RedirectToPage("HandError/Index", new { area = "" });
                    }
                }
                return View(service);
            }
            return RedirectToAction(nameof(Index));
        }


        // GET: Admin/Services/Edit/5
        public IActionResult Edit(Guid? id)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                if (id == null)
                {
                    return NotFound();
                }

                var service = _context.Service(id);
                if (service == null)
                {
                    return NotFound();
                }
                return View(service);
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Admin/Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,CategoryId,Title,Description,Image,ImageFile,Price,PromotionPrice,IsActive,IsFeatured,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] Service service)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                if (id != service.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        if (service.ImageFile != null)
                        {
                            string wwwRootPath = _hostEnvironment.WebRootPath;
                            string fileName = Path.GetFileNameWithoutExtension(service.ImageFile.FileName);
                            string extension = Path.GetExtension(service.ImageFile.FileName);
                            service.Image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                            string path = Path.Combine(wwwRootPath + "/assets/img/services/", fileName);
                            using (var fileStream = new FileStream(path, FileMode.Create))
                            {
                                await service.ImageFile.CopyToAsync(fileStream);
                            }
                        }
                        _context.Edit(service);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!_context.ServiceExists(service.Id))
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
                return View(service);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/Services/Delete/5
        public IActionResult Delete(Guid? id)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                if (id == null)
                {
                    return NotFound();
                }

                var service = _context.Service(id);
                if (service == null)
                {
                    return NotFound();
                }

                return View(service);
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Admin/Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                _context.Detele(id);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
    }
}