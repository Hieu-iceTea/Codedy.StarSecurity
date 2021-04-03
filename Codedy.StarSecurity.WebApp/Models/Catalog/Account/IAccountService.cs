using Codedy.StarSecurity.WebApp.Areas.Account.Views._ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Account
{
    public interface IAccountService
    {
        public bool Login(string username, string password);

        public Guid GetUserID(string username, string password);       
    }
}
