using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Security;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IEntityInstanceDefaultPermission
{
	Type EntityType { get; }

	void CreatePermissions(IEntity entity);
}
