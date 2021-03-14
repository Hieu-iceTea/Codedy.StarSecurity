using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Users
{
    public interface IUsersService
    {
        public List<User> Users();
        public User User(Guid? Id);
        public void Create(User bookRequest);
        public void Detele(Guid? Id);
        public void Edit(User book);
        public bool UserExists(Guid id);
    }
}
