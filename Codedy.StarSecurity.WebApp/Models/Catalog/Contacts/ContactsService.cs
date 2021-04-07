﻿using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
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

        public bool ContactExists(Guid id)
        {
            return _starSecurityDbContext.Contacts.Any(e => e.ID == id);
        }

        public List<ContactModel> ContactModels()
        {
            var query= from c in _starSecurityDbContext.Contacts
                       join s in _starSecurityDbContext.Services on c.ID_Service equals s.Id
                       select new { c,s };
            var contactModels = query.Select(x => new ContactModel()
            {
                ID = x.c.ID,
                ID_Service = x.s.Id,
                NameService=x.s.Title,
                FullName = x.c.FullName,
                Subject = x.c.Subject,
                Email = x.c.Email,
                Message = x.c.Message,
                Status=x.c.Status
            }).ToList();
            return contactModels;
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

        public void Edit(Contact contact)
        {
            _starSecurityDbContext.Update(contact);
            _starSecurityDbContext.SaveChanges();
        }

        public Service Service(Guid? ID)
        {
            var service = _starSecurityDbContext.Services.FirstOrDefault(m => m.Id == ID);
            return service;
        }
    }
}
