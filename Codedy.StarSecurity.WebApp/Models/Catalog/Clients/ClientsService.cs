using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
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

        public ClientModel ClientModel(Guid ID)
        {
            var query = from c in _starSecurityDbContext.Clients
                        join s in _starSecurityDbContext.Services on c.ID_Service equals s.Id
                        select new { c, s };
            var clientDetail = query.Where(x => x.c.Id == ID)
                .Select(x => new ClientModel()
                {
                    Id = x.c.Id,
                    ID_Service = x.c.ID_Service,
                    NameService = x.s.Title,
                    Email = x.c.Email,
                    Phone = x.c.Phone,
                    Address = x.c.Address,
                    Gender = x.c.Gender,
                    FirtName = x.c.FirtName,
                    LastName = x.c.LastName,
                    DOB = x.c.DOB,
                    Status = x.c.Status,
                }).FirstOrDefault();
            return clientDetail;
        }

        public List<ClientModel> ClientModels()
        {
            var query = from c in _starSecurityDbContext.Clients
                        join s in _starSecurityDbContext.Services on c.ID_Service equals s.Id
                        select new { c, s };
            var clientModels = query.Select(x => new ClientModel()
            {
                Id = x.c.Id,
                ID_Service = x.c.ID_Service,
                NameService = x.s.Title,
                Email = x.c.Email,
                Phone = x.c.Phone,
                Address = x.c.Address,
                Gender = x.c.Gender,
                FirtName = x.c.FirtName,
                LastName = x.c.LastName,
                DOB = x.c.DOB,
                Status = x.c.Status,
            }).ToList();
            return clientModels;
                      
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

        public Service Service(Guid ID)
        {
            var service = _starSecurityDbContext.Services.FirstOrDefault(m => m.Id == ID);
            return service;
        }

        public List<Service> Services()
        {
            var services = _starSecurityDbContext.Services.ToList();
            return services;
        }
    }
}
