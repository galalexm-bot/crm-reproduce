using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntityModelBinderProvider
{
	Guid ProviderUid { get; }

	object LoadEntity(Type entityType, object id);
}
