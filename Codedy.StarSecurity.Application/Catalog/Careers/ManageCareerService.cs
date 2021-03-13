using Codedy.StarSecurity.Application.Catalog.Careers.Dtos;
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

namespace Codedy.StarSecurity.Application.Catalog.Careers
{
    class ManageCareerService : IManageCareersServe
    {
        private readonly StarSecurityDbContext _context;
        public ManageCareerService(StarSecurityDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(CareerCreateRequest request)
        {
            var career = new Career()
            {
                Id = request.Id,
                Title = request.Title,
                Salary = request.Salary,
                WorkAddress = request.WorkAddress,
                Description = request.Description,
                ExpirationDate = request.ExpirationDate,
            };
            _context.Careers.Add(career);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int Id)
        {
            var career = await _context.Careers.FindAsync(Id);
            _context.Careers.Remove(career);
            return await _context.SaveChangesAsync();
        }

        public async Task<Career> Detail(int ID)
        {
            var career = await _context.Careers.FirstOrDefaultAsync(m => m.Id == ID);
            if (career == null) throw new StarSecurityException($"Cannot find a Career with id: {ID}");
            return career;
        }

        public Task<List<CareerViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedViewModel<CareerViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(CareerEditRequest request)
        {
            var career = await _context.Careers.FindAsync(request.Id);
            if (career == null) throw new StarSecurityException($"Cannot find a career with id: {request.Id}");

            career.Id = request.Id;
            career.Title = request.Title;
            career.Salary = request.Salary;
            career.WorkAddress = request.WorkAddress;
            career.Description = request.Description;
            career.ExpirationDate = request.ExpirationDate;

            return await _context.SaveChangesAsync();
        }
    }
}
