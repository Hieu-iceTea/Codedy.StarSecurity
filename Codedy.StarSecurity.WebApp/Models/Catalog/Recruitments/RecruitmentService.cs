using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Recruitments
{
    public class RecruitmentService : IRecruitmentService
    {
        private readonly StarSecurityDbContext _starSecurityDbContext;
        public RecruitmentService(StarSecurityDbContext starSecurityDbContext)
        {
            _starSecurityDbContext = starSecurityDbContext;
        }
        public Career Career(Guid? ID)
        {
            var career = _starSecurityDbContext.Careers.FirstOrDefault(m => m.Id == ID);
            return career;
        }

        public void Create(Recruitment recruitmentRequest)
        {
            _starSecurityDbContext.Add(recruitmentRequest);
            _starSecurityDbContext.SaveChanges();
        }

        public void Delete(Guid? ID)
        {
            var recruitment = Recruitment(ID);
            _starSecurityDbContext.Remove(recruitment);
            _starSecurityDbContext.SaveChangesAsync();
        }

        public void Edit(Recruitment recruitment)
        {
            _starSecurityDbContext.Update(recruitment);
            _starSecurityDbContext.SaveChangesAsync();
        }

        public Recruitment Recruitment(Guid? ID)
        {
            var recruitment = _starSecurityDbContext.Recruitments.FirstOrDefault(m => m.Id == ID);
            return recruitment;
        }

        public bool RecruitmentExists(Guid id)
        {
            return _starSecurityDbContext.Recruitments.Any(e => e.Id == id);
        }

        public RecruitmentModel RecruitmentModel(Guid? ID)
        {
            var query = from r in _starSecurityDbContext.Recruitments
                        join c in _starSecurityDbContext.Careers on r.ID_Career equals c.Id
                        select new { r, c };
            var recruitmentDetails = query.Where(x => x.r.Id == ID)
                .Select(x => new RecruitmentModel()
                {
                    Id = x.r.Id,
                    ID_Career = x.c.Id,
                    NameCareer = x.c.Title,
                    Education = x.r.Email,
                    Phone = x.r.Phone,
                    Address = x.r.Address,
                    Gender = x.r.Gender,
                    FirstName = x.r.FirstName,
                    LastName = x.r.LastName,
                    DOB = x.r.DOB,
                    Email = x.r.Email,
                    Experience = x.r.Experience,
                    Image=x.c.Image,
                    Description=x.c.Description,
                    AddressCareer=x.c.WorkAddress,
                    Status=x.r.Status,
                }).FirstOrDefault();
            return recruitmentDetails;
        }

        public List<RecruitmentModel> RecruitmentModels()
        {
            var query = from r in _starSecurityDbContext.Recruitments
                        join c in _starSecurityDbContext.Careers on r.ID_Career equals c.Id
                        select new { r, c };
            var recruitmentModels = query.Select(x => new RecruitmentModel()
            {
                Id = x.r.Id,
                ID_Career = x.c.Id,
                NameCareer = x.c.Title,
                Education = x.r.Email,
                Phone = x.r.Phone,
                Address = x.r.Address,
                Gender = x.r.Gender,
                FirstName = x.r.FirstName,
                LastName = x.r.LastName,
                DOB = x.r.DOB,
                Email = x.r.Email,
                Experience = x.r.Experience,
                Status = x.r.Status
            }).ToList();
            return recruitmentModels;
        }
    }
}
