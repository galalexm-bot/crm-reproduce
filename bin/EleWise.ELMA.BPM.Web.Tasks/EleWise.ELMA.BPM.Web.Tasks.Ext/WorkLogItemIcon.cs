using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class WorkLogItemIcon : IObjectIcon
{
	public bool CheckType(Type type)
	{
		return InterfaceActivator.UID(type) == InterfaceActivator.UID<IWorkLogItem>();
	}

	public string Icon(UrlHelper url, ObjectIconFormat format, object obj)
	{
		IWorkLogItem workLogItem = (IWorkLogItem)obj;
		return url.ObjectIcon(format, WorkLogExtensionHelper.LoadObject(workLogItem));
	}
}
