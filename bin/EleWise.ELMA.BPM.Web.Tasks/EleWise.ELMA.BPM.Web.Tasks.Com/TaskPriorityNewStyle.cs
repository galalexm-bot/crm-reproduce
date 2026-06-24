using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 10)]
public class TaskPriorityNewStyle : AbstractRowStyles
{
	private Guid taskUid = new Guid("298b2c71-619f-463c-95b2-8e029085680d");

	public override string GetClass(ITaskBase task)
	{
		return "task-priority-unread";
	}

	public override bool IsValid(ITaskBase task)
	{
		if (task.Status == TaskBaseStatus.NewOrder)
		{
			if (task.EndDate.HasValue)
			{
				return task.EndDate.Value > DateTime.Now;
			}
			return true;
		}
		return false;
	}

	public override MvcHtmlString GetIcon(HtmlHelper htmlHelper, ITaskBase task)
	{
		var htmlAttributes = new
		{
			@class = "icon-blue taskStatusLinkIcon"
		};
		if (task.TypeUid == taskUid)
		{
			return htmlHelper.SvgImage("#task_fill.svg", htmlAttributes);
		}
		return GetMetadataIcon(htmlHelper, task.TypeUid, "#task.svg", htmlAttributes);
	}
}
