using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Security.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IUserSecurityProfileEventHandler : IEventHandler
{
	void AllowLogon(IEnumerable<long> ids = null);

	void ResetCountFailedLogon(IEnumerable<long> ids = null);

	void SetForcedChangePassword(IEnumerable<long> ids = null);
}
