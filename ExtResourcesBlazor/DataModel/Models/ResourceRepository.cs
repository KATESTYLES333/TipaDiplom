using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataModel
{
	public class ResourceRepository : IResourceRepository
	{
		private readonly PartnersContext _appDbContext;
		public ResourceRepository(PartnersContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public async Task<Resource> AddResource(Resource Resource, string FileName)
		{
			//generate unique id
			Guid guid = Guid.NewGuid();
			Resource.Id = guid;
			Resource.CvtoolLinkMaster = FileName;
			var result = await _appDbContext.Resource.AddAsync(Resource);

			await _appDbContext.SaveChangesAsync();
			return result.Entity;
		}

		public async Task<Resource> DeleteResource(Guid ResourceId)
		{
			var Resource = await _appDbContext.Resource.FindAsync(ResourceId);
			if (Resource != null)
			{
				_appDbContext.Resource.Remove(Resource);
				await _appDbContext.SaveChangesAsync();
			}
			return Resource;
		}

		public async Task<Resource> GetResource(Guid ResourceId)
		{
			var result = await _appDbContext.Resource
			.Include(e => e.Partner)
			.FirstOrDefaultAsync(e => e.Id == ResourceId);
			return result;
		}

		public async Task<IEnumerable<Resource>> GetResources()
		{
			return await _appDbContext.Resource.Include(e => e.Partner).ToListAsync();
		}

		public async Task<Resource> UpdateResource(Resource Resource)
		{
			var result = await _appDbContext.Resource.FirstOrDefaultAsync(e => e.Id == Resource.Id);

			if (result != null)
			{
				result.FirstName = Resource.FirstName;
				result.LastName = Resource.LastName;
				//TODO

				await _appDbContext.SaveChangesAsync();
			}
			return result;
		}
	}
}
