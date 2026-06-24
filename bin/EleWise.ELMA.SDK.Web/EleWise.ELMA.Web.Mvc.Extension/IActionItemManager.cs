using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IActionItemManager
{
	void ProcessItem(IActionItem actionItem, HtmlHelper htmlHelper);
}
