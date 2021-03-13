using Codedy.StarSecurity.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Application.Catalog.Users.Dtos
{
    public class UserCreateRequest
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string EmployeeEducationalQualification { get; set; }
        public string EmployeeDepartment { get; set; }
        public string EmployeeRole { get; set; }
        public string EmployeeGrade { get; set; }
        public string EmployeeAchievements { get; set; }
    }
}
