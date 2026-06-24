using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.Scheduling.Managers;

public interface ISchedulerJobRunInfoManager : IEntityManager<ISchedulerJobRunInfo, long>, IEntityManager<ISchedulerJobRunInfo>, IEntityManager
{
	DateTime? GetLastRun(ITrigger trigger);

	DateTime? GetLastRun(ITrigger trigger, Guid jobId);

	ISchedulerJobRunInfo GetLastRunInfo(ITrigger trigger, bool onlyFinished);

	ISchedulerJobRunInfo GetLastRunInfo(ITrigger trigger, Guid jobId, bool onlyFinished);

	ISchedulerJobRunInfo GetLastRunInfo(Guid triggerId, Guid jobId, bool onlyFinished);

	IList<ISchedulerJobRunInfo> GetLastRunInfos(Guid triggerId, Guid jobId, bool onlyFinished);

	IList<ISchedulerJobRunInfo> GetLastRunInfos(IEnumerable<Guid> triggerIds, bool onlyFinished);

	JobStatus GetStatus(ITrigger trigger, IJob job, DateTime dateToRun);

	ISchedulerJobRunInfo Get(ITrigger trigger, IJob job, DateTime dateToRun);

	ISchedulerJobRunInfo SetResult(ITrigger trigger, IJob job, DateTime dateToRun, JobResult result);

	ISchedulerJobRunInfo SetResult(ITrigger trigger, IJob job, DateTime dateToRun, DateTime? actualStartDate, JobResult result);

	bool SetPending(ITrigger trigger, ICollection<IJob> jobs, DateTime dateToRun);

	void CancelPending(ITrigger trigger, ICollection<IJob> jobs, DateTime dateToRun);
}
