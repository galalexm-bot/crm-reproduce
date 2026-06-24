using System;
using System.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Security.Services;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IInstanceExpressionPermission
{
	Type EntityType { get; }

	Type PermissionType { get; }

	IPropertyExpressionDescriptor[] AccessExpressions { get; }

	string PermissionsTable { get; }

	IEnumerable GetPermissionCollection(object target);
}
