using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Users
{
    public class UsersService : IUsersService
    {
        private readonly StarSecurityDbContext _starSecurityDbContext;
        public UsersService(StarSecurityDbContext starSecurityDbContext)
        {
            _starSecurityDbContext = starSecurityDbContext;
        }
        public User User(Guid? Id)
        {
            var user = _starSecurityDbContext.Users.FirstOrDefault(m => m.Id == Id);
            return user;
        }

        public bool UserExists(Guid id)
        {
            return _starSecurityDbContext.Users.Any(e => e.Id == id);
        }

        public List<User> Users()
        {
            var users = _starSecurityDbContext.Users.ToList();
            return users;
        }

        public void Create(User userRequest)
        {
            _starSecurityDbContext.Add(userRequest);
            _starSecurityDbContext.SaveChanges();
        }

        public void Detele(Guid? Id)
        {
            var user = User(Id);
            _starSecurityDbContext.Remove(user);
            _starSecurityDbContext.SaveChanges();
        }

        public void Edit(User user)
        {
            _starSecurityDbContext.Update(user);
            _starSecurityDbContext.SaveChanges();
        }
    }
}
