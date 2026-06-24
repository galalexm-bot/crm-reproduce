using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Modules;

[ExtensionPoint(ComponentType.Server)]
public interface IPrivilegeModuleAccessGroup
{
	Guid ModuleUid { get; }

	Guid UserGroupUid { get; }
}
