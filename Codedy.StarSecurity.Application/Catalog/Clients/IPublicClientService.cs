using Codedy.StarSecurity.Application.Catalog.Clients.Dtos;
using Codedy.StarSecurity.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Application.Catalog.Clients
{
    interface IPublicClientService
    {
        PagedViewModel<ClientViewModel> GetAllByUserId(int Id, int pageIndex, int pageSize);
    }
}
