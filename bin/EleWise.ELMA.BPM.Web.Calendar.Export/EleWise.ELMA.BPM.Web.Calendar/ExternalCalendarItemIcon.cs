using System;
using System.Web.Mvc;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Calendar.Export.Components;

[Component]
public class ExternalCalendarItemIcon : IObjectIcon
{
	public bool CheckType(Type type)
	{
		return typeof(ExternalCalendarItem).IsAssignableFrom(type);
	}

	public string Icon(UrlHelper url, ObjectIconFormat format, object obj)
	{
		return "#calendar_external.svg";
	}
}
