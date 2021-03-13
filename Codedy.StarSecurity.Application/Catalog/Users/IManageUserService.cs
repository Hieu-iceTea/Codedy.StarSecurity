using Codedy.StarSecurity.Application.Catalog.Users.Dtos;
using Codedy.StarSecurity.Application.Dtos;
using Codedy.StarSecurity.Data.Entiies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.Application.Catalog.Users
{
    public interface IManageUserService
    {
        Task<int> Create(UserCreateRequest request);
        Task<int> Update(UserEditRequest request);
        Task<int> Delete(int Id);
        Task<User> Detail(string ID);
        Task<List<UserViewModel>> GetAll();
        Task<PagedViewModel<UserViewModel>> GetAllPaging(string KeySearch, int pageIndex, int pageSize);    
    }
}
