using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Data.Entiies
{
    class Role: IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
