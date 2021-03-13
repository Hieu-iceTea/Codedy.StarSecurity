using Codedy.StarSecurity.Application.Catalog.Categories.Dtos;
using Codedy.StarSecurity.Application.Dtos;
using Codedy.StarSecurity.Data.Entiies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.Application.Catalog.Categories
{
    interface IManageCategoryService
    {
        Task<int> Create(CategoryCreateRequest request);
        Task<int> Update(CategoryEditRequest request);
        Task<int> Delete(int Id);
        Task<Category> Detail(int Id);
        Task<List<CategoryViewModel>> GetAll();
        Task<PagedViewModel<CategoryViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize);
    }
}
