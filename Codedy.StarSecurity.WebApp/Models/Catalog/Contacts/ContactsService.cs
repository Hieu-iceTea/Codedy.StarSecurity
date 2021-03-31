using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Catalog.Contacts
{
    public class ContactsService : IContactsService
    {
        private readonly StarSecurityDbContext _starSecurityDbContext;
        public ContactsService(StarSecurityDbContext starSecurityDbContext)
        {
            _starSecurityDbContext = starSecurityDbContext;
        }

        public Contact Contact(Guid? ID)
        {
            var contact = _starSecurityDbContext.Contacts.FirstOrDefault(m => m.ID == ID);
            return contact;
        }

        public List<Contact> Contacts()
        {
            var contacts = _starSecurityDbContext.Contacts.ToList();
            return contacts;
        }

        public void Create(Contact contactRequest)
        {
            _starSecurityDbContext.Contacts.Add(contactRequest);
            _starSecurityDbContext.SaveChanges();
            
        }

        public void Delete(Guid? ID)
        {
            var contact = Contact(ID);
            _starSecurityDbContext.Remove(contact);
            _starSecurityDbContext.SaveChangesAsync();
        }
    }
}
