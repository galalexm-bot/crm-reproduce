using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.UI.Deploy.Export;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Components;

[Component]
internal sealed class FormPageViewNamePrefixProvider : IPageViewNamePrefixProvider
{
	public bool Check(string metadataTypeCode)
	{
		return metadataTypeCode == "Form";
	}

	public string GetViewNamePrefix(string metadataName)
	{
		return UIFormExportExtension.GetViewNamePrefix(metadataName);
	}
}
