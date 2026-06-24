using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IMonitorUpdateActionQueueItem))]
public interface IMonitorUpdateActionQueueItemFilter : IEntityFilter
{
	IUser User { get; set; }
}
