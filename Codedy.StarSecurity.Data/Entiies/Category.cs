using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Data.Entiies
{
    class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShortOder{ get; set; }
        public bool IsShow{ get; set; }


        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int Version { get; set; }
        public bool Deleted { get; set; }

        public List<Service> Services { get; set; }
    }
}
