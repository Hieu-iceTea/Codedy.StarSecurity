using Codedy.StarSecurity.WebApp.Models.Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Account.Models
{
    public class KeyUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Level Level { get; set; }
    }
}
