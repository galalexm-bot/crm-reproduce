using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class TasksPriorityFilterPortletColumnModifier : IFilterPortletColumnModifier
{
	public string UniqueName => InterfaceActivator.PropertyUid((ITaskBase p) => p.Priority, inherit: true).ToString();

	public bool NeedHeader => true;

	public string Header => SR.T("Пр.");

	public bool NeedTemplate => true;

	public bool AvailableFilterType(Guid filterTypeUid)
	{
		return true;
	}

	public MvcHtmlString Template(IEntity entity, HtmlHelper html)
	{
		ITaskBase taskBase = entity as ITaskBase;
		return html.Image(html.Url().ObjectIcon(ObjectIconFormat.x16, taskBase.Priority), ModelHelper.GetEnumDisplayName(taskBase.Priority));
	}
}
