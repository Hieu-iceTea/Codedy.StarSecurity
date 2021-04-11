using Codedy.StarSecurity.WebApp.Areas.Admin.Services;
using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
using Codedy.StarSecurity.WebApp.Models.Catalog.Recruitments;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Codedy.StarSecurity.WebApp.Models.Database.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RecruitmentAdminController : Controller
    {
        private readonly IRecruitmentService _context;
        public RecruitmentAdminController(IRecruitmentService context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var info = _context.RecruitmentModels();
            return View(info);
        }

        public IActionResult Detail(Guid ID, Guid ID_Career)
        {
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

        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recruitment= _context.RecruitmentModel(id);
            if (recruitment == null)
            {
                return NotFound();
            }
            return View(recruitment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Id,ID_Career,Email,Phone,Address,Gender,FirstName,LastName,DOB,Education,Experience,Status,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted")] Recruitment recruitment)
        {
            if (id != recruitment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    SendEmailService sendEmail = new SendEmailService();
                    if (recruitment.Status == Status.Using)
                    {
                        sendEmail.Seed(recruitment.Email, "Thank you for registering our service. We will contact you to register for the service");
                    }
                    else if (recruitment.Status == Status.Used)
                    {
                        sendEmail.Seed(recruitment.Email, "Your security service at our company is out of class. Please note that you re-register the service");
                    }
                    else if (recruitment.Status == Status.Cancelled)
                    {
                        sendEmail.Seed(recruitment.Email, "Your service has ended. We have commanded your service pack");
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
    }
}
