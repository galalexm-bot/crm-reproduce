using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Settings;

namespace EleWise.ELMA.Security.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IExternalMembershipModule
{
	Guid Uid { get; }

	string Name { get; }

	string Description { get; }

	string Category { get; }

	IExternalMembershipModuleSettings CreateDefaultSettings();

	IEnumerable<IUser> FindUsers(string searchString, IExternalMembershipModuleSettings settings);

	void Sync(IUser user, IExternalMembershipModuleSettings settings);

	bool ValidateUser(UserValidationContext context, IExternalMembershipModuleSettings settings);
}
