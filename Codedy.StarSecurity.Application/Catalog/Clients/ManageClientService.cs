using Codedy.StarSecurity.Application.Catalog.Clients.Dtos;
using Codedy.StarSecurity.Application.Dtos;
using Codedy.StarSecurity.Data.EF;
using Codedy.StarSecurity.Data.Entiies;
using Codedy.StarSecurity.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.Application.Catalog.Clients
{
    class ManageClientService : IManageClientService
    {
        private readonly StarSecurityDbContext _context;
        public ManageClientService(StarSecurityDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ClientCreateRequest request)
        {
            var client = new Client()
            {
                Id = request.Id,
                Email = request.Email,
                Phone = request.Phone,
                Address = request.Address,
                Gender = request.Gender,
                FirtName = request.FirtName,
                LastName = request.LastName,
                DOB = request.DOB,
            };
            _context.Clients.Add(client);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int Id)
        {
            var client = await _context.Clients.FindAsync(Id);
            _context.Clients.Remove(client);
            return await _context.SaveChangesAsync();
        }

        public async Task<Client> Detail(int ID)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(m => m.Id == ID);
            if (client == null) throw new StarSecurityException($"Cannot find a user with id: {ID}");
            return client;
        }

        public List<ClientViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PagedViewModel<ClientViewModel> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ClientEditRequest request)
        {
            var client = await _context.Clients.FindAsync(request.Id);
            if (client == null) throw new StarSecurityException($"Cannot find a user with id: {request.Id}");

            client.Id = request.Id;
            client.Email = request.Email;
            client.Phone = request.Phone;
            client.Address = request.Address;
            client.Gender = request.Gender;
            client.FirtName = request.FirtName;
            client.LastName = request.LastName;
            client.DOB = request.DOB;
            return await _context.SaveChangesAsync();
        }

        Task<List<ClientViewModel>> IManageClientService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<PagedViewModel<ClientViewModel>> IManageClientService.GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
