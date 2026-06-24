using System;
using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IActionItemType
{
	Guid Uid { get; }

	void Render(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder);
}
