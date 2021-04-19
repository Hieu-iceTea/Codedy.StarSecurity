using Codedy.StarSecurity.WebApp.Areas.Account.Controllers;
using Codedy.StarSecurity.WebApp.Areas.Admin.Services;
using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
using Codedy.StarSecurity.WebApp.Models.Catalog.Contacts;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Codedy.StarSecurity.WebApp.Models.Database.Enums;
using Microsoft.AspNetCore.Http;
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
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                if (id == null)
                {
                    return NotFound();
                }

                var contact = _context.ContactModelDetail(id);
                if (contact == null)
                {
                    return NotFound();
                }
                return View(contact);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,ID_Service,FullName,Subject,Email,Phone,Message,Status,CreatedAt,CreatedBy,UpdateAt,UpdateBy,Version,Delete")] Contact contact)
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
                    if (contact.Status == Status.Using)
                    {
                        sendEmail.Seed(contact.Email, "Thank you for registering our service. We will contact you to register for the service");
                    }
                    else if (contact.Status == Status.Used)
                    {
                        sendEmail.Seed(contact.Email, "Your security service at our company is out of class. Please note that you re-register the service");
                    }
                    else if (contact.Status == Status.Cancelled)
                    {
                        sendEmail.Seed(contact.Email, "Your service has ended. We have commanded your service pack");
                    }
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

        public async Task<IActionResult> Mail(Guid id)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                if (id == null)
                {
                    return NotFound();
                }

                var contact = _context.Contact(id);
                var mail = new MailModel()
                {
                    ID = contact.ID,
                    FullName = contact.FullName,
                    Email = contact.Email,
                    Phone = contact.Phone
                };
                if (contact == null)
                {
                    return NotFound();
                }
                return View(mail);
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> SendMail([Bind("ID,Email,FullName,TitleEmail,Subject")]MailModel mailModel)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                if (ModelState.IsValid)
                {
                    var serviceSendMail = new SendEmailService();
                    serviceSendMail.Seed(mailModel.Email,mailModel.FullName, mailModel.TitleEmail, mailModel.Subject);
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToPage(nameof(Mail),mailModel.ID);
            }
            return RedirectToAction(nameof(Index));
            
        }
    }
}
