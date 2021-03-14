using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Careers
{
    public interface ICareersService
    {
        public List<Career> Careers();
        public Career Career(Guid? Id);
        public void Create(Career careerRequest);
        public void Detele(Guid? Id);
        public void Edit(Career book);
        public bool CareerExists(Guid id);
    }
}
