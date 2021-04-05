using Codedy.StarSecurity.WebApp.Areas.Account.Views._ViewModels;
using Codedy.StarSecurity.WebApp.Models.Catalog.Account;
using Codedy.StarSecurity.WebApp.Models.Database.EF;
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

                var result = _accountService.Login(model.Username, model.Password);
                if (result)
                {
                    var user = _accountService.GetUserID(model.Username, model.Password);
                    HttpContext.Session.SetString(UserSession, user.UserName);
                    HttpContext.Session.SetString(PasswordSession, user.Password);

                    return RedirectToAction("Index", "Home", new { area = "Admin" });

                }
                else
                    ModelState.AddModelError("", "Login feild. Please enter user and password");
            }
            return View(nameof(Login));

        }
    }
}
