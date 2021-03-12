using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Data.Entiies
{
  public  class Role: IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
