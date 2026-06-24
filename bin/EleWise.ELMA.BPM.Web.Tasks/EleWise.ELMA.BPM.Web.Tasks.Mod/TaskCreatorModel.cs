using System;
using System.Collections.Generic;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class TaskCreatorModel
{
	public ITaskBase ParentTask { get; set; }

	public string Hidden { get; set; }

	public string GridId { get; set; }

	public bool CheckReplacement { get; set; }

	public Func<ITaskBase, IEnumerable<ITaskBase>> GetChildTasks { get; set; }

	public TaskCreatorModel()
	{
		Hidden = "JsonChildTasks";
		GridId = "SubTasksGrid";
		CheckReplacement = true;
	}
}
