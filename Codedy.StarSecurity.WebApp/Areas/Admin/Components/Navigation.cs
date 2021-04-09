using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Views._ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Components
{
    public class Navigation : ViewComponent
    {
        public readonly StarSecurityDbContext _context;
        public Navigation(StarSecurityDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {

            var overview = new HomeModel()
            {
                ContactTotal = _context.Contacts.Count(),
                RecruitmentTotal=_context.Recruitments.Count(),

            };

            var session = HttpContext.Session.GetString("LevelSession");
            @ViewBag.Session = session;
            return View(overview);
        }


    }
}
