using Codedy.StarSecurity.WebApp.Areas.Account.Views._ViewModels;
using Codedy.StarSecurity.WebApp.Models.Catalog.Account;
using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (ModelState.IsValid)
            {
                //var resultToken = await _accountService.Authencate(request);
                //if (string.IsNullOrEmpty(resultToken))
                //{
                //    return View(request);
                //}
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
            return View(request);

        }
    }
}
