using Codedy.StarSecurity.WebApp.Models.Catalog.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Components
{

    public class AccountInfo : ViewComponent
    {
        public readonly IAccountService _accountService;
        public AccountInfo(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IViewComponentResult Invoke()
        {
            var sessionUser = HttpContext.Session.GetString("UserSession");
            var sessionPass = HttpContext.Session.GetString("PasswordSession");
            var user = _accountService.GetUserID(sessionUser, sessionPass);
            ViewBag.SessionName = user.Name;
            ViewBag.SessionEmail = user.Email;
            return View();
        }
    }
}