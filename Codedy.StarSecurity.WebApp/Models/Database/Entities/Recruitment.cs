using Codedy.StarSecurity.WebApp.Models.Database.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Database.Entities
{
    public class Recruitment
    {
        public Guid Id { get; set; }
        public Guid ID_Career { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; } 
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public StatusRecruitment StatusRecruitment { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("File Name")]
        public string FileNameRecruitment { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile FileRecruitment { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int Version { get; set; }
        public bool Deleted { get; set; }
    }
}
