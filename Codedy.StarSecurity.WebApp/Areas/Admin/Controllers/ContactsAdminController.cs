using Codedy.StarSecurity.WebApp.Areas.Account.Controllers;
using Codedy.StarSecurity.WebApp.Areas.Admin.Services;
using Codedy.StarSecurity.WebApp.Models.Catalog.Contacts;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactsAdminController : BaseController
    {
        private readonly IContactsService _context;
        public ContactsAdminController(IContactsService context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var info = _context.ContactModels();
            return View(info);
        }

        public IActionResult Delete(Guid? ID)
        {
            if (ID == null)
            {
                return NotFound();
            }

            var contact = _context.Contact(ID);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid ID)
        {
            _context.Delete(ID);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = _context.Contact(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,ID_Service,FullName,Subject,Email,Message,Status,CreatedAt,CreatedBy,UpdateAt,UpdateBy,Version,Delete")] Contact contact)
        {
            if (id != contact.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    SendEmailService sendEmail = new SendEmailService();
                    sendEmail.Seed(contact.Email, "We will contact you to register for the service");
                    _context.Edit(contact);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.ContactExists(contact.ID))
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
            return View(contact);
        }
    }
}
