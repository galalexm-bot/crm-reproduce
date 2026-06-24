using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IExecutedTaskInfoProvider
{
	HtmlString GetInfo(HtmlHelper html, IWorkflowInstance instance);

	WebData GetData(IWorkflowInstance instance);
}
