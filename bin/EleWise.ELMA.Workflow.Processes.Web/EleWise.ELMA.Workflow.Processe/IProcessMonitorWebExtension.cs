using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IProcessMonitorWebExtension
{
	MvcHtmlString RenderInfoPagePanel(HtmlHelper html, IProcessHeader header);

	MvcHtmlString RenderProcessListItemTitle(HtmlHelper html, ProcessHeaderInfo model);
}
