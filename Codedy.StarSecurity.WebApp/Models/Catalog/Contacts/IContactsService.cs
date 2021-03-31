using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Contacts
{
    public interface IContactsService
    {
        public List<Contact> Contacts();
        public void Create(Contact contactRequest);
        public Contact Contact(Guid? ID);
        public void Delete(Guid? ID);
    }
}
