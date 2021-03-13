using Codedy.StarSecurity.Data.Entiies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.Application.Catalog.Services.Dtos
{
    class ServiceEditRequest
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public bool IsActive { get; set; }
        public DateTime DOB { get; set; }
        public Category Category { get; set; }
    }
}
