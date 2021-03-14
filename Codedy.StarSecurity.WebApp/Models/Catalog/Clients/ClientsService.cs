using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Clients
{
    public class ClientsService:IClientsService
    {
        private readonly StarSecurityDbContext _starSecurityDbContext;
        public ClientsService(StarSecurityDbContext starSecurityDbContext)
        {
            _starSecurityDbContext = starSecurityDbContext;
        }
        public Client Client(Guid? Id)
        {
            var client = _starSecurityDbContext.Clients.FirstOrDefault(m => m.Id == Id);
            return client;
        }

        public bool ClientExists(Guid id)
        {
            return _starSecurityDbContext.Users.Any(e => e.Id == id);
        }

        public List<Client> Clients()
        {
            var clients = _starSecurityDbContext.Clients.ToList();
            return clients;
        }

        public void Create(Client clientRequest)
        {
            _starSecurityDbContext.Add(clientRequest);
            _starSecurityDbContext.SaveChanges();
        }

        public void Detele(Guid? Id)
        {
            var client = Client(Id);
            _starSecurityDbContext.Remove(client);
            _starSecurityDbContext.SaveChangesAsync();
        }

        public void Edit(Client client)
        {
            _starSecurityDbContext.Update(client);
            _starSecurityDbContext.SaveChangesAsync();
        }

       
    }
}
