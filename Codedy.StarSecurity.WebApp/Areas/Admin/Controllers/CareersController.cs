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

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CareersController : Controller
    {
        private readonly ICareersService _context;

        public CareersController(ICareersService context)
        {
            _context = context;
        }

        // GET: Admin/Careers
        public IActionResult Index()
        {
            var info = _context.Careers();
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
            return View();
        }

        // POST: Admin/Careers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Title,Salary,WorkAddress,Description,ExpirationDate,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] Career career)
        {
            if (ModelState.IsValid)
            {
                career.Id = Guid.NewGuid();
                _context.Create(career);
                return RedirectToAction(nameof(Index));
            }
            return View(career);
        }

        // GET: Admin/Careers/Edit/5
        public IActionResult Edit(Guid? id)
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

        // POST: Admin/Careers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Id,Title,Salary,WorkAddress,Description,ExpirationDate,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] Career career)
        {
            if (id != career.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Edit(career);                }
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

        // GET: Admin/Careers/Delete/5
        public IActionResult Delete(Guid? id)
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
