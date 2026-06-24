using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class FilterPortletTaskColorExtension : IFilterPortletColor
{
	public bool AvailableFilterType(Guid TypeUid)
	{
		return TypeUid == InterfaceActivator.UID<ITaskBase>();
	}

	public MvcHtmlString Template(IEntity entity, HtmlHelper html)
	{
		return html.StatusLink(entity as ITaskBase, showInfo: false, false, false, false);
	}
}
