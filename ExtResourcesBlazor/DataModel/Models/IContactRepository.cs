using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataModel;

namespace DataModel
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetContacts();
        Task<Contact> GetContact(Guid ContactId);
        Task<Contact> AddContact(Contact Contact);
        Task<Contact> UpdateContact(Contact Contact);
        Task<Contact> DeleteContact(Guid ContactId);
        
    }
}