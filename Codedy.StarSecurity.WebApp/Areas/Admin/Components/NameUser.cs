using Codedy.StarSecurity.WebApp.Models.Catalog.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Components
{
    public class UserName : ViewComponent
    {
        public readonly IAccountService _accountService;
        public UserName(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IViewComponentResult Invoke()
        {
            var sessionUser = HttpContext.Session.GetString("UserSession");
            var sessionPass = HttpContext.Session.GetString("PasswordSession");
            var user = _accountService.GetUserID(sessionUser, sessionPass);
            ViewBag.Session = user.Name;
            return View();
        }
    }
}
