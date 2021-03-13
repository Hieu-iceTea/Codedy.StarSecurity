using Codedy.StarSecurity.Application.Catalog.Careers.Dtos;
using Codedy.StarSecurity.Application.Dtos;
using Codedy.StarSecurity.Data.Entiies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.Application.Catalog.Careers
{
    interface IManageCareersServe
    {
        Task<int> Create(CareerCreateRequest request);
        Task<int> Update(CareerEditRequest request);
        Task<int> Delete(int Id);
        Task<Career> Detail(int Id);
        Task<List<CareerViewModel>> GetAll();
        Task<PagedViewModel<CareerViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize);
    }
}
