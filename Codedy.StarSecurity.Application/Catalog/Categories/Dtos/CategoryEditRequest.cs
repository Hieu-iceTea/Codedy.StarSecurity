using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Application.Catalog.Categories.Dtos
{
    public class CategoryEditRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShortOder { get; set; }
        public bool IsShow { get; set; }
    }
}
