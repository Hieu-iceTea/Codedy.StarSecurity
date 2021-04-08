using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels
{
    public class ClientDetailModel
    {
        public ClientModel ClientModel { get; set; }
        public Service Service { get; set; }
    }
}
