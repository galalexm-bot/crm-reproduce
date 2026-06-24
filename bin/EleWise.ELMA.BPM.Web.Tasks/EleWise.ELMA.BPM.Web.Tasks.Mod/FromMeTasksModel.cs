using System;
using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class FromMeTasksModel : FromMeTasksBaseModel
{
	public long UnderControlTasks { get; set; }

	public long ControlCurrentTasks { get; set; }

	public bool ShowCompleted { get; set; }

	public string PortletId { get; set; }

	public Dictionary<DateTime, long> TasksGrids { get; set; }

	public FromMeTasksModel()
	{
		TasksGrids = new Dictionary<DateTime, long>();
	}
}
