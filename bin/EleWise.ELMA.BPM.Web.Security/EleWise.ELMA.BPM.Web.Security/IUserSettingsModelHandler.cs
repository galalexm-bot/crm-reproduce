using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IUserSettingsModelHandler
{
	void Process(IUser user, IUserSettingsModel model);
}
