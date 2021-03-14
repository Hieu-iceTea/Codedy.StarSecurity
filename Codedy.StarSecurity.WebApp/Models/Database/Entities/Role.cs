using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Database.Entities
{
    public class Role:IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
