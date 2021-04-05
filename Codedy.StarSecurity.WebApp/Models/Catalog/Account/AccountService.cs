using Codedy.StarSecurity.WebApp.Areas.Account.Models;
using Codedy.StarSecurity.WebApp.Areas.Account.Views._ViewModels;
using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Account
{
    public class AccountService : IAccountService
    {

        public StarSecurityDbContext context;

        public AccountService(StarSecurityDbContext _context)
        {
            context = _context;
        }
        public bool Login(string username, string password)
        {
            var result = context.Users.Where(x => x.UserName == username && x.Password == password).Count();
            if (result > 0) return true;
            else return false;
        }
        public KeyUser GetUserID(string username, string password)
        {
            var result = context.Users.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();
            var keyUser = new KeyUser()
            {
                UserName = result.UserName,
                Password = result.Password
            };
            return keyUser;
        }
    }
}
