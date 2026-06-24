using System;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class TaskCalendarItemLink : IObjectLink
{
	public bool CheckType(Type type)
	{
		return typeof(TaskCalendarItem).IsAssignableFrom(type);
	}

	public string Url(RequestContext context, object obj)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		return UrlExtensions.Entity(new UrlHelper(context), ((TaskCalendarItem)obj).TimePlan.Task);
	}
}
