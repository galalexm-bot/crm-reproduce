using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
internal sealed class DocumentPageViewNamePrefixProvider : IPageViewNamePrefixProvider
{
	private const string MetadataTypeCode = "Document";

	public bool Check(string metadataTypeCode)
	{
		return metadataTypeCode == "Document";
	}

	public string GetViewNamePrefix(string metadataName)
	{
		return "Forms/Entities/" + metadataName + "/";
	}
}
