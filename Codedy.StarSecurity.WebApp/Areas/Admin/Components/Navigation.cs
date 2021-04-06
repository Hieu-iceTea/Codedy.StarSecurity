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
        public IViewComponentResult Invoke()
        {
            var session = HttpContext.Session.GetString("LevelSession");
            @ViewBag.Session = session;
            return View();
        }
    }
}
