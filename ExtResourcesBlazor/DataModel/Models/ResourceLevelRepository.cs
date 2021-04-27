using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
	public class ResourceLevelRepository : IResourceLevelRepository
	{
		private readonly PartnersContext _appDbContext;
		public ResourceLevelRepository(PartnersContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		public async Task<ResourceLevel> AddLevel(ResourceLevel RLevel)
		{
			var result = await _appDbContext.ResourceLevel.AddAsync(RLevel);

			await _appDbContext.SaveChangesAsync();
			return result.Entity;
		}

		public async Task<ResourceLevel> DeleteLevel(Guid RLevelId)
		{
			var Level = await _appDbContext.ResourceLevel.FindAsync(RLevelId);
			if (Level != null)
			{
				_appDbContext.ResourceLevel.Remove(Level);
				await _appDbContext.SaveChangesAsync();
			}
			return Level;
		}

		public async Task<ResourceLevel> GetLevel(Guid RLevelId)
		{
			throw new NotImplementedException();
		}

		public async  Task<IEnumerable<ResourceLevel>> GetLevels()
		{
			return await _appDbContext.ResourceLevel.Include(e => e.Name).ToListAsync();
		}

		public async Task<ResourceLevel> UpdateLevel(ResourceLevel RLevel)
		{
			throw new NotImplementedException();
		}
	}
}
