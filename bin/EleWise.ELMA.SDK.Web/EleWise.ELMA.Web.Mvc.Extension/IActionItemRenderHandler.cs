using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IActionItemRenderHandler
{
	void OnRenderBegin(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder);

	void OnRenderComplete(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder);
}
