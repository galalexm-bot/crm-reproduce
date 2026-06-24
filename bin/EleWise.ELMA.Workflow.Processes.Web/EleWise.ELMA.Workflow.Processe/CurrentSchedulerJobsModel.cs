using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class CurrentSchedulerJobsModel
{
	private ISchedulerTaskJob _currentRecreateMonitorTaskJob;

	private ISchedulerTaskJob _currentOptimizeTaskJob;

	public ISchedulerTaskJob RecreateMonitorCurrentTaskJob
	{
		get
		{
			if (_currentRecreateMonitorTaskJob == null)
			{
				IRecreateMonitorCacheJob recreateMonitorCacheJob = (IRecreateMonitorCacheJob)(_currentRecreateMonitorTaskJob = AbstractNHEntityManager<IRecreateMonitorCacheJob, long>.Instance.LoadOrNull(WorkflowConstants.RecreateCacheJobId));
			}
			return _currentRecreateMonitorTaskJob;
		}
	}

	public ISchedulerTaskJob OptimizeMonitorCacheCurrentTaskJob
	{
		get
		{
			if (_currentOptimizeTaskJob == null)
			{
				IOptimizeMonitorCacheJob optimizeMonitorCacheJob = (IOptimizeMonitorCacheJob)(_currentOptimizeTaskJob = AbstractNHEntityManager<IOptimizeMonitorCacheJob, long>.Instance.Find(new Filter(), new FetchOptions(0, 1, ListSortDirection.Descending, "Id")).FirstOrDefault());
			}
			return _currentOptimizeTaskJob;
		}
	}
}
