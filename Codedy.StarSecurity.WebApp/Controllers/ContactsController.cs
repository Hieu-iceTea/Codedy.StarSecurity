using Codedy.StarSecurity.WebApp.Models;
using Codedy.StarSecurity.WebApp.Models.Catalog.Contacts;
using Codedy.StarSecurity.WebApp.Models.Database.EF;
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
    public class ContactsController : Controller
    {
        private readonly IContactsService _context;
        private readonly ILogger<HomeController> _logger;

        public ContactsController(ILogger<HomeController> logger, IContactsService context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind("ID,FullName,Email,Subject,Message,CreatedAt,CreatedBy,UpdatedBy,Version,Delete")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.ID = Guid.NewGuid();
                _context.Create(contact);
                return RedirectToAction("Index", "Home");
            }
            return View(contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
