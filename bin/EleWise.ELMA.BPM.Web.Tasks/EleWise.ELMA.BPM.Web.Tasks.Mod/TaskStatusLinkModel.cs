using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public sealed class TaskStatusLinkModel
{
	public ITaskBase Task { get; }

	public bool ShowInfo { get; set; }

	public string Url { get; set; }

	public bool ShowAuthor { get; set; }

	public bool CompleteAlwaysThrough { get; set; }

	public string DefaultTitle { get; set; }

	public bool? InNewTab { get; set; }

	public bool ShowTaskIcon { get; set; }

	public bool ShowDescription { get; set; }

	public string DescriptionViewName { get; set; }

	public bool TaskLinkAdditionalInfo { get; set; }

	public string TaskLinkAdditionalInfoViewName { get; set; }

	public bool IsCardView { get; set; }

	public string InfoText { get; set; }

	public TaskStatusLinkModel(ITaskBase task)
	{
		Task = task;
	}

	public MvcHtmlString Render(HtmlHelper html)
	{
		if (IsCardView)
		{
			return html.CardStatusLink(Task, (Func<(MvcHtmlString, string)>)(() => (html.StatusLink(this), "")));
		}
		return html.StatusLink(this);
	}
}
