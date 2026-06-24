using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Components;

[Component]
internal sealed class ComponentViewNamePrefixProvider : IPageViewNamePrefixProvider
{
	private const string MetadataTypeCodeConstant = "UI";

	public bool Check(string metadataTypeCode)
	{
		return metadataTypeCode == "UI";
	}

	public string GetViewNamePrefix(string metadataName)
	{
		return ComponentExportExtension.GetViewNamePrefix(metadataName);
	}
}
