using Codedy.StarSecurity.WebApp.Areas.Account.Views._ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Account
{
    public interface IAccountService
    {
        Task<string> Authencate(LoginRequest request);
    }
}
