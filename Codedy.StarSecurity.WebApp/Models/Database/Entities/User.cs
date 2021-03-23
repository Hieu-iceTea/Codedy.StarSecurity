using Codedy.StarSecurity.WebApp.Models.Database.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Database.Entities
{
    public class User : IdentityUser<Guid>
    {
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string FirtName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        public string EmployeeEducationalQualification { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeDepartment { get; set; }
        public string EmployeeRole { get; set; }
        public string EmployeeGrade { get; set; }
        public string EmployeeAchievements { get; set; }
        public DateTime LastLoginDate { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int Version { get; set; }
        public bool Deleted { get; set; }
    }
}
