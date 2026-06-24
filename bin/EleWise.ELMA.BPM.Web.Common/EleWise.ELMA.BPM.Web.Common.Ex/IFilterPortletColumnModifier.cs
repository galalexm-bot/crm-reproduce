using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterPortletColumnModifier
{
	string UniqueName { get; }

	bool NeedHeader { get; }

	string Header { get; }

	bool NeedTemplate { get; }

	bool AvailableFilterType(Guid filterTypeUid);

	MvcHtmlString Template(IEntity entity, HtmlHelper html);
}
