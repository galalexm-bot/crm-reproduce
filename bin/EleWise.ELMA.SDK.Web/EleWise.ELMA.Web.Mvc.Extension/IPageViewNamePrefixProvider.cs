using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPageViewNamePrefixProvider
{
	bool Check(string metadataTypeCode);

	string GetViewNamePrefix(string metadataName);
}
