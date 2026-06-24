using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.SDK.Web.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IDeepExtensionCheck
{
	bool DeepCheckFileExtension(string tempFilePath);
}
