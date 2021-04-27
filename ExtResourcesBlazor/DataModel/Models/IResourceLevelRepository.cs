using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
	public interface IResourceLevelRepository
	{
		Task<IEnumerable<ResourceLevel>> GetLevels();
		Task<ResourceLevel> GetLevel(Guid RLevelId);
		Task<ResourceLevel> AddLevel(ResourceLevel RLevel);
		Task<ResourceLevel> UpdateLevel(ResourceLevel RLevel);
		Task<ResourceLevel> DeleteLevel(Guid RLevelId);
	}
}
