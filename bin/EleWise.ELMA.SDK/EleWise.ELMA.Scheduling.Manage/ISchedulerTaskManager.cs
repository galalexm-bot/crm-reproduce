using System.Collections.Generic;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.Scheduling.Managers;

public interface ISchedulerTaskManager : IEntityManager<ISchedulerTask, long>, IEntityManager<ISchedulerTask>, IEntityManager
{
	IEnumerable<ISchedulerTask> FindTasksToExecute();

	IEnumerable<ISchedulerTask> FindPeriodicTasksToExecute();

	IEnumerable<ISchedulerTask> FindOnceExecuteTasksToExecute();

	void ExecuteTask(ISchedulerTask task);

	void DeleteTaskAndJobs(ISchedulerTask task, IEnumerable<long> excludeJobs);
}
