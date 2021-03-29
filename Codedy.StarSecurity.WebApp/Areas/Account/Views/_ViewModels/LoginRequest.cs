using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Account.Views._ViewModels
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Please enter user name")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter user name")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
