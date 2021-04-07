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
    public class Career
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string Image { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        [Required]
        public string Salary { get; set; }
        [Required]
        public string WorkAddress { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int Version { get; set; }
        public bool Deleted { get; set; }
    }
}
