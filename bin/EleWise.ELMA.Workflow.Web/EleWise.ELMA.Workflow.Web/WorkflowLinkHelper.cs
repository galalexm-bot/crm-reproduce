using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web;

public class WorkflowLinkHelper
{
	public static string TaskUrl(UrlHelper url, IWorkflowTaskBase task)
	{
		string text = url.Entity(task);
		string value = url.get_RequestContext().HttpContext.Request["CloseAfterPost"] ?? string.Empty;
		bool result = false;
		if (bool.TryParse(value, out result) && result)
		{
			text = text + (text.Contains("?") ? "&" : "?") + "interface=lite";
		}
		return text;
	}
}
