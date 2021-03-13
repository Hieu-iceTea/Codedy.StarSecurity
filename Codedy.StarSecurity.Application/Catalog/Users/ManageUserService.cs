using Codedy.StarSecurity.Application.Catalog.Users.Dtos;
using Codedy.StarSecurity.Application.Dtos;
using Codedy.StarSecurity.Data.EF;
using Codedy.StarSecurity.Data.Entiies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Codedy.StarSecurity.Utilities.Exceptions;

namespace Codedy.StarSecurity.Application.Catalog.Users
{
    public class ManageUserService : IManageUserService
    {
        private readonly StarSecurityDbContext _context;
        public ManageUserService(StarSecurityDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(UserCreateRequest request)
        {
            var user = new User()
            {
                UserName = request.UserName,
                PasswordHash = request.PassWord,
                Email = request.Email,
                Phone = request.Phone,
                Address = request.Address,
                DOB = request.DOB,
                Gender = request.Gender,
                FirtName = request.FirtName,
                LastName = request.LastName,
                EmployeeEducationalQualification = request.EmployeeEducationalQualification,
                EmployeeDepartment = request.EmployeeDepartment,
                EmployeeRole = request.EmployeeRole,
                EmployeeGrade = request.EmployeeGrade,
                EmployeeAchievements = request.EmployeeAchievements,
            };
            _context.Users.Add(user);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int Id)
        {
            var user = await _context.Users.FindAsync(Id);
            _context.Users.Remove(user);
            return await _context.SaveChangesAsync();   
        }

        public async Task<User> Detail(string ID)
        {
            var user = await _context.Users.FirstOrDefaultAsync(m => m.Id == Guid.Parse(ID));
            if (user == null) throw new StarSecurityException($"Cannot find a user with id: {ID}");
            return user;
        }

        public Task<List<UserViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedViewModel<UserViewModel>> GetAllPaging(string KeySearch, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(UserEditRequest request)
        {
            var user = await _context.Users.FindAsync(request.Id);
            if (user == null) throw new StarSecurityException($"Cannot find a user with id: {request.Id}");

            user.UserName = request.UserName;
            user.PasswordHash = request.PassWord;
            user.Email = request.Email;
            user.Phone = request.Phone;
            user.Address = request.Address;
            user.DOB = request.DOB;
            user.Gender = request.Gender;
            user.FirtName = request.FirtName;
            user.LastName = request.LastName;
            user.EmployeeEducationalQualification = request.EmployeeEducationalQualification;
            user.EmployeeDepartment = request.EmployeeDepartment;
            user.EmployeeRole = request.EmployeeRole;
            user.EmployeeGrade = request.EmployeeGrade;
            user.EmployeeAchievements = request.EmployeeAchievements;

            return await _context.SaveChangesAsync();
        }
    }
}
