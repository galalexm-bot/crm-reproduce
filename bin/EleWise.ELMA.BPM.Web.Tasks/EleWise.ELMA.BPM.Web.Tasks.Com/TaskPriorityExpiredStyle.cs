using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 5)]
public class TaskPriorityExpiredStyle : AbstractRowStyles
{
	public override string GetClass(ITaskBase task)
	{
		return string.Empty;
	}

	public override bool IsValid(ITaskBase task)
	{
		return task.EndDate < DateTime.Now;
	}

	public override MvcHtmlString GetIcon(HtmlHelper htmlHelper, ITaskBase task)
	{
		return GetMetadataIcon(htmlHelper, task.TypeUid, "#task.svg", new
		{
			@class = "icon-red taskStatusLinkIcon"
		});
	}
}
