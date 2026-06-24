using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterPortletColor
{
	bool AvailableFilterType(Guid TypeUid);

	MvcHtmlString Template(IEntity entity, HtmlHelper html);
}
