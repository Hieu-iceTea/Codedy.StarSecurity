using Codedy.StarSecurity.Application.Catalog.Careers.Dtos;
using Codedy.StarSecurity.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Application.Catalog.Careers
{
    interface IPublicCareersService
    {
        PagedViewModel<CareerViewModel> GetAllByUserId(int Id, int pageIndex, int pageSize);
    }
}
