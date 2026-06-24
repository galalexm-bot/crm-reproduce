using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IWorkflowInstanceWebExtension
{
	MvcHtmlString RenderTitlePrefix(HtmlHelper html, IWorkflowInstance instance);

	MvcHtmlString RenderInfoPagePanel(HtmlHelper html, WorkflowInstanceViewModel model);
}
