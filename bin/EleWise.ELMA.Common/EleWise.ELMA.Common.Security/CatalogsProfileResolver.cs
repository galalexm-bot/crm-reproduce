using System;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Common.Security;

[Component(Order = 100)]
internal class CatalogsProfileResolver : IProfileResolver
{
	private readonly Func<Type, Guid> getImplementationUid;

	public CatalogsProfileResolver()
	{
		getImplementationUid = MetadataLoader.UseCachingForFunc((Type type) => GetImplementationUid(type));
	}

	private Guid GetImplementationUid(Type type)
	{
		if (type.IsInheritOrSame<IEntity>() && MetadataLoader.LoadMetadata(type, inherit: false) is EntityMetadata entityMetadata && entityMetadata.ShowInCatalogList)
		{
			return entityMetadata.ImplementationUid;
		}
		return Guid.Empty;
	}

	public Type ResolveProfileType(Type type)
	{
		if (!(getImplementationUid(type) != Guid.Empty))
		{
			return null;
		}
		return InterfaceActivator.TypeOf<ICatalogProfile>();
	}

	public object ResolveProfile(Type type)
	{
		Guid guid = getImplementationUid(type);
		if (!(guid != Guid.Empty))
		{
			return null;
		}
		return CatalogManager.Instance.LoadByCatalog(guid);
	}
}
