
using Codedy.StarSecurity.Application.Dtos;
using System;
using System.Collections.Generic;
using Codedy.StarSecurity.Data.Entiies;
using System.Text;
using System.Threading.Tasks;
using Codedy.StarSecurity.Application.Catalog.Services.Dtos;

namespace Codedy.StarSecurity.Application.Catalog.Services
{
    interface IManageServiceService
    {
        Task<int> Create(ServiceCreateRequest request);
        Task<int> Update(ServiceEditRequest request);
        Task<int> Delete(int Id);
        Task<Service> Detail(int ID);
        Task<List<ServiceViewModel>> GetAll();
        Task<PagedViewModel<ServiceViewModel>> GetAllPaging(string KeySearch, int pageIndex, int pageSize);
    }
}
