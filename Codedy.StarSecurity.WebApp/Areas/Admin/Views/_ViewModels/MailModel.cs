using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels
{
    public class MailModel:ContactModel
    {
        [Required(ErrorMessage ="Please enter context Description")]
        public new string Subject{ get; set; }
        public string TitleEmail { get; set; }
    }
}
