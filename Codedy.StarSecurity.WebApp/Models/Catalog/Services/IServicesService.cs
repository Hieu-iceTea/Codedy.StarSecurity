using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Services
{
    public interface IServicesService
    {
        public List<Service> Services();
        public Service Service(Guid? Id);
        public void Create(Service serviceRequest);
        public void Detele(Guid? Id);
        public void Edit(Service service);
        public bool ServiceExists(Guid id);
    }
}
