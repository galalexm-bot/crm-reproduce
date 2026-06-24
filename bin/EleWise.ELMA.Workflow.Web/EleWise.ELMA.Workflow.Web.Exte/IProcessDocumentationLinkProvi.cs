using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IProcessDocumentationLinkProvider
{
	string ResolveLink(UrlHelper url, IWorkflowProcess process);
}
