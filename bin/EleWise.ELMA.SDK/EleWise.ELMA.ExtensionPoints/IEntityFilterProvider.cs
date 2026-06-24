using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.ExtensionPoints;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntityFilterProvider
{
	Guid ProviderUid { get; }

	void ApplyFilter(IEntityFilter filter, string data);

	string GetFilterProviderData(Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes);

	IEntityFilter GetFilter(Guid uid, IEntityFilter filter);
}
