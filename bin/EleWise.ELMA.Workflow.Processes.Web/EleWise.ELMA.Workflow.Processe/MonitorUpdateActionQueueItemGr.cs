using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class MonitorUpdateActionQueueItemGrid
{
	public GridData<IMonitorUpdateActionQueueItem, IMonitorUpdateActionQueueItemFilter> Data { get; set; }

	public IMonitorUpdateQueueAction GetActionProvider(Guid uid)
	{
		return ComponentManager.Current.GetExtensionPoints<IMonitorUpdateQueueAction>().FirstOrDefault((IMonitorUpdateQueueAction a) => a.ActionUid == uid);
	}
}
