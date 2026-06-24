using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class CurrentSchedulerTaskInfoModel
{
	public string CurrentOperationFormatText { get; set; }

	public string NoOperationFormatText { get; set; }

	public ISchedulerTaskJob Job { get; set; }

	public ISchedulerJobRunInfo GetJubRunInfo()
	{
		if (Job == null)
		{
			return null;
		}
		InstanceOf<ISchedulerJobRunInfoFilter> instanceOf = new InstanceOf<ISchedulerJobRunInfoFilter>();
		instanceOf.New.Job = Job;
		instanceOf.New.DisableSecurity = true;
		ISchedulerJobRunInfoFilter @new = instanceOf.New;
		return AbstractNHEntityManager<ISchedulerJobRunInfo, long>.Instance.Find(@new, new FetchOptions(0, 1, ListSortDirection.Descending, "Id")).FirstOrDefault();
	}
}
