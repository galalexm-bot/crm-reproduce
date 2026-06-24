using System.IO;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.ExtensionPoints;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component(Order = 100)]
public class ProcessDocumentationLinkProvider : IProcessDocumentationLinkProvider
{
	public string ResolveLink(UrlHelper url, IWorkflowProcess process)
	{
		if (process == null)
		{
			return string.Empty;
		}
		string text = null;
		text = $"{Path.GetDirectoryName(Locator.GetServiceNotNull<IRuntimeApplication>().Configuration.Config.FilePath)}\\Documentation\\{process.Id}\\index.html";
		if (!File.Exists(text))
		{
			text = null;
		}
		if (string.IsNullOrWhiteSpace(text))
		{
			return string.Empty;
		}
		return url.Action("View", "Documentation", (object)new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web",
			id = process.Id
		}) + "/index.html";
	}
}
