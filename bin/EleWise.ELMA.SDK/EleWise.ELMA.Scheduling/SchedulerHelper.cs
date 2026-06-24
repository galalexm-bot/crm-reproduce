using System;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Scheduling.Triggers;

namespace EleWise.ELMA.Scheduling;

internal static class SchedulerHelper
{
	public static DateTime? GetDateTimeToRun(ITrigger trigger, DateTime dateTime, ISchedulerJobRunInfoManager schedulerJobRunInfoManager, IRuntimeApplication runtimeApplication)
	{
		ISchedulerJobRunInfo lastRunInfo = schedulerJobRunInfoManager.GetLastRunInfo(trigger, onlyFinished: false);
		if (lastRunInfo != null && (lastRunInfo.Status == JobStatus.Pending || lastRunInfo.Status == JobStatus.Working) && (lastRunInfo.ConnectionUid == Guid.Empty || !runtimeApplication.IsConnectionAlive(lastRunInfo.ConnectionUid) || dateTime > lastRunInfo.StatusUpdateDate.Add(trigger.GetTriggerTimeout())))
		{
			lastRunInfo = schedulerJobRunInfoManager.GetLastRunInfo(trigger, onlyFinished: true);
		}
		if (lastRunInfo != null && (lastRunInfo.Status == JobStatus.Pending || lastRunInfo.Status == JobStatus.Pending))
		{
			return null;
		}
		DateTime? dateTime2 = lastRunInfo?.DateToRun;
		if (!(trigger is OnceExecuteTrigger))
		{
			return trigger.GetNextTimeAfterUnfolded(dateTime2, dateTime);
		}
		return trigger.GetNextTimeAfter(dateTime2, dateTime);
	}
}
