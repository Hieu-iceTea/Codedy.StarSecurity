using Codedy.StarSecurity.WebApp.Areas.Admin.Views._ViewModels;
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
                Phone=x.c.Phone,
                Message = x.c.Message,
                Status=x.c.Status
            }).ToList();
            return contactModels;
        }

        public ContactModel ContactModelDetail(Guid? id)
        {
            var query = from c in _starSecurityDbContext.Contacts
                        where c.ID == id
                        select new ContactModel
                        {
                             ID = c.ID,
                            ID_Service = c.ID_Service,
                            FullName = c.FullName,
                            Subject = c.Subject,
                            Email = c.Email,
                            Phone = c.Phone,
                            Message = c.Message,
                            Status = c.Status,
                            Title = _starSecurityDbContext.Services.Where(x => x.Id == c.ID_Service).FirstOrDefault().Title,
                            Description = _starSecurityDbContext.Services.Where(x => x.Id == c.ID_Service).FirstOrDefault().Description,
                            Image = _starSecurityDbContext.Services.Where(x => x.Id == c.ID_Service).FirstOrDefault().Image,
                            ImageFile = _starSecurityDbContext.Services.Where(x => x.Id == c.ID_Service).FirstOrDefault().ImageFile,
                            Price = _starSecurityDbContext.Services.Where(x => x.Id == c.ID_Service).FirstOrDefault().Price,
                            PromotionPrice = _starSecurityDbContext.Services.Where(x => x.Id == c.ID_Service).FirstOrDefault().PromotionPrice,
                        };
            return query.FirstOrDefault();
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
            _starSecurityDbContext.SaveChanges();
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
