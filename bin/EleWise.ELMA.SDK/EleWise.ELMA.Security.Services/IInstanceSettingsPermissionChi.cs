using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Security.Services;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IInstanceSettingsPermissionChild : IInstanceSettingsPermission
{
	string ParentPropertyName { get; }

	Guid GetParentPermissionId(Guid childPermissionId);
}
