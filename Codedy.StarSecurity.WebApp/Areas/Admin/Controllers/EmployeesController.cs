using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Codedy.StarSecurity.WebApp.Models.Catalog.Users;
using Codedy.StarSecurity.WebApp.Areas.Account.Controllers;
using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
using Microsoft.AspNetCore.Http;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeesController : BaseController
    {
        private readonly IUsersService _context;

        public EmployeesController(IUsersService context)
        {
            _context = context;

        }

        // GET: Admin/Employees
        public IActionResult Index()
        {
            var info = _context.Users();
            var session = HttpContext.Session.GetString("LevelSession");
            ViewBag.SessionLevel = session;
            return View(info);
        }

        // GET: Admin/Employees/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.SessionLevel = HttpContext.Session.GetString("LevelSession");
            var user = _context.User(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Admin/Employees/Create
        public IActionResult Create()
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Admin/Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserRequest userRequest)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                if (ModelState.IsValid)
                {
                    userRequest.ID = Guid.NewGuid();
                    var user = new User()
                    {
                        Id = userRequest.ID,
                        Address = userRequest.Address,
                        Email = userRequest.Email,
                        DOB = userRequest.DOB,
                        FirtName = userRequest.FirtName,
                        LastName = userRequest.LastName,
                        EmployeeCode = userRequest.EmployeeCode,
                        UserName = userRequest.UserName,
                        Password = userRequest.Password,
                        PasswordHash = userRequest.Password,
                        EmployeeEducationalQualification = userRequest.EmployeeEducationalQualification,
                        EmployeeDepartment = userRequest.EmployeeDepartment,
                        EmployeeGrade = userRequest.EmployeeGrade,
                        Gender = userRequest.Gender,
                        //EmployeeRole = userRequest.EmployeeRole,
                        LastLoginDate = userRequest.LastLoginDate,
                        Phone = userRequest.Phone,
                        EmployeeAchievements = userRequest.EmployeeAchievements,
                    };
                    _context.Create(user);
                    return RedirectToAction(nameof(Index));
                }
                return View(userRequest);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/Employees/Edit/5
        public IActionResult Edit(Guid? id)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                if (id == null)
                {
                    return NotFound();
                }

                var user = _context.User(id);
                if (user == null)
                {
                    return NotFound();
                }
                return View(user);
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Admin/Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Phone,Password,Address,Gender,FirtName,LastName,DOB,EmployeeEducationalQualification,EmployeeCode,EmployeeDepartment,EmployeeRole,EmployeeGrade,EmployeeAchievements,LastLoginDate,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] User user)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                if (id != user.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Edit(user);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!_context.UserExists(user.Id))
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
                return View(user);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/Employees/Delete/5
        public IActionResult Delete(Guid? id)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                if (id == null)
                {
                    return NotFound();
                }

                var user = _context.User(id);
                if (user == null)
                {
                    return NotFound();
                }

                return View(user);
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Admin/Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid? id)
        {
            var session = HttpContext.Session.GetString("LevelSession");
            if (session == "Admin")
            {
                _context.Detele(id);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }


    }
}