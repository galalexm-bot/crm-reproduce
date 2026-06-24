using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IMonitorCacheItem))]
public interface IMonitorCacheItemFilter : IEntityFilter
{
	IProcessHeader ProcessHeader { get; set; }

	IUser User { get; set; }
}
