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
using Codedy.StarSecurity.WebApp.Models.Catalog.Clients;
using Codedy.StarSecurity.WebApp.Areas.Account.Controllers;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClientsController : CheckAccount
    {
        private readonly IClientsService _context;

        public ClientsController(IClientsService context)
        {
            _context = context;
        }

        // GET: Admin/Clients
        public IActionResult Index()
        {
            var info = _context.Clients();
            return View(info);
        }

        // GET: Admin/Clients/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _context.Client(id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Admin/Clients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Phone,Address,Gender,FirtName,LastName,DOB,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] Client client)
        {
            if (ModelState.IsValid)
            {
                client.Id = Guid.NewGuid();
                _context.Create(client);
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // GET: Admin/Clients/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _context.Client(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Admin/Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Id,Email,Phone,Address,Gender,FirtName,LastName,DOB,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] Client client)
        {
            if (id != client.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Edit(client);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.ClientExists(client.Id))
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
            return View(client);
        }

        // GET: Admin/Clients/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _context.Client(id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Admin/Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _context.Detele(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
