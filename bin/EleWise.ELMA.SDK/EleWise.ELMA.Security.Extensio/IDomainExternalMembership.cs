using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Settings;

namespace EleWise.ELMA.Security.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IDomainExternalMembership
{
	Guid Uid { get; }

	IUser ValidateDomainUser(string userName, IExternalMembershipModuleSettings settings);
}
