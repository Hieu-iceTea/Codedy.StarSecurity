using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Application.Catalog.Careers.Dtos
{
    public class CareerCreateRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Salary { get; set; }
        public string WorkAddress { get; set; }
        public string Description { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
