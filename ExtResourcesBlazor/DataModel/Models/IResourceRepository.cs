using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DataModel
{
	public interface IResourceRepository
	{
		Task<IEnumerable<Resource>> GetResources();
		Task<Resource> GetResource(Guid ResourceId);
		Task<Resource> AddResource(Resource Resource);
		Task<Resource> UpdateResource(Resource Resource);
		Task<Resource> DeleteResource(Guid ResourceId);
	}
}
