using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Careers
{
    public class CareersService:ICareersService
    {
        private readonly StarSecurityDbContext _starSecurityDbContext;
        public CareersService(StarSecurityDbContext starSecurityDbContext)
        {
            _starSecurityDbContext = starSecurityDbContext;
        }
        public Career Career(Guid? Id)
        {
            var career = _starSecurityDbContext.Careers.FirstOrDefault(m => m.Id == Id);
            return career;
        }

        public bool CareerExists(Guid id)
        {
            return _starSecurityDbContext.Careers.Any(e => e.Id == id);
        }

        public List<Career> Careers()
        {
            var careers = _starSecurityDbContext.Careers.ToList();
            return careers;
        }

        public void Create(Career careerRequest)
        {
            _starSecurityDbContext.Add(careerRequest);
            _starSecurityDbContext.SaveChanges();
        }

        public void Detele(Guid? Id)
        {
            var career = Career(Id);
            _starSecurityDbContext.Remove(career);
            _starSecurityDbContext.SaveChanges();
        }

        public void Edit(Career career)
        {
            _starSecurityDbContext.Update(career);
            _starSecurityDbContext.SaveChanges();
        }
    }
}
