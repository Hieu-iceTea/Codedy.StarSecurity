using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Catalog.Users;
using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
using Codedy.StarSecurity.WebApp.Areas.Account.Controllers;
using Microsoft.AspNetCore.Http;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : CheckAccount
    {
        private readonly IUsersService _context;

        public UsersController(IUsersService context)
        {
            _context = context;
        }

        // GET: Admin/Users
        public IActionResult Index()
        {
            var info = _context.Users();
            return View(info);
        }

        // GET: Admin/Users/Details/5
        public IActionResult Details(Guid? id)
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

        // GET: Admin/Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync([Bind("Phone,Address,Gender,FirtName,LastName,DOB,EmployeeEducationalQualification,Password,PasswordHash,EmployeeCode,EmployeeRole,EmployeeDepartment,EmployeeGrade,EmployeeAchievements,LastLoginDate,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] User user)
        {
            if (ModelState.IsValid)
            {
                user.Id = Guid.NewGuid();
                _context.Create(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Admin/Users/Edit/5
        // GET: Admin/Employees/Edit/5
        public IActionResult Edit(Guid? id)
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

        // POST: Admin/Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Phone,Address,Gender,FirtName,LastName,DOB,EmployeeEducationalQualification,EmployeeCode,EmployeeDepartment,EmployeeRole,EmployeeGrade,EmployeeAchievements,LastLoginDate,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] User user)
        //{
        //    if (id != user.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Edit(user);
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!_context.UserExists(user.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(user);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Phone,Password,Address,Gender,FirtName,LastName,DOB,EmployeeEducationalQualification,EmployeeCode,EmployeeDepartment,EmployeeRole,EmployeeGrade,EmployeeAchievements,LastLoginDate,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Version,Deleted,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] User user)
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

        // GET: Admin/Employees/Delete/5
        public IActionResult Delete(Guid? id)
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

        // POST: Admin/Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _context.Detele(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
