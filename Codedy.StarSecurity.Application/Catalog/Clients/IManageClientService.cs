using Codedy.StarSecurity.Application.Catalog.Clients.Dtos;
using Codedy.StarSecurity.Application.Dtos;
using Codedy.StarSecurity.Data.Entiies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.Application.Catalog.Clients
{
    interface IManageClientService
    {
        Task<int> Create(ClientCreateRequest request);
        Task<int> Update(ClientEditRequest request);
        Task<int> Delete(int Id);
        Task<Client> Detail(int Id);
        Task<List<ClientViewModel>> GetAll();
        Task<PagedViewModel<ClientViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize);
    }
}
