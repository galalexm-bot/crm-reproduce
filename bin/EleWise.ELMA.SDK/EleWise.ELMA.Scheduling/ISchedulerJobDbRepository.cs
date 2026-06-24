using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.Scheduling;

internal interface ISchedulerJobDbRepository : ISchedulerJobRepository
{
	ISchedulerJob CreateSchedulerJob(ISchedulerTask task, DateTime? customExecuteTime = null);

	ICollection<ISchedulerJob> GetOnceSchedulerJobs();

	Task<ICollection<ISchedulerJob>> GetSchedulerJobs(DateTime dateTimeToRun);
}
