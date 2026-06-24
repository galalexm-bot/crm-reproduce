using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IUnblockUserExtension
{
	void AfterUnblockUser(EleWise.ELMA.Security.Models.IUser user);
}
