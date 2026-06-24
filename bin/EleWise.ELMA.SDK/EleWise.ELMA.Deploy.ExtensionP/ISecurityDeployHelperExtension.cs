using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Deploy.ExtensionPoints;

[ExtensionPoint(ComponentType.Server)]
public interface ISecurityDeployHelperExtension
{
	IUser LoadUserOrNull(long userId);
}
