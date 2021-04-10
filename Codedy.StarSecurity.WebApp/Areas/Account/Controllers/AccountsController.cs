using Codedy.StarSecurity.WebApp.Areas.Account.Views._ViewModels;
using Codedy.StarSecurity.WebApp.Models.Catalog.Account;
using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Database.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Account.Controllers
{
    [Area("Account")]
    public class AccountsController : Controller
    {
        public readonly IAccountService _accountService;
        public IAccountService context;

        const string UserSession = "UserSession";
        const string PasswordSession = "PasswordSession";
        const string LevelSession = "LevelSession";
        const string NameUser = "NameUser";

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public  IActionResult Login(LoginRequest model)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.Clear();

                var result = _accountService.Login(model.Username, model.Password);
                if (result)
                {
                    var user = _accountService.GetUserID(model.Username, model.Password);
                    HttpContext.Session.SetString(UserSession, user.UserName);
                    HttpContext.Session.SetString(PasswordSession, user.Password);
                    if (user.Level == Level.Admin) HttpContext.Session.SetString(LevelSession, "Admin");
                    if (user.Level == Level.Employee) HttpContext.Session.SetString(LevelSession, "Employee");
                    if (user.Level == Level.Customer) HttpContext.Session.SetString(LevelSession, "Customer");
                    return RedirectToAction("Index", "Services", new { area = "Admin" });

                }
                else
                    ModelState.AddModelError("", "Login failed. Please enter user and password");
            }
            return View(nameof(Login));

        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Accounts", new { area = "Account" });
        }

    }
}
