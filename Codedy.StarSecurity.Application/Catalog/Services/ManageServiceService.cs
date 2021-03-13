using Codedy.StarSecurity.Application.Catalog.Services.Dtos;
using Codedy.StarSecurity.Application.Dtos;
using Codedy.StarSecurity.Data.EF;
using Codedy.StarSecurity.Data.Entiies;
using Codedy.StarSecurity.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.Application.Catalog.Services
{
    class ManageServiceService : IManageServiceService
    {
        private readonly StarSecurityDbContext _context;
        public ManageServiceService(StarSecurityDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ServiceCreateRequest request)
        {
            var service = new Service()
            {
                Id = request.Id,
                CategoryId = request.CategoryId,
                Title = request.Title,
                Description = request.Description,
                Image = request.Image,
                Price = request.Price,
                PromotionPrice = request.PromotionPrice,
                IsActive = request.IsActive,
                DOB = request.DOB,
                Category = request.Category,
            };
           _context.Services.Add(service);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int Id)
        {
            var service = await _context.Services.FindAsync(Id);
            _context.Services.Remove(service);
            return await _context.SaveChangesAsync();
        }

        public async Task<Service> Detail(int ID)
        {
            var service = await _context.Services.FirstOrDefaultAsync(m => m.Id == ID);
            if (service == null) throw new StarSecurityException($"Cannot find a service with id: {ID}");
            return service;
        }

        public Task<List<ServiceViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedViewModel<ServiceViewModel>> GetAllPaging(string KeySearch, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ServiceEditRequest request)
        {
            var service = await _context.Services.FindAsync(request.Id);
            if (service == null) throw new StarSecurityException($"Cannot find a service with id: {request.Id}");

            service.Id = request.Id;
            service.CategoryId = request.CategoryId;
            service.Title = request.Title;
            service.Description = request.Description;
            service.Image = request.Image;
            service.Price = request.Price;
            service.PromotionPrice = request.PromotionPrice;
            service.IsActive = request.IsActive;
            service.DOB = request.DOB;
            service.Category = request.Category;

            return await _context.SaveChangesAsync();
        }
    }
}
