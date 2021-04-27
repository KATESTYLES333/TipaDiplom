using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataModel;

namespace DataModel
{
    public interface IPartnerRepository
    {
        Task<IEnumerable<Partner>> GetPartners();
        Task<Partner> GetPartner(Guid PartnerId);
    }
}