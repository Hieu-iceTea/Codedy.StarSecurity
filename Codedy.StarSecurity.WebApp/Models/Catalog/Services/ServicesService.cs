using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Services
{
    public class ServicesService:IServicesService
    {
        private readonly StarSecurityDbContext _starSecurityDbContext;
        public ServicesService(StarSecurityDbContext starSecurityDbContext)
        {
            _starSecurityDbContext = starSecurityDbContext;
        }
        public Service Service(Guid? Id)
        {
            var service = _starSecurityDbContext.Services.FirstOrDefault(m => m.Id == Id);
            return service;
        }

        public bool ServiceExists(Guid id)
        {
            return _starSecurityDbContext.Services.Any(e => e.Id == id);
        }

        public List<Service> Services()
        {
            var services = _starSecurityDbContext.Services.ToList();
            return services;
        }

        public void Create(Service serviceRequest)
        {
            _starSecurityDbContext.Add(serviceRequest);
            _starSecurityDbContext.SaveChanges();
        }

        public void Detele(Guid? Id)
        {
            var service= Service(Id);
            _starSecurityDbContext.Remove(service);
            _starSecurityDbContext.SaveChangesAsync();
        }

        public void Edit(Service service)
        {
            _starSecurityDbContext.Update(service);
            _starSecurityDbContext.SaveChangesAsync();
        }
    }
}
