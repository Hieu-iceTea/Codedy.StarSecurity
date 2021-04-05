using Codedy.StarSecurity.WebApp.Areas.Account.Controllers;
using Codedy.StarSecurity.WebApp.Models.Catalog.Contacts;
using Microsoft.AspNetCore.Mvc;
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
            var info = _context.Contacts();
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
    }
}
