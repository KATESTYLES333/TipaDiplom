using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace DataModel
{
    public class ContactRepository : IContactRepository
    {
        private readonly PartnersContext _appDbContext;
        public ContactRepository(PartnersContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Contact> AddContact(Contact Contact)
        {
            var result = await _appDbContext.Contact.AddAsync(Contact);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Contact> DeleteContact(Guid id)
        {
            var Contact = await _appDbContext.Contact.FindAsync(id);
            if (Contact != null)
            {
                _appDbContext.Contact.Remove(Contact);
                await _appDbContext.SaveChangesAsync();
            }
            return Contact;
        }


        public async Task<Contact> GetContact(Guid ContactId)
        {
            var result = await _appDbContext.Contact
            .Include(e => e.Partner)
            .FirstOrDefaultAsync(e => e.Id == ContactId);
            return result;
        }

        public async Task<IEnumerable<Contact>> GetContacts()
        {
            return await _appDbContext.Contact.Include(e => e.Partner).ToListAsync();
        }

        public async Task<Contact> UpdateContact(Contact Contact)
        {
            var result = await _appDbContext.Contact.FirstOrDefaultAsync(e => e.Id == Contact.Id);

            if (result != null)
            {
                result.FirstName = Contact.FirstName;
                result.LastName = Contact.LastName;
                //TODO

                await _appDbContext.SaveChangesAsync();
            }
            return result;
        }
    }
}