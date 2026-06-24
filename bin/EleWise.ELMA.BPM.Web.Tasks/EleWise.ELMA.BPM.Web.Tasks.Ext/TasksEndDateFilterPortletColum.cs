using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class TasksEndDateFilterPortletColumnModifier : IFilterPortletColumnModifier
{
	public string UniqueName => InterfaceActivator.PropertyUid((ITaskBase p) => p.EndDate, inherit: true).ToString();

	public bool NeedHeader => true;

	public string Header => SR.T("Срок");

	public bool NeedTemplate => false;

	public bool AvailableFilterType(Guid filterTypeUid)
	{
		return filterTypeUid == InterfaceActivator.UID<ITaskBase>();
	}

	public MvcHtmlString Template(IEntity entity, HtmlHelper html)
	{
		return null;
	}
}
