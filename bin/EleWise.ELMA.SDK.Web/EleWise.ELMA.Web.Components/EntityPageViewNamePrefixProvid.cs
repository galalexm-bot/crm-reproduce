using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Components;

[Component]
internal sealed class EntityPageViewNamePrefixProvider : IPageViewNamePrefixProvider
{
	public bool Check(string metadataTypeCode)
	{
		return metadataTypeCode == "Entity";
	}

	public string GetViewNamePrefix(string metadataName)
	{
		return "Forms/Entities/" + metadataName + "/";
	}
}
