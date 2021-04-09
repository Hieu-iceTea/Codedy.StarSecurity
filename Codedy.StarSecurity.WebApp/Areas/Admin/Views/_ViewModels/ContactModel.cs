using Codedy.StarSecurity.WebApp.Models.Database.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels
{
    public partial class ContactModel
    {
        public Guid ID { get; set; }
        public Guid ID_Service { get; set; }
        public string NameService { get; set; }
        public string FullName { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public Status Status { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
    }
}
