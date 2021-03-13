using Codedy.StarSecurity.Application.Catalog.Categories.Dtos;
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

namespace Codedy.StarSecurity.Application.Catalog.Categories
{
    class ManageCategoryService : IManageCategoryService
    {
        private readonly StarSecurityDbContext _context;
        public ManageCategoryService(StarSecurityDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(CategoryCreateRequest request)
        {
            var category = new Category()
            {
                Id = request.Id,
                Title = request.Title,
                Description = request.Description,
                ShortOder = request.ShortOder,
                IsShow = request.IsShow,
            };
            _context.Categories.Add(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int Id)
        {
            var category = await _context.Categories.FindAsync(Id);
            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<Category> Detail(int ID)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(m => m.Id == ID);
            if (category == null) throw new StarSecurityException($"Cannot find a category with id: {ID}");
            return category;
        }

        public Task<List<CategoryViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedViewModel<CategoryViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(CategoryEditRequest request)
        {
            var category = await _context.Categories.FindAsync(request.Id);
            if (category == null) throw new StarSecurityException($"Cannot find a user with id: {request.Id}");

            category.Id = request.Id;
            category.Title = request.Title;
            category.Description = request.Description;
            category.ShortOder = request.ShortOder;
            category.IsShow = request.IsShow;

            return await _context.SaveChangesAsync();
        }
    }
}
