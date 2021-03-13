using Codedy.StarSecurity.Application.Catalog.Categories.Dtos;
using Codedy.StarSecurity.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Application.Catalog.Categories
{
    interface IPublicCategoryService 
    {
        PagedViewModel<CategoryViewModel> GetAllByUserId(int Id, int pageIndex, int pageSize);
    }
}
