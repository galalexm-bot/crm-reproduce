using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Components;

[Component]
internal sealed class WorkflowPageViewNamePrefixProvider : IPageViewNamePrefixProvider
{
	public bool Check(string metadataTypeCode)
	{
		return metadataTypeCode == "WorkflowProcess";
	}

	public string GetViewNamePrefix(string metadataName)
	{
		return "Forms/Workflow/" + metadataName + "/";
	}
}
