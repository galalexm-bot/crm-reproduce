using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
internal interface ILicenseWorkplaceExceededExceptionEventHandler : IEventHandler
{
	void UserLicenseWorkplaceExceededException(EleWise.ELMA.Security.Models.IUser user);
}
