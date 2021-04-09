using Codedy.StarSecurity.WebApp.Models.Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels
{
    public class ClientModel
    {
        public Guid Id { get; set; }
        public Guid ID_Service { get; set; }
        public string NameService { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public Status Status { get; set; }
    }
}
