﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Data.Entiies
{
    class Service
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

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int Version { get; set; }
        public bool Deleted { get; set; }
    }
}