using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataModel
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly PartnersContext _appDbContext;
        public PartnerRepository(PartnersContext appDbContext) => _appDbContext = appDbContext;

        public async Task<Partner> GetPartner(Guid PartnerId)
        {
            var result = await _appDbContext.Partner.FirstOrDefaultAsync(e => e.Id == PartnerId);
            return result;
        }

        public async Task<IEnumerable<Partner>> GetPartners()
        {
            return await _appDbContext.Partner.ToListAsync();
        }
    }
}