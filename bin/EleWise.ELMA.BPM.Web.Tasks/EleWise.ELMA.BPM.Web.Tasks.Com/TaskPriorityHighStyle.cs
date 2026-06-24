using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 20)]
public class TaskPriorityHighStyle : AbstractRowStyles
{
	public override string GetClass(ITaskBase task)
	{
		return "task-priority-high";
	}

	public override bool IsValid(ITaskBase task)
	{
		return task.Priority == TaskPriority.High;
	}

	public override MvcHtmlString GetIcon(HtmlHelper htmlHelper, ITaskBase task)
	{
		return GetMetadataIcon(htmlHelper, task.TypeUid, "#task.svg", new
		{
			@class = "taskStatusLinkIcon"
		});
	}
}
