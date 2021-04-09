using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
using Codedy.StarSecurity.WebApp.Models.Catalog.Recruitments;
using Microsoft.AspNetCore.Mvc;
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
    }
}
