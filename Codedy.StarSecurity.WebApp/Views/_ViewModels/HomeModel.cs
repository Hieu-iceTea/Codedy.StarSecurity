using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Views._ViewModels
{
    public class HomeModel
    {
        public List<Service> Services { get; set; }
        public List<Career> Careers{ get; set; }
        public int ContactTotal { get; set; }
    }

}
