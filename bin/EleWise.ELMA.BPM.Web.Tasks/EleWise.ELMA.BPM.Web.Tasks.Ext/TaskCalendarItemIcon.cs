using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class TaskCalendarItemIcon : IObjectIcon
{
	public bool CheckType(Type type)
	{
		if (!typeof(TaskCalendarItem).IsAssignableFrom(type))
		{
			return typeof(TaskCalendarPlannedItem).IsAssignableFrom(type);
		}
		return true;
	}

	public string Icon(UrlHelper url, ObjectIconFormat format, object obj)
	{
		ITaskBase taskBase = null;
		if (obj is TaskCalendarItem)
		{
			taskBase = ((TaskCalendarItem)obj).TimePlan.Task;
		}
		else if (obj is TaskCalendarPlannedItem)
		{
			taskBase = ((TaskCalendarPlannedItem)obj).Task;
		}
		if (taskBase == null)
		{
			return null;
		}
		return url.ObjectIcon(format, taskBase);
	}
}
