using System;
using System.Web.Script.Serialization;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks;

public class TaskCalendarPlannedItem : ICalendarPlannedItem
{
	[ScriptIgnore]
	public readonly ITaskBase Task;

	public string Id
	{
		get
		{
			return Task.Id.ToString();
		}
		set
		{
		}
	}

	public string Theme
	{
		get
		{
			return Task.Subject;
		}
		set
		{
		}
	}

	public string Description
	{
		get
		{
			string text = "";
			if (Task == null)
			{
				return text;
			}
			if (Task.StartDate.HasValue)
			{
				text = text + SR.T("Дата начала задачи: {0}", Task.StartDate.Value.ToShortDateString()) + "\r\n";
			}
			if (Task.EndDate.HasValue)
			{
				text = text + SR.T("Дата окончания задачи: {0}", Task.EndDate.Value.ToShortDateString()) + "\r\n";
			}
			if (Task.CreationAuthor != null)
			{
				text += SR.T("Автор: {0}", Task.CreationAuthor.ToString().HtmlEncode());
			}
			return text;
		}
		set
		{
		}
	}

	public TaskCalendarPlannedItem(ITaskBase task)
	{
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		Task = task;
	}
}
