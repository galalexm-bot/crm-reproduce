using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.Scheduling;

[ExtensionPoint(ComponentType.WebServer)]
public interface ISchedulerTaskJobExecutor
{
	bool CanExecute(ISchedulerTaskJob job);

	JobResult Do(ISchedulerTaskJob job, DateTime dateToRun);
}
