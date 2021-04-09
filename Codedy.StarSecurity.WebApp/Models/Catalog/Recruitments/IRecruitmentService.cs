using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Recruitments
{
    public interface IRecruitmentService
    {
        public Career Career(Guid? ID);
        public void Create(Recruitment recruitmentRequest);
        public List<RecruitmentModel> RecruitmentModels();
        public RecruitmentModel RecruitmentModel(Guid ID);
        public void Delete(Guid? ID);
        public Recruitment Recruitment(Guid? ID);
    }
}
