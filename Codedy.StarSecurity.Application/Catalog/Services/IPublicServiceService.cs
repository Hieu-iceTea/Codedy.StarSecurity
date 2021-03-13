using Codedy.StarSecurity.Application.Catalog.Services.Dtos;
using Codedy.StarSecurity.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.Application.Catalog.Services
{
    interface IPublicServiceService
    {
        PagedViewModel<ServiceViewModel> GetAllByUserId(int Id, int pageIndex, int pageSize);
    }
}
