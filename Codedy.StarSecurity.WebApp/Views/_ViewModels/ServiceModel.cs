using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Views._ViewModels
{
    public class ServiceModel
    {
        public List<Service> Services { get; set; }
        public Service Service { get; set; }
    }
}
