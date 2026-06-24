using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.ExtensionPoints;

namespace EleWise.ELMA.Workflow.Web.Extensions;

public static class UrlExtensions
{
	public static string ProcessDocumentationLink(this UrlHelper html, IWorkflowProcess process)
	{
		IProcessDocumentationLinkProvider processDocumentationLinkProvider = ComponentManager.Current.GetExtensionPoints<IProcessDocumentationLinkProvider>().FirstOrDefault();
		if (processDocumentationLinkProvider == null)
		{
			return string.Empty;
		}
		return processDocumentationLinkProvider.ResolveLink(html, process);
	}
}
