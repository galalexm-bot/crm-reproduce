using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.Scheduling;

internal interface ISchedulerJobDb : ISchedulerJob
{
	ISchedulerTask SchedulerTask { get; set; }

	void Refresh();
}
