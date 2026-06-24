using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Security;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IRoleTypeSelectorGroupsCategory
{
	string Name { get; }

	string Id { get; }

	Guid Uid { get; }
}
