using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Clients
{
    public interface IClientsService
    {
        public List<ClientModel> ClientModels();
        public ClientModel ClientModel(Guid ID);
        public Service Service(Guid ID);
        public List<Client> Clients();
        public Client Client(Guid? Id);
        public void Create(Client clientRequest);
        public void Detele(Guid? Id);
        public void Edit(Client book);
        public bool ClientExists(Guid id);
        public List<Service> Services(); 
    }
}
