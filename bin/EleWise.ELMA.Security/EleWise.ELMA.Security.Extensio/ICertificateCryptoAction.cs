using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ICertificateCryptoAction : ICryptoAction
{
	bool SupportOnlyDefaultCertificate { get; }

	bool SupportOtherDevices { get; }

	bool HasPermission(EleWise.ELMA.Security.Models.IUser user);

	bool HasPermission(EleWise.ELMA.Security.Models.IUser user, out string msg);

	bool CanRegisterCertificate(out string msg);

	bool CanUnregisterCertificate(IUserCertificate cert, out string msg);

	void EnableTrusted(EleWise.ELMA.Security.Models.IUser user, bool enabled);
}
