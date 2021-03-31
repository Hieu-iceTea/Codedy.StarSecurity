using Codedy.StarSecurity.WebApp.Models.Database.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels
{
    public class UserRequest
    {
        public Guid ID { get; set; }
        [Required(ErrorMessage ="Please enter User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter Password")]
        [Display(Name = "Password")]
        public string PasswordHash { get; set; }

        [Required(ErrorMessage = "Please enter Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter Email")]
        public string Address { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Please enter First Name")]
        [Display( Name = "First Name")]
        public string FirtName { get; set; }
        [Required(ErrorMessage = "Please enter Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter DOB")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Display(Name = "Educational Qualification")]
        public string EmployeeEducationalQualification { get; set; }
        [Display(Name = "Code Employee")]
        public string EmployeeCode { get; set; }
        [Display(Name = "Department")]
        public string EmployeeDepartment { get; set; }
        [Display(Name = "Role")]
        public string EmployeeRole { get; set; }
        [Display(Name = "Grade ")]
        public string EmployeeGrade { get; set; }
        [Display(Name = "Grade")]
        public string EmployeeAchievements { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastLoginDate { get; set; }
    }
}
