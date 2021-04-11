using Codedy.StarSecurity.WebApp.Models.Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels
{
    public partial class RecruitmentModel
    {
        public Guid Id { get; set; }
        public Guid ID_Career { get; set; }
        public string NameCareer { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public Status Status { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string AddressCareer { get; set; }
    }
}
