using System;
using System.Collections.Generic;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class SwimlaneInfo
{
	public string Name { get; set; }

	public long TotalCount { get; set; }

	public Guid SwimlaneUid { get; set; }

	public List<ActivityInfo> ActivitiesInfo { get; set; }

	public SwimlaneInfo()
	{
		ActivitiesInfo = new List<ActivityInfo>();
	}
}
