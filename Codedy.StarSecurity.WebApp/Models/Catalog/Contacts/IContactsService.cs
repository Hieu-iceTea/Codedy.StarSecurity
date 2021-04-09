using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
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
        public List<ContactModel> ContactModels();
        public ContactModel ContactModelDetail(Guid? ID);
        public void Create(Contact contactRequest);
        public Contact Contact(Guid? ID);
        public void Delete(Guid? ID);
        public Service Service(Guid? ID);
        public void Edit(Contact contact);
        public bool ContactExists(Guid id);
    }
}
