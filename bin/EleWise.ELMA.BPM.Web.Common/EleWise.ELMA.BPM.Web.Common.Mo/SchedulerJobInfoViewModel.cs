using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class SchedulerJobInfoViewModel
{
	[NotNull]
	public IEnumerable<Pair<IJob, ISchedulerJobRunInfo>> JobsInfo = new Pair<IJob, ISchedulerJobRunInfo>[0];

	public ISchedulerJob SchedulerJob { get; set; }

	public DateTime? LatestRunDate { get; set; }

	public DateTime? NextRunDate { get; set; }
}
