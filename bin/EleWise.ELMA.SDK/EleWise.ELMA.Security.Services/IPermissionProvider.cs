using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Security.Services;

[DeveloperApi(DeveloperApiType.Service)]
[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IPermissionProvider
{
	[Obsolete("Используйте SR.M в названиях пермишенов")]
	List<string> LocalizedItemsNames { get; }

	[Obsolete("Используйте SR.M в описания пермишенов")]
	List<string> LocalizedItemsDescriptions { get; }

	[Obsolete("Используйте SR.M в описании категорий")]
	List<string> LocalizedItemsCategories { get; }

	IEnumerable<Permission> GetPermissions();

	IEnumerable<PermissionStereotype> GetPermissionStereotypes();
}
