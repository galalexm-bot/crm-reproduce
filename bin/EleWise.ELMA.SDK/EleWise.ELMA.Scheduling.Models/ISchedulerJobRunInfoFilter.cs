using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Scheduling.Models;

[FilterFor(typeof(ISchedulerJobRunInfo))]
public interface ISchedulerJobRunInfoFilter : IEntityFilter
{
	Guid? TriggerId { get; set; }

	Guid? JobId { get; set; }

	ISchedulerTaskJob Job { get; set; }
}
